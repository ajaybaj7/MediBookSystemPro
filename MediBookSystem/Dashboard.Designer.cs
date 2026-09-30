namespace MediBookSystem
{
	partial class Dashboard
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();

			this.panelSidebar = new System.Windows.Forms.Panel();
			this.pictureBoxDashboardLogo = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.panelHeader = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.lblRole = new System.Windows.Forms.Label();
			this.panelMain = new System.Windows.Forms.Panel();
			this.panelCardDoctors = new System.Windows.Forms.Panel();
			this.lblCardDoctorsTitle = new System.Windows.Forms.Label();
			this.lblDoctors = new System.Windows.Forms.Label();
			this.panelCardPatients = new System.Windows.Forms.Panel();
			this.lblCardPatientsTitle = new System.Windows.Forms.Label();
			this.lblPatients = new System.Windows.Forms.Label();
			this.panelCardAppointments = new System.Windows.Forms.Panel();
			this.lblCardAppointmentsTitle = new System.Windows.Forms.Label();
			this.lblAppointments = new System.Windows.Forms.Label();
			this.panelCardStaff = new System.Windows.Forms.Panel();
			this.lblCardStaffTitle = new System.Windows.Forms.Label();
			this.lblStaff = new System.Windows.Forms.Label();
			this.chartDashboard = new System.Windows.Forms.DataVisualization.Charting.Chart();

			this.panelSidebar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardLogo)).BeginInit();
			this.panelHeader.SuspendLayout();
			this.panelMain.SuspendLayout();
			this.panelCardDoctors.SuspendLayout();
			this.panelCardPatients.SuspendLayout();
			this.panelCardAppointments.SuspendLayout();
			this.panelCardStaff.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartDashboard)).BeginInit();
			this.SuspendLayout();

			// ── panelSidebar ──
			this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
			this.panelSidebar.Controls.Add(this.button8);
			this.panelSidebar.Controls.Add(this.button7);
			this.panelSidebar.Controls.Add(this.button6);
			this.panelSidebar.Controls.Add(this.button5);
			this.panelSidebar.Controls.Add(this.button4);
			this.panelSidebar.Controls.Add(this.button3);
			this.panelSidebar.Controls.Add(this.button2);
			this.panelSidebar.Controls.Add(this.button1);
			this.panelSidebar.Controls.Add(this.pictureBoxDashboardLogo);
			this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelSidebar.Location = new System.Drawing.Point(0, 0);
			this.panelSidebar.Name = "panelSidebar";
			this.panelSidebar.Size = new System.Drawing.Size(220, 450);
			this.panelSidebar.TabIndex = 0;

			// ── Logo ──
			this.pictureBoxDashboardLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDashboardLogo.Image")));
			this.pictureBoxDashboardLogo.Location = new System.Drawing.Point(10, 10);
			this.pictureBoxDashboardLogo.Name = "pictureBoxDashboardLogo";
			this.pictureBoxDashboardLogo.Size = new System.Drawing.Size(200, 60);
			this.pictureBoxDashboardLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxDashboardLogo.TabIndex = 0;
			this.pictureBoxDashboardLogo.TabStop = false;

			// ── button1 - Dashboard ──
			this.button1.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(59, 130, 246);
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.button1.Location = new System.Drawing.Point(0, 80);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(220, 45);
			this.button1.TabIndex = 1;
			this.button1.Text = "🏠  Dashboard";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);

			// ── button2 - Appointments ──
			this.button2.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(59, 130, 246);
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.button2.Location = new System.Drawing.Point(0, 130);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(220, 45);
			this.button2.TabIndex = 2;
			this.button2.Text = "📅  Appointments";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);

			// ── button3 - Doctors ──
			this.button3.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(59, 130, 246);
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.button3.Location = new System.Drawing.Point(0, 180);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(220, 45);
			this.button3.TabIndex = 3;
			this.button3.Text = "👨‍⚕️  Doctors";
			this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);

			// ── button4 - Patients ──
			this.button4.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(59, 130, 246);
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.button4.Location = new System.Drawing.Point(0, 230);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(220, 45);
			this.button4.TabIndex = 4;
			this.button4.Text = "🧑  Patients";
			this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);

			// ── button5 - Staff ──
			this.button5.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(59, 130, 246);
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.ForeColor = System.Drawing.Color.White;
			this.button5.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.button5.Location = new System.Drawing.Point(0, 280);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(220, 45);
			this.button5.TabIndex = 5;
			this.button5.Text = "👥  Staff";
			this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button5.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);

			// ── button6 - Billing ──
			this.button6.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(59, 130, 246);
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.ForeColor = System.Drawing.Color.White;
			this.button6.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.button6.Location = new System.Drawing.Point(0, 330);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(220, 45);
			this.button6.TabIndex = 6;
			this.button6.Text = "💳  Billing";
			this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button6.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);

			// ── button7 - Settings ──
			this.button7.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(59, 130, 246);
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.ForeColor = System.Drawing.Color.White;
			this.button7.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.button7.Location = new System.Drawing.Point(0, 380);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(220, 45);
			this.button7.TabIndex = 7;
			this.button7.Text = "⚙️  Settings";
			this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button7.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);

			// ── button8 - Logout ──
			this.button8.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(220, 38, 38);
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.ForeColor = System.Drawing.Color.White;
			this.button8.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.button8.Location = new System.Drawing.Point(0, 430);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(220, 45);
			this.button8.TabIndex = 8;
			this.button8.Text = "🚪  Logout";
			this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button8.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.button8_Click);

			// ── panelHeader ──
			this.panelHeader.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.panelHeader.Controls.Add(this.lblRole);
			this.panelHeader.Controls.Add(this.label1);
			this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(220, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(580, 70);
			this.panelHeader.TabIndex = 1;

			// ── label1 ──
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(20, 20);
			this.label1.Name = "label1";
			this.label1.Text = "Welcome Admin";

			// ── lblRole ──
			this.lblRole.AutoSize = true;
			this.lblRole.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.lblRole.ForeColor = System.Drawing.Color.FromArgb(99, 179, 237);
			this.lblRole.Location = new System.Drawing.Point(480, 25);
			this.lblRole.Name = "lblRole";
			this.lblRole.Text = "Role: Admin";

			// ── panelMain ──
			this.panelMain.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
			this.panelMain.Controls.Add(this.panelCardDoctors);
			this.panelMain.Controls.Add(this.panelCardPatients);
			this.panelMain.Controls.Add(this.panelCardAppointments);
			this.panelMain.Controls.Add(this.panelCardStaff);
			this.panelMain.Controls.Add(this.chartDashboard);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(220, 70);
			this.panelMain.Name = "panelMain";
			this.panelMain.TabIndex = 2;
			this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);

			// ── panelCardDoctors ──
			this.panelCardDoctors.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.panelCardDoctors.Controls.Add(this.lblCardDoctorsTitle);
			this.panelCardDoctors.Controls.Add(this.lblDoctors);
			this.panelCardDoctors.Location = new System.Drawing.Point(20, 15);
			this.panelCardDoctors.Name = "panelCardDoctors";
			this.panelCardDoctors.Size = new System.Drawing.Size(145, 90);
			this.panelCardDoctors.TabIndex = 1;

			this.lblCardDoctorsTitle.AutoSize = false;
			this.lblCardDoctorsTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblCardDoctorsTitle.ForeColor = System.Drawing.Color.FromArgb(59, 130, 246);
			this.lblCardDoctorsTitle.Location = new System.Drawing.Point(8, 10);
			this.lblCardDoctorsTitle.Name = "lblCardDoctorsTitle";
			this.lblCardDoctorsTitle.Size = new System.Drawing.Size(130, 20);
			this.lblCardDoctorsTitle.Text = "👨‍⚕️ Doctors";

			this.lblDoctors.AutoSize = false;
			this.lblDoctors.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
			this.lblDoctors.ForeColor = System.Drawing.Color.White;
			this.lblDoctors.Location = new System.Drawing.Point(8, 35);
			this.lblDoctors.Name = "lblDoctors";
			this.lblDoctors.Size = new System.Drawing.Size(130, 45);
			this.lblDoctors.Text = "0";

			// ── panelCardPatients ──
			this.panelCardPatients.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.panelCardPatients.Controls.Add(this.lblCardPatientsTitle);
			this.panelCardPatients.Controls.Add(this.lblPatients);
			this.panelCardPatients.Location = new System.Drawing.Point(180, 15);
			this.panelCardPatients.Name = "panelCardPatients";
			this.panelCardPatients.Size = new System.Drawing.Size(145, 90);
			this.panelCardPatients.TabIndex = 2;

			this.lblCardPatientsTitle.AutoSize = false;
			this.lblCardPatientsTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblCardPatientsTitle.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
			this.lblCardPatientsTitle.Location = new System.Drawing.Point(8, 10);
			this.lblCardPatientsTitle.Name = "lblCardPatientsTitle";
			this.lblCardPatientsTitle.Size = new System.Drawing.Size(130, 20);
			this.lblCardPatientsTitle.Text = "🧑 Patients";

			this.lblPatients.AutoSize = false;
			this.lblPatients.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
			this.lblPatients.ForeColor = System.Drawing.Color.White;
			this.lblPatients.Location = new System.Drawing.Point(8, 35);
			this.lblPatients.Name = "lblPatients";
			this.lblPatients.Size = new System.Drawing.Size(130, 45);
			this.lblPatients.Text = "0";

			// ── panelCardAppointments ──
			this.panelCardAppointments.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.panelCardAppointments.Controls.Add(this.lblCardAppointmentsTitle);
			this.panelCardAppointments.Controls.Add(this.lblAppointments);
			this.panelCardAppointments.Location = new System.Drawing.Point(340, 15);
			this.panelCardAppointments.Name = "panelCardAppointments";
			this.panelCardAppointments.Size = new System.Drawing.Size(145, 90);
			this.panelCardAppointments.TabIndex = 3;

			this.lblCardAppointmentsTitle.AutoSize = false;
			this.lblCardAppointmentsTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblCardAppointmentsTitle.ForeColor = System.Drawing.Color.FromArgb(245, 158, 11);
			this.lblCardAppointmentsTitle.Location = new System.Drawing.Point(8, 10);
			this.lblCardAppointmentsTitle.Name = "lblCardAppointmentsTitle";
			this.lblCardAppointmentsTitle.Size = new System.Drawing.Size(130, 20);
			this.lblCardAppointmentsTitle.Text = "📅 Appointments";

			this.lblAppointments.AutoSize = false;
			this.lblAppointments.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
			this.lblAppointments.ForeColor = System.Drawing.Color.White;
			this.lblAppointments.Location = new System.Drawing.Point(8, 35);
			this.lblAppointments.Name = "lblAppointments";
			this.lblAppointments.Size = new System.Drawing.Size(130, 45);
			this.lblAppointments.Text = "0";

			// ── panelCardStaff ──
			this.panelCardStaff.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.panelCardStaff.Controls.Add(this.lblCardStaffTitle);
			this.panelCardStaff.Controls.Add(this.lblStaff);
			this.panelCardStaff.Location = new System.Drawing.Point(500, 15);
			this.panelCardStaff.Name = "panelCardStaff";
			this.panelCardStaff.Size = new System.Drawing.Size(145, 90);
			this.panelCardStaff.TabIndex = 4;

			this.lblCardStaffTitle.AutoSize = false;
			this.lblCardStaffTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblCardStaffTitle.ForeColor = System.Drawing.Color.FromArgb(139, 92, 246);
			this.lblCardStaffTitle.Location = new System.Drawing.Point(8, 10);
			this.lblCardStaffTitle.Name = "lblCardStaffTitle";
			this.lblCardStaffTitle.Size = new System.Drawing.Size(130, 20);
			this.lblCardStaffTitle.Text = "👥 Staff";

			this.lblStaff.AutoSize = false;
			this.lblStaff.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
			this.lblStaff.ForeColor = System.Drawing.Color.White;
			this.lblStaff.Location = new System.Drawing.Point(8, 35);
			this.lblStaff.Name = "lblStaff";
			this.lblStaff.Size = new System.Drawing.Size(130, 45);
			this.lblStaff.Text = "0";

			// ── chartDashboard ──
			chartArea1.Name = "ChartArea1";
			chartArea1.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.chartDashboard.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			legend1.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			legend1.ForeColor = System.Drawing.Color.White;
			this.chartDashboard.Legends.Add(legend1);
			this.chartDashboard.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.chartDashboard.Location = new System.Drawing.Point(20, 120);
			this.chartDashboard.Name = "chartDashboard";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chartDashboard.Series.Add(series1);
			this.chartDashboard.Size = new System.Drawing.Size(600, 320);
			this.chartDashboard.TabIndex = 5;

			// ── Dashboard Form ──
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panelMain);
			this.Controls.Add(this.panelHeader);
			this.Controls.Add(this.panelSidebar);
			this.Name = "Dashboard";
			this.Text = "Dashboard";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form2_Load);

			this.panelCardDoctors.ResumeLayout(false);
			this.panelCardPatients.ResumeLayout(false);
			this.panelCardAppointments.ResumeLayout(false);
			this.panelCardStaff.ResumeLayout(false);
			this.panelSidebar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardLogo)).EndInit();
			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			this.panelMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartDashboard)).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Panel panelSidebar;
		private System.Windows.Forms.PictureBox pictureBoxDashboardLogo;
		private System.Windows.Forms.Button button1, button2, button3;
		private System.Windows.Forms.Button button4, button5, button6, button7, button8;
		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.Label label1, lblRole;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Panel panelCardDoctors, panelCardPatients;
		private System.Windows.Forms.Panel panelCardAppointments, panelCardStaff;
		private System.Windows.Forms.Label lblCardDoctorsTitle, lblCardPatientsTitle;
		private System.Windows.Forms.Label lblCardAppointmentsTitle, lblCardStaffTitle;
		private System.Windows.Forms.Label lblDoctors, lblPatients;
		private System.Windows.Forms.Label lblAppointments, lblStaff;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartDashboard;
	}
}