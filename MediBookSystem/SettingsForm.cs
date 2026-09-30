using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MediBookSystem
{
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			InitializeComponent();
			ThemeManager.ApplyDarkTheme(this);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtNewUsername.Text) ||
				string.IsNullOrWhiteSpace(txtNewPassword.Text))
			{
				MessageBox.Show(
					"Please fill in both fields before saving.",
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
					"UPDATE users SET username=@username, password=@password " +
					"WHERE role='Admin'";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@username", txtNewUsername.Text.Trim());
				cmd.Parameters.AddWithValue("@password", txtNewPassword.Text);
				int rows = cmd.ExecuteNonQuery();

				if (rows > 0)
				{
					MessageBox.Show(
						"Credentials updated successfully!",
						"Saved",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information
					);
					txtNewUsername.Clear();
					txtNewPassword.Clear();
				}
				else
				{
					MessageBox.Show(
						"No Admin account found to update.",
						"Not Found",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning
					);
				}
				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Database Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnDarkMode_Click(object sender, EventArgs e)
		{
			ThemeManager.ApplyDarkTheme(this);
		}

		private void btnLightMode_Click(object sender, EventArgs e)
		{
			ThemeManager.ApplyLightTheme(this);
		}
	}
}