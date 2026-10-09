using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MediBookSystem
{
	public partial class PatientForm : Form
	{
		public PatientForm()
		{
			InitializeComponent();
			LoadPatients();

			txtPatientName.KeyPress += Validator.NameChars;
			txtAge.KeyPress += Validator.DigitsOnly;
			txtAge.MaxLength = 3;
			txtPatientContact.KeyPress += Validator.PhoneChars;
			txtPatientContact.MaxLength = 15;
		}

		private bool ValidatePatient()
		{
			if (!Validator.IsName(txtPatientName.Text))
				return Validator.Fail(txtPatientName, "Enter a valid patient name (letters only, 2-50 characters).");

			int age;
			if (!Validator.TryAge(txtAge.Text, out age))
				return Validator.Fail(txtAge, "Age must be a whole number between 1 and 120.");

			if (string.IsNullOrWhiteSpace(cmbGender.Text))
				return Validator.Fail(cmbGender, "Please select a gender.");

			if (!Validator.IsPhone(txtPatientContact.Text))
				return Validator.Fail(txtPatientContact, "Contact must be 7 to 15 digits (a + is allowed at the start).");
			return true;
		}

		public void LoadPatients()
		{
			MySqlConnection conn = DBConnection.GetConnection();
			try
			{
				conn.Open();
				string query = "SELECT * FROM patients";
				MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				dgvPatients.DataSource = dt;
				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void PatientForm_Load(object sender, EventArgs e) { }

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (!ValidatePatient()) return;

			MySqlConnection conn = DBConnection.GetConnection();
			try
			{
				conn.Open();
				string query =
					"INSERT INTO patients (patient_name, age, gender, contact) " +
					"VALUES (@name, @age, @gender, @contact)";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@name", txtPatientName.Text.Trim());
				cmd.Parameters.AddWithValue("@age", txtAge.Text.Trim());
				cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
				cmd.Parameters.AddWithValue("@contact", txtPatientContact.Text.Trim());
				cmd.ExecuteNonQuery();
				MessageBox.Show(
					"Patient added successfully!",
					"Success",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
				LoadPatients();
				btnClear_Click(sender, e);
				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (dgvPatients.SelectedRows.Count == 0)
			{
				MessageBox.Show(
					"Please select a patient to update.",
					"Validation",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}

			if (!ValidatePatient()) return;

			int id = Convert.ToInt32(dgvPatients.SelectedRows[0].Cells[0].Value);
			MySqlConnection conn = DBConnection.GetConnection();
			try
			{
				conn.Open();
				string query =
					"UPDATE patients SET " +
					"patient_name=@name, age=@age, " +
					"gender=@gender, contact=@contact " +
					"WHERE id=@id";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@name", txtPatientName.Text.Trim());
				cmd.Parameters.AddWithValue("@age", txtAge.Text.Trim());
				cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
				cmd.Parameters.AddWithValue("@contact", txtPatientContact.Text.Trim());
				cmd.Parameters.AddWithValue("@id", id);
				cmd.ExecuteNonQuery();
				MessageBox.Show(
					"Patient updated successfully!",
					"Updated",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
				LoadPatients();
				btnClear_Click(sender, e);
				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgvPatients.SelectedRows.Count == 0)
			{
				MessageBox.Show(
					"Please select a patient to delete.",
					"Validation",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}

			DialogResult confirm = MessageBox.Show(
				"Are you sure you want to delete this patient?",
				"Confirm Delete",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning
			);

			if (confirm == DialogResult.Yes)
			{
				int id = Convert.ToInt32(dgvPatients.SelectedRows[0].Cells[0].Value);
				MySqlConnection conn = DBConnection.GetConnection();
				try
				{
					conn.Open();
					string query = "DELETE FROM patients WHERE id=@id";
					MySqlCommand cmd = new MySqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@id", id);
					cmd.ExecuteNonQuery();
					MessageBox.Show(
						"Patient deleted successfully!",
						"Deleted",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information
					);
					LoadPatients();
					conn.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dgvPatients.Rows)
			{
				if (row.Cells["patient_name"].Value != null &&
					row.Cells["patient_name"].Value.ToString().ToLower()
					.Contains(txtPatientName.Text.ToLower()))
				{
					dgvPatients.ClearSelection();
					row.Selected = true;
					dgvPatients.FirstDisplayedScrollingRowIndex = row.Index;
					break;
				}
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtPatientName.Clear();
			txtAge.Clear();
			cmbGender.SelectedIndex = -1;
			txtPatientContact.Clear();
			txtPatientName.Focus();
		}

		private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgvPatients.Rows[e.RowIndex];
				if (row.Cells["patient_name"].Value != null)
					txtPatientName.Text = row.Cells["patient_name"].Value.ToString();
				if (row.Cells["age"].Value != null)
					txtAge.Text = row.Cells["age"].Value.ToString();
				if (row.Cells["gender"].Value != null)
					cmbGender.Text = row.Cells["gender"].Value.ToString();
				if (row.Cells["contact"].Value != null)
					txtPatientContact.Text = row.Cells["contact"].Value.ToString();
			}
		}
	}
}