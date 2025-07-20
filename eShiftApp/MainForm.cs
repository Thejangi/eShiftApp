using Entities.Models;

namespace eShiftApp
{
    public partial class MainForm : Form
    {
        private readonly string _currentUser;
        private readonly bool _isAdmin;

        // Section controls
        private DashboardControl _dashboardControl;
        private CustomersControl _customersControl;
        private JobsControl _jobsControl;
        private JobLoadControl _jobLoadControl;
        private TransportUnitControl _transportUnitControl;
        private ReportsControl _reportsControl;
        private AdminsControl _adminsControl;

        //public MainForm() : this(string.Empty) { }

        public MainForm(string currentUser, bool isAdmin)
        {
            InitializeComponent();

            _isAdmin = isAdmin;
            _currentUser = currentUser;
            lblCurrentUser.Text = currentUser;

            // Instantiate all views
            _dashboardControl = new DashboardControl();
            _customersControl = new CustomersControl();
            _jobsControl = new JobsControl();
            _jobLoadControl = new JobLoadControl();
            _transportUnitControl = new TransportUnitControl();
            _reportsControl = new ReportsControl();
            _adminsControl = new AdminsControl();

            ApplyRolePermissions();         // hide/show nav

            // Subscribe DashboardControl “New…” events to our LoadView method
            _dashboardControl.NewCustomerRequested += () => LoadView(_customersControl, "Customers");
            _dashboardControl.NewJobRequested += () => LoadView(_jobsControl, "Jobs");
            _dashboardControl.NewLoadRequested += () => LoadView(_jobLoadControl, "Loads");
            _dashboardControl.NewUnitRequested += () => LoadView(_transportUnitControl, "Units");
            _dashboardControl.GenerateReportRequested += () => LoadView(_reportsControl, "Reports");

            ////— Subscribe a global DataChanged event so Dashboard and any active view refresh
            //AppEvents.DataChanged += () =>
            //{
            //    _dashboardControl.RefreshDashboard();   // you’ll need to make RefreshDashboard public/internal
            //    // optionally auto-refresh the active view:
            //    if (pnlContent.Controls.Count > 0)
            //    {
            //        var active = pnlContent.Controls[0] as IRefreshable;
            //        active?.RefreshData();
            //    }
            //};

            // show the dashboard by default
            LoadView(_dashboardControl, "Dashboard");
        }

        private void ApplyRolePermissions()
        {
            // Always visible
            btnDashboard.Visible = true;
            btnJobs.Visible = true;

            // Admin‐only
            btnCustomers.Visible = _isAdmin;   // manage customers
            btnUnits.Visible = _isAdmin;   // manage transport units
            btnLoads.Visible = _isAdmin;   // manage loads
            btnAdmins.Visible = _isAdmin;   // manage admin accounts
            btnReports.Visible = _isAdmin;   // view/export reports
        }

        /// <summary>
        /// Clears the content panel and loads the specified view.
        /// Also updates the header and window title.
        /// </summary>
        private void LoadView(UserControl view, string title)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(view);

            lblTitle.Text = title;
            this.Text = $"eShift — {title}";

            // if the view says it can refresh, do it now
            if (view is IRefreshable r)
                r.RefreshData();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadView(_jobLoadControl, "Loads");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadView(_dashboardControl, "Dashboard");
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            LoadView(_customersControl, "Customers");
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            LoadView(_jobsControl, "Jobs");
            _jobsControl.LoadJobs();      // ensure dropdown & grid are up-to-date
        }

        private void btnUnits_Click(object sender, EventArgs e)
        {
            LoadView(_transportUnitControl, "Units");
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            LoadView(_reportsControl, "Reports");
        }

        private void btnAdmins_Click(object sender, EventArgs e)
        {
            LoadView(_adminsControl, "Admins");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
