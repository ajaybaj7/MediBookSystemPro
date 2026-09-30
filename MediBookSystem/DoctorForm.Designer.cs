namespace MediBookSystem
{
	partial class DoctorForm
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
			this.txtDoctorName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSpecialization = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtContact = new System.Windows.Forms.TextBox();
			this.panelButtons = new System.Windows.Forms.Panel();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.dgvDoctors = new System.Windows.Forms.DataGridView();

			this.panelHeader.SuspendLayout();
			this.panelForm.SuspendLayout();
			this.panelButtons.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
			this.SuspendLayout();

			// ── panelHeader ──
			this.panelHeader.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.panelHeader.Controls.Add(this.lblTitle);
			this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(800, 60);
			this.panelHeader.TabIndex = 0;

			// ── lblTitle ──
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(20, 15);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Text = "👨‍⚕️  Doctor Management";

			// ── panelForm ──
			this.panelForm.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.panelForm.Controls.Add(this.label1);
			this.panelForm.Controls.Add(this.txtDoctorName);
			this.panelForm.Controls.Add(this.label2);
			this.panelForm.Controls.Add(this.txtSpecialization);
			this.panelForm.Controls.Add(this.label3);
			this.panelForm.Controls.Add(this.txtContact);
			this.panelForm.Location = new System.Drawing.Point(20, 75);
			this.panelForm.Name = "panelForm";
			this.panelForm.Size = new System.Drawing.Size(760, 80);
			this.panelForm.TabIndex = 1;

			// ── label1 - Doctor Name ──
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.label1.Location = new System.Drawing.Point(10, 10);
			this.label1.Name = "label1";
			this.label1.Text = "DOCTOR NAME";

			// ── txtDoctorName ──
			this.txtDoctorName.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.txtDoctorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDoctorName.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtDoctorName.ForeColor = System.Drawing.Color.White;
			this.txtDoctorName.Location = new System.Drawing.Point(10, 30);
			this.txtDoctorName.Name = "txtDoctorName";
			this.txtDoctorName.Size = new System.Drawing.Size(220, 25);
			this.txtDoctorName.TabIndex = 1;

			// ── label2 - Specialization ──
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.label2.Location = new System.Drawing.Point(260, 10);
			this.label2.Name = "label2";
			this.label2.Text = "SPECIALIZATION";

			// ── txtSpecialization ──
			this.txtSpecialization.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.txtSpecialization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSpecialization.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtSpecialization.ForeColor = System.Drawing.Color.White;
			this.txtSpecialization.Location = new System.Drawing.Point(260, 30);
			this.txtSpecialization.Name = "txtSpecialization";
			this.txtSpecialization.Size = new System.Drawing.Size(220, 25);
			this.txtSpecialization.TabIndex = 2;

			// ── label3 - Contact ──
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.label3.Location = new System.Drawing.Point(510, 10);
			this.label3.Name = "label3";
			this.label3.Text = "CONTACT NUMBER";

			// ── txtContact ──
			this.txtContact.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtContact.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtContact.ForeColor = System.Drawing.Color.White;
			this.txtContact.Location = new System.Drawing.Point(510, 30);
			this.txtContact.Name = "txtContact";
			this.txtContact.Size = new System.Drawing.Size(220, 25);
			this.txtContact.TabIndex = 3;

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

			// ── btnAdd ──
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Location = new System.Drawing.Point(0, 10);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(120, 35);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "➕  Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

			// ── btnUpdate ──
			this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
			this.btnUpdate.FlatAppearance.BorderSize = 0;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnUpdate.ForeColor = System.Drawing.Color.White;
			this.btnUpdate.Location = new System.Drawing.Point(130, 10);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(120, 35);
			this.btnUpdate.TabIndex = 1;
			this.btnUpdate.Text = "✏️  Update";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

			// ── btnDelete ──
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(260, 10);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 35);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "🗑️  Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

			// ── btnSearch ──
			this.btnSearch.BackColor = System.Drawing.Color.FromArgb(245, 158, 11);
			this.btnSearch.FlatAppearance.BorderSize = 0;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(390, 10);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(120, 35);
			this.btnSearch.TabIndex = 3;
			this.btnSearch.Text = "🔍  Search";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

			// ── btnClear ──
			this.btnClear.BackColor = System.Drawing.Color.FromArgb(71, 85, 105);
			this.btnClear.FlatAppearance.BorderSize = 0;
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnClear.ForeColor = System.Drawing.Color.White;
			this.btnClear.Location = new System.Drawing.Point(520, 10);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(120, 35);
			this.btnClear.TabIndex = 4;
			this.btnClear.Text = "🔄  Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

			// ── dgvDoctors ──
			this.dgvDoctors.AllowUserToAddRows = false;
			this.dgvDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDoctors.BackgroundColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.dgvDoctors.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDoctors.MultiSelect = false;
			this.dgvDoctors.ReadOnly = true;
			this.dgvDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDoctors.Location = new System.Drawing.Point(20, 225);
			this.dgvDoctors.Name = "dgvDoctors";
			this.dgvDoctors.Size = new System.Drawing.Size(760, 380);
			this.dgvDoctors.TabIndex = 3;

			// DataGridView dark styling
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

			this.dgvDoctors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctors_CellContentClick);

			// ── DoctorForm ──
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
			this.ClientSize = new System.Drawing.Size(800, 620);
			this.Controls.Add(this.dgvDoctors);
			this.Controls.Add(this.panelButtons);
			this.Controls.Add(this.panelForm);
			this.Controls.Add(this.panelHeader);
			this.Name = "DoctorForm";
			this.Text = "Doctor Management";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.DoctorForm_Load);

			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			this.panelForm.ResumeLayout(false);
			this.panelForm.PerformLayout();
			this.panelButtons.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel panelForm;
		private System.Windows.Forms.Panel panelButtons;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDoctorName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSpecialization;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtContact;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.DataGridView dgvDoctors;
	}
}