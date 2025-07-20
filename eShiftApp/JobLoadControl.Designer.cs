namespace eShiftApp
{
    partial class JobLoadControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvJobLoads = new DataGridView();
            grpLoadDetails = new GroupBox();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            txtDropoffLocation = new TextBox();
            lblDropoff = new Label();
            txtPickupLocation = new TextBox();
            lblPickup = new Label();
            txtVolume = new TextBox();
            lblVolume = new Label();
            txtWeight = new TextBox();
            lblWeight = new Label();
            cboUnitLoad = new ComboBox();
            lblUnit = new Label();
            cboJobLoad = new ComboBox();
            lblJobId = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvJobLoads).BeginInit();
            grpLoadDetails.SuspendLayout();
            SuspendLayout();
            // 
            // dgvJobLoads
            // 
            dgvJobLoads.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvJobLoads.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvJobLoads.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobLoads.Location = new Point(20, 20);
            dgvJobLoads.Name = "dgvJobLoads";
            dgvJobLoads.ReadOnly = true;
            dgvJobLoads.RowHeadersVisible = false;
            dgvJobLoads.RowHeadersWidth = 51;
            dgvJobLoads.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJobLoads.Size = new Size(766, 370);
            dgvJobLoads.TabIndex = 0;
            // 
            // grpLoadDetails
            // 
            grpLoadDetails.Controls.Add(btnRefresh);
            grpLoadDetails.Controls.Add(btnDelete);
            grpLoadDetails.Controls.Add(btnSave);
            grpLoadDetails.Controls.Add(txtDropoffLocation);
            grpLoadDetails.Controls.Add(lblDropoff);
            grpLoadDetails.Controls.Add(txtPickupLocation);
            grpLoadDetails.Controls.Add(lblPickup);
            grpLoadDetails.Controls.Add(txtVolume);
            grpLoadDetails.Controls.Add(lblVolume);
            grpLoadDetails.Controls.Add(txtWeight);
            grpLoadDetails.Controls.Add(lblWeight);
            grpLoadDetails.Controls.Add(cboUnitLoad);
            grpLoadDetails.Controls.Add(lblUnit);
            grpLoadDetails.Controls.Add(cboJobLoad);
            grpLoadDetails.Controls.Add(lblJobId);
            grpLoadDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpLoadDetails.Location = new Point(20, 400);
            grpLoadDetails.Name = "grpLoadDetails";
            grpLoadDetails.Size = new Size(766, 240);
            grpLoadDetails.TabIndex = 1;
            grpLoadDetails.TabStop = false;
            grpLoadDetails.Text = "Load Details";
            // 
            // btnRefresh
            // 
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.Location = new Point(622, 190);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 30);
            btnRefresh.TabIndex = 14;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.Location = new Point(502, 190);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.Location = new Point(382, 190);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtDropoffLocation
            // 
            txtDropoffLocation.Font = new Font("Segoe UI", 10F);
            txtDropoffLocation.Location = new Point(520, 116);
            txtDropoffLocation.Name = "txtDropoffLocation";
            txtDropoffLocation.Size = new Size(230, 30);
            txtDropoffLocation.TabIndex = 10;
            // 
            // lblDropoff
            // 
            lblDropoff.AutoSize = true;
            lblDropoff.Font = new Font("Segoe UI", 10F);
            lblDropoff.Location = new Point(420, 116);
            lblDropoff.Name = "lblDropoff";
            lblDropoff.Size = new Size(72, 23);
            lblDropoff.TabIndex = 11;
            lblDropoff.Text = "Dropoff:";
            // 
            // txtPickupLocation
            // 
            txtPickupLocation.Font = new Font("Segoe UI", 10F);
            txtPickupLocation.Location = new Point(520, 76);
            txtPickupLocation.Name = "txtPickupLocation";
            txtPickupLocation.Size = new Size(230, 30);
            txtPickupLocation.TabIndex = 9;
            // 
            // lblPickup
            // 
            lblPickup.AutoSize = true;
            lblPickup.Font = new Font("Segoe UI", 10F);
            lblPickup.Location = new Point(420, 80);
            lblPickup.Name = "lblPickup";
            lblPickup.Size = new Size(99, 23);
            lblPickup.TabIndex = 8;
            lblPickup.Text = "Pickup Loc.:";
            // 
            // txtVolume
            // 
            txtVolume.Font = new Font("Segoe UI", 10F);
            txtVolume.Location = new Point(520, 36);
            txtVolume.Name = "txtVolume";
            txtVolume.Size = new Size(100, 30);
            txtVolume.TabIndex = 7;
            // 
            // lblVolume
            // 
            lblVolume.AutoSize = true;
            lblVolume.Font = new Font("Segoe UI", 10F);
            lblVolume.Location = new Point(420, 40);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new Size(72, 23);
            lblVolume.TabIndex = 6;
            lblVolume.Text = "Volume:";
            // 
            // txtWeight
            // 
            txtWeight.Font = new Font("Segoe UI", 10F);
            txtWeight.Location = new Point(130, 116);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(100, 30);
            txtWeight.TabIndex = 5;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI", 9F);
            lblWeight.Location = new Point(30, 120);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(59, 20);
            lblWeight.TabIndex = 4;
            lblWeight.Text = "Weight:";
            // 
            // cboUnitLoad
            // 
            cboUnitLoad.Font = new Font("Segoe UI", 10F);
            cboUnitLoad.FormattingEnabled = true;
            cboUnitLoad.Location = new Point(130, 76);
            cboUnitLoad.Name = "cboUnitLoad";
            cboUnitLoad.Size = new Size(250, 31);
            cboUnitLoad.TabIndex = 3;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("Segoe UI", 10F);
            lblUnit.Location = new Point(30, 80);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(46, 23);
            lblUnit.TabIndex = 2;
            lblUnit.Text = "Unit:";
            // 
            // cboJobLoad
            // 
            cboJobLoad.Font = new Font("Segoe UI", 10F);
            cboJobLoad.FormattingEnabled = true;
            cboJobLoad.Location = new Point(130, 36);
            cboJobLoad.Name = "cboJobLoad";
            cboJobLoad.Size = new Size(250, 31);
            cboJobLoad.TabIndex = 1;
            // 
            // lblJobId
            // 
            lblJobId.AutoSize = true;
            lblJobId.Font = new Font("Segoe UI", 10F);
            lblJobId.Location = new Point(30, 40);
            lblJobId.Name = "lblJobId";
            lblJobId.Size = new Size(40, 23);
            lblJobId.TabIndex = 0;
            lblJobId.Text = "Job:";
            // 
            // JobLoadControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(grpLoadDetails);
            Controls.Add(dgvJobLoads);
            Name = "JobLoadControl";
            Size = new Size(806, 661);
            ((System.ComponentModel.ISupportInitialize)dgvJobLoads).EndInit();
            grpLoadDetails.ResumeLayout(false);
            grpLoadDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvJobLoads;
        private GroupBox grpLoadDetails;
        private Label lblJobId;
        private ComboBox cboUnitLoad;
        private Label lblUnit;
        private ComboBox cboJobLoad;
        private Label lblPickup;
        private TextBox txtVolume;
        private Label lblVolume;
        private TextBox txtWeight;
        private Label lblWeight;
        private TextBox txtDropoffLocation;
        private TextBox txtPickupLocation;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnSave;
        private Label lblDropoff;
    }
}
