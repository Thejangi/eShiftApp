using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using Entities.Models;
using eShiftApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eShiftApp
{
    public partial class RegistrationForm : Form
    {
        // Service for registering new customers
        private readonly ICustomerService _customerService = new CustomerService();
        public RegistrationForm()
        {
            InitializeComponent();

            // Wire up button clicks
            btnRegister.Click += BtnRegister_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        /// <summary>
        /// Runs when the user clicks “Register”:
        /// 1) Clears prior error messages
        /// 2) Validates each input field
        /// 3) If valid, hashes password & calls CustomerService.Register(...)
        /// 4) Fires AppEvents.OnDataChanged() and closes the form
        /// </summary>
        /// 

        private void BtnRegister_Click(object? sender, EventArgs e)
        {
            // Clear previous errors
            ClearErrorLabels();

            bool isValid = true;

            // Full Name required
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                lblNameError.Text = "Full name is required.";
                isValid = false;
            }

            // Email required & format check
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                lblEmailError.Text = "Email is required.";
                isValid = false;
            }
            else if (!Regex.IsMatch(txtEmail.Text.Trim(),
                     @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lblEmailError.Text = "Enter a valid email address.";
                isValid = false;
            }

            // Username (optional: if your Customer model uses it)
            // if (string.IsNullOrWhiteSpace(txtUsername.Text))
            // {
            //     lblUserError.Text = "Username is required.";
            //     isValid = false;
            // }

            // Password length & presence
            if (string.IsNullOrEmpty(txtPassword.Text) ||
                txtPassword.Text.Length < 6)
            {
                lblPwdError.Text = "Password must be ≥ 6 characters.";
                isValid = false;
            }

            // Confirm matches
            if (txtPassword.Text != txtConfirm.Text)
            {
                lblConfirmError.Text = "Passwords do not match.";
                isValid = false;
            }

            if (!isValid)
                return;  // stop if any validation failed

            // Construct the new Customer entity
            var newCustomer = new Customer
            {
                Name = txtName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
            };

            try
            {
                // Register (hashes password internally)
                _customerService.Register(newCustomer, txtPassword.Text);

                // Notify other views (dashboard, lists) of new data
                AppEvents.OnDataChanged();

                MessageBox.Show(
                    "Registration successful! You can now log in.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.Close();  // close registration form
            }
            catch (Exception ex)
            {
                // If something goes wrong (e.g. duplicate email), show error
                MessageBox.Show(
                    $"Registration failed:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        /// <summary>
        /// Runs when the user clicks “Cancel”: simply closes the form.
        /// </summary>
        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Clears all the little validation labels under each input.
        /// </summary>
        private void ClearErrorLabels()
        {
            lblNameError.Text = "";
            lblEmailError.Text = "";
            lblUserError.Text = "";
            lblPwdError.Text = "";
            lblConfirmError.Text = "";
        }
    }
}
