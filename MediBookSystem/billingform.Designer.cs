namespace MediBookSystem
{
	partial class BillingForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.dgvBilling = new System.Windows.Forms.DataGridView();
			this.cmbPatient = new System.Windows.Forms.ComboBox();
			this.cmbDoctor = new System.Windows.Forms.ComboBox();
			this.cmbStatus = new System.Windows.Forms.ComboBox();
			this.txtService = new System.Windows.Forms.TextBox();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.btnUpdateStatus = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblPatient = new System.Windows.Forms.Label();
			this.lblDoctor = new System.Windows.Forms.Label();
			this.lblService = new System.Windows.Forms.Label();
			this.lblAmount = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();

			((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).BeginInit();
			this.SuspendLayout();

			// Title
			this.lblTitle.Text = "Billing & Invoice Management";
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblTitle.Height = 50;
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

			// Labels
			int lx = 20;
			System.Drawing.Color lc = System.Drawing.Color.White;
			this.lblPatient.Text = "Patient:"; this.lblPatient.Location = new System.Drawing.Point(lx, 70); this.lblPatient.Size = new System.Drawing.Size(90, 20); this.lblPatient.ForeColor = lc;
			this.lblDoctor.Text = "Doctor:"; this.lblDoctor.Location = new System.Drawing.Point(lx, 100); this.lblDoctor.Size = new System.Drawing.Size(90, 20); this.lblDoctor.ForeColor = lc;
			this.lblService.Text = "Service:"; this.lblService.Location = new System.Drawing.Point(lx, 130); this.lblService.Size = new System.Drawing.Size(90, 20); this.lblService.ForeColor = lc;
			this.lblAmount.Text = "Amount:"; this.lblAmount.Location = new System.Drawing.Point(lx, 160); this.lblAmount.Size = new System.Drawing.Size(90, 20); this.lblAmount.ForeColor = lc;
			this.lblStatus.Text = "Status:"; this.lblStatus.Location = new System.Drawing.Point(lx, 190); this.lblStatus.Size = new System.Drawing.Size(90, 20); this.lblStatus.ForeColor = lc;

			// Inputs
			int ix = 120, iw = 200;
			System.Drawing.Color ibg = System.Drawing.Color.FromArgb(51, 65, 85);

			this.cmbPatient.Location = new System.Drawing.Point(ix, 67); this.cmbPatient.Size = new System.Drawing.Size(iw, 22); this.cmbPatient.BackColor = ibg; this.cmbPatient.ForeColor = System.Drawing.Color.White; this.cmbPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
			this.cmbDoctor.Location = new System.Drawing.Point(ix, 97); this.cmbDoctor.Size = new System.Drawing.Size(iw, 22); this.cmbDoctor.BackColor = ibg; this.cmbDoctor.ForeColor = System.Drawing.Color.White; this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
			this.txtService.Location = new System.Drawing.Point(ix, 127); this.txtService.Size = new System.Drawing.Size(iw, 22); this.txtService.BackColor = ibg; this.txtService.ForeColor = System.Drawing.Color.White;
			this.txtAmount.Location = new System.Drawing.Point(ix, 157); this.txtAmount.Size = new System.Drawing.Size(iw, 22); this.txtAmount.BackColor = ibg; this.txtAmount.ForeColor = System.Drawing.Color.White;
			this.cmbStatus.Location = new System.Drawing.Point(ix, 187); this.cmbStatus.Size = new System.Drawing.Size(iw, 22); this.cmbStatus.BackColor = ibg; this.cmbStatus.ForeColor = System.Drawing.Color.White;
			this.cmbStatus.Items.AddRange(new string[] { "Unpaid", "Paid", "Partial" });
			this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

			// Buttons
			int bx = 340, bw = 110, bh = 30;
			this.btnGenerate.Text = "Generate Bill"; this.btnGenerate.Location = new System.Drawing.Point(bx, 67); this.btnGenerate.Size = new System.Drawing.Size(bw, bh); this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(59, 130, 246); this.btnGenerate.ForeColor = System.Drawing.Color.White; this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdateStatus.Text = "Update Status"; this.btnUpdateStatus.Location = new System.Drawing.Point(bx, 107); this.btnUpdateStatus.Size = new System.Drawing.Size(bw, bh); this.btnUpdateStatus.BackColor = System.Drawing.Color.FromArgb(16, 185, 129); this.btnUpdateStatus.ForeColor = System.Drawing.Color.White; this.btnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Text = "Delete"; this.btnDelete.Location = new System.Drawing.Point(bx, 147); this.btnDelete.Size = new System.Drawing.Size(bw, bh); this.btnDelete.BackColor = System.Drawing.Color.FromArgb(239, 68, 68); this.btnDelete.ForeColor = System.Drawing.Color.White; this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Text = "Clear"; this.btnClear.Location = new System.Drawing.Point(bx, 187); this.btnClear.Size = new System.Drawing.Size(bw, bh); this.btnClear.BackColor = System.Drawing.Color.FromArgb(100, 116, 139); this.btnClear.ForeColor = System.Drawing.Color.White; this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

			// DataGridView
			this.dgvBilling.Location = new System.Drawing.Point(20, 230);
			this.dgvBilling.Size = new System.Drawing.Size(760, 280);
			this.dgvBilling.BackgroundColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.dgvBilling.ForeColor = System.Drawing.Color.White;
			this.dgvBilling.GridColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.dgvBilling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvBilling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvBilling.ReadOnly = true;
			this.dgvBilling.AllowUserToAddRows = false;
			this.dgvBilling.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
			this.dgvBilling.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
			this.dgvBilling.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.dgvBilling.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
			this.dgvBilling.RowHeadersVisible = false;

			// Events
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			this.dgvBilling.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBilling_CellClick);
			this.Load += new System.EventHandler(this.BillingForm_Load);

			// Form
			this.ClientSize = new System.Drawing.Size(800, 530);
			this.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.Text = "MediBook - Billing & Invoice";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.lblPatient); this.Controls.Add(this.cmbPatient);
			this.Controls.Add(this.lblDoctor); this.Controls.Add(this.cmbDoctor);
			this.Controls.Add(this.lblService); this.Controls.Add(this.txtService);
			this.Controls.Add(this.lblAmount); this.Controls.Add(this.txtAmount);
			this.Controls.Add(this.lblStatus); this.Controls.Add(this.cmbStatus);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.btnUpdateStatus);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.dgvBilling);

			((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.DataGridView dgvBilling;
		private System.Windows.Forms.ComboBox cmbPatient;
		private System.Windows.Forms.ComboBox cmbDoctor;
		private System.Windows.Forms.ComboBox cmbStatus;
		private System.Windows.Forms.TextBox txtService;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Button btnUpdateStatus;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblPatient;
		private System.Windows.Forms.Label lblDoctor;
		private System.Windows.Forms.Label lblService;
		private System.Windows.Forms.Label lblAmount;
		private System.Windows.Forms.Label lblStatus;
	}
}