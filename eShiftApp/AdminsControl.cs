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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eShiftApp
{
    public partial class AdminsControl : UserControl
    {
        private readonly IAdminService _service = new AdminService();
        private int _selectedAdminId = -1;  // -1 => creating new

        public AdminsControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            // Subscribe to global data‐changed events
            AppEvents.DataChanged += RefreshData;
            // Refresh on first load
            this.Load += (s, e) => RefreshData();

            // Wire UI events
            dgvAdmins.SelectionChanged += DgvAdmins_SelectionChanged;
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnRefresh.Click += BtnRefresh_Click;
        }

        /// <summary>
        /// IRefreshable implementation; reloads the admin list.
        /// </summary>
        public void RefreshData() => LoadAdmins();

        private void LoadAdmins()
        {
            var list = _service.GetAll().ToList();
            dgvAdmins.DataSource = list;

            // Hide the raw password hash column
            if (dgvAdmins.Columns["PasswordHash"] != null)
                dgvAdmins.Columns["PasswordHash"].Visible = false;

            // If there's at least one admin, allow editing
            grpAdminDetails.Enabled = list.Any();
            ClearDetailFields();
        }

        private void DgvAdmins_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAdmins.SelectedRows.Count == 0)
            {
                grpAdminDetails.Enabled = false;
                ClearDetailFields();
                return;
            }

            // Cast the bound Admin object
            grpAdminDetails.Enabled = true;
            var admin = (Admin)dgvAdmins.SelectedRows[0].DataBoundItem;
            _selectedAdminId = admin.AdminId;

            // Populate fields (password textbox always blank)
            txtName.Text = admin.Username;
            txtEmail.Text = admin.Email;
            txtPassword.Text = string.Empty;
        }

        private void ClearDetailFields()
        {
            _selectedAdminId = -1;
            txtName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            dgvAdmins.ClearSelection();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Username and Email are required.",
                                "Validation",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (_selectedAdminId == -1)
            {
                // CREATE new admin
                var newAdmin = new Admin
                {
                    Username = txtName.Text.Trim(),
                    Email = txtEmail.Text.Trim()
                };
                _service.Register(newAdmin, txtPassword.Text);
            }
            else
            {
                // UPDATE existing
                var existing = _service.GetById(_selectedAdminId);
                existing.Username = txtName.Text.Trim();
                existing.Email = txtEmail.Text.Trim();

                // Only re-hash if a new password was entered
                if (!string.IsNullOrEmpty(txtPassword.Text))
                    _service.Update(existing, txtPassword.Text);
                else
                    _service.Update(existing);
            }

            // Notify everyone and refresh
            AppEvents.OnDataChanged();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedAdminId == -1) return;
            var dr = MessageBox.Show(
                "Are you sure you want to delete this admin?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (dr != DialogResult.Yes) return;

            _service.Delete(_selectedAdminId);
            AppEvents.OnDataChanged();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadAdmins();
        }
    }
}
