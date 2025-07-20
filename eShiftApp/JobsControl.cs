using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using Entities.Models;

namespace eShiftApp
{
    /// <summary>
    /// UserControl for listing, creating, updating and deleting Jobs.
    /// Shows all jobs in a grid and details in the form below.
    /// </summary>
    public partial class JobsControl : UserControl
    {
        private readonly IJobService _jobService = new JobService();
        private readonly ICustomerService _custService = new CustomerService();
        private int _selectedJobId = -1; // -1 indicates “creating new job”
        public JobsControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            AppEvents.DataChanged += RefreshData;
            this.Load += (s, e) => RefreshData();

            // Wire UI event handlers
            this.Load += JobsControl_Load;
            dgvJobs.SelectionChanged += DgvJobs_SelectionChanged;
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnRefresh.Click += BtnRefresh_Click;
        }

        public void RefreshData() => LoadJobs();

        /// <summary>
        /// Runs when the control is first shown:
        /// - Populates the Customer and Status dropdowns
        /// - Loads all jobs into the grid
        /// </summary>
        private void JobsControl_Load(object? sender, EventArgs e)
        {

            // Populate Status combo for JobStatus enum
            cboStatus.DataSource = Enum.GetValues(typeof(JobStatus));

            // Load the grid
            LoadJobs();
        }

        /// <summary>
        /// Fetches all jobs and binds them to dgvJobs.
        /// Also hides foreign‐key columns and clears the detail form.
        /// </summary>
        public void LoadJobs()
        {
            // Always reload the customer list
            var customers = _custService.GetAll().ToList();
            cboCustomer.DataSource = customers;
            cboCustomer.DisplayMember = nameof(Customer.Name);
            cboCustomer.ValueMember = nameof(Customer.CustomerId);

            // Bind grid with Customer names
            var viewList = _jobService.GetAll()
                .Select(j => new JobView
                {
                    JobId = j.JobId,
                    Status = j.Status,
                    CreatedDate = j.CreatedDate,
                    Customer = _custService.GetById(j.CustomerId)?.Name
                                  ?? "<Unknown>"
                })
                .ToList();

            dgvJobs.DataSource = viewList;

            if (dgvJobs.Rows.Count > 0)
            {
                dgvJobs.ClearSelection();
                dgvJobs.Rows[0].Selected = true;
                dgvJobs.FirstDisplayedScrollingRowIndex = 0;
            }

            ClearDetailFields();
        }

        /// <summary>
        /// Populates detail fields when the user selects a row in the grid.
        /// </summary>
        private void DgvJobs_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvJobs.SelectedRows.Count == 0)
            {
                ClearDetailFields();
                return;
            }

            // Cast to JobView—no error now
            var view = (JobView)dgvJobs.SelectedRows[0].DataBoundItem!;
            _selectedJobId = view.JobId;

            // Populate detail fields
            txtJobId.Text = view.JobId.ToString();
            cboCustomer.SelectedValue = _jobService
                                           .GetById(_selectedJobId)
                                           .CustomerId;
            cboStatus.SelectedItem = view.Status;
            dtpCreated.Value = view.CreatedDate;
        }

        /// <summary>
        /// Resets the detail form to “new record” state.
        /// </summary>
        private void ClearDetailFields()
        {
            _selectedJobId = -1;
            txtJobId.Clear();
            cboCustomer.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;
            dtpCreated.Value = DateTime.Today;
            dgvJobs.ClearSelection();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            // Validation: must pick a customer and a status
            if (cboCustomer.SelectedIndex < 0 || cboStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Please select both Customer and Status.",
                                "Validation", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning
                );
                return;
            }

            // Safely unbox the selected values
            int selectedCustId = Convert.ToInt32(cboCustomer.SelectedValue);
            if (!(cboStatus.SelectedItem is JobStatus selectedStatus))
            {
                MessageBox.Show("Invalid status selected.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_selectedJobId == -1)
            {
                // CREATE new Job
                var newJob = new Job
                {
                    CustomerId = selectedCustId,
                    Status = selectedStatus,
                    CreatedDate = DateTime.Now,
                };
                _jobService.Create(newJob);
            }
            else
            {
                // UPDATE existing Job
                var existing = _jobService.GetById(_selectedJobId);
                existing.CustomerId = selectedCustId;
                existing.Status = selectedStatus;
                existing.CreatedDate = dtpCreated.Value;
                _jobService.Update(existing);
            }

            // Refresh grid & reset form
            LoadJobs();

            AppEvents.OnDataChanged();
        }

        /// <summary>
        /// Deletes the selected Job after user confirmation.
        /// </summary>
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (_selectedJobId == -1) 
                return; // nothing to delete

            var result = MessageBox.Show(
                "Are you sure you want to delete this job?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                _jobService.Delete(_selectedJobId);
                LoadJobs();
            }

            AppEvents.OnDataChanged();
        }

        /// <summary>
        /// Reloads the job list from the database.
        /// </summary>
        private void BtnRefresh_Click(object? sender, EventArgs e)
        {
            LoadJobs();
        }

    }
}
