using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MediBookSystem
{
	public partial class AppointmentForm : Form
	{
		DataTable appointmentTable = new DataTable();
		public string DoctorFilter = "";

		// Wrapper so the dropdown can SHOW "Name (Specialization)"
		// while the code USES only the plain name everywhere else.
		private class DoctorItem
		{
			public string Name { get; set; }
			public string Specialization { get; set; }
			public override string ToString()
			{
				return Name + " (" + Specialization + ")";
			}
		}

		public AppointmentForm()
		{
			InitializeComponent();

			// Doctor must be picked from the list, never typed
			cmbDoctor.DropDownStyle = ComboBoxStyle.DropDownList;

			// Typing filters: block characters that can never be valid
			txtPatient.KeyPress += Validator.NameChars;
			txtAge.KeyPress += Validator.DigitsOnly;
			txtAge.MaxLength = 3;
			txtContact.KeyPress += Validator.PhoneChars;
			txtContact.MaxLength = 15;
			dateTimePicker1.KeyPress += Validator.DateChars;
			dateTimePicker1.MaxLength = 10;
			txtTime.KeyPress += Validator.TimeChars;
			txtTime.MaxLength = 8;
			txtSymptoms.KeyPress += Validator.SymptomsChars;
			txtSymptoms.MaxLength = 300;

			LoadDoctors();

			// Tidy the date/time into one standard format when the user leaves the box
			dateTimePicker1.Leave += (s, ev) =>
			{
				DateTime d;
				if (Validator.TryDate(dateTimePicker1.Text, out d))
					dateTimePicker1.Text = d.ToString(Validator.DateFormat);
			};
			txtTime.Leave += (s, ev) =>
			{
				DateTime t;
				if (Validator.TryTime(txtTime.Text, out t))
					txtTime.Text = t.ToString(Validator.TimeFormat, System.Globalization.CultureInfo.InvariantCulture);
			};
		}

		// Returns ONLY the doctor's name (never the "(Specialization)" part)
		// for saving, checking double bookings, and filtering.
		private string SelectedDoctorName
		{
			get
			{
				DoctorItem item = cmbDoctor.SelectedItem as DoctorItem;
				return item != null ? item.Name : "";
			}
		}

		// Fills the doctor dropdown from the database.
		private void LoadDoctors()
		{
			cmbDoctor.Items.Clear();
			try
			{
				using (MySqlConnection conn = DBConnection.GetConnection())
				{
					conn.Open();
					MySqlCommand cmd = new MySqlCommand("SELECT doctor_name, specialization FROM doctors ORDER BY doctor_name", conn);
					using (MySqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							cmbDoctor.Items.Add(new DoctorItem
							{
								Name = reader["doctor_name"].ToString(),
								Specialization = reader["specialization"].ToString()
							});
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Could not load doctors: " + ex.Message);
			}
		}

		// Checks every field. isNew = true when booking (past dates are not allowed).
		private bool ValidateForm(bool isNew)
		{
			if (!Validator.IsName(txtPatient.Text))
				return Validator.Fail(txtPatient, "Enter the patient's full name, e.g. \"Ram Sharma\".");

			int age;
			if (!Validator.TryAge(txtAge.Text, out age))
				return Validator.Fail(txtAge, "Age must be a whole number between 1 and 120.");

			if (cmbGender.SelectedIndex < 0)
				return Validator.Fail(cmbGender, "Please select a gender.");

			if (!Validator.IsPhone(txtContact.Text))
				return Validator.Fail(txtContact, "Enter a valid mobile number, e.g. 9841234567.");

			if (!Validator.IsSymptoms(txtSymptoms.Text))
				return Validator.Fail(txtSymptoms, "Symptoms contain invalid characters.\nUse letters, numbers, spaces and , . - ' / ( ) only (or leave it empty).");

			if (cmbDoctor.SelectedIndex < 0)
				return Validator.Fail(cmbDoctor, "Please select a doctor from the list.");

			DateTime date;
			if (!Validator.TryDate(dateTimePicker1.Text, out date))
				return Validator.Fail(dateTimePicker1, "Enter a real date in the format yyyy-MM-dd, for example 2026-10-25.");

			if (isNew && date.Date < DateTime.Today)
				return Validator.Fail(dateTimePicker1, "The appointment date cannot be in the past.");

			if (date.Date > DateTime.Today.AddYears(1))
				return Validator.Fail(dateTimePicker1, "The appointment date cannot be more than one year ahead.");

			DateTime time;
			if (!Validator.TryTime(txtTime.Text, out time))
				return Validator.Fail(txtTime, "Enter a real time, for example 10:30 AM or 14:30.");

			if (isNew && date.Date == DateTime.Today && time.TimeOfDay < DateTime.Now.TimeOfDay)
				return Validator.Fail(txtTime, "That time has already passed today. Choose a later time.");

			// Store date and time in one standard format so the double-booking check works
			dateTimePicker1.Text = date.ToString(Validator.DateFormat);
			txtTime.Text = time.ToString(Validator.TimeFormat, System.Globalization.CultureInfo.InvariantCulture);
			return true;
		}

		private void AppointmentForm_Load(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(DoctorFilter))
				LoadAppointments(DoctorFilter);
			else
				LoadAppointments();
		}

		public void LoadAppointments(string filter = "")
		{
			MySqlConnection conn = DBConnection.GetConnection();
			try
			{
				conn.Open();
				string sql = "SELECT * FROM appointments";

				if (!string.IsNullOrWhiteSpace(filter))
				{
					if (filter == DoctorFilter && !string.IsNullOrEmpty(DoctorFilter))
						sql += " WHERE doctor_name=@f";
					else
						sql += " WHERE patient_name LIKE @f OR doctor_name LIKE @f OR appointment_date LIKE @f";
				}

				sql += " ORDER BY id DESC";

				MySqlCommand cmd = new MySqlCommand(sql, conn);
				if (!string.IsNullOrWhiteSpace(filter))
				{
					if (filter == DoctorFilter && !string.IsNullOrEmpty(DoctorFilter))
						cmd.Parameters.AddWithValue("@f", filter);
					else
						cmd.Parameters.AddWithValue("@f", "%" + filter + "%");
				}

				MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				dgvAppointments.DataSource = dt;
				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnBook_Click(object sender, EventArgs e)
		{
			if (!ValidateForm(true)) return;

			// Double booking check
			try
			{
				using (var connCheck = DBConnection.GetConnection())
				{
					connCheck.Open();
					string checkQuery =
						"SELECT COUNT(*) FROM appointments " +
						"WHERE doctor_name=@doctor " +
						"AND appointment_date=@date " +
						"AND appointment_time=@time";
					MySqlCommand checkCmd = new MySqlCommand(checkQuery, connCheck);
					checkCmd.Parameters.AddWithValue("@doctor", SelectedDoctorName);
					checkCmd.Parameters.AddWithValue("@date", dateTimePicker1.Text.Trim());
					checkCmd.Parameters.AddWithValue("@time", txtTime.Text.Trim());
					int existing = Convert.ToInt32(checkCmd.ExecuteScalar());

					if (existing > 0)
					{
						MessageBox.Show(
							"This doctor already has an appointment at this date and time.\nPlease choose a different time slot.",
							"Double Booking Detected",
							MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); return; }

			// Proceed with booking
			MySqlConnection conn = DBConnection.GetConnection();
			try
			{
				conn.Open();
				string query =
					"INSERT INTO appointments " +
					"(patient_name, age, gender, contact, doctor_name, " +
					"appointment_date, appointment_time, symptoms) " +
					"VALUES (@patient, @age, @gender, @contact, @doctor, @date, @time, @symptoms)";

				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@patient", txtPatient.Text.Trim());
				cmd.Parameters.AddWithValue("@age", txtAge.Text.Trim());
				cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
				cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim());
				cmd.Parameters.AddWithValue("@doctor", SelectedDoctorName);
				cmd.Parameters.AddWithValue("@date", dateTimePicker1.Text.Trim());
				cmd.Parameters.AddWithValue("@time", txtTime.Text.Trim());
				cmd.Parameters.AddWithValue("@symptoms", txtSymptoms.Text.Trim());
				cmd.ExecuteNonQuery();

				MessageBox.Show("Appointment Booked Successfully!", "Success",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadAppointments();
				btnClear_Click(sender, e);
				conn.Close();
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (dgvAppointments.SelectedRows.Count == 0)
			{
				MessageBox.Show("Please select an appointment to update.",
					"Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!ValidateForm(false)) return;

			int id = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells[0].Value);
			MySqlConnection conn = DBConnection.GetConnection();
			try
			{
				conn.Open();
				string query =
					"UPDATE appointments SET " +
					"patient_name=@patient, age=@age, gender=@gender, contact=@contact, " +
					"doctor_name=@doctor, appointment_date=@date, " +
					"appointment_time=@time, symptoms=@symptoms WHERE id=@id";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@patient", txtPatient.Text.Trim());
				cmd.Parameters.AddWithValue("@age", txtAge.Text.Trim());
				cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
				cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim());
				cmd.Parameters.AddWithValue("@doctor", SelectedDoctorName);
				cmd.Parameters.AddWithValue("@date", dateTimePicker1.Text.Trim());
				cmd.Parameters.AddWithValue("@time", txtTime.Text.Trim());
				cmd.Parameters.AddWithValue("@symptoms", txtSymptoms.Text.Trim());
				cmd.Parameters.AddWithValue("@id", id);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Appointment updated!", "Updated",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadAppointments();
				btnClear_Click(sender, e);
				conn.Close();
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgvAppointments.SelectedRows.Count == 0)
			{
				MessageBox.Show("Please select an appointment to delete.",
					"Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (MessageBox.Show("Are you sure you want to delete this appointment?",
				"Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
				return;

			int id = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells[0].Value);
			MySqlConnection conn = DBConnection.GetConnection();
			try
			{
				conn.Open();
				MySqlCommand cmd = new MySqlCommand("DELETE FROM appointments WHERE id=@id", conn);
				cmd.Parameters.AddWithValue("@id", id);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Appointment deleted!", "Deleted",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadAppointments();
				conn.Close();
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			LoadAppointments(txtSearch.Text.Trim());
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtPatient.Clear();
			cmbDoctor.SelectedIndex = -1;
			dateTimePicker1.Clear();
			txtTime.Clear();
			txtSymptoms.Clear();
			txtAge.Clear();
			cmbGender.SelectedIndex = -1;
			txtContact.Clear();
			txtSearch.Clear();
			LoadAppointments();
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			if (dgvAppointments.Rows.Count == 0)
			{
				MessageBox.Show("No appointments to export.", "Export",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "CSV files (*.csv)|*.csv";
			sfd.FileName = "Appointments_" + DateTime.Now.ToString("yyyyMMdd");

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				System.Text.StringBuilder sb = new System.Text.StringBuilder();

				for (int i = 0; i < dgvAppointments.Columns.Count; i++)
				{
					sb.Append(dgvAppointments.Columns[i].HeaderText);
					if (i < dgvAppointments.Columns.Count - 1) sb.Append(",");
				}
				sb.AppendLine();

				foreach (DataGridViewRow row in dgvAppointments.Rows)
				{
					for (int i = 0; i < dgvAppointments.Columns.Count; i++)
					{
						object value = row.Cells[i].Value;
						string text = value == null ? "" : value.ToString().Replace(",", ";");
						sb.Append(text);
						if (i < dgvAppointments.Columns.Count - 1) sb.Append(",");
					}
					sb.AppendLine();
				}

				System.IO.File.WriteAllText(sfd.FileName, sb.ToString());
				MessageBox.Show("Report exported successfully!\n" + sfd.FileName,
					"Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgvAppointments.Rows[e.RowIndex];
				if (row.Cells["patient_name"].Value != null)
					txtPatient.Text = row.Cells["patient_name"].Value.ToString();

				// Match the saved doctor NAME to the right dropdown item,
				// so the "(Specialization)" part is never typed into the box.
				if (row.Cells["doctor_name"].Value != null)
				{
					string doctorName = row.Cells["doctor_name"].Value.ToString();
					cmbDoctor.SelectedIndex = -1;
					foreach (DoctorItem d in cmbDoctor.Items)
					{
						if (d.Name == doctorName)
						{
							cmbDoctor.SelectedItem = d;
							break;
						}
					}
				}

				if (row.Cells["appointment_date"].Value != null)
					dateTimePicker1.Text = row.Cells["appointment_date"].Value.ToString();
				if (row.Cells["appointment_time"].Value != null)
					txtTime.Text = row.Cells["appointment_time"].Value.ToString();
				if (row.Cells["symptoms"].Value != null)
					txtSymptoms.Text = row.Cells["symptoms"].Value.ToString();
				if (row.Cells["age"].Value != null)
					txtAge.Text = row.Cells["age"].Value.ToString();
				if (row.Cells["gender"].Value != null)
					cmbGender.Text = row.Cells["gender"].Value.ToString();
				if (row.Cells["contact"].Value != null)
					txtContact.Text = row.Cells["contact"].Value.ToString();
			}
		}
	}
}