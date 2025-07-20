using BusinessLogic.Interfaces;    // ICustomerService, IAdminService
using BusinessLogic.Services;      // CustomerService, AdminService
using Entities.Models;             // Customer, Admin
using System.Windows.Forms;
using System;
using System.Windows.Forms;
// allows access to DbConnectionFactory
using DataAccess;

namespace eShiftApp
{
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Exposed after successful login so Program.Main can pick it up.
        /// </summary>
        public string LoggedInUser { get; private set; }
        public bool IsAdmin { get; private set; }
        private readonly ICustomerService _customerService;
        private readonly IAdminService _adminService;
        public LoginForm()
        {
            InitializeComponent();

            // instantiate services
            _customerService = new CustomerService();
            _adminService = new AdminService();

            // default to Customer login
            rdoCustomer.Checked = true;

            // set the AcceptButton so Enter triggers login
            this.AcceptButton = btnLogin;
            lnkRegister.Click += LnkRegister_Click;
            lnkForgotPassword.Click += LnkForgotPassword_Click;
        }

        private void LnkForgotPassword_Click(object? sender, EventArgs e)
        {
            // Open the forgot-password workflow
            using var fpw = new ForgotPasswordForm();
            fpw.ShowDialog();

            // After returning, let them re-enter credentials
            txtPassword.Clear();
            txtPassword.Focus();
        }

        // Make sure in the Designer btnLogin.Click is set to this handler
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (rdoCustomer.Checked)
            {
                Customer cust = _customerService.Login(email, password);
                if (cust != null)
                {
                    // TODO: open CustomerDashboardForm, passing cust.CustomerId
                    MessageBox.Show($"Welcome, {cust.Name}!");
                    LoggedInUser = cust.Name;
                    IsAdmin = false;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show(
                        "Invalid customer credentials",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            else // Admin
            {
                Admin adm = _adminService.Login(email, password);
                if (adm != null)
                {
                    // TODO: open AdminDashboardForm
                    MessageBox.Show($"Welcome, {adm.Username}!");
                    LoggedInUser = adm.Username;
                    IsAdmin = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show(
                        "Invalid admin credentials",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }

        private void LnkRegister_Click(object? sender, EventArgs e)
        {
            // Open the public registration form (customers only)
            using var regForm = new RegistrationForm();
            regForm.ShowDialog();

            // After they close RegistrationForm, clear login fields
            txtEmail.Clear();
            txtPassword.Clear();
            txtEmail.Focus();
        }

        // this method runs when the form first appears
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // create and open a MySQL connection
                using var conn = DbConnectionFactory.Create();
                conn.Open();

                // run a simple query to verify connectivity
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT 1";
                var result = cmd.ExecuteScalar();

                // show success message
                MessageBox.Show(
                    $"Connection OK ({result})",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex){
                // show any error that occurred
                MessageBox.Show(
                    $"Connection failed:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
