using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MediBookSystem
{
	public partial class StaffForm : Form
	{
		public StaffForm()
		{
			InitializeComponent();
			LoadStaff();
		}

		private void LoadStaff()
		{
			MySqlConnection conn = DBConnection.GetConnection();
			try
			{
				conn.Open();
				string query = "SELECT * FROM staff";
				MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				dgvStaff.DataSource = dt;
				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading staff: " + ex.Message);
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtStaffName.Text) ||
				string.IsNullOrWhiteSpace(txtRole.Text))
			{
				MessageBox.Show(
					"Please fill in Staff Name and Role.",
					"Validation",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}

			MySqlConnection conn = DBConnection.GetConnection();
			try
			{
				conn.Open();
				string query =
					"INSERT INTO staff (staff_name, role, contact, email, address) " +
					"VALUES (@name, @role, @contact, @email, @address)";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@name", txtStaffName.Text.Trim());
				cmd.Parameters.AddWithValue("@role", txtRole.Text.Trim());
				cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim());
				cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
				cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
				cmd.ExecuteNonQuery();
				MessageBox.Show(
					"Staff added successfully!",
					"Success",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
				LoadStaff();
				ClearFields();
				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (dgvStaff.SelectedRows.Count == 0)
			{
				MessageBox.Show(
					"Please select a staff member to update.",
					"Validation",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}

			int id = Convert.ToInt32(dgvStaff.SelectedRows[0].Cells["id"].Value);
			MySqlConnection conn = DBConnection.GetConnection();
			try
			{
				conn.Open();
				string query =
					"UPDATE staff SET " +
					"staff_name=@name, role=@role, " +
					"contact=@contact, email=@email, address=@address " +
					"WHERE id=@id";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@name", txtStaffName.Text.Trim());
				cmd.Parameters.AddWithValue("@role", txtRole.Text.Trim());
				cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim());
				cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
				cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
				cmd.Parameters.AddWithValue("@id", id);
				cmd.ExecuteNonQuery();
				MessageBox.Show(
					"Staff updated successfully!",
					"Updated",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
				LoadStaff();
				ClearFields();
				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgvStaff.SelectedRows.Count == 0)
			{
				MessageBox.Show(
					"Please select a staff member to delete.",
					"Validation",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}

			DialogResult confirm = MessageBox.Show(
				"Are you sure you want to delete this staff member?",
				"Confirm Delete",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning
			);

			if (confirm == DialogResult.Yes)
			{
				int id = Convert.ToInt32(dgvStaff.SelectedRows[0].Cells["id"].Value);
				MySqlConnection conn = DBConnection.GetConnection();
				try
				{
					conn.Open();
					string query = "DELETE FROM staff WHERE id=@id";
					MySqlCommand cmd = new MySqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@id", id);
					cmd.ExecuteNonQuery();
					MessageBox.Show(
						"Staff deleted successfully!",
						"Deleted",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information
					);
					LoadStaff();
					ClearFields();
					conn.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message);
				}
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearFields();
		}

		private void ClearFields()
		{
			txtStaffName.Clear();
			txtRole.Clear();
			txtContact.Clear();
			txtEmail.Clear();
			txtAddress.Clear();
			txtStaffName.Focus();
		}

		private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgvStaff.Rows[e.RowIndex];
				if (row.Cells["staff_name"].Value != null)
					txtStaffName.Text = row.Cells["staff_name"].Value.ToString();
				if (row.Cells["role"].Value != null)
					txtRole.Text = row.Cells["role"].Value.ToString();
				if (row.Cells["contact"].Value != null)
					txtContact.Text = row.Cells["contact"].Value.ToString();
				if (row.Cells["email"].Value != null)
					txtEmail.Text = row.Cells["email"].Value.ToString();
				if (row.Cells["address"].Value != null)
					txtAddress.Text = row.Cells["address"].Value.ToString();
			}
		}

		private void StaffForm_Load(object sender, EventArgs e) { }
	}
}