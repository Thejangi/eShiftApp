namespace eShiftApp
{
    partial class DashboardControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            flpKpiCards = new FlowLayoutPanel();
            pnlKpiCustomers = new Panel();
            lblKpiCustLabel = new Label();
            lblKpiCustCount = new Label();
            pnlKpiJobs = new Panel();
            lblKpiJobsLabel = new Label();
            lblKpiJobsCount = new Label();
            pnlKpiPending = new Panel();
            lblKpiPendLabel = new Label();
            lblKpiPendCount = new Label();
            pnlKpiCompleted = new Panel();
            lblKpiCompLabel = new Label();
            lblKpiCompCount = new Label();
            chartJobStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dgvRecentJobs = new DataGridView();
            flpQuickActions = new FlowLayoutPanel();
            btnNewCustomer = new Button();
            btnNewJob = new Button();
            btnNewLoad = new Button();
            btnNewUnit = new Button();
            btnGenerateReport = new Button();
            flpKpiCards.SuspendLayout();
            pnlKpiCustomers.SuspendLayout();
            pnlKpiJobs.SuspendLayout();
            pnlKpiPending.SuspendLayout();
            pnlKpiCompleted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartJobStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentJobs).BeginInit();
            flpQuickActions.SuspendLayout();
            SuspendLayout();
            // 
            // flpKpiCards
            // 
            flpKpiCards.Controls.Add(pnlKpiCustomers);
            flpKpiCards.Controls.Add(pnlKpiJobs);
            flpKpiCards.Controls.Add(pnlKpiPending);
            flpKpiCards.Controls.Add(pnlKpiCompleted);
            flpKpiCards.Location = new Point(20, 20);
            flpKpiCards.Name = "flpKpiCards";
            flpKpiCards.Padding = new Padding(10);
            flpKpiCards.Size = new Size(766, 100);
            flpKpiCards.TabIndex = 0;
            flpKpiCards.WrapContents = false;
            // 
            // pnlKpiCustomers
            // 
            pnlKpiCustomers.BackColor = Color.FromArgb(225, 245, 254);
            pnlKpiCustomers.Controls.Add(lblKpiCustLabel);
            pnlKpiCustomers.Controls.Add(lblKpiCustCount);
            pnlKpiCustomers.Location = new Point(10, 10);
            pnlKpiCustomers.Margin = new Padding(0, 0, 10, 0);
            pnlKpiCustomers.Name = "pnlKpiCustomers";
            pnlKpiCustomers.RightToLeft = RightToLeft.No;
            pnlKpiCustomers.Size = new Size(180, 80);
            pnlKpiCustomers.TabIndex = 0;
            // 
            // lblKpiCustLabel
            // 
            lblKpiCustLabel.AutoSize = true;
            lblKpiCustLabel.Location = new Point(32, 48);
            lblKpiCustLabel.Name = "lblKpiCustLabel";
            lblKpiCustLabel.Size = new Size(115, 20);
            lblKpiCustLabel.TabIndex = 1;
            lblKpiCustLabel.Text = "Total Customers";
            lblKpiCustLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKpiCustCount
            // 
            lblKpiCustCount.AutoSize = true;
            lblKpiCustCount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblKpiCustCount.Location = new Point(50, 8);
            lblKpiCustCount.Name = "lblKpiCustCount";
            lblKpiCustCount.Size = new Size(80, 46);
            lblKpiCustCount.TabIndex = 0;
            lblKpiCustCount.Text = "000";
            lblKpiCustCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlKpiJobs
            // 
            pnlKpiJobs.BackColor = Color.FromArgb(225, 245, 254);
            pnlKpiJobs.Controls.Add(lblKpiJobsLabel);
            pnlKpiJobs.Controls.Add(lblKpiJobsCount);
            pnlKpiJobs.Location = new Point(200, 10);
            pnlKpiJobs.Margin = new Padding(0, 0, 10, 0);
            pnlKpiJobs.Name = "pnlKpiJobs";
            pnlKpiJobs.RightToLeft = RightToLeft.No;
            pnlKpiJobs.Size = new Size(180, 80);
            pnlKpiJobs.TabIndex = 1;
            // 
            // lblKpiJobsLabel
            // 
            lblKpiJobsLabel.AutoSize = true;
            lblKpiJobsLabel.Location = new Point(52, 48);
            lblKpiJobsLabel.Name = "lblKpiJobsLabel";
            lblKpiJobsLabel.Size = new Size(75, 20);
            lblKpiJobsLabel.TabIndex = 1;
            lblKpiJobsLabel.Text = "Total Jobs";
            lblKpiJobsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKpiJobsCount
            // 
            lblKpiJobsCount.AutoSize = true;
            lblKpiJobsCount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblKpiJobsCount.Location = new Point(50, 8);
            lblKpiJobsCount.Name = "lblKpiJobsCount";
            lblKpiJobsCount.Size = new Size(80, 46);
            lblKpiJobsCount.TabIndex = 0;
            lblKpiJobsCount.Text = "000";
            lblKpiJobsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlKpiPending
            // 
            pnlKpiPending.BackColor = Color.FromArgb(225, 245, 254);
            pnlKpiPending.Controls.Add(lblKpiPendLabel);
            pnlKpiPending.Controls.Add(lblKpiPendCount);
            pnlKpiPending.Location = new Point(390, 10);
            pnlKpiPending.Margin = new Padding(0, 0, 10, 0);
            pnlKpiPending.Name = "pnlKpiPending";
            pnlKpiPending.RightToLeft = RightToLeft.No;
            pnlKpiPending.Size = new Size(180, 80);
            pnlKpiPending.TabIndex = 2;
            // 
            // lblKpiPendLabel
            // 
            lblKpiPendLabel.AutoSize = true;
            lblKpiPendLabel.Location = new Point(42, 48);
            lblKpiPendLabel.Name = "lblKpiPendLabel";
            lblKpiPendLabel.Size = new Size(95, 20);
            lblKpiPendLabel.TabIndex = 1;
            lblKpiPendLabel.Text = "Pending Jobs";
            lblKpiPendLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKpiPendCount
            // 
            lblKpiPendCount.AutoSize = true;
            lblKpiPendCount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblKpiPendCount.Location = new Point(50, 8);
            lblKpiPendCount.Name = "lblKpiPendCount";
            lblKpiPendCount.Size = new Size(80, 46);
            lblKpiPendCount.TabIndex = 0;
            lblKpiPendCount.Text = "000";
            lblKpiPendCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlKpiCompleted
            // 
            pnlKpiCompleted.BackColor = Color.FromArgb(225, 245, 254);
            pnlKpiCompleted.Controls.Add(lblKpiCompLabel);
            pnlKpiCompleted.Controls.Add(lblKpiCompCount);
            pnlKpiCompleted.Location = new Point(580, 10);
            pnlKpiCompleted.Margin = new Padding(0, 0, 10, 0);
            pnlKpiCompleted.Name = "pnlKpiCompleted";
            pnlKpiCompleted.RightToLeft = RightToLeft.No;
            pnlKpiCompleted.Size = new Size(180, 80);
            pnlKpiCompleted.TabIndex = 3;
            // 
            // lblKpiCompLabel
            // 
            lblKpiCompLabel.AutoSize = true;
            lblKpiCompLabel.Location = new Point(32, 48);
            lblKpiCompLabel.Name = "lblKpiCompLabel";
            lblKpiCompLabel.Size = new Size(116, 20);
            lblKpiCompLabel.TabIndex = 1;
            lblKpiCompLabel.Text = "Completed Jobs";
            lblKpiCompLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKpiCompCount
            // 
            lblKpiCompCount.AutoSize = true;
            lblKpiCompCount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblKpiCompCount.Location = new Point(50, 8);
            lblKpiCompCount.Name = "lblKpiCompCount";
            lblKpiCompCount.Size = new Size(80, 46);
            lblKpiCompCount.TabIndex = 0;
            lblKpiCompCount.Text = "000";
            lblKpiCompCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chartJobStatus
            // 
            chartArea1.Name = "ChartArea1";
            chartJobStatus.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartJobStatus.Legends.Add(legend1);
            chartJobStatus.Location = new Point(20, 140);
            chartJobStatus.Name = "chartJobStatus";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Status";
            chartJobStatus.Series.Add(series1);
            chartJobStatus.Size = new Size(380, 250);
            chartJobStatus.TabIndex = 1;
            chartJobStatus.Text = "chart1";
            // 
            // dgvRecentJobs
            // 
            dgvRecentJobs.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dgvRecentJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRecentJobs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecentJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentJobs.Location = new Point(420, 140);
            dgvRecentJobs.Name = "dgvRecentJobs";
            dgvRecentJobs.ReadOnly = true;
            dgvRecentJobs.RowHeadersVisible = false;
            dgvRecentJobs.RowHeadersWidth = 51;
            dgvRecentJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentJobs.Size = new Size(364, 250);
            dgvRecentJobs.TabIndex = 2;
            // 
            // flpQuickActions
            // 
            flpQuickActions.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flpQuickActions.Controls.Add(btnNewCustomer);
            flpQuickActions.Controls.Add(btnNewJob);
            flpQuickActions.Controls.Add(btnNewLoad);
            flpQuickActions.Controls.Add(btnNewUnit);
            flpQuickActions.Controls.Add(btnGenerateReport);
            flpQuickActions.FlowDirection = FlowDirection.TopDown;
            flpQuickActions.Location = new Point(420, 410);
            flpQuickActions.Name = "flpQuickActions";
            flpQuickActions.Padding = new Padding(10);
            flpQuickActions.Size = new Size(364, 240);
            flpQuickActions.TabIndex = 3;
            flpQuickActions.WrapContents = false;
            // 
            // btnNewCustomer
            // 
            btnNewCustomer.Cursor = Cursors.Hand;
            btnNewCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNewCustomer.Location = new Point(10, 10);
            btnNewCustomer.Margin = new Padding(0, 0, 0, 10);
            btnNewCustomer.Name = "btnNewCustomer";
            btnNewCustomer.Size = new Size(150, 30);
            btnNewCustomer.TabIndex = 0;
            btnNewCustomer.Text = "New Customer";
            btnNewCustomer.UseVisualStyleBackColor = true;
            // 
            // btnNewJob
            // 
            btnNewJob.Cursor = Cursors.Hand;
            btnNewJob.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNewJob.Location = new Point(10, 50);
            btnNewJob.Margin = new Padding(0, 0, 0, 10);
            btnNewJob.Name = "btnNewJob";
            btnNewJob.Size = new Size(150, 30);
            btnNewJob.TabIndex = 1;
            btnNewJob.Text = "New Job";
            btnNewJob.UseVisualStyleBackColor = true;
            // 
            // btnNewLoad
            // 
            btnNewLoad.Cursor = Cursors.Hand;
            btnNewLoad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNewLoad.Location = new Point(10, 90);
            btnNewLoad.Margin = new Padding(0, 0, 0, 10);
            btnNewLoad.Name = "btnNewLoad";
            btnNewLoad.Size = new Size(150, 30);
            btnNewLoad.TabIndex = 2;
            btnNewLoad.Text = "New Load";
            btnNewLoad.UseVisualStyleBackColor = true;
            // 
            // btnNewUnit
            // 
            btnNewUnit.Cursor = Cursors.Hand;
            btnNewUnit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNewUnit.Location = new Point(10, 130);
            btnNewUnit.Margin = new Padding(0, 0, 0, 10);
            btnNewUnit.Name = "btnNewUnit";
            btnNewUnit.Size = new Size(150, 30);
            btnNewUnit.TabIndex = 3;
            btnNewUnit.Text = "New Unit";
            btnNewUnit.UseVisualStyleBackColor = true;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Cursor = Cursors.Hand;
            btnGenerateReport.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGenerateReport.Location = new Point(10, 170);
            btnGenerateReport.Margin = new Padding(0, 0, 0, 10);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(150, 30);
            btnGenerateReport.TabIndex = 4;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flpQuickActions);
            Controls.Add(dgvRecentJobs);
            Controls.Add(chartJobStatus);
            Controls.Add(flpKpiCards);
            Name = "DashboardControl";
            Size = new Size(806, 661);
            flpKpiCards.ResumeLayout(false);
            pnlKpiCustomers.ResumeLayout(false);
            pnlKpiCustomers.PerformLayout();
            pnlKpiJobs.ResumeLayout(false);
            pnlKpiJobs.PerformLayout();
            pnlKpiPending.ResumeLayout(false);
            pnlKpiPending.PerformLayout();
            pnlKpiCompleted.ResumeLayout(false);
            pnlKpiCompleted.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartJobStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentJobs).EndInit();
            flpQuickActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpKpiCards;
        private Panel pnlKpiCustomers;
        private Label lblKpiCustCount;
        private Label lblKpiCustLabel;
        private Panel pnlKpiJobs;
        private Label lblKpiJobsLabel;
        private Label lblKpiJobsCount;
        private Panel pnlKpiPending;
        private Label lblKpiPendLabel;
        private Label lblKpiPendCount;
        private Panel pnlKpiCompleted;
        private Label lblKpiCompLabel;
        private Label lblKpiCompCount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartJobStatus;
        private DataGridView dgvRecentJobs;
        private FlowLayoutPanel flpQuickActions;
        private Button btnNewCustomer;
        private Button btnNewJob;
        private Button btnNewLoad;
        private Button btnNewUnit;
        private Button btnGenerateReport;
    }
}
