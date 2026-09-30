namespace MediBookSystem
{
	partial class SuperAdminForm
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
			this.lblUsername = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblRole = new System.Windows.Forms.Label();
			this.cmbRole = new System.Windows.Forms.ComboBox();
			this.panelButtons = new System.Windows.Forms.Panel();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.dgvUsers = new System.Windows.Forms.DataGridView();

			this.panelHeader.SuspendLayout();
			this.panelForm.SuspendLayout();
			this.panelButtons.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
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
			this.lblTitle.Text = "👑  Super Admin — User Management";

			// ── panelForm ──
			this.panelForm.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.panelForm.Controls.Add(this.lblUsername);
			this.panelForm.Controls.Add(this.txtUsername);
			this.panelForm.Controls.Add(this.lblPassword);
			this.panelForm.Controls.Add(this.txtPassword);
			this.panelForm.Controls.Add(this.lblRole);
			this.panelForm.Controls.Add(this.cmbRole);
			this.panelForm.Location = new System.Drawing.Point(20, 75);
			this.panelForm.Name = "panelForm";
			this.panelForm.Size = new System.Drawing.Size(760, 80);
			this.panelForm.TabIndex = 1;

			// ── lblUsername ──
			this.lblUsername.AutoSize = true;
			this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.lblUsername.Location = new System.Drawing.Point(10, 10);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Text = "USERNAME";

			this.txtUsername.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtUsername.ForeColor = System.Drawing.Color.White;
			this.txtUsername.Location = new System.Drawing.Point(10, 30);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(200, 25);
			this.txtUsername.TabIndex = 1;

			// ── lblPassword ──
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.lblPassword.Location = new System.Drawing.Point(230, 10);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Text = "PASSWORD";

			this.txtPassword.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtPassword.ForeColor = System.Drawing.Color.White;
			this.txtPassword.Location = new System.Drawing.Point(230, 30);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(200, 25);
			this.txtPassword.TabIndex = 2;

			// ── lblRole ──
			this.lblRole.AutoSize = true;
			this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblRole.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.lblRole.Location = new System.Drawing.Point(450, 10);
			this.lblRole.Name = "lblRole";
			this.lblRole.Text = "ROLE";

			this.cmbRole.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.cmbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbRole.ForeColor = System.Drawing.Color.White;
			this.cmbRole.FormattingEnabled = true;
			this.cmbRole.Items.AddRange(new object[] {
				"Super Admin", "Admin", "Doctor", "Patient", "Receptionist"
			});
			this.cmbRole.Location = new System.Drawing.Point(450, 30);
			this.cmbRole.Name = "cmbRole";
			this.cmbRole.Size = new System.Drawing.Size(200, 25);
			this.cmbRole.TabIndex = 3;

			// ── panelButtons ──
			this.panelButtons.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
			this.panelButtons.Controls.Add(this.btnAdd);
			this.panelButtons.Controls.Add(this.btnUpdate);
			this.panelButtons.Controls.Add(this.btnDelete);
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
			this.btnAdd.Text = "➕  Add User";
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

			this.btnClear.BackColor = System.Drawing.Color.FromArgb(71, 85, 105);
			this.btnClear.FlatAppearance.BorderSize = 0;
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnClear.ForeColor = System.Drawing.Color.White;
			this.btnClear.Location = new System.Drawing.Point(390, 10);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(120, 35);
			this.btnClear.Text = "🔄  Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

			// ── dgvUsers ──
			this.dgvUsers.AllowUserToAddRows = false;
			this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsers.MultiSelect = false;
			this.dgvUsers.ReadOnly = true;
			this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUsers.Location = new System.Drawing.Point(20, 225);
			this.dgvUsers.Name = "dgvUsers";
			this.dgvUsers.Size = new System.Drawing.Size(760, 380);
			this.dgvUsers.TabIndex = 3;
			this.dgvUsers.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.dgvUsers.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
			this.dgvUsers.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(59, 130, 246);
			this.dgvUsers.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
			this.dgvUsers.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
			this.dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.dgvUsers.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.dgvUsers.EnableHeadersVisualStyles = false;
			this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.dgvUsers.RowTemplate.Height = 35;
			this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);

			// ── SuperAdminForm ──
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
			this.ClientSize = new System.Drawing.Size(800, 620);
			this.Controls.Add(this.dgvUsers);
			this.Controls.Add(this.panelButtons);
			this.Controls.Add(this.panelForm);
			this.Controls.Add(this.panelHeader);
			this.Name = "SuperAdminForm";
			this.Text = "Super Admin — User Management";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.SuperAdminForm_Load);

			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			this.panelForm.ResumeLayout(false);
			this.panelForm.PerformLayout();
			this.panelButtons.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel panelForm;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label lblRole;
		private System.Windows.Forms.ComboBox cmbRole;
		private System.Windows.Forms.Panel panelButtons;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.DataGridView dgvUsers;
	}
}