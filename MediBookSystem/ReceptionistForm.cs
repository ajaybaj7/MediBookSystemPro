using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MediBookSystem
{
	public partial class ReceptionistForm : Form
	{
		public ReceptionistForm()
		{
			InitializeComponent();
		}

		private void ReceptionistForm_Load(object sender, EventArgs e)
		{
			LoadAppointments();
			LoadPatients();
			LoadDoctors();
			PopulateDoctorCombo();
		}

		// ═════════════════════════════════════════════════
		//  LOAD DATA
		// ═════════════════════════════════════════════════
		private void LoadAppointments()
		{
			try
			{
				using (var conn = DBConnection.GetConnection())
				{
					conn.Open();
					var dt = new DataTable();
					new MySqlDataAdapter("SELECT * FROM appointments ORDER BY id DESC", conn).Fill(dt);
					dgvAppointments.DataSource = dt;
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void LoadPatients()
		{
			try
			{
				using (var conn = DBConnection.GetConnection())
				{
					conn.Open();
					var dt = new DataTable();
					new MySqlDataAdapter("SELECT * FROM patients ORDER BY id DESC", conn).Fill(dt);
					dgvPatients.DataSource = dt;
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void LoadDoctors()
		{
			try
			{
				using (var conn = DBConnection.GetConnection())
				{
					conn.Open();
					var dt = new DataTable();
					new MySqlDataAdapter("SELECT * FROM doctors ORDER BY id", conn).Fill(dt);
					dgvDoctors.DataSource = dt;
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void PopulateDoctorCombo()
		{
			try
			{
				using (var conn = DBConnection.GetConnection())
				{
					conn.Open();
					var dt = new DataTable();
					new MySqlDataAdapter("SELECT doctor_name FROM doctors ORDER BY doctor_name", conn).Fill(dt);
					cmbApptDoctor.Items.Clear();
					foreach (DataRow row in dt.Rows)
						cmbApptDoctor.Items.Add(row["doctor_name"].ToString());
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		// ═════════════════════════════════════════════════
		//  APPOINTMENTS — CRUD
		// ═════════════════════════════════════════════════
		private void btnApptBook_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtApptPatient.Text) ||
				string.IsNullOrWhiteSpace(cmbApptDoctor.Text) ||
				string.IsNullOrWhiteSpace(txtApptDate.Text))
			{
				MessageBox.Show("Patient, Doctor and Date are required.",
					"Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// ── Double booking check ──
			try
			{
				using (var connCheck = DBConnection.GetConnection())
				{
					connCheck.Open();
					string checkSql =
						"SELECT COUNT(*) FROM appointments " +
						"WHERE doctor_name=@doctor " +
						"AND appointment_date=@date " +
						"AND appointment_time=@time";
					var checkCmd = new MySqlCommand(checkSql, connCheck);
					checkCmd.Parameters.AddWithValue("@doctor", cmbApptDoctor.Text);
					checkCmd.Parameters.AddWithValue("@date", txtApptDate.Text.Trim());
					checkCmd.Parameters.AddWithValue("@time", txtApptTime.Text.Trim());
					int existing = Convert.ToInt32(checkCmd.ExecuteScalar());

					if (existing > 0)
					{
						MessageBox.Show(
							"This doctor already has an appointment at this date and time.\n" +
							"Please choose a different time slot.",
							"Double Booking Detected",
							MessageBoxButtons.OK,
							MessageBoxIcon.Warning
						);
						return;
					}
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); return; }

			// ── Proceed with booking ──
			try
			{
				using (var conn = DBConnection.GetConnection())
				{
					conn.Open();
					string sql =
						"INSERT INTO appointments " +
						"(patient_name, doctor_name, appointment_date, appointment_time, symptoms) " +
						"VALUES (@p, @d, @dt, @t, @s)";
					var cmd = new MySqlCommand(sql, conn);
					cmd.Parameters.AddWithValue("@p", txtApptPatient.Text.Trim());
					cmd.Parameters.AddWithValue("@d", cmbApptDoctor.Text);
					cmd.Parameters.AddWithValue("@dt", txtApptDate.Text.Trim());
					cmd.Parameters.AddWithValue("@t", txtApptTime.Text.Trim());
					cmd.Parameters.AddWithValue("@s", txtApptSymptoms.Text.Trim());
					cmd.ExecuteNonQuery();
				}
				MessageBox.Show("Appointment booked!", "Success",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadAppointments();
				ClearApptFields();
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void btnApptUpdate_Click(object sender, EventArgs e)
		{
			if (dgvAppointments.SelectedRows.Count == 0)
			{
				MessageBox.Show("Select a row to update.", "Validation",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int id = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells[0].Value);
			try
			{
				using (var conn = DBConnection.GetConnection())
				{
					conn.Open();
					string sql =
						"UPDATE appointments SET patient_name=@p, doctor_name=@d, " +
						"appointment_date=@dt, appointment_time=@t, symptoms=@s WHERE id=@id";
					var cmd = new MySqlCommand(sql, conn);
					cmd.Parameters.AddWithValue("@p", txtApptPatient.Text.Trim());
					cmd.Parameters.AddWithValue("@d", cmbApptDoctor.Text);
					cmd.Parameters.AddWithValue("@dt", txtApptDate.Text.Trim());
					cmd.Parameters.AddWithValue("@t", txtApptTime.Text.Trim());
					cmd.Parameters.AddWithValue("@s", txtApptSymptoms.Text.Trim());
					cmd.Parameters.AddWithValue("@id", id);
					cmd.ExecuteNonQuery();
				}
				MessageBox.Show("Appointment updated!", "Updated",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadAppointments();
				ClearApptFields();
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void btnApptDelete_Click(object sender, EventArgs e)
		{
			if (dgvAppointments.SelectedRows.Count == 0)
			{
				MessageBox.Show("Select a row to delete.", "Validation",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (MessageBox.Show("Delete this appointment?", "Confirm",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
				return;

			int id = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells[0].Value);
			try
			{
				using (var conn = DBConnection.GetConnection())
				{
					conn.Open();
					var cmd = new MySqlCommand("DELETE FROM appointments WHERE id=@id", conn);
					cmd.Parameters.AddWithValue("@id", id);
					cmd.ExecuteNonQuery();
				}
				MessageBox.Show("Appointment deleted.", "Deleted",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadAppointments();
				ClearApptFields();
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void btnApptClear_Click(object sender, EventArgs e) => ClearApptFields();

		private void dgvAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;
			var row = dgvAppointments.Rows[e.RowIndex];
			try
			{
				txtApptPatient.Text = row.Cells["patient_name"].Value?.ToString();
				cmbApptDoctor.Text = row.Cells["doctor_name"].Value?.ToString();
				txtApptDate.Text = row.Cells["appointment_date"].Value?.ToString();
				txtApptTime.Text = row.Cells["appointment_time"].Value?.ToString();
				txtApptSymptoms.Text = row.Cells["symptoms"].Value?.ToString();
			}
			catch { }
		}

		private void ClearApptFields()
		{
			txtApptPatient.Clear();
			cmbApptDoctor.SelectedIndex = -1;
			txtApptDate.Clear();
			txtApptTime.Clear();
			txtApptSymptoms.Clear();
		}

		// ═════════════════════════════════════════════════
		//  PATIENTS — CRUD
		// ═════════════════════════════════════════════════
		private void btnPatAdd_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtPatName.Text) ||
				string.IsNullOrWhiteSpace(txtPatContact.Text))
			{
				MessageBox.Show("Name and Contact are required.", "Validation",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				using (var conn = DBConnection.GetConnection())
				{
					conn.Open();
					string sql =
						"INSERT INTO patients (patient_name, age, gender, contact) " +
						"VALUES (@n, @a, @g, @c)";
					var cmd = new MySqlCommand(sql, conn);
					cmd.Parameters.AddWithValue("@n", txtPatName.Text.Trim());
					cmd.Parameters.AddWithValue("@a", txtPatAge.Text.Trim());
					cmd.Parameters.AddWithValue("@g", cmbPatGender.Text);
					cmd.Parameters.AddWithValue("@c", txtPatContact.Text.Trim());
					cmd.ExecuteNonQuery();
				}
				MessageBox.Show("Patient registered!", "Success",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadPatients();
				ClearPatFields();
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void btnPatUpdate_Click(object sender, EventArgs e)
		{
			if (dgvPatients.SelectedRows.Count == 0)
			{
				MessageBox.Show("Select a patient to update.", "Validation",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int id = Convert.ToInt32(dgvPatients.SelectedRows[0].Cells[0].Value);
			try
			{
				using (var conn = DBConnection.GetConnection())
				{
					conn.Open();
					string sql =
						"UPDATE patients SET patient_name=@n, age=@a, " +
						"gender=@g, contact=@c WHERE id=@id";
					var cmd = new MySqlCommand(sql, conn);
					cmd.Parameters.AddWithValue("@n", txtPatName.Text.Trim());
					cmd.Parameters.AddWithValue("@a", txtPatAge.Text.Trim());
					cmd.Parameters.AddWithValue("@g", cmbPatGender.Text);
					cmd.Parameters.AddWithValue("@c", txtPatContact.Text.Trim());
					cmd.Parameters.AddWithValue("@id", id);
					cmd.ExecuteNonQuery();
				}
				MessageBox.Show("Patient updated!", "Updated",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadPatients();
				ClearPatFields();
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void btnPatDelete_Click(object sender, EventArgs e)
		{
			if (dgvPatients.SelectedRows.Count == 0)
			{
				MessageBox.Show("Select a patient to delete.", "Validation",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (MessageBox.Show("Delete this patient?", "Confirm",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
				return;

			int id = Convert.ToInt32(dgvPatients.SelectedRows[0].Cells[0].Value);
			try
			{
				using (var conn = DBConnection.GetConnection())
				{
					conn.Open();
					var cmd = new MySqlCommand("DELETE FROM patients WHERE id=@id", conn);
					cmd.Parameters.AddWithValue("@id", id);
					cmd.ExecuteNonQuery();
				}
				MessageBox.Show("Patient deleted.", "Deleted",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadPatients();
				ClearPatFields();
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void btnPatClear_Click(object sender, EventArgs e) => ClearPatFields();

		private void dgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;
			var row = dgvPatients.Rows[e.RowIndex];
			try
			{
				txtPatName.Text = row.Cells["patient_name"].Value?.ToString();
				txtPatAge.Text = row.Cells["age"].Value?.ToString();
				cmbPatGender.Text = row.Cells["gender"].Value?.ToString();
				txtPatContact.Text = row.Cells["contact"].Value?.ToString();
			}
			catch { }
		}

		private void ClearPatFields()
		{
			txtPatName.Clear();
			txtPatAge.Clear();
			cmbPatGender.SelectedIndex = -1;
			txtPatContact.Clear();
		}
	}
}