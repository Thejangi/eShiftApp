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
    public partial class CustomersControl : UserControl
    {
        // Service instance
        private readonly ICustomerService _customerService = new CustomerService();
        // Tracks the currently selected CustomerId (-1 = “new”)
        private int _selectedCustomerId = -1;
        public CustomersControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            // whenever any data changes anywhere, refresh the dashboard
            AppEvents.DataChanged += RefreshData;

            // on first load
            this.Load += (s, e) => RefreshData();

            // Wire event handlers
            //this.Load += CustomersControl_Load;
            dgvCustomers.SelectionChanged += DgvCustomers_SelectionChanged;
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnRefresh.Click += BtnRefresh_Click;
        }

        public void RefreshData() => LoadCustomers();

        private void CustomersControl_Load(object? sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            // Fetch all customers and bind to grid
            var list = _customerService.GetAll().ToList();
            dgvCustomers.DataSource = list;

            // Hide the raw PasswordHash column if it's auto-generated
            if (dgvCustomers.Columns["PasswordHash"] != null)
                dgvCustomers.Columns["PasswordHash"].Visible = false;

            ClearDetailFields();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DgvCustomers_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                ClearDetailFields();
                return;
            }

            // Pull the bound Customer instance
            var cust = (Customer)dgvCustomers.SelectedRows[0].DataBoundItem;
            _selectedCustomerId = cust.CustomerId;

            // Fill fields (don't show the hash!)
            txtName.Text = cust.Name;
            txtEmail.Text = cust.Email;
            txtPassword.Text = string.Empty;   // Always blank
        }

        private void ClearDetailFields()
        {
            _selectedCustomerId = -1;
            txtName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            dgvCustomers.ClearSelection();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Name and Email are required.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_selectedCustomerId == -1)
            {
                // Create new
                var newCust = new Customer
                {
                    Name = txtName.Text.Trim(),
                    Email = txtEmail.Text.Trim()
                };
                _customerService.Register(newCust, txtPassword.Text);
            }
            else
            {
                // Update existing
                var existing = _customerService.GetById(_selectedCustomerId);
                existing.Name = txtName.Text.Trim();
                existing.Email = txtEmail.Text.Trim();

                // Only re-hash if password was entered
                if (!string.IsNullOrEmpty(txtPassword.Text))
                    _customerService.Update(existing, txtPassword.Text);
                else
                    _customerService.Update(existing);
            }

            AppEvents.OnDataChanged();

            // Refresh grid & clear fields
            LoadCustomers();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (_selectedCustomerId == -1)
                return;  // nothing selected

            var dr = MessageBox.Show(
                "Are you sure you want to delete this customer?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (dr != DialogResult.Yes) return;

            _customerService.Delete(_selectedCustomerId);
            LoadCustomers();

            AppEvents.OnDataChanged();
        }

        private void BtnRefresh_Click(object? sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
