namespace MediBookSystem
{
	partial class StaffForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.dgvStaff = new System.Windows.Forms.DataGridView();
			this.txtStaffName = new System.Windows.Forms.TextBox();
			this.txtRole = new System.Windows.Forms.TextBox();
			this.txtContact = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblRole = new System.Windows.Forms.Label();
			this.lblContact = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();

			((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
			this.SuspendLayout();

			// lblTitle
			this.lblTitle.Text = "Staff Management";
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblTitle.Height = 50;
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

			// Labels
			int lx = 20;
			this.lblName.Text = "Staff Name:"; this.lblName.Location = new System.Drawing.Point(lx, 70); this.lblName.Size = new System.Drawing.Size(90, 20); this.lblName.ForeColor = System.Drawing.Color.White;
			this.lblRole.Text = "Role:"; this.lblRole.Location = new System.Drawing.Point(lx, 100); this.lblRole.Size = new System.Drawing.Size(90, 20); this.lblRole.ForeColor = System.Drawing.Color.White;
			this.lblContact.Text = "Contact:"; this.lblContact.Location = new System.Drawing.Point(lx, 130); this.lblContact.Size = new System.Drawing.Size(90, 20); this.lblContact.ForeColor = System.Drawing.Color.White;
			this.lblEmail.Text = "Email:"; this.lblEmail.Location = new System.Drawing.Point(lx, 160); this.lblEmail.Size = new System.Drawing.Size(90, 20); this.lblEmail.ForeColor = System.Drawing.Color.White;
			this.lblAddress.Text = "Address:"; this.lblAddress.Location = new System.Drawing.Point(lx, 190); this.lblAddress.Size = new System.Drawing.Size(90, 20); this.lblAddress.ForeColor = System.Drawing.Color.White;

			// TextBoxes
			int tx = 120, tw = 200;
			this.txtStaffName.Location = new System.Drawing.Point(tx, 67); this.txtStaffName.Size = new System.Drawing.Size(tw, 22); this.txtStaffName.BackColor = System.Drawing.Color.FromArgb(51, 65, 85); this.txtStaffName.ForeColor = System.Drawing.Color.White;
			this.txtRole.Location = new System.Drawing.Point(tx, 97); this.txtRole.Size = new System.Drawing.Size(tw, 22); this.txtRole.BackColor = System.Drawing.Color.FromArgb(51, 65, 85); this.txtRole.ForeColor = System.Drawing.Color.White;
			this.txtContact.Location = new System.Drawing.Point(tx, 127); this.txtContact.Size = new System.Drawing.Size(tw, 22); this.txtContact.BackColor = System.Drawing.Color.FromArgb(51, 65, 85); this.txtContact.ForeColor = System.Drawing.Color.White;
			this.txtEmail.Location = new System.Drawing.Point(tx, 157); this.txtEmail.Size = new System.Drawing.Size(tw, 22); this.txtEmail.BackColor = System.Drawing.Color.FromArgb(51, 65, 85); this.txtEmail.ForeColor = System.Drawing.Color.White;
			this.txtAddress.Location = new System.Drawing.Point(tx, 187); this.txtAddress.Size = new System.Drawing.Size(tw, 22); this.txtAddress.BackColor = System.Drawing.Color.FromArgb(51, 65, 85); this.txtAddress.ForeColor = System.Drawing.Color.White;

			// Buttons
			System.Drawing.Color btnColor = System.Drawing.Color.FromArgb(59, 130, 246);
			int bx = 340, bw = 90, bh = 30;
			this.btnAdd.Text = "Add"; this.btnAdd.Location = new System.Drawing.Point(bx, 67); this.btnAdd.Size = new System.Drawing.Size(bw, bh); this.btnAdd.BackColor = btnColor; this.btnAdd.ForeColor = System.Drawing.Color.White; this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Text = "Update"; this.btnUpdate.Location = new System.Drawing.Point(bx, 107); this.btnUpdate.Size = new System.Drawing.Size(bw, bh); this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(16, 185, 129); this.btnUpdate.ForeColor = System.Drawing.Color.White; this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Text = "Delete"; this.btnDelete.Location = new System.Drawing.Point(bx, 147); this.btnDelete.Size = new System.Drawing.Size(bw, bh); this.btnDelete.BackColor = System.Drawing.Color.FromArgb(239, 68, 68); this.btnDelete.ForeColor = System.Drawing.Color.White; this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Text = "Clear"; this.btnClear.Location = new System.Drawing.Point(bx, 187); this.btnClear.Size = new System.Drawing.Size(bw, bh); this.btnClear.BackColor = System.Drawing.Color.FromArgb(100, 116, 139); this.btnClear.ForeColor = System.Drawing.Color.White; this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

			// DataGridView
			this.dgvStaff.Location = new System.Drawing.Point(20, 230);
			this.dgvStaff.Size = new System.Drawing.Size(760, 280);
			this.dgvStaff.BackgroundColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.dgvStaff.ForeColor = System.Drawing.Color.White;
			this.dgvStaff.GridColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvStaff.ReadOnly = true;
			this.dgvStaff.AllowUserToAddRows = false;
			this.dgvStaff.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
			this.dgvStaff.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
			this.dgvStaff.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.dgvStaff.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
			this.dgvStaff.RowHeadersVisible = false;

			// Event handlers
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick);
			this.Load += new System.EventHandler(this.StaffForm_Load);

			// Form
			this.ClientSize = new System.Drawing.Size(800, 530);
			this.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.Text = "MediBook - Staff Management";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.lblName); this.Controls.Add(this.txtStaffName);
			this.Controls.Add(this.lblRole); this.Controls.Add(this.txtRole);
			this.Controls.Add(this.lblContact); this.Controls.Add(this.txtContact);
			this.Controls.Add(this.lblEmail); this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.lblAddress); this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.dgvStaff);

			((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.DataGridView dgvStaff;
		private System.Windows.Forms.TextBox txtStaffName;
		private System.Windows.Forms.TextBox txtRole;
		private System.Windows.Forms.TextBox txtContact;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblRole;
		private System.Windows.Forms.Label lblContact;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblAddress;
	}
}