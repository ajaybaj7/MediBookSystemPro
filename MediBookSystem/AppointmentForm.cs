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

		public AppointmentForm()
		{
			InitializeComponent();
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
						cmd.Parameters.AddWithValue("@f", $"%{filter}%");
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
			if (string.IsNullOrWhiteSpace(txtPatient.Text) ||
				string.IsNullOrWhiteSpace(txtDoctor.Text) ||
				string.IsNullOrWhiteSpace(dateTimePicker1.Text))
			{
				MessageBox.Show("Patient Name, Doctor and Date are required.",
					"Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

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
					checkCmd.Parameters.AddWithValue("@doctor", txtDoctor.Text.Trim());
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
				cmd.Parameters.AddWithValue("@doctor", txtDoctor.Text.Trim());
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
				cmd.Parameters.AddWithValue("@doctor", txtDoctor.Text.Trim());
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
			txtDoctor.Clear();
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
						sb.Append(row.Cells[i].Value?.ToString()?.Replace(",", ";"));
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
				if (row.Cells["doctor_name"].Value != null)
					txtDoctor.Text = row.Cells["doctor_name"].Value.ToString();
				if (row.Cells["appointment_date"].Value != null)
					dateTimePicker1.Text = row.Cells["appointment_date"].Value.ToString();
				if (row.Cells["appointment_time"].Value != null)
					txtTime.Text = row.Cells["appointment_time"].Value.ToString();
				if (row.Cells["symptoms"].Value != null)
					txtSymptoms.Text = row.Cells["symptoms"].Value.ToString();
			}
		}
	}
}