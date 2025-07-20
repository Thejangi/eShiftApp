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
    public partial class DashboardControl : UserControl
    {
        // Services for live data
        private readonly ICustomerService _custSvc = new CustomerService();
        private readonly IJobService _jobSvc = new JobService();
        private readonly IJobLoadService _loadSvc = new JobLoadService();
        private readonly ITransportUnitService _unitSvc = new TransportUnitService();

        // Events the host (MainForm) can subscribe to
        public event Action NewCustomerRequested;
        public event Action NewJobRequested;
        public event Action NewLoadRequested;
        public event Action NewUnitRequested;
        public event Action GenerateReportRequested;

        public DashboardControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            // whenever any data changes anywhere, refresh the dashboard
            AppEvents.DataChanged += RefreshData;

            // on first load
            this.Load += (s, e) => RefreshData();

            // when the control is shown, load the live stats
            this.Load += (s, e) => RefreshDashboard();

            // Wire button clicks to our events
            btnNewCustomer.Click += (s, e) => NewCustomerRequested?.Invoke();
            btnNewJob.Click += (s, e) => NewJobRequested?.Invoke();
            btnNewLoad.Click += (s, e) => NewLoadRequested?.Invoke();
            btnNewUnit.Click += (s, e) => NewUnitRequested?.Invoke();
            btnGenerateReport.Click += (s, e) => GenerateReportRequested?.Invoke();
        }

        /// <summary>
        /// Public wrapper so MainForm and AppEvents can call it.
        /// </summary>
        public void RefreshData() => RefreshDashboard();
        private void RefreshDashboard()
        {
            // Totals
            var allCustomers = _custSvc.GetAll().ToList();
            var allJobs = _jobSvc.GetAll().ToList();

            lblKpiCustCount.Text = allCustomers.Count.ToString();
            lblKpiJobsCount.Text = allJobs.Count.ToString();

            // Pending vs Completed
            int pending = allJobs.Count(j => j.Status == JobStatus.Pending);
            int completed = allJobs.Count(j => j.Status == JobStatus.Completed);

            lblKpiPendCount.Text = pending.ToString();
            lblKpiCompCount.Text = completed.ToString();

            // Build a pie chart for jobs by status
            chartJobStatus.Series.Clear();
            var series = chartJobStatus.Series.Add("ByStatus");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            foreach (JobStatus st in Enum.GetValues(typeof(JobStatus)))
            {
                int cnt = allJobs.Count(j => j.Status == st);
                if (cnt > 0)
                    series.Points.AddXY(st.ToString(), cnt);
            }
            chartJobStatus.Invalidate();  // force redraw

            // Fill Recent Jobs
            var recent = _jobSvc
                .GetAll()
                .OrderByDescending(j => j.CreatedDate)
                .Take(5)
                .Select(j => new {
                    j.JobId,
                    Customer = _custSvc.GetById(j.CustomerId).Name,
                    j.Status,
                    CreatedDate = j.CreatedDate.ToString("g")  // short date+time
                })
                .ToList();

            dgvRecentJobs.DataSource = recent;
            dgvRecentJobs.Columns["JobId"].HeaderText = "Job ID";
            dgvRecentJobs.Columns["Customer"].HeaderText = "Customer";
            dgvRecentJobs.Columns["Status"].HeaderText = "Status";
            dgvRecentJobs.Columns["CreatedDate"].HeaderText = "Created";
        }
    }
}
