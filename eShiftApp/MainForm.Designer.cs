namespace eShiftApp
{
    partial class MainForm
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
            pnlNav = new Panel();
            flpButtons = new FlowLayoutPanel();
            btnDashboard = new Button();
            btnCustomers = new Button();
            btnJobs = new Button();
            btnLoads = new Button();
            btnUnits = new Button();
            btnReports = new Button();
            btnAdmins = new Button();
            pnlHeader = new Panel();
            btnLogout = new Button();
            lblCurrentUser = new Label();
            lblTitle = new Label();
            pnlContent = new Panel();
            pnlNav.SuspendLayout();
            flpButtons.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNav
            // 
            pnlNav.BackColor = SystemColors.ButtonFace;
            pnlNav.Controls.Add(flpButtons);
            pnlNav.Dock = DockStyle.Left;
            pnlNav.Location = new Point(0, 0);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(200, 721);
            pnlNav.TabIndex = 0;
            // 
            // flpButtons
            // 
            flpButtons.Controls.Add(btnDashboard);
            flpButtons.Controls.Add(btnCustomers);
            flpButtons.Controls.Add(btnAdmins);
            flpButtons.Controls.Add(btnJobs);
            flpButtons.Controls.Add(btnLoads);
            flpButtons.Controls.Add(btnUnits);
            flpButtons.Controls.Add(btnReports);
            flpButtons.Dock = DockStyle.Fill;
            flpButtons.FlowDirection = FlowDirection.TopDown;
            flpButtons.Location = new Point(0, 0);
            flpButtons.Name = "flpButtons";
            flpButtons.Padding = new Padding(10);
            flpButtons.Size = new Size(200, 721);
            flpButtons.TabIndex = 0;
            flpButtons.WrapContents = false;
            flpButtons.Paint += flowLayoutPanel1_Paint;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDashboard.Location = new Point(10, 10);
            btnDashboard.Margin = new Padding(0, 0, 0, 15);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(180, 40);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCustomers.Location = new Point(10, 65);
            btnCustomers.Margin = new Padding(0, 0, 0, 15);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(180, 40);
            btnCustomers.TabIndex = 1;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnJobs
            // 
            btnJobs.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnJobs.Location = new Point(10, 175);
            btnJobs.Margin = new Padding(0, 0, 0, 15);
            btnJobs.Name = "btnJobs";
            btnJobs.Size = new Size(180, 40);
            btnJobs.TabIndex = 2;
            btnJobs.Text = "Jobs";
            btnJobs.UseVisualStyleBackColor = true;
            btnJobs.Click += btnJobs_Click;
            // 
            // btnLoads
            // 
            btnLoads.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLoads.Location = new Point(10, 230);
            btnLoads.Margin = new Padding(0, 0, 0, 15);
            btnLoads.Name = "btnLoads";
            btnLoads.Size = new Size(180, 40);
            btnLoads.TabIndex = 3;
            btnLoads.Text = "Loads";
            btnLoads.UseVisualStyleBackColor = true;
            btnLoads.Click += button4_Click;
            // 
            // btnUnits
            // 
            btnUnits.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUnits.Location = new Point(10, 285);
            btnUnits.Margin = new Padding(0, 0, 0, 15);
            btnUnits.Name = "btnUnits";
            btnUnits.Size = new Size(180, 45);
            btnUnits.TabIndex = 4;
            btnUnits.Text = "Units";
            btnUnits.UseVisualStyleBackColor = true;
            btnUnits.Click += btnUnits_Click;
            // 
            // btnReports
            // 
            btnReports.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReports.Location = new Point(10, 345);
            btnReports.Margin = new Padding(0, 0, 0, 15);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(180, 40);
            btnReports.TabIndex = 5;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnAdmins
            // 
            btnAdmins.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdmins.Location = new Point(10, 120);
            btnAdmins.Margin = new Padding(0, 0, 0, 15);
            btnAdmins.Name = "btnAdmins";
            btnAdmins.Size = new Size(180, 40);
            btnAdmins.TabIndex = 6;
            btnAdmins.Text = "Admins";
            btnAdmins.UseVisualStyleBackColor = true;
            btnAdmins.Click += btnAdmins_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(0, 122, 204);
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Controls.Add(lblCurrentUser);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(200, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(806, 60);
            pnlHeader.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(695, 15);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(80, 30);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCurrentUser.ForeColor = Color.White;
            lblCurrentUser.Location = new Point(550, 20);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(44, 20);
            lblCurrentUser.TabIndex = 1;
            lblCurrentUser.Text = "User: ";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(138, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dashboard";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(200, 60);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(806, 661);
            pnlContent.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlNav);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Shift Management System";
            pnlNav.ResumeLayout(false);
            flpButtons.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNav;
        private FlowLayoutPanel flpButtons;
        private Button btnDashboard;
        private Button btnCustomers;
        private Button btnJobs;
        private Button btnLoads;
        private Button btnUnits;
        private Button btnReports;
        private Panel pnlHeader;
        private Label lblTitle;
        private Button btnLogout;
        private Label lblCurrentUser;
        private Panel pnlContent;
        private Button btnAdmins;
    }
}