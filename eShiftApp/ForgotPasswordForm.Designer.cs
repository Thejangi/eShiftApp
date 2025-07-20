namespace eShiftApp
{
    partial class ForgotPasswordForm
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
            gbReset = new GroupBox();
            lblFP_Email = new Label();
            txtFP_Email = new TextBox();
            txtFP_NewPwd = new TextBox();
            lblFP_NewPwd = new Label();
            txtFP_Confirm = new TextBox();
            lblFP_Confirm = new Label();
            lblFP_EmailError = new Label();
            lblFP_NewPwdError = new Label();
            lblFP_ConfirmError = new Label();
            btnFP_Reset = new Button();
            btnFP_Cancel = new Button();
            gbReset.SuspendLayout();
            SuspendLayout();
            // 
            // gbReset
            // 
            gbReset.Controls.Add(btnFP_Cancel);
            gbReset.Controls.Add(btnFP_Reset);
            gbReset.Controls.Add(lblFP_ConfirmError);
            gbReset.Controls.Add(txtFP_Confirm);
            gbReset.Controls.Add(lblFP_NewPwdError);
            gbReset.Controls.Add(lblFP_Confirm);
            gbReset.Controls.Add(txtFP_NewPwd);
            gbReset.Controls.Add(lblFP_NewPwd);
            gbReset.Controls.Add(lblFP_EmailError);
            gbReset.Controls.Add(txtFP_Email);
            gbReset.Controls.Add(lblFP_Email);
            gbReset.Font = new Font("Segoe UI", 12F);
            gbReset.Location = new Point(20, 20);
            gbReset.Name = "gbReset";
            gbReset.Size = new Size(390, 260);
            gbReset.TabIndex = 0;
            gbReset.TabStop = false;
            gbReset.Text = "Reset Your Password";
            // 
            // lblFP_Email
            // 
            lblFP_Email.AutoSize = true;
            lblFP_Email.Font = new Font("Segoe UI", 10F);
            lblFP_Email.Location = new Point(30, 40);
            lblFP_Email.Name = "lblFP_Email";
            lblFP_Email.Size = new Size(55, 23);
            lblFP_Email.TabIndex = 0;
            lblFP_Email.Text = "Email:";
            // 
            // txtFP_Email
            // 
            txtFP_Email.Font = new Font("Segoe UI", 10F);
            txtFP_Email.Location = new Point(190, 36);
            txtFP_Email.Name = "txtFP_Email";
            txtFP_Email.Size = new Size(180, 30);
            txtFP_Email.TabIndex = 1;
            // 
            // txtFP_NewPwd
            // 
            txtFP_NewPwd.Font = new Font("Segoe UI", 10F);
            txtFP_NewPwd.Location = new Point(195, 96);
            txtFP_NewPwd.Name = "txtFP_NewPwd";
            txtFP_NewPwd.Size = new Size(180, 30);
            txtFP_NewPwd.TabIndex = 3;
            // 
            // lblFP_NewPwd
            // 
            lblFP_NewPwd.AutoSize = true;
            lblFP_NewPwd.Font = new Font("Segoe UI", 10F);
            lblFP_NewPwd.Location = new Point(30, 100);
            lblFP_NewPwd.Name = "lblFP_NewPwd";
            lblFP_NewPwd.Size = new Size(84, 23);
            lblFP_NewPwd.TabIndex = 2;
            lblFP_NewPwd.Text = "Password:";
            // 
            // txtFP_Confirm
            // 
            txtFP_Confirm.Font = new Font("Segoe UI", 10F);
            txtFP_Confirm.Location = new Point(190, 156);
            txtFP_Confirm.Name = "txtFP_Confirm";
            txtFP_Confirm.Size = new Size(180, 30);
            txtFP_Confirm.TabIndex = 5;
            // 
            // lblFP_Confirm
            // 
            lblFP_Confirm.AutoSize = true;
            lblFP_Confirm.Font = new Font("Segoe UI", 10F);
            lblFP_Confirm.Location = new Point(30, 160);
            lblFP_Confirm.Name = "lblFP_Confirm";
            lblFP_Confirm.Size = new Size(150, 23);
            lblFP_Confirm.TabIndex = 4;
            lblFP_Confirm.Text = "Confirm Password:";
            // 
            // lblFP_EmailError
            // 
            lblFP_EmailError.AutoSize = true;
            lblFP_EmailError.Font = new Font("Segoe UI", 8F);
            lblFP_EmailError.ForeColor = Color.Tomato;
            lblFP_EmailError.Location = new Point(190, 66);
            lblFP_EmailError.Name = "lblFP_EmailError";
            lblFP_EmailError.Size = new Size(0, 19);
            lblFP_EmailError.TabIndex = 6;
            // 
            // lblFP_NewPwdError
            // 
            lblFP_NewPwdError.AutoSize = true;
            lblFP_NewPwdError.Font = new Font("Segoe UI", 8F);
            lblFP_NewPwdError.ForeColor = Color.Tomato;
            lblFP_NewPwdError.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblFP_NewPwdError.Location = new Point(195, 121);
            lblFP_NewPwdError.Name = "lblFP_NewPwdError";
            lblFP_NewPwdError.Size = new Size(0, 19);
            lblFP_NewPwdError.TabIndex = 7;
            // 
            // lblFP_ConfirmError
            // 
            lblFP_ConfirmError.AutoSize = true;
            lblFP_ConfirmError.Font = new Font("Segoe UI", 8F);
            lblFP_ConfirmError.ForeColor = Color.Tomato;
            lblFP_ConfirmError.Location = new Point(190, 186);
            lblFP_ConfirmError.Name = "lblFP_ConfirmError";
            lblFP_ConfirmError.Size = new Size(0, 19);
            lblFP_ConfirmError.TabIndex = 8;
            // 
            // btnFP_Reset
            // 
            btnFP_Reset.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFP_Reset.Location = new Point(80, 205);
            btnFP_Reset.Name = "btnFP_Reset";
            btnFP_Reset.Size = new Size(100, 36);
            btnFP_Reset.TabIndex = 9;
            btnFP_Reset.Text = "Reset";
            btnFP_Reset.UseVisualStyleBackColor = true;
            // 
            // btnFP_Cancel
            // 
            btnFP_Cancel.BackColor = Color.Gray;
            btnFP_Cancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFP_Cancel.ForeColor = Color.White;
            btnFP_Cancel.Location = new Point(200, 200);
            btnFP_Cancel.Name = "btnFP_Cancel";
            btnFP_Cancel.Size = new Size(100, 36);
            btnFP_Cancel.TabIndex = 10;
            btnFP_Cancel.Text = "Cancel";
            btnFP_Cancel.UseVisualStyleBackColor = false;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(430, 298);
            Controls.Add(gbReset);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Reset Password";
            gbReset.ResumeLayout(false);
            gbReset.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbReset;
        private Label lblFP_Confirm;
        private TextBox txtFP_Confirm;
        private Label lblFP_NewPwd;
        private TextBox txtFP_NewPwd;
        private TextBox txtFP_Email;
        private Label lblFP_Email;
        private Button btnFP_Reset;
        private Label lblFP_ConfirmError;
        private Label lblFP_NewPwdError;
        private Label lblFP_EmailError;
        private Button btnFP_Cancel;
    }
}