using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MediBookSystem
{
	public partial class DoctorForm : Form
	{
		public DoctorForm()
		{
			InitializeComponent();
			LoadDoctors();

			txtDoctorName.KeyPress += Validator.NameChars;
			txtDoctorName.MaxLength = 50;
			txtSpecialization.KeyPress += Validator.NameChars;
			txtSpecialization.MaxLength = 50;
			txtContact.KeyPress += Validator.PhoneChars;
			txtContact.MaxLength = 15;
		}

		private bool ValidateDoctor()
		{
			if (!Validator.IsName(txtDoctorName.Text))
				return Validator.Fail(txtDoctorName, "Enter a valid doctor name, e.g. \"Amit Mishra\" (letters only, 2-50 characters).");
			if (!Validator.IsSpecialization(txtSpecialization.Text))
				return Validator.Fail(txtSpecialization, "Enter a valid specialization, e.g. \"Surgeon\" or \"Heart Specialist\" (letters only, 2-50 characters).");
			if (!Validator.IsPhone(txtContact.Text))
				return Validator.Fail(txtContact, "Enter a valid mobile number, e.g. 9841234567.");
			return true;
		}

		public void LoadDoctors()
		{
			MySqlConnection conn = DBConnection.GetConnection();
			try
			{
				conn.Open();
				string query = "SELECT * FROM doctors";
				MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				dgvDoctors.DataSource = dt;
				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void DoctorForm_Load(object sender, EventArgs e) { }

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (!ValidateDoctor()) return;

			MySqlConnection conn = DBConnection.GetConnection();
			try
			{
				conn.Open();
				string query =
					"INSERT INTO doctors (doctor_name, specialization, contact) " +
					"VALUES (@name, @specialization, @contact)";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@name", txtDoctorName.Text.Trim());
				cmd.Parameters.AddWithValue("@specialization", txtSpecialization.Text.Trim());
				cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim());
				cmd.ExecuteNonQuery();
				MessageBox.Show(
					"Doctor added successfully!",
					"Success",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
				LoadDoctors();
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
			if (dgvDoctors.SelectedRows.Count == 0)
			{
				MessageBox.Show(
					"Please select a doctor to update.",
					"Validation",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}

			if (!ValidateDoctor()) return;

			int id = Convert.ToInt32(dgvDoctors.SelectedRows[0].Cells[0].Value);
			MySqlConnection conn = DBConnection.GetConnection();
			try
			{
				conn.Open();
				string query =
					"UPDATE doctors SET " +
					"doctor_name=@name, " +
					"specialization=@specialization, " +
					"contact=@contact " +
					"WHERE id=@id";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@name", txtDoctorName.Text.Trim());
				cmd.Parameters.AddWithValue("@specialization", txtSpecialization.Text.Trim());
				cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim());
				cmd.Parameters.AddWithValue("@id", id);
				cmd.ExecuteNonQuery();
				MessageBox.Show(
					"Doctor updated successfully!",
					"Updated",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
				LoadDoctors();
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
			if (dgvDoctors.SelectedRows.Count == 0)
			{
				MessageBox.Show(
					"Please select a doctor to delete.",
					"Validation",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}

			DialogResult confirm = MessageBox.Show(
				"Are you sure you want to delete this doctor?",
				"Confirm Delete",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning
			);

			if (confirm == DialogResult.Yes)
			{
				int id = Convert.ToInt32(dgvDoctors.SelectedRows[0].Cells[0].Value);
				MySqlConnection conn = DBConnection.GetConnection();
				try
				{
					conn.Open();
					string query = "DELETE FROM doctors WHERE id=@id";
					MySqlCommand cmd = new MySqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@id", id);
					cmd.ExecuteNonQuery();
					MessageBox.Show(
						"Doctor deleted successfully!",
						"Deleted",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information
					);
					LoadDoctors();
					conn.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtDoctorName.Clear();
			txtSpecialization.Clear();
			txtContact.Clear();
			txtDoctorName.Focus();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dgvDoctors.Rows)
			{
				if (row.Cells["doctor_name"].Value != null &&
					row.Cells["doctor_name"].Value.ToString().ToLower()
					.Contains(txtDoctorName.Text.ToLower()))
				{
					dgvDoctors.ClearSelection();
					row.Selected = true;
					dgvDoctors.FirstDisplayedScrollingRowIndex = row.Index;
					break;
				}
			}
		}

		private void dgvDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgvDoctors.Rows[e.RowIndex];
				if (row.Cells["doctor_name"].Value != null)
					txtDoctorName.Text = row.Cells["doctor_name"].Value.ToString();
				if (row.Cells["specialization"].Value != null)
					txtSpecialization.Text = row.Cells["specialization"].Value.ToString();
				if (row.Cells["contact"].Value != null)
					txtContact.Text = row.Cells["contact"].Value.ToString();
			}
		}
	}
}