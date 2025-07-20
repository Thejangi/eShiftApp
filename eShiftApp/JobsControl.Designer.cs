namespace eShiftApp
{
    partial class JobsControl
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvJobs = new DataGridView();
            grpJobDetails = new GroupBox();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            dtpCreated = new DateTimePicker();
            lblCreated = new Label();
            cboStatus = new ComboBox();
            lblStatus = new Label();
            cboCustomer = new ComboBox();
            lblCustomer = new Label();
            txtJobId = new TextBox();
            lblJobId = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).BeginInit();
            grpJobDetails.SuspendLayout();
            SuspendLayout();
            // 
            // dgvJobs
            // 
            dgvJobs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvJobs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobs.Location = new Point(20, 20);
            dgvJobs.Name = "dgvJobs";
            dgvJobs.ReadOnly = true;
            dgvJobs.RowHeadersVisible = false;
            dgvJobs.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvJobs.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJobs.ShowCellToolTips = false;
            dgvJobs.Size = new Size(766, 400);
            dgvJobs.TabIndex = 0;
            // 
            // grpJobDetails
            // 
            grpJobDetails.Controls.Add(btnRefresh);
            grpJobDetails.Controls.Add(btnDelete);
            grpJobDetails.Controls.Add(btnSave);
            grpJobDetails.Controls.Add(dtpCreated);
            grpJobDetails.Controls.Add(lblCreated);
            grpJobDetails.Controls.Add(cboStatus);
            grpJobDetails.Controls.Add(lblStatus);
            grpJobDetails.Controls.Add(cboCustomer);
            grpJobDetails.Controls.Add(lblCustomer);
            grpJobDetails.Controls.Add(txtJobId);
            grpJobDetails.Controls.Add(lblJobId);
            grpJobDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpJobDetails.Location = new Point(20, 440);
            grpJobDetails.Name = "grpJobDetails";
            grpJobDetails.Size = new Size(766, 200);
            grpJobDetails.TabIndex = 1;
            grpJobDetails.TabStop = false;
            grpJobDetails.Text = "Job Details";
            // 
            // btnRefresh
            // 
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.Location = new Point(622, 150);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 30);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.Location = new Point(502, 150);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.Location = new Point(382, 150);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // dtpCreated
            // 
            dtpCreated.CustomFormat = "dd/MM/yyyy";
            dtpCreated.Font = new Font("Segoe UI", 10F);
            dtpCreated.Format = DateTimePickerFormat.Custom;
            dtpCreated.Location = new Point(580, 76);
            dtpCreated.Name = "dtpCreated";
            dtpCreated.Size = new Size(150, 30);
            dtpCreated.TabIndex = 7;
            // 
            // lblCreated
            // 
            lblCreated.AutoSize = true;
            lblCreated.Font = new Font("Segoe UI", 10F);
            lblCreated.Location = new Point(440, 80);
            lblCreated.Name = "lblCreated";
            lblCreated.Size = new Size(115, 23);
            lblCreated.TabIndex = 6;
            lblCreated.Text = "Created Date:";
            // 
            // cboStatus
            // 
            cboStatus.Font = new Font("Segoe UI", 10F);
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(580, 36);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(150, 31);
            cboStatus.TabIndex = 5;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.Location = new Point(440, 40);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 23);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status:";
            // 
            // cboCustomer
            // 
            cboCustomer.Font = new Font("Segoe UI", 10F);
            cboCustomer.FormattingEnabled = true;
            cboCustomer.Location = new Point(130, 76);
            cboCustomer.Name = "cboCustomer";
            cboCustomer.Size = new Size(250, 31);
            cboCustomer.TabIndex = 3;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 10F);
            lblCustomer.Location = new Point(30, 80);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(88, 23);
            lblCustomer.TabIndex = 2;
            lblCustomer.Text = "Customer:";
            // 
            // txtJobId
            // 
            txtJobId.Font = new Font("Segoe UI", 10F);
            txtJobId.Location = new Point(130, 36);
            txtJobId.Name = "txtJobId";
            txtJobId.ReadOnly = true;
            txtJobId.Size = new Size(100, 30);
            txtJobId.TabIndex = 1;
            // 
            // lblJobId
            // 
            lblJobId.AutoSize = true;
            lblJobId.Font = new Font("Segoe UI", 10F);
            lblJobId.Location = new Point(30, 40);
            lblJobId.Name = "lblJobId";
            lblJobId.Size = new Size(62, 23);
            lblJobId.TabIndex = 0;
            lblJobId.Text = "Job ID:";
            // 
            // JobsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(grpJobDetails);
            Controls.Add(dgvJobs);
            Name = "JobsControl";
            Size = new Size(806, 661);
            ((System.ComponentModel.ISupportInitialize)dgvJobs).EndInit();
            grpJobDetails.ResumeLayout(false);
            grpJobDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvJobs;
        private GroupBox grpJobDetails;
        private TextBox txtJobId;
        private Label lblJobId;
        private Label lblCustomer;
        private ComboBox cboStatus;
        private Label lblStatus;
        private ComboBox cboCustomer;
        private DateTimePicker dtpCreated;
        private Label lblCreated;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnSave;
    }
}
