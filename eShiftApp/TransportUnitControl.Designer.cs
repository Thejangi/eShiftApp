namespace eShiftApp
{
    partial class TransportUnitControl
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
            dgvUnits = new DataGridView();
            grpUnitDetails = new GroupBox();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            txtContainerId = new TextBox();
            lblContainerId = new Label();
            txtAssistant = new TextBox();
            lblAssistant = new Label();
            txtDriverName = new TextBox();
            lblDriverName = new Label();
            txtLorryPlate = new TextBox();
            lblLorryPlate = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUnits).BeginInit();
            grpUnitDetails.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUnits
            // 
            dgvUnits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUnits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUnits.Location = new Point(20, 20);
            dgvUnits.Name = "dgvUnits";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUnits.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUnits.RowHeadersVisible = false;
            dgvUnits.RowHeadersWidth = 51;
            dgvUnits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUnits.Size = new Size(766, 400);
            dgvUnits.TabIndex = 0;
            // 
            // grpUnitDetails
            // 
            grpUnitDetails.Controls.Add(btnRefresh);
            grpUnitDetails.Controls.Add(btnDelete);
            grpUnitDetails.Controls.Add(btnSave);
            grpUnitDetails.Controls.Add(txtContainerId);
            grpUnitDetails.Controls.Add(lblContainerId);
            grpUnitDetails.Controls.Add(txtAssistant);
            grpUnitDetails.Controls.Add(lblAssistant);
            grpUnitDetails.Controls.Add(txtDriverName);
            grpUnitDetails.Controls.Add(lblDriverName);
            grpUnitDetails.Controls.Add(txtLorryPlate);
            grpUnitDetails.Controls.Add(lblLorryPlate);
            grpUnitDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpUnitDetails.Location = new Point(20, 440);
            grpUnitDetails.Name = "grpUnitDetails";
            grpUnitDetails.Size = new Size(766, 200);
            grpUnitDetails.TabIndex = 1;
            grpUnitDetails.TabStop = false;
            grpUnitDetails.Text = "Unit Details";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.Location = new Point(622, 150);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 30);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.Location = new Point(502, 150);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.Location = new Point(382, 150);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // txtContainerId
            // 
            txtContainerId.Font = new Font("Segoe UI", 10F);
            txtContainerId.Location = new Point(530, 76);
            txtContainerId.Name = "txtContainerId";
            txtContainerId.Size = new Size(200, 30);
            txtContainerId.TabIndex = 7;
            // 
            // lblContainerId
            // 
            lblContainerId.AutoSize = true;
            lblContainerId.Font = new Font("Segoe UI", 10F);
            lblContainerId.Location = new Point(400, 80);
            lblContainerId.Name = "lblContainerId";
            lblContainerId.Size = new Size(111, 23);
            lblContainerId.TabIndex = 6;
            lblContainerId.Text = "Container ID:";
            // 
            // txtAssistant
            // 
            txtAssistant.Font = new Font("Segoe UI", 10F);
            txtAssistant.Location = new Point(530, 36);
            txtAssistant.Name = "txtAssistant";
            txtAssistant.Size = new Size(200, 30);
            txtAssistant.TabIndex = 5;
            // 
            // lblAssistant
            // 
            lblAssistant.AutoSize = true;
            lblAssistant.Font = new Font("Segoe UI", 10F);
            lblAssistant.Location = new Point(400, 40);
            lblAssistant.Name = "lblAssistant";
            lblAssistant.Size = new Size(81, 23);
            lblAssistant.TabIndex = 4;
            lblAssistant.Text = "Assistant:";
            // 
            // txtDriverName
            // 
            txtDriverName.Font = new Font("Segoe UI", 10F);
            txtDriverName.Location = new Point(150, 76);
            txtDriverName.Name = "txtDriverName";
            txtDriverName.Size = new Size(200, 30);
            txtDriverName.TabIndex = 3;
            // 
            // lblDriverName
            // 
            lblDriverName.AutoSize = true;
            lblDriverName.Font = new Font("Segoe UI", 10F);
            lblDriverName.Location = new Point(30, 80);
            lblDriverName.Name = "lblDriverName";
            lblDriverName.Size = new Size(110, 23);
            lblDriverName.TabIndex = 2;
            lblDriverName.Text = "Driver Name:";
            // 
            // txtLorryPlate
            // 
            txtLorryPlate.Font = new Font("Segoe UI", 10F);
            txtLorryPlate.Location = new Point(150, 36);
            txtLorryPlate.Name = "txtLorryPlate";
            txtLorryPlate.Size = new Size(200, 30);
            txtLorryPlate.TabIndex = 1;
            // 
            // lblLorryPlate
            // 
            lblLorryPlate.AutoSize = true;
            lblLorryPlate.Font = new Font("Segoe UI", 10F);
            lblLorryPlate.Location = new Point(30, 40);
            lblLorryPlate.Name = "lblLorryPlate";
            lblLorryPlate.Size = new Size(95, 23);
            lblLorryPlate.TabIndex = 0;
            lblLorryPlate.Text = "Lorry Plate:";
            // 
            // TransportUnitControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpUnitDetails);
            Controls.Add(dgvUnits);
            Name = "TransportUnitControl";
            Size = new Size(806, 661);
            ((System.ComponentModel.ISupportInitialize)dgvUnits).EndInit();
            grpUnitDetails.ResumeLayout(false);
            grpUnitDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUnits;
        private GroupBox grpUnitDetails;
        private Label lblLorryPlate;
        private Label lblAssistant;
        private TextBox txtDriverName;
        private Label lblDriverName;
        private TextBox txtLorryPlate;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnSave;
        private TextBox txtContainerId;
        private Label lblContainerId;
        private TextBox txtAssistant;
    }
}
