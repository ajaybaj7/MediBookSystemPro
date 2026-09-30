using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MediBookSystem
{
	public partial class SuperAdminForm : Form
	{
		public SuperAdminForm()
		{
			InitializeComponent();
		}

		private void SuperAdminForm_Load(object sender, EventArgs e)
		{
			LoadUsers();
		}

		private void LoadUsers()
		{
			MySqlConnection conn = DBConnection.GetConnection();
			try
			{
				conn.Open();
				MySqlDataAdapter adapter = new MySqlDataAdapter(
					"SELECT id, username, role FROM users ORDER BY role", conn);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				dgvUsers.DataSource = dt;
				conn.Close();
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
				string.IsNullOrWhiteSpace(txtPassword.Text) ||
				string.IsNullOrWhiteSpace(cmbRole.Text))
			{
				MessageBox.Show("All fields are required.",
					"Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			MySqlConnection conn = DBConnection.GetConnection();
			try
			{
				conn.Open();
				string query =
					"INSERT INTO users (username, password, role) " +
					"VALUES (@u, @p, @r)";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim());
				cmd.Parameters.AddWithValue("@p", txtPassword.Text);
				cmd.Parameters.AddWithValue("@r", cmbRole.Text);
				cmd.ExecuteNonQuery();
				MessageBox.Show("User added successfully!", "Success",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadUsers();
				btnClear_Click(sender, e);
				conn.Close();
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (dgvUsers.SelectedRows.Count == 0)
			{
				MessageBox.Show("Please select a user to update.",
					"Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int id = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells[0].Value);
			MySqlConnection conn = DBConnection.GetConnection();
			try
			{
				conn.Open();
				string query =
					"UPDATE users SET username=@u, password=@p, role=@r " +
					"WHERE id=@id";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim());
				cmd.Parameters.AddWithValue("@p", txtPassword.Text);
				cmd.Parameters.AddWithValue("@r", cmbRole.Text);
				cmd.Parameters.AddWithValue("@id", id);
				cmd.ExecuteNonQuery();
				MessageBox.Show("User updated successfully!", "Updated",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadUsers();
				btnClear_Click(sender, e);
				conn.Close();
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgvUsers.SelectedRows.Count == 0)
			{
				MessageBox.Show("Please select a user to delete.",
					"Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (MessageBox.Show("Are you sure you want to delete this user?",
				"Confirm Delete", MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning) != DialogResult.Yes)
				return;

			int id = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells[0].Value);
			MySqlConnection conn = DBConnection.GetConnection();
			try
			{
				conn.Open();
				MySqlCommand cmd = new MySqlCommand(
					"DELETE FROM users WHERE id=@id", conn);
				cmd.Parameters.AddWithValue("@id", id);
				cmd.ExecuteNonQuery();
				MessageBox.Show("User deleted successfully!", "Deleted",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadUsers();
				conn.Close();
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtUsername.Clear();
			txtPassword.Clear();
			cmbRole.SelectedIndex = -1;
			txtUsername.Focus();
		}

		private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;
			DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
			txtUsername.Text = row.Cells["username"].Value?.ToString();
			txtPassword.Text = "";
			cmbRole.Text = row.Cells["role"].Value?.ToString();
		}
	}
}