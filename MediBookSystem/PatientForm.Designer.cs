namespace MediBookSystem
{
	partial class PatientForm
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
			this.txtPatientName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAge = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbGender = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPatientContact = new System.Windows.Forms.TextBox();
			this.panelButtons = new System.Windows.Forms.Panel();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.dgvPatients = new System.Windows.Forms.DataGridView();

			this.panelHeader.SuspendLayout();
			this.panelForm.SuspendLayout();
			this.panelButtons.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
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
			this.lblTitle.Text = "🧑  Patient Management";

			// ── panelForm ──
			this.panelForm.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.panelForm.Controls.Add(this.label1);
			this.panelForm.Controls.Add(this.txtPatientName);
			this.panelForm.Controls.Add(this.label2);
			this.panelForm.Controls.Add(this.txtAge);
			this.panelForm.Controls.Add(this.label3);
			this.panelForm.Controls.Add(this.cmbGender);
			this.panelForm.Controls.Add(this.label4);
			this.panelForm.Controls.Add(this.txtPatientContact);
			this.panelForm.Location = new System.Drawing.Point(20, 75);
			this.panelForm.Name = "panelForm";
			this.panelForm.Size = new System.Drawing.Size(760, 80);
			this.panelForm.TabIndex = 1;

			// ── label1 Patient Name ──
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.label1.Location = new System.Drawing.Point(10, 10);
			this.label1.Name = "label1";
			this.label1.Text = "PATIENT NAME";

			this.txtPatientName.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPatientName.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtPatientName.ForeColor = System.Drawing.Color.White;
			this.txtPatientName.Location = new System.Drawing.Point(10, 30);
			this.txtPatientName.Name = "txtPatientName";
			this.txtPatientName.Size = new System.Drawing.Size(160, 25);
			this.txtPatientName.TabIndex = 1;

			// ── label2 Age ──
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.label2.Location = new System.Drawing.Point(190, 10);
			this.label2.Name = "label2";
			this.label2.Text = "AGE";

			this.txtAge.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAge.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtAge.ForeColor = System.Drawing.Color.White;
			this.txtAge.Location = new System.Drawing.Point(190, 30);
			this.txtAge.Name = "txtAge";
			this.txtAge.Size = new System.Drawing.Size(100, 25);
			this.txtAge.TabIndex = 2;

			// ── label3 Gender ──
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.label3.Location = new System.Drawing.Point(310, 10);
			this.label3.Name = "label3";
			this.label3.Text = "GENDER";

			this.cmbGender.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbGender.ForeColor = System.Drawing.Color.White;
			this.cmbGender.FormattingEnabled = true;
			this.cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
			this.cmbGender.Location = new System.Drawing.Point(310, 30);
			this.cmbGender.Name = "cmbGender";
			this.cmbGender.Size = new System.Drawing.Size(150, 25);
			this.cmbGender.TabIndex = 3;

			// ── label4 Contact ──
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.label4.Location = new System.Drawing.Point(480, 10);
			this.label4.Name = "label4";
			this.label4.Text = "CONTACT";

			this.txtPatientContact.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.txtPatientContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPatientContact.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtPatientContact.ForeColor = System.Drawing.Color.White;
			this.txtPatientContact.Location = new System.Drawing.Point(480, 30);
			this.txtPatientContact.Name = "txtPatientContact";
			this.txtPatientContact.Size = new System.Drawing.Size(260, 25);
			this.txtPatientContact.TabIndex = 4;

			// ── panelButtons ──
			this.panelButtons.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
			this.panelButtons.Controls.Add(this.btnAdd);
			this.panelButtons.Controls.Add(this.btnUpdate);
			this.panelButtons.Controls.Add(this.btnDelete);
			this.panelButtons.Controls.Add(this.btnSearch);
			this.panelButtons.Controls.Add(this.btnClear);
			this.panelButtons.Location = new System.Drawing.Point(20, 165);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.Size = new System.Drawing.Size(760, 50);
			this.panelButtons.TabIndex = 2;

			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Location = new System.Drawing.Point(0, 10);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(120, 35);
			this.btnAdd.Text = "➕  Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

			this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
			this.btnUpdate.FlatAppearance.BorderSize = 0;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnUpdate.ForeColor = System.Drawing.Color.White;
			this.btnUpdate.Location = new System.Drawing.Point(130, 10);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(120, 35);
			this.btnUpdate.Text = "✏️  Update";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(260, 10);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 35);
			this.btnDelete.Text = "🗑️  Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

			this.btnSearch.BackColor = System.Drawing.Color.FromArgb(245, 158, 11);
			this.btnSearch.FlatAppearance.BorderSize = 0;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(390, 10);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(120, 35);
			this.btnSearch.Text = "🔍  Search";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

			this.btnClear.BackColor = System.Drawing.Color.FromArgb(71, 85, 105);
			this.btnClear.FlatAppearance.BorderSize = 0;
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnClear.ForeColor = System.Drawing.Color.White;
			this.btnClear.Location = new System.Drawing.Point(520, 10);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(120, 35);
			this.btnClear.Text = "🔄  Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

			// ── dgvPatients ──
			this.dgvPatients.AllowUserToAddRows = false;
			this.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvPatients.BackgroundColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.dgvPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPatients.MultiSelect = false;
			this.dgvPatients.ReadOnly = true;
			this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPatients.Location = new System.Drawing.Point(20, 225);
			this.dgvPatients.Name = "dgvPatients";
			this.dgvPatients.Size = new System.Drawing.Size(760, 380);
			this.dgvPatients.TabIndex = 3;
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
			this.dgvPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatients_CellContentClick);

			// ── PatientForm ──
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
			this.ClientSize = new System.Drawing.Size(800, 620);
			this.Controls.Add(this.dgvPatients);
			this.Controls.Add(this.panelButtons);
			this.Controls.Add(this.panelForm);
			this.Controls.Add(this.panelHeader);
			this.Name = "PatientForm";
			this.Text = "Patient Management";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.PatientForm_Load);

			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			this.panelForm.ResumeLayout(false);
			this.panelForm.PerformLayout();
			this.panelButtons.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel panelForm;
		private System.Windows.Forms.Panel panelButtons;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPatientName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAge;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbGender;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPatientContact;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.DataGridView dgvPatients;
	}
}