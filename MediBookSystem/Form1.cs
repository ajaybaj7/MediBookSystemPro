using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MediBookSystem
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cmbRole.Items.Add("Admin");
			cmbRole.Items.Add("Doctor");
			cmbRole.Items.Add("Patient");
			cmbRole.Items.Add("Staff");

			cmbRole.SelectedIndex = 0;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			// Basic validation
			if (string.IsNullOrWhiteSpace(txtUsername.Text))
			{
				MessageBox.Show(
					"Please enter your username.",
					"Validation",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				txtUsername.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(txtPassword.Text))
			{
				MessageBox.Show(
					"Please enter your password.",
					"Validation",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				txtPassword.Focus();
				return;
			}

			MySqlConnection conn = DBConnection.GetConnection();

			try
			{
				conn.Open();

				string query =
					"SELECT * FROM users " +
					"WHERE username=@username " +
					"AND password=@password " +
					"AND role=@role";

				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
				cmd.Parameters.AddWithValue("@password", txtPassword.Text);
				cmd.Parameters.AddWithValue("@role", cmbRole.Text);

				MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adapter.Fill(dt);

				if (dt.Rows.Count > 0)
				{
					Dashboard dashboard = new Dashboard();
					dashboard.LoginForm = this;
					dashboard.UserRole = cmbRole.Text;
					dashboard.UserName = txtUsername.Text.Trim();
					dashboard.Show();
					this.Hide();
				}
				else
				{
					MessageBox.Show(
						"Invalid username, password or role.\nPlease try again.",
						"Login Failed",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error
					);
					txtPassword.Clear();
					txtPassword.Focus();
				}

				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					"Connection error: " + ex.Message,
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}

		private void pictureBoxLogo_Click(object sender, EventArgs e) { }
		private void lblSubtitle_Click(object sender, EventArgs e) { }
		private void cmbRole_SelectedIndexChanged(object sender, EventArgs e) { }
	}
}