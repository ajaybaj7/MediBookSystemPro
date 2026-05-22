using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediBookSystem
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void pictureBoxLogo_Click(object sender, EventArgs e)
		{

		}

		private void lblSubtitle_Click(object sender, EventArgs e)
		{

		}

		private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cmbRole.Items.Add("Super Admin");
			cmbRole.Items.Add("Admin");
			cmbRole.Items.Add("Doctor");
			cmbRole.Items.Add("Patient");
			cmbRole.Items.Add("Receptionist");

			cmbRole.SelectedIndex = 0;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = txtUsername.Text;
			string password = txtPassword.Text;
			string role = cmbRole.SelectedItem.ToString();

			if (username == "" || password == "")
			{
				MessageBox.Show("Please enter username and password");
				return;
			}

			Dashboard dashboard = new Dashboard();

			dashboard.UserRole = role;

			dashboard.Show();

			this.Hide();

			this.Hide();
		}
	}
}
