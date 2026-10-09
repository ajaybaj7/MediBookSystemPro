namespace MediBookSystem
{
	partial class AppointmentForm
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
			this.panelForm = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPatient = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbDoctor = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTime = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtSymptoms = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtAge = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbGender = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtContact = new System.Windows.Forms.TextBox();
			this.panelSearch = new System.Windows.Forms.Panel();
			this.labelSearch = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.panelButtons = new System.Windows.Forms.Panel();
			this.btnBook = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnExport = new System.Windows.Forms.Button();
			this.dgvAppointments = new System.Windows.Forms.DataGridView();

			this.panelHeader.SuspendLayout();
			this.panelForm.SuspendLayout();
			this.panelSearch.SuspendLayout();
			this.panelButtons.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
			this.SuspendLayout();

			// ── panelHeader ──
			this.panelHeader.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.panelHeader.Controls.Add(this.lblTitle);
			this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(800, 60);
			this.panelHeader.TabIndex = 0;

			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(20, 15);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Text = "📅  Appointment Booking";

			// ── panelForm (2 rows of fields) ──
			this.panelForm.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.panelForm.Controls.Add(this.label1);
			this.panelForm.Controls.Add(this.txtPatient);
			this.panelForm.Controls.Add(this.label2);
			this.panelForm.Controls.Add(this.cmbDoctor);
			this.panelForm.Controls.Add(this.label3);
			this.panelForm.Controls.Add(this.dateTimePicker1);
			this.panelForm.Controls.Add(this.label4);
			this.panelForm.Controls.Add(this.txtTime);
			this.panelForm.Controls.Add(this.label5);
			this.panelForm.Controls.Add(this.txtSymptoms);
			this.panelForm.Controls.Add(this.label6);
			this.panelForm.Controls.Add(this.txtAge);
			this.panelForm.Controls.Add(this.label7);
			this.panelForm.Controls.Add(this.cmbGender);
			this.panelForm.Controls.Add(this.label8);
			this.panelForm.Controls.Add(this.txtContact);
			this.panelForm.Location = new System.Drawing.Point(20, 75);
			this.panelForm.Name = "panelForm";
			this.panelForm.Size = new System.Drawing.Size(760, 130);
			this.panelForm.TabIndex = 1;

			// ── Row 1 fields ──
			// Patient Name
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.label1.Location = new System.Drawing.Point(10, 8);
			this.label1.Name = "label1";
			this.label1.Text = "PATIENT NAME";

			this.txtPatient.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.txtPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPatient.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtPatient.ForeColor = System.Drawing.Color.White;
			this.txtPatient.Location = new System.Drawing.Point(10, 28);
			this.txtPatient.Name = "txtPatient";
			this.txtPatient.Size = new System.Drawing.Size(150, 25);
			this.txtPatient.TabIndex = 1;

			// Doctor Name
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.label2.Location = new System.Drawing.Point(175, 8);
			this.label2.Name = "label2";
			this.label2.Text = "DOCTOR NAME";

			this.cmbDoctor.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbDoctor.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbDoctor.ForeColor = System.Drawing.Color.White;
			this.cmbDoctor.FormattingEnabled = true;
			this.cmbDoctor.Location = new System.Drawing.Point(175, 28);
			this.cmbDoctor.Name = "cmbDoctor";
			this.cmbDoctor.Size = new System.Drawing.Size(150, 25);
			this.cmbDoctor.TabIndex = 2;

			// Date
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.label3.Location = new System.Drawing.Point(340, 8);
			this.label3.Name = "label3";
			this.label3.Text = "DATE";

			this.dateTimePicker1.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.dateTimePicker1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.dateTimePicker1.ForeColor = System.Drawing.Color.White;
			this.dateTimePicker1.Location = new System.Drawing.Point(340, 28);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(130, 25);
			this.dateTimePicker1.TabIndex = 3;

			// Time
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.label4.Location = new System.Drawing.Point(485, 8);
			this.label4.Name = "label4";
			this.label4.Text = "TIME";

			this.txtTime.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTime.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtTime.ForeColor = System.Drawing.Color.White;
			this.txtTime.Location = new System.Drawing.Point(485, 28);
			this.txtTime.Name = "txtTime";
			this.txtTime.Size = new System.Drawing.Size(120, 25);
			this.txtTime.TabIndex = 4;

			// Symptoms
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.label5.Location = new System.Drawing.Point(620, 8);
			this.label5.Name = "label5";
			this.label5.Text = "SYMPTOMS";

			this.txtSymptoms.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.txtSymptoms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSymptoms.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtSymptoms.ForeColor = System.Drawing.Color.White;
			this.txtSymptoms.Location = new System.Drawing.Point(620, 28);
			this.txtSymptoms.Name = "txtSymptoms";
			this.txtSymptoms.Size = new System.Drawing.Size(130, 25);
			this.txtSymptoms.TabIndex = 5;

			// ── Row 2 fields ──
			// Age
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.label6.Location = new System.Drawing.Point(10, 68);
			this.label6.Name = "label6";
			this.label6.Text = "AGE";

			this.txtAge.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAge.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtAge.ForeColor = System.Drawing.Color.White;
			this.txtAge.Location = new System.Drawing.Point(10, 88);
			this.txtAge.Name = "txtAge";
			this.txtAge.Size = new System.Drawing.Size(150, 25);
			this.txtAge.TabIndex = 6;

			// Gender
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.label7.Location = new System.Drawing.Point(175, 68);
			this.label7.Name = "label7";
			this.label7.Text = "GENDER";

			this.cmbGender.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbGender.ForeColor = System.Drawing.Color.White;
			this.cmbGender.FormattingEnabled = true;
			this.cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
			this.cmbGender.Location = new System.Drawing.Point(175, 88);
			this.cmbGender.Name = "cmbGender";
			this.cmbGender.Size = new System.Drawing.Size(150, 25);
			this.cmbGender.TabIndex = 7;

			// Contact
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.label8.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.label8.Location = new System.Drawing.Point(340, 68);
			this.label8.Name = "label8";
			this.label8.Text = "CONTACT";

			this.txtContact.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtContact.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtContact.ForeColor = System.Drawing.Color.White;
			this.txtContact.Location = new System.Drawing.Point(340, 88);
			this.txtContact.Name = "txtContact";
			this.txtContact.Size = new System.Drawing.Size(130, 25);
			this.txtContact.TabIndex = 8;

			// ── panelSearch ──
			this.panelSearch.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.panelSearch.Controls.Add(this.labelSearch);
			this.panelSearch.Controls.Add(this.txtSearch);
			this.panelSearch.Controls.Add(this.btnSearch);
			this.panelSearch.Location = new System.Drawing.Point(20, 215);
			this.panelSearch.Name = "panelSearch";
			this.panelSearch.Size = new System.Drawing.Size(760, 45);
			this.panelSearch.TabIndex = 2;

			this.labelSearch.AutoSize = true;
			this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.labelSearch.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.labelSearch.Location = new System.Drawing.Point(0, 13);
			this.labelSearch.Name = "labelSearch";
			this.labelSearch.Text = "SEARCH:";

			this.txtSearch.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtSearch.ForeColor = System.Drawing.Color.White;
			this.txtSearch.Location = new System.Drawing.Point(70, 10);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(200, 25);
			this.txtSearch.TabIndex = 0;

			this.btnSearch.BackColor = System.Drawing.Color.FromArgb(245, 158, 11);
			this.btnSearch.FlatAppearance.BorderSize = 0;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(280, 8);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(100, 30);
			this.btnSearch.Text = "🔍  Search";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

			// ── panelButtons ──
			this.panelButtons.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
			this.panelButtons.Controls.Add(this.btnBook);
			this.panelButtons.Controls.Add(this.btnUpdate);
			this.panelButtons.Controls.Add(this.btnDelete);
			this.panelButtons.Controls.Add(this.btnClear);
			this.panelButtons.Controls.Add(this.btnExport);
			this.panelButtons.Location = new System.Drawing.Point(20, 268);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.Size = new System.Drawing.Size(760, 50);
			this.panelButtons.TabIndex = 3;

			this.btnBook.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
			this.btnBook.FlatAppearance.BorderSize = 0;
			this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnBook.ForeColor = System.Drawing.Color.White;
			this.btnBook.Location = new System.Drawing.Point(0, 10);
			this.btnBook.Name = "btnBook";
			this.btnBook.Size = new System.Drawing.Size(150, 35);
			this.btnBook.Text = "📋  Book";
			this.btnBook.UseVisualStyleBackColor = false;
			this.btnBook.Click += new System.EventHandler(this.btnBook_Click);

			this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
			this.btnUpdate.FlatAppearance.BorderSize = 0;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnUpdate.ForeColor = System.Drawing.Color.White;
			this.btnUpdate.Location = new System.Drawing.Point(160, 10);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(120, 35);
			this.btnUpdate.Text = "✏️  Update";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.button1_Click);

			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(290, 10);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 35);
			this.btnDelete.Text = "🗑️  Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

			this.btnClear.BackColor = System.Drawing.Color.FromArgb(71, 85, 105);
			this.btnClear.FlatAppearance.BorderSize = 0;
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnClear.ForeColor = System.Drawing.Color.White;
			this.btnClear.Location = new System.Drawing.Point(420, 10);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(120, 35);
			this.btnClear.Text = "🔄  Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

			this.btnExport.BackColor = System.Drawing.Color.FromArgb(139, 92, 246);
			this.btnExport.FlatAppearance.BorderSize = 0;
			this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnExport.ForeColor = System.Drawing.Color.White;
			this.btnExport.Location = new System.Drawing.Point(550, 10);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(140, 35);
			this.btnExport.Text = "📊  Export CSV";
			this.btnExport.UseVisualStyleBackColor = false;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);

			// ── dgvAppointments ──
			this.dgvAppointments.AllowUserToAddRows = false;
			this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAppointments.BackgroundColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAppointments.MultiSelect = false;
			this.dgvAppointments.ReadOnly = true;
			this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAppointments.Location = new System.Drawing.Point(20, 328);
			this.dgvAppointments.Name = "dgvAppointments";
			this.dgvAppointments.Size = new System.Drawing.Size(760, 350);
			this.dgvAppointments.TabIndex = 4;
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
			this.dgvAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointments_CellContentClick);

			// ── AppointmentForm ──
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
			this.ClientSize = new System.Drawing.Size(800, 700);
			this.Controls.Add(this.dgvAppointments);
			this.Controls.Add(this.panelButtons);
			this.Controls.Add(this.panelSearch);
			this.Controls.Add(this.panelForm);
			this.Controls.Add(this.panelHeader);
			this.Name = "AppointmentForm";
			this.Text = "Appointment Booking";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.AppointmentForm_Load);

			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			this.panelForm.ResumeLayout(false);
			this.panelForm.PerformLayout();
			this.panelSearch.ResumeLayout(false);
			this.panelSearch.PerformLayout();
			this.panelButtons.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel panelForm;
		private System.Windows.Forms.Panel panelSearch;
		private System.Windows.Forms.Panel panelButtons;
		private System.Windows.Forms.Label label1, label2, label3, label4, label5;
		private System.Windows.Forms.Label label6, label7, label8;
		private System.Windows.Forms.TextBox txtPatient, dateTimePicker1;
		private System.Windows.Forms.TextBox txtTime, txtSymptoms, txtAge, txtContact;
		private System.Windows.Forms.ComboBox cmbGender, cmbDoctor;
		private System.Windows.Forms.Label labelSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnSearch, btnBook, btnUpdate, btnDelete, btnClear;
		private System.Windows.Forms.DataGridView dgvAppointments;
		private System.Windows.Forms.Button btnExport;
	}
}