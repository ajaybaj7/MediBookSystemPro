using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MediBookSystem
{
	public partial class Dashboard : Form
	{
		public string UserRole;
		public string UserName;
		private bool isDarkMode = true;
		public Form LoginForm;            // the login form that opened this dashboard
		private bool loggingOut = false;

		public Dashboard()
		{
			InitializeComponent();
			this.Resize += Dashboard_Resize;
			this.FormClosed += Dashboard_FormClosed;
		}

		public void LoadChart()
		{
			MySqlConnection conn = DBConnection.GetConnection();
			try
			{
				conn.Open();

				int doctors = Convert.ToInt32(
					new MySqlCommand(
						"SELECT COUNT(*) FROM doctors", conn
					).ExecuteScalar());

				int patients = Convert.ToInt32(
					new MySqlCommand(
						"SELECT COUNT(*) FROM patients", conn
					).ExecuteScalar());

				int appointments = Convert.ToInt32(
					new MySqlCommand(
						"SELECT COUNT(*) FROM appointments", conn
					).ExecuteScalar());

				int staff = Convert.ToInt32(
					new MySqlCommand(
						"SELECT COUNT(*) FROM users WHERE role='Staff'", conn
					).ExecuteScalar());

				// Update stat cards
				lblDoctors.Text = doctors.ToString();
				lblPatients.Text = patients.ToString();
				lblAppointments.Text = appointments.ToString();
				lblStaff.Text = staff.ToString();

				// Build chart
				chartDashboard.Series.Clear();

				Series series = new Series();
				series.Name = "Hospital Data";
				series.ChartType = SeriesChartType.Pie;
				series.IsValueShownAsLabel = true;
				series["PieLabelStyle"] = "Outside";
				series.Label = "#PERCENT{P0}";
				series.LabelForeColor = System.Drawing.Color.White;
				series.LegendText = "#VALX";

				series.Points.AddXY("Doctors", doctors);
				series.Points.AddXY("Patients", patients);
				series.Points.AddXY("Appointments", appointments);
				series.Points.AddXY("Staff", staff);

				series.Points[0].Color = System.Drawing.Color.FromArgb(59, 130, 246);
				series.Points[1].Color = System.Drawing.Color.FromArgb(16, 185, 129);
				series.Points[2].Color = System.Drawing.Color.FromArgb(245, 158, 11);
				series.Points[3].Color = System.Drawing.Color.FromArgb(139, 92, 246);

				chartDashboard.ChartAreas[0].Area3DStyle.Enable3D = true;
				chartDashboard.ChartAreas[0].BackColor =
					System.Drawing.Color.FromArgb(30, 41, 59);
				chartDashboard.BackColor =
					System.Drawing.Color.FromArgb(30, 41, 59);
				chartDashboard.Legends[0].BackColor =
					System.Drawing.Color.FromArgb(30, 41, 59);
				chartDashboard.Legends[0].ForeColor =
					System.Drawing.Color.White;

				chartDashboard.Series.Add(series);
				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			label1.Text = "Welcome " + UserRole;
			lblRole.Text = "Role: " + UserRole;

			ThemeManager.ApplyDarkTheme(this);
			isDarkMode = true;

			LoadChart();

			chartDashboard.Width = panelMain.Width - 40;
			chartDashboard.Height = panelMain.Height - 140;

			// Doctor — hide Doctors, Staff and Billing buttons
			if (UserRole == "Doctor")
			{
				button3.Visible = false;
				button5.Visible = false;
				button6.Visible = false;
			}

			// Patient — hide Doctors, Patients and Staff
			if (UserRole == "Patient")
			{
				button3.Visible = false;
				button4.Visible = false;
				button5.Visible = false;
			}

			// Staff — hide Doctors and Staff management
			if (UserRole == "Staff")
			{
				button3.Visible = false;
				button5.Visible = false;
			}

			ArrangeSidebar();
		}

		// ── Sidebar layout ──

		private void ArrangeSidebar()
		{
			// Menu buttons stack from the top, skipping hidden ones
			int y = 80;
			foreach (Button b in new[] { button1, button2, button3, button4, button5, button6 })
			{
				if (!b.Visible) continue;
				b.Top = y;
				y += 50;
			}

			// Settings and Logout pinned to the bottom
			button8.Top = panelSidebar.Height - 60;
			button7.Top = button8.Top - 50;
		}

		private void Dashboard_Resize(object sender, EventArgs e)
		{
			ArrangeSidebar();
		}

		// ── Sidebar Navigation ──

		private void button1_Click(object sender, EventArgs e)
		{
			// Toggle dark/light theme
			isDarkMode = !isDarkMode;
			if (isDarkMode)
				ThemeManager.ApplyDarkTheme(this);
			else
				ThemeManager.ApplyLightTheme(this);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			AppointmentForm appointmentForm = new AppointmentForm();

			if (UserRole == "Doctor")
				appointmentForm.DoctorFilter = UserName;

			appointmentForm.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			DoctorForm doctorForm = new DoctorForm();
			doctorForm.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			PatientForm patientForm = new PatientForm();
			patientForm.Show();
		}

		private void button5_Click(object sender, EventArgs e)   // Staff
		{
			StaffForm staffForm = new StaffForm();
			staffForm.Show();
		}

		private void button6_Click(object sender, EventArgs e)   // Billing
		{
			BillingForm billingForm = new BillingForm();
			billingForm.Show();
		}

		private void button7_Click(object sender, EventArgs e)   // Settings
		{
			SettingsForm settings = new SettingsForm();
			settings.Show();
		}

		private void button8_Click(object sender, EventArgs e)   // Logout
		{
			loggingOut = true;

			// Reuse the existing (hidden) login form instead of creating another one
			if (LoginForm != null)
				LoginForm.Show();
			else
				new Form1().Show();

			this.Close();
		}

		// Closing the dashboard with X ends the whole application
		private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (!loggingOut)
				Application.Exit();
		}

		// ── Empty handlers ──

		private void panelMain_Paint(object sender, PaintEventArgs e)
		{
		}

		private void lblPatients_Click(object sender, EventArgs e)
		{
		}
	}
}