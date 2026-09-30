namespace MediBookSystem
{
	partial class ReceptionistForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.panelHeader = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.tabControl = new System.Windows.Forms.TabControl();

			// Tab pages
			this.tabAppointments = new System.Windows.Forms.TabPage();
			this.tabPatients = new System.Windows.Forms.TabPage();
			this.tabDoctors = new System.Windows.Forms.TabPage();

			// ── Appointments Tab controls ──
			this.panelApptForm = new System.Windows.Forms.Panel();
			this.lblApptPatient = new System.Windows.Forms.Label();
			this.txtApptPatient = new System.Windows.Forms.TextBox();
			this.lblApptDoctor = new System.Windows.Forms.Label();
			this.cmbApptDoctor = new System.Windows.Forms.ComboBox();
			this.lblApptDate = new System.Windows.Forms.Label();
			this.txtApptDate = new System.Windows.Forms.TextBox();
			this.lblApptTime = new System.Windows.Forms.Label();
			this.txtApptTime = new System.Windows.Forms.TextBox();
			this.lblApptSymptoms = new System.Windows.Forms.Label();
			this.txtApptSymptoms = new System.Windows.Forms.TextBox();
			this.panelApptButtons = new System.Windows.Forms.Panel();
			this.btnApptBook = new System.Windows.Forms.Button();
			this.btnApptUpdate = new System.Windows.Forms.Button();
			this.btnApptDelete = new System.Windows.Forms.Button();
			this.btnApptClear = new System.Windows.Forms.Button();
			this.dgvAppointments = new System.Windows.Forms.DataGridView();

			// ── Patients Tab controls ──
			this.panelPatientForm = new System.Windows.Forms.Panel();
			this.lblPatName = new System.Windows.Forms.Label();
			this.txtPatName = new System.Windows.Forms.TextBox();
			this.lblPatAge = new System.Windows.Forms.Label();
			this.txtPatAge = new System.Windows.Forms.TextBox();
			this.lblPatGender = new System.Windows.Forms.Label();
			this.cmbPatGender = new System.Windows.Forms.ComboBox();
			this.lblPatContact = new System.Windows.Forms.Label();
			this.txtPatContact = new System.Windows.Forms.TextBox();
			this.panelPatButtons = new System.Windows.Forms.Panel();
			this.btnPatAdd = new System.Windows.Forms.Button();
			this.btnPatUpdate = new System.Windows.Forms.Button();
			this.btnPatDelete = new System.Windows.Forms.Button();
			this.btnPatClear = new System.Windows.Forms.Button();
			this.dgvPatients = new System.Windows.Forms.DataGridView();

			// ── Doctors Tab controls ──
			this.dgvDoctors = new System.Windows.Forms.DataGridView();

			// Suspend
			this.panelHeader.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabAppointments.SuspendLayout();
			this.tabPatients.SuspendLayout();
			this.tabDoctors.SuspendLayout();
			this.panelApptForm.SuspendLayout();
			this.panelApptButtons.SuspendLayout();
			this.panelPatientForm.SuspendLayout();
			this.panelPatButtons.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
			this.SuspendLayout();

			// ── panelHeader ──
			this.panelHeader.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.panelHeader.Controls.Add(this.lblTitle);
			this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(1000, 60);
			this.panelHeader.TabIndex = 0;

			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(20, 15);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Text = "📋  Receptionist Panel";

			// ── tabControl ──
			this.tabControl.Controls.Add(this.tabAppointments);
			this.tabControl.Controls.Add(this.tabPatients);
			this.tabControl.Controls.Add(this.tabDoctors);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.tabControl.Location = new System.Drawing.Point(0, 60);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.TabIndex = 1;

			// ════════════════════════════════
			//  TAB 1 — APPOINTMENTS
			// ════════════════════════════════
			this.tabAppointments.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
			this.tabAppointments.Name = "tabAppointments";
			this.tabAppointments.Text = "📅  Appointments";
			this.tabAppointments.Controls.Add(this.dgvAppointments);
			this.tabAppointments.Controls.Add(this.panelApptButtons);
			this.tabAppointments.Controls.Add(this.panelApptForm);

			// panelApptForm
			this.panelApptForm.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.panelApptForm.Controls.Add(this.lblApptPatient);
			this.panelApptForm.Controls.Add(this.txtApptPatient);
			this.panelApptForm.Controls.Add(this.lblApptDoctor);
			this.panelApptForm.Controls.Add(this.cmbApptDoctor);
			this.panelApptForm.Controls.Add(this.lblApptDate);
			this.panelApptForm.Controls.Add(this.txtApptDate);
			this.panelApptForm.Controls.Add(this.lblApptTime);
			this.panelApptForm.Controls.Add(this.txtApptTime);
			this.panelApptForm.Controls.Add(this.lblApptSymptoms);
			this.panelApptForm.Controls.Add(this.txtApptSymptoms);
			this.panelApptForm.Location = new System.Drawing.Point(10, 10);
			this.panelApptForm.Name = "panelApptForm";
			this.panelApptForm.Size = new System.Drawing.Size(960, 80);
			this.panelApptForm.TabIndex = 0;

			// Patient
			this.lblApptPatient.AutoSize = true;
			this.lblApptPatient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblApptPatient.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.lblApptPatient.Location = new System.Drawing.Point(5, 8);
			this.lblApptPatient.Text = "PATIENT NAME";

			this.txtApptPatient.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.txtApptPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtApptPatient.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtApptPatient.ForeColor = System.Drawing.Color.White;
			this.txtApptPatient.Location = new System.Drawing.Point(5, 28);
			this.txtApptPatient.Name = "txtApptPatient";
			this.txtApptPatient.Size = new System.Drawing.Size(170, 25);

			// Doctor
			this.lblApptDoctor.AutoSize = true;
			this.lblApptDoctor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblApptDoctor.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.lblApptDoctor.Location = new System.Drawing.Point(190, 8);
			this.lblApptDoctor.Text = "ASSIGN DOCTOR";

			this.cmbApptDoctor.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.cmbApptDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbApptDoctor.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbApptDoctor.ForeColor = System.Drawing.Color.White;
			this.cmbApptDoctor.FormattingEnabled = true;
			this.cmbApptDoctor.Location = new System.Drawing.Point(190, 28);
			this.cmbApptDoctor.Name = "cmbApptDoctor";
			this.cmbApptDoctor.Size = new System.Drawing.Size(180, 25);

			// Date
			this.lblApptDate.AutoSize = true;
			this.lblApptDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblApptDate.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.lblApptDate.Location = new System.Drawing.Point(385, 8);
			this.lblApptDate.Text = "DATE";

			this.txtApptDate.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.txtApptDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtApptDate.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtApptDate.ForeColor = System.Drawing.Color.White;
			this.txtApptDate.Location = new System.Drawing.Point(385, 28);
			this.txtApptDate.Name = "txtApptDate";
			this.txtApptDate.Size = new System.Drawing.Size(140, 25);

			// Time
			this.lblApptTime.AutoSize = true;
			this.lblApptTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblApptTime.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.lblApptTime.Location = new System.Drawing.Point(540, 8);
			this.lblApptTime.Text = "TIME";

			this.txtApptTime.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.txtApptTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtApptTime.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtApptTime.ForeColor = System.Drawing.Color.White;
			this.txtApptTime.Location = new System.Drawing.Point(540, 28);
			this.txtApptTime.Name = "txtApptTime";
			this.txtApptTime.Size = new System.Drawing.Size(120, 25);

			// Symptoms
			this.lblApptSymptoms.AutoSize = true;
			this.lblApptSymptoms.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblApptSymptoms.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.lblApptSymptoms.Location = new System.Drawing.Point(675, 8);
			this.lblApptSymptoms.Text = "SYMPTOMS";

			this.txtApptSymptoms.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.txtApptSymptoms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtApptSymptoms.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtApptSymptoms.ForeColor = System.Drawing.Color.White;
			this.txtApptSymptoms.Location = new System.Drawing.Point(675, 28);
			this.txtApptSymptoms.Name = "txtApptSymptoms";
			this.txtApptSymptoms.Size = new System.Drawing.Size(270, 25);

			// panelApptButtons
			this.panelApptButtons.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
			this.panelApptButtons.Controls.Add(this.btnApptBook);
			this.panelApptButtons.Controls.Add(this.btnApptUpdate);
			this.panelApptButtons.Controls.Add(this.btnApptDelete);
			this.panelApptButtons.Controls.Add(this.btnApptClear);
			this.panelApptButtons.Location = new System.Drawing.Point(10, 100);
			this.panelApptButtons.Name = "panelApptButtons";
			this.panelApptButtons.Size = new System.Drawing.Size(960, 50);
			this.panelApptButtons.TabIndex = 1;

			this.btnApptBook.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
			this.btnApptBook.FlatAppearance.BorderSize = 0;
			this.btnApptBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnApptBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnApptBook.ForeColor = System.Drawing.Color.White;
			this.btnApptBook.Location = new System.Drawing.Point(0, 8);
			this.btnApptBook.Name = "btnApptBook";
			this.btnApptBook.Size = new System.Drawing.Size(140, 35);
			this.btnApptBook.Text = "📋  Book";
			this.btnApptBook.UseVisualStyleBackColor = false;
			this.btnApptBook.Click += new System.EventHandler(this.btnApptBook_Click);

			this.btnApptUpdate.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
			this.btnApptUpdate.FlatAppearance.BorderSize = 0;
			this.btnApptUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnApptUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnApptUpdate.ForeColor = System.Drawing.Color.White;
			this.btnApptUpdate.Location = new System.Drawing.Point(150, 8);
			this.btnApptUpdate.Name = "btnApptUpdate";
			this.btnApptUpdate.Size = new System.Drawing.Size(120, 35);
			this.btnApptUpdate.Text = "✏️  Update";
			this.btnApptUpdate.UseVisualStyleBackColor = false;
			this.btnApptUpdate.Click += new System.EventHandler(this.btnApptUpdate_Click);

			this.btnApptDelete.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
			this.btnApptDelete.FlatAppearance.BorderSize = 0;
			this.btnApptDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnApptDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnApptDelete.ForeColor = System.Drawing.Color.White;
			this.btnApptDelete.Location = new System.Drawing.Point(280, 8);
			this.btnApptDelete.Name = "btnApptDelete";
			this.btnApptDelete.Size = new System.Drawing.Size(120, 35);
			this.btnApptDelete.Text = "🗑️  Delete";
			this.btnApptDelete.UseVisualStyleBackColor = false;
			this.btnApptDelete.Click += new System.EventHandler(this.btnApptDelete_Click);

			this.btnApptClear.BackColor = System.Drawing.Color.FromArgb(71, 85, 105);
			this.btnApptClear.FlatAppearance.BorderSize = 0;
			this.btnApptClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnApptClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnApptClear.ForeColor = System.Drawing.Color.White;
			this.btnApptClear.Location = new System.Drawing.Point(410, 8);
			this.btnApptClear.Name = "btnApptClear";
			this.btnApptClear.Size = new System.Drawing.Size(120, 35);
			this.btnApptClear.Text = "🔄  Clear";
			this.btnApptClear.UseVisualStyleBackColor = false;
			this.btnApptClear.Click += new System.EventHandler(this.btnApptClear_Click);

			// dgvAppointments
			this.dgvAppointments.AllowUserToAddRows = false;
			this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAppointments.BackgroundColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvAppointments.MultiSelect = false;
			this.dgvAppointments.ReadOnly = true;
			this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAppointments.Location = new System.Drawing.Point(10, 160);
			this.dgvAppointments.Name = "dgvAppointments";
			this.dgvAppointments.Size = new System.Drawing.Size(960, 400);
			this.dgvAppointments.TabIndex = 2;
			this.dgvAppointments.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.dgvAppointments.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
			this.dgvAppointments.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(59, 130, 246);
			this.dgvAppointments.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
			this.dgvAppointments.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.dgvAppointments.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
			this.dgvAppointments.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.dgvAppointments.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.dgvAppointments.EnableHeadersVisualStyles = false;
			this.dgvAppointments.GridColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.dgvAppointments.RowTemplate.Height = 35;
			this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAppointments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointments_CellClick);

			// ════════════════════════════════
			//  TAB 2 — PATIENTS
			// ════════════════════════════════
			this.tabPatients.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
			this.tabPatients.Name = "tabPatients";
			this.tabPatients.Text = "🧑  Patients";
			this.tabPatients.Controls.Add(this.dgvPatients);
			this.tabPatients.Controls.Add(this.panelPatButtons);
			this.tabPatients.Controls.Add(this.panelPatientForm);

			// panelPatientForm
			this.panelPatientForm.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.panelPatientForm.Controls.Add(this.lblPatName);
			this.panelPatientForm.Controls.Add(this.txtPatName);
			this.panelPatientForm.Controls.Add(this.lblPatAge);
			this.panelPatientForm.Controls.Add(this.txtPatAge);
			this.panelPatientForm.Controls.Add(this.lblPatGender);
			this.panelPatientForm.Controls.Add(this.cmbPatGender);
			this.panelPatientForm.Controls.Add(this.lblPatContact);
			this.panelPatientForm.Controls.Add(this.txtPatContact);
			this.panelPatientForm.Location = new System.Drawing.Point(10, 10);
			this.panelPatientForm.Name = "panelPatientForm";
			this.panelPatientForm.Size = new System.Drawing.Size(960, 80);
			this.panelPatientForm.TabIndex = 0;

			this.lblPatName.AutoSize = true;
			this.lblPatName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblPatName.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.lblPatName.Location = new System.Drawing.Point(5, 8);
			this.lblPatName.Text = "PATIENT NAME";

			this.txtPatName.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.txtPatName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPatName.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtPatName.ForeColor = System.Drawing.Color.White;
			this.txtPatName.Location = new System.Drawing.Point(5, 28);
			this.txtPatName.Name = "txtPatName";
			this.txtPatName.Size = new System.Drawing.Size(200, 25);

			this.lblPatAge.AutoSize = true;
			this.lblPatAge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblPatAge.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.lblPatAge.Location = new System.Drawing.Point(220, 8);
			this.lblPatAge.Text = "AGE";

			this.txtPatAge.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.txtPatAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPatAge.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtPatAge.ForeColor = System.Drawing.Color.White;
			this.txtPatAge.Location = new System.Drawing.Point(220, 28);
			this.txtPatAge.Name = "txtPatAge";
			this.txtPatAge.Size = new System.Drawing.Size(100, 25);

			this.lblPatGender.AutoSize = true;
			this.lblPatGender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblPatGender.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.lblPatGender.Location = new System.Drawing.Point(335, 8);
			this.lblPatGender.Text = "GENDER";

			this.cmbPatGender.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.cmbPatGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbPatGender.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbPatGender.ForeColor = System.Drawing.Color.White;
			this.cmbPatGender.FormattingEnabled = true;
			this.cmbPatGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
			this.cmbPatGender.Location = new System.Drawing.Point(335, 28);
			this.cmbPatGender.Name = "cmbPatGender";
			this.cmbPatGender.Size = new System.Drawing.Size(140, 25);

			this.lblPatContact.AutoSize = true;
			this.lblPatContact.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblPatContact.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.lblPatContact.Location = new System.Drawing.Point(490, 8);
			this.lblPatContact.Text = "CONTACT";

			this.txtPatContact.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.txtPatContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPatContact.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtPatContact.ForeColor = System.Drawing.Color.White;
			this.txtPatContact.Location = new System.Drawing.Point(490, 28);
			this.txtPatContact.Name = "txtPatContact";
			this.txtPatContact.Size = new System.Drawing.Size(200, 25);

			// panelPatButtons
			this.panelPatButtons.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
			this.panelPatButtons.Controls.Add(this.btnPatAdd);
			this.panelPatButtons.Controls.Add(this.btnPatUpdate);
			this.panelPatButtons.Controls.Add(this.btnPatDelete);
			this.panelPatButtons.Controls.Add(this.btnPatClear);
			this.panelPatButtons.Location = new System.Drawing.Point(10, 100);
			this.panelPatButtons.Name = "panelPatButtons";
			this.panelPatButtons.Size = new System.Drawing.Size(960, 50);
			this.panelPatButtons.TabIndex = 1;

			this.btnPatAdd.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
			this.btnPatAdd.FlatAppearance.BorderSize = 0;
			this.btnPatAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPatAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnPatAdd.ForeColor = System.Drawing.Color.White;
			this.btnPatAdd.Location = new System.Drawing.Point(0, 8);
			this.btnPatAdd.Name = "btnPatAdd";
			this.btnPatAdd.Size = new System.Drawing.Size(120, 35);
			this.btnPatAdd.Text = "➕  Add";
			this.btnPatAdd.UseVisualStyleBackColor = false;
			this.btnPatAdd.Click += new System.EventHandler(this.btnPatAdd_Click);

			this.btnPatUpdate.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
			this.btnPatUpdate.FlatAppearance.BorderSize = 0;
			this.btnPatUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPatUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnPatUpdate.ForeColor = System.Drawing.Color.White;
			this.btnPatUpdate.Location = new System.Drawing.Point(130, 8);
			this.btnPatUpdate.Name = "btnPatUpdate";
			this.btnPatUpdate.Size = new System.Drawing.Size(120, 35);
			this.btnPatUpdate.Text = "✏️  Update";
			this.btnPatUpdate.UseVisualStyleBackColor = false;
			this.btnPatUpdate.Click += new System.EventHandler(this.btnPatUpdate_Click);

			this.btnPatDelete.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
			this.btnPatDelete.FlatAppearance.BorderSize = 0;
			this.btnPatDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPatDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnPatDelete.ForeColor = System.Drawing.Color.White;
			this.btnPatDelete.Location = new System.Drawing.Point(260, 8);
			this.btnPatDelete.Name = "btnPatDelete";
			this.btnPatDelete.Size = new System.Drawing.Size(120, 35);
			this.btnPatDelete.Text = "🗑️  Delete";
			this.btnPatDelete.UseVisualStyleBackColor = false;
			this.btnPatDelete.Click += new System.EventHandler(this.btnPatDelete_Click);

			this.btnPatClear.BackColor = System.Drawing.Color.FromArgb(71, 85, 105);
			this.btnPatClear.FlatAppearance.BorderSize = 0;
			this.btnPatClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPatClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnPatClear.ForeColor = System.Drawing.Color.White;
			this.btnPatClear.Location = new System.Drawing.Point(390, 8);
			this.btnPatClear.Name = "btnPatClear";
			this.btnPatClear.Size = new System.Drawing.Size(120, 35);
			this.btnPatClear.Text = "🔄  Clear";
			this.btnPatClear.UseVisualStyleBackColor = false;
			this.btnPatClear.Click += new System.EventHandler(this.btnPatClear_Click);

			// dgvPatients
			this.dgvPatients.AllowUserToAddRows = false;
			this.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvPatients.BackgroundColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.dgvPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvPatients.MultiSelect = false;
			this.dgvPatients.ReadOnly = true;
			this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPatients.Location = new System.Drawing.Point(10, 160);
			this.dgvPatients.Name = "dgvPatients";
			this.dgvPatients.Size = new System.Drawing.Size(960, 400);
			this.dgvPatients.TabIndex = 2;
			this.dgvPatients.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.dgvPatients.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
			this.dgvPatients.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(59, 130, 246);
			this.dgvPatients.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
			this.dgvPatients.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.dgvPatients.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
			this.dgvPatients.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.dgvPatients.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.dgvPatients.EnableHeadersVisualStyles = false;
			this.dgvPatients.GridColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.dgvPatients.RowTemplate.Height = 35;
			this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatients_CellClick);

			// ════════════════════════════════
			//  TAB 3 — DOCTORS (view only)
			// ════════════════════════════════
			this.tabDoctors.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
			this.tabDoctors.Name = "tabDoctors";
			this.tabDoctors.Text = "👨‍⚕️  Doctors";
			this.tabDoctors.Controls.Add(this.dgvDoctors);

			this.dgvDoctors.AllowUserToAddRows = false;
			this.dgvDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDoctors.BackgroundColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.dgvDoctors.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvDoctors.MultiSelect = false;
			this.dgvDoctors.ReadOnly = true;
			this.dgvDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDoctors.Location = new System.Drawing.Point(10, 10);
			this.dgvDoctors.Name = "dgvDoctors";
			this.dgvDoctors.Size = new System.Drawing.Size(960, 550);
			this.dgvDoctors.TabIndex = 0;
			this.dgvDoctors.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.dgvDoctors.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
			this.dgvDoctors.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(59, 130, 246);
			this.dgvDoctors.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
			this.dgvDoctors.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.dgvDoctors.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
			this.dgvDoctors.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.dgvDoctors.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.dgvDoctors.EnableHeadersVisualStyles = false;
			this.dgvDoctors.GridColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.dgvDoctors.RowTemplate.Height = 35;
			this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

			// ── ReceptionistForm ──
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
			this.ClientSize = new System.Drawing.Size(1000, 700);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.panelHeader);
			this.Name = "ReceptionistForm";
			this.Text = "Receptionist Panel";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.ReceptionistForm_Load);

			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			this.panelApptForm.ResumeLayout(false);
			this.panelApptForm.PerformLayout();
			this.panelApptButtons.ResumeLayout(false);
			this.panelPatientForm.ResumeLayout(false);
			this.panelPatientForm.PerformLayout();
			this.panelPatButtons.ResumeLayout(false);
			this.tabAppointments.ResumeLayout(false);
			this.tabPatients.ResumeLayout(false);
			this.tabDoctors.ResumeLayout(false);
			this.tabControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabAppointments, tabPatients, tabDoctors;
		private System.Windows.Forms.Panel panelApptForm, panelApptButtons;
		private System.Windows.Forms.Label lblApptPatient, lblApptDoctor, lblApptDate, lblApptTime, lblApptSymptoms;
		private System.Windows.Forms.TextBox txtApptPatient, txtApptDate, txtApptTime, txtApptSymptoms;
		private System.Windows.Forms.ComboBox cmbApptDoctor;
		private System.Windows.Forms.Button btnApptBook, btnApptUpdate, btnApptDelete, btnApptClear;
		private System.Windows.Forms.DataGridView dgvAppointments;
		private System.Windows.Forms.Panel panelPatientForm, panelPatButtons;
		private System.Windows.Forms.Label lblPatName, lblPatAge, lblPatGender, lblPatContact;
		private System.Windows.Forms.TextBox txtPatName, txtPatAge, txtPatContact;
		private System.Windows.Forms.ComboBox cmbPatGender;
		private System.Windows.Forms.Button btnPatAdd, btnPatUpdate, btnPatDelete, btnPatClear;
		private System.Windows.Forms.DataGridView dgvPatients;
		private System.Windows.Forms.DataGridView dgvDoctors;
	}
}