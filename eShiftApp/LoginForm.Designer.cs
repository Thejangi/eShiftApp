namespace eShiftApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpUserType = new GroupBox();
            rdoAdmin = new RadioButton();
            rdoCustomer = new RadioButton();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lnkRegister = new LinkLabel();
            lnkForgotPassword = new LinkLabel();
            grpUserType.SuspendLayout();
            SuspendLayout();
            // 
            // grpUserType
            // 
            grpUserType.Controls.Add(rdoAdmin);
            grpUserType.Controls.Add(rdoCustomer);
            grpUserType.Location = new Point(20, 20);
            grpUserType.Name = "grpUserType";
            grpUserType.Size = new Size(340, 60);
            grpUserType.TabIndex = 0;
            grpUserType.TabStop = false;
            grpUserType.Text = "User Type";
            // 
            // rdoAdmin
            // 
            rdoAdmin.AutoSize = true;
            rdoAdmin.Location = new Point(140, 24);
            rdoAdmin.Name = "rdoAdmin";
            rdoAdmin.Size = new Size(74, 24);
            rdoAdmin.TabIndex = 1;
            rdoAdmin.TabStop = true;
            rdoAdmin.Text = "Admin";
            rdoAdmin.UseVisualStyleBackColor = true;
            // 
            // rdoCustomer
            // 
            rdoCustomer.AutoSize = true;
            rdoCustomer.Location = new Point(20, 24);
            rdoCustomer.Name = "rdoCustomer";
            rdoCustomer.Size = new Size(93, 24);
            rdoCustomer.TabIndex = 0;
            rdoCustomer.TabStop = true;
            rdoCustomer.Text = "Customer";
            rdoCustomer.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 100);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(100, 96);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 27);
            txtEmail.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(20, 140);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(100, 136);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(260, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 122, 204);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(150, 210);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 30);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lnkRegister
            // 
            lnkRegister.ActiveLinkColor = Color.DarkBlue;
            lnkRegister.AutoSize = true;
            lnkRegister.LinkColor = Color.SteelBlue;
            lnkRegister.Location = new Point(120, 250);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(162, 20);
            lnkRegister.TabIndex = 6;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Register a new account";
            lnkRegister.TextAlign = ContentAlignment.TopCenter;
            lnkRegister.VisitedLinkColor = Color.Purple;
            // 
            // lnkForgotPassword
            // 
            lnkForgotPassword.ActiveLinkColor = Color.Red;
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lnkForgotPassword.LinkColor = Color.Tomato;
            lnkForgotPassword.Location = new Point(240, 170);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(120, 20);
            lnkForgotPassword.TabIndex = 7;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Forgot password?";
            lnkForgotPassword.TextAlign = ContentAlignment.TopCenter;
            lnkForgotPassword.VisitedLinkColor = Color.DarkRed;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(382, 293);
            Controls.Add(lnkRegister);
            Controls.Add(btnLogin);
            Controls.Add(lnkForgotPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(grpUserType);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += Form1_Load;
            grpUserType.ResumeLayout(false);
            grpUserType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpUserType;
        private RadioButton rdoCustomer;
        private RadioButton rdoAdmin;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel lnkRegister;
        private LinkLabel lnkForgotPassword;
    }
}
