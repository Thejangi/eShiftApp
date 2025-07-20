using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eShiftApp
{
    public partial class ForgotPasswordForm : Form
    {
        // Service for lookup and updating customer records
        private readonly ICustomerService _customerService = new CustomerService();
        public ForgotPasswordForm()
        {
            InitializeComponent();

            // Wire up button click handlers
            btnFP_Reset.Click += BtnFP_Reset_Click;
            btnFP_Cancel.Click += BtnFP_Cancel_Click;
        }

        // Clears all validation labels before each reset attempt
        private void ClearErrorLabels()
        {
            lblFP_EmailError.Text = "";
            lblFP_NewPwdError.Text = "";
            lblFP_ConfirmError.Text = "";
        }

        /// <summary>
        /// Handles the Reset button:
        ///    - Validates email, new password, confirmation
        ///    - Finds the customer by email
        ///    - Calls Update(...) to re-hash & save new password
        ///    - Fires AppEvents.OnDataChanged() and closes on success
        /// </summary>
        private void BtnFP_Reset_Click(object? sender, EventArgs e)
        {
            ClearErrorLabels();
            bool isValid = true;

            // Email presence
            var email = txtFP_Email.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                lblFP_EmailError.Text = "Email is required.";
                isValid = false;
            }

            // New password length
            var newPwd = txtFP_NewPwd.Text;
            if (string.IsNullOrEmpty(newPwd) || newPwd.Length < 6)
            {
                lblFP_NewPwdError.Text = "Password must be ≥ 6 chars.";
                isValid = false;
            }

            // Confirmation matches
            var confirm = txtFP_Confirm.Text;
            if (newPwd != confirm)
            {
                lblFP_ConfirmError.Text = "Passwords do not match.";
                isValid = false;
            }

            if (!isValid)
                return;

            // Lookup customer by email
            var customer = _customerService
                .GetAll()
                .FirstOrDefault(c =>
                    c.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

            if (customer == null)
            {
                lblFP_EmailError.Text = "No account found with that email.";
                return;
            }

            try
            {
                // Invoke Update to re-hash & persist the new password
                _customerService.Update(customer, newPwd);

                // Notify other views that data changed
                AppEvents.OnDataChanged();

                MessageBox.Show(
                    "Password reset successful!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.Close();
            }
            catch (Exception ex)
            {
                // Handle any errors (e.g. DB issues)
                MessageBox.Show(
                    $"Unable to reset password:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        /// <summary>
        /// Handles Cancel: simply closes the dialog without changes.
        /// </summary>
        private void BtnFP_Cancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
