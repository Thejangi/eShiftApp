namespace eShiftApp
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpRegistration = new GroupBox();
            lblName = new Label();
            txtName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirm = new Label();
            txtConfirm = new TextBox();
            lblNameError = new Label();
            lblEmailError = new Label();
            lblUserError = new Label();
            lblPwdError = new Label();
            lblConfirmError = new Label();
            btnRegister = new Button();
            btnCancel = new Button();
            grpRegistration.SuspendLayout();
            SuspendLayout();
            // 
            // grpRegistration
            // 
            grpRegistration.Controls.Add(btnCancel);
            grpRegistration.Controls.Add(btnRegister);
            grpRegistration.Controls.Add(lblConfirmError);
            grpRegistration.Controls.Add(txtConfirm);
            grpRegistration.Controls.Add(lblConfirm);
            grpRegistration.Controls.Add(lblPwdError);
            grpRegistration.Controls.Add(txtPassword);
            grpRegistration.Controls.Add(lblPassword);
            grpRegistration.Controls.Add(lblUserError);
            grpRegistration.Controls.Add(txtUsername);
            grpRegistration.Controls.Add(lblUsername);
            grpRegistration.Controls.Add(lblEmailError);
            grpRegistration.Controls.Add(txtEmail);
            grpRegistration.Controls.Add(lblEmail);
            grpRegistration.Controls.Add(lblNameError);
            grpRegistration.Controls.Add(txtName);
            grpRegistration.Controls.Add(lblName);
            grpRegistration.Font = new Font("Segoe UI", 12F);
            grpRegistration.Location = new Point(20, 20);
            grpRegistration.Name = "grpRegistration";
            grpRegistration.Size = new Size(440, 380);
            grpRegistration.TabIndex = 0;
            grpRegistration.TabStop = false;
            grpRegistration.Text = "Create New Account";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.Location = new Point(30, 40);
            lblName.Name = "lblName";
            lblName.Size = new Size(91, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Full Name:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(190, 36);
            txtName.Name = "txtName";
            txtName.Size = new Size(230, 30);
            txtName.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(30, 90);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(120, 23);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email Address:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(190, 86);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(230, 30);
            txtEmail.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F);
            lblUsername.Location = new Point(30, 140);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 23);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(190, 136);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(230, 30);
            txtUsername.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.Location = new Point(30, 190);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(84, 23);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(190, 186);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(230, 30);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Font = new Font("Segoe UI", 10F);
            lblConfirm.Location = new Point(30, 240);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(150, 23);
            lblConfirm.TabIndex = 8;
            lblConfirm.Text = "Confirm Password:";
            // 
            // txtConfirm
            // 
            txtConfirm.Font = new Font("Segoe UI", 10F);
            txtConfirm.Location = new Point(190, 236);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(230, 30);
            txtConfirm.TabIndex = 9;
            txtConfirm.UseSystemPasswordChar = true;
            // 
            // lblNameError
            // 
            lblNameError.AutoSize = true;
            lblNameError.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNameError.ForeColor = Color.Tomato;
            lblNameError.Location = new Point(190, 66);
            lblNameError.Name = "lblNameError";
            lblNameError.Size = new Size(73, 17);
            lblNameError.TabIndex = 10;
            lblNameError.Text = "NameError";
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmailError.ForeColor = Color.Tomato;
            lblEmailError.Location = new Point(190, 116);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(69, 17);
            lblEmailError.TabIndex = 11;
            lblEmailError.Text = "EmailError";
            // 
            // lblUserError
            // 
            lblUserError.AutoSize = true;
            lblUserError.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserError.ForeColor = Color.Tomato;
            lblUserError.Location = new Point(190, 166);
            lblUserError.Name = "lblUserError";
            lblUserError.Size = new Size(65, 17);
            lblUserError.TabIndex = 12;
            lblUserError.Text = "UserError";
            // 
            // lblPwdError
            // 
            lblPwdError.AutoSize = true;
            lblPwdError.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPwdError.ForeColor = Color.Tomato;
            lblPwdError.Location = new Point(190, 216);
            lblPwdError.Name = "lblPwdError";
            lblPwdError.Size = new Size(62, 17);
            lblPwdError.TabIndex = 13;
            lblPwdError.Text = "PwdError";
            // 
            // lblConfirmError
            // 
            lblConfirmError.AutoSize = true;
            lblConfirmError.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmError.ForeColor = Color.Tomato;
            lblConfirmError.Location = new Point(190, 266);
            lblConfirmError.Name = "lblConfirmError";
            lblConfirmError.Size = new Size(84, 17);
            lblConfirmError.TabIndex = 14;
            lblConfirmError.Text = "ConfirmError";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegister.Location = new Point(80, 320);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(120, 36);
            btnRegister.TabIndex = 16;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gray;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(260, 320);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 36);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(482, 413);
            Controls.Add(grpRegistration);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Registration";
            grpRegistration.ResumeLayout(false);
            grpRegistration.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpRegistration;
        private Label lblName;
        private Label lblEmail;
        private TextBox txtName;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private TextBox txtEmail;
        private TextBox txtConfirm;
        private Label lblConfirm;
        private Label lblConfirmError;
        private Label lblPwdError;
        private Label lblUserError;
        private Label lblEmailError;
        private Label lblNameError;
        private Button btnRegister;
        private Button btnCancel;
    }
}