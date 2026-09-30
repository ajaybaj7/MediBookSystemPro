namespace MediBookSystem
{
	partial class SettingsForm
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
			this.panelAccount = new System.Windows.Forms.Panel();
			this.lblSectionAccount = new System.Windows.Forms.Label();
			this.lblUsername = new System.Windows.Forms.Label();
			this.txtNewUsername = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtNewPassword = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.panelTheme = new System.Windows.Forms.Panel();
			this.lblSectionTheme = new System.Windows.Forms.Label();
			this.lblThemeHint = new System.Windows.Forms.Label();
			this.btnDarkMode = new System.Windows.Forms.Button();
			this.btnLightMode = new System.Windows.Forms.Button();

			this.panelHeader.SuspendLayout();
			this.panelAccount.SuspendLayout();
			this.panelTheme.SuspendLayout();
			this.SuspendLayout();

			// panelHeader
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
			this.lblTitle.Text = "⚙️  Settings";

			// panelAccount
			this.panelAccount.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.panelAccount.Controls.Add(this.lblSectionAccount);
			this.panelAccount.Controls.Add(this.lblUsername);
			this.panelAccount.Controls.Add(this.txtNewUsername);
			this.panelAccount.Controls.Add(this.lblPassword);
			this.panelAccount.Controls.Add(this.txtNewPassword);
			this.panelAccount.Controls.Add(this.btnSave);
			this.panelAccount.Location = new System.Drawing.Point(20, 80);
			this.panelAccount.Name = "panelAccount";
			this.panelAccount.Size = new System.Drawing.Size(460, 220);
			this.panelAccount.TabIndex = 1;

			this.lblSectionAccount.AutoSize = true;
			this.lblSectionAccount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.lblSectionAccount.ForeColor = System.Drawing.Color.FromArgb(99, 179, 237);
			this.lblSectionAccount.Location = new System.Drawing.Point(15, 15);
			this.lblSectionAccount.Name = "lblSectionAccount";
			this.lblSectionAccount.Text = "🔐  Account Credentials";

			this.lblUsername.AutoSize = true;
			this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.lblUsername.Location = new System.Drawing.Point(15, 58);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Text = "NEW USERNAME";

			this.txtNewUsername.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.txtNewUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNewUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.txtNewUsername.ForeColor = System.Drawing.Color.White;
			this.txtNewUsername.Location = new System.Drawing.Point(15, 78);
			this.txtNewUsername.Name = "txtNewUsername";
			this.txtNewUsername.Size = new System.Drawing.Size(420, 27);
			this.txtNewUsername.TabIndex = 1;

			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.lblPassword.Location = new System.Drawing.Point(15, 118);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Text = "NEW PASSWORD";

			this.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
			this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.txtNewPassword.ForeColor = System.Drawing.Color.White;
			this.txtNewPassword.Location = new System.Drawing.Point(15, 138);
			this.txtNewPassword.Name = "txtNewPassword";
			this.txtNewPassword.PasswordChar = '*';
			this.txtNewPassword.Size = new System.Drawing.Size(420, 27);
			this.txtNewPassword.TabIndex = 2;

			this.btnSave.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(15, 180);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(180, 35);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "💾  Save Changes";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

			// panelTheme
			this.panelTheme.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
			this.panelTheme.Controls.Add(this.lblSectionTheme);
			this.panelTheme.Controls.Add(this.lblThemeHint);
			this.panelTheme.Controls.Add(this.btnDarkMode);
			this.panelTheme.Controls.Add(this.btnLightMode);
			this.panelTheme.Location = new System.Drawing.Point(500, 80);
			this.panelTheme.Name = "panelTheme";
			this.panelTheme.Size = new System.Drawing.Size(280, 220);
			this.panelTheme.TabIndex = 2;

			this.lblSectionTheme.AutoSize = true;
			this.lblSectionTheme.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.lblSectionTheme.ForeColor = System.Drawing.Color.FromArgb(99, 179, 237);
			this.lblSectionTheme.Location = new System.Drawing.Point(15, 15);
			this.lblSectionTheme.Name = "lblSectionTheme";
			this.lblSectionTheme.Text = "🎨  Appearance";

			this.lblThemeHint.AutoSize = false;
			this.lblThemeHint.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.lblThemeHint.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
			this.lblThemeHint.Location = new System.Drawing.Point(15, 50);
			this.lblThemeHint.Name = "lblThemeHint";
			this.lblThemeHint.Size = new System.Drawing.Size(250, 40);
			this.lblThemeHint.Text = "Choose a theme for this form.\nDashboard toggle also available on the sidebar.";

			this.btnDarkMode.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
			this.btnDarkMode.FlatAppearance.BorderSize = 0;
			this.btnDarkMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDarkMode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnDarkMode.ForeColor = System.Drawing.Color.White;
			this.btnDarkMode.Location = new System.Drawing.Point(15, 110);
			this.btnDarkMode.Name = "btnDarkMode";
			this.btnDarkMode.Size = new System.Drawing.Size(120, 40);
			this.btnDarkMode.TabIndex = 4;
			this.btnDarkMode.Text = "🌙  Dark";
			this.btnDarkMode.UseVisualStyleBackColor = false;
			this.btnDarkMode.Click += new System.EventHandler(this.btnDarkMode_Click);

			this.btnLightMode.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
			this.btnLightMode.FlatAppearance.BorderSize = 0;
			this.btnLightMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLightMode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnLightMode.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
			this.btnLightMode.Location = new System.Drawing.Point(15, 160);
			this.btnLightMode.Name = "btnLightMode";
			this.btnLightMode.Size = new System.Drawing.Size(120, 40);
			this.btnLightMode.TabIndex = 5;
			this.btnLightMode.Text = "☀️  Light";
			this.btnLightMode.UseVisualStyleBackColor = false;
			this.btnLightMode.Click += new System.EventHandler(this.btnLightMode_Click);

			// SettingsForm
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panelTheme);
			this.Controls.Add(this.panelAccount);
			this.Controls.Add(this.panelHeader);
			this.Name = "SettingsForm";
			this.Text = "Settings";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			this.panelAccount.ResumeLayout(false);
			this.panelAccount.PerformLayout();
			this.panelTheme.ResumeLayout(false);
			this.panelTheme.PerformLayout();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel panelAccount;
		private System.Windows.Forms.Label lblSectionAccount;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.TextBox txtNewUsername;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtNewPassword;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Panel panelTheme;
		private System.Windows.Forms.Label lblSectionTheme;
		private System.Windows.Forms.Label lblThemeHint;
		private System.Windows.Forms.Button btnDarkMode;
		private System.Windows.Forms.Button btnLightMode;
	}
}