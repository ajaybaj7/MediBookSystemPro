namespace MediBookSystem
{
	partial class Form1
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
			this.lblSubtitle = new System.Windows.Forms.Label();
			this.panelLogin = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbRole = new System.Windows.Forms.ComboBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.lblWelcome = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
			this.panelLogin.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxLogo
			// 
			this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
			this.pictureBoxLogo.Location = new System.Drawing.Point(142, 30);
			this.pictureBoxLogo.Name = "pictureBoxLogo";
			this.pictureBoxLogo.Size = new System.Drawing.Size(200, 65);
			this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLogo.TabIndex = 0;
			this.pictureBoxLogo.TabStop = false;
			this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
			// 
			// lblSubtitle
			// 
			this.lblSubtitle.AutoSize = true;
			this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
			this.lblSubtitle.Location = new System.Drawing.Point(124, 140);
			this.lblSubtitle.Name = "lblSubtitle";
			this.lblSubtitle.Size = new System.Drawing.Size(228, 15);
			this.lblSubtitle.TabIndex = 4;
			this.lblSubtitle.Text = "Hospital Appointment Scheduling System";
			this.lblSubtitle.Click += new System.EventHandler(this.lblSubtitle_Click);
			// 
			// panelLogin
			// 
			this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelLogin.Controls.Add(this.label1);
			this.panelLogin.Controls.Add(this.txtUsername);
			this.panelLogin.Controls.Add(this.label2);
			this.panelLogin.Controls.Add(this.txtPassword);
			this.panelLogin.Controls.Add(this.label3);
			this.panelLogin.Controls.Add(this.cmbRole);
			this.panelLogin.Controls.Add(this.btnLogin);
			this.panelLogin.Location = new System.Drawing.Point(42, 175);
			this.panelLogin.Name = "panelLogin";
			this.panelLogin.Size = new System.Drawing.Size(400, 300);
			this.panelLogin.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
			this.label1.Location = new System.Drawing.Point(25, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "USERNAME";
			// 
			// txtUsername
			// 
			this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
			this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.txtUsername.ForeColor = System.Drawing.Color.White;
			this.txtUsername.Location = new System.Drawing.Point(25, 45);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(350, 27);
			this.txtUsername.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
			this.label2.Location = new System.Drawing.Point(25, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "PASSWORD";
			// 
			// txtPassword
			// 
			this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.txtPassword.ForeColor = System.Drawing.Color.White;
			this.txtPassword.Location = new System.Drawing.Point(25, 110);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(350, 27);
			this.txtPassword.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
			this.label3.Location = new System.Drawing.Point(25, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "LOGIN AS";
			// 
			// cmbRole
			// 
			this.cmbRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
			this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbRole.ForeColor = System.Drawing.Color.White;
			this.cmbRole.FormattingEnabled = true;
			this.cmbRole.Location = new System.Drawing.Point(25, 175);
			this.cmbRole.Name = "cmbRole";
			this.cmbRole.Size = new System.Drawing.Size(350, 25);
			this.cmbRole.TabIndex = 3;
			this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
			this.btnLogin.FlatAppearance.BorderSize = 0;
			this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(25, 225);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(350, 45);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "Sign In";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// lblWelcome
			// 
			this.lblWelcome.AutoSize = true;
			this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
			this.lblWelcome.ForeColor = System.Drawing.Color.White;
			this.lblWelcome.Location = new System.Drawing.Point(139, 103);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Size = new System.Drawing.Size(203, 37);
			this.lblWelcome.TabIndex = 3;
			this.lblWelcome.Text = "Welcome Back";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
			this.ClientSize = new System.Drawing.Size(484, 490);
			this.Controls.Add(this.panelLogin);
			this.Controls.Add(this.lblWelcome);
			this.Controls.Add(this.lblSubtitle);
			this.Controls.Add(this.pictureBoxLogo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MediBook — Login";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
			this.panelLogin.ResumeLayout(false);
			this.panelLogin.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.PictureBox pictureBoxLogo;
		private System.Windows.Forms.Label lblSubtitle;
		private System.Windows.Forms.Label lblWelcome;
		private System.Windows.Forms.Panel panelLogin;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbRole;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnLogin;
	}
}