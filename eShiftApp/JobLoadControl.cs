using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using Entities.Models;
using Mysqlx.Crud;
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
    public partial class JobLoadControl : UserControl
    {
        // Services for lookups and persistence
        private readonly IJobLoadService _loadSvc = new JobLoadService();
        private readonly IJobService _jobSvc = new JobService();
        private readonly ITransportUnitService _unitSvc = new TransportUnitService();

        // Tracks the currently selected Load ID (-1 = new)
        private int _selectedLoadId = -1;

        public JobLoadControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            AppEvents.DataChanged += RefreshData;
            this.Load += (s, e) => RefreshData();

            // Wire event handlers
            this.Load += JobLoadControl_Load;
            dgvJobLoads.SelectionChanged += dgvJobLoads_SelectionChanged;
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnRefresh.Click += BtnRefresh_Click;
        }

        public void RefreshData() => LoadLoads();

        /// <summary>
        /// Runs when the control appears:
        /// 1) Populates Job and Unit dropdowns
        /// 2) Loads the grid with all JobLoad records
        /// </summary>
        private void JobLoadControl_Load(object? sender, EventArgs e)
        {
            // 1) Populate Job dropdown
            var jobs = _jobSvc.GetAll().ToList();
            cboJobLoad.DataSource = jobs;
            cboJobLoad.DisplayMember = nameof(Job.JobId);    // or use a combined string if you want
            cboJobLoad.ValueMember = nameof(Job.JobId);

            // 2) Populate Unit dropdown
            var units = _unitSvc.GetAll().ToList();
            cboUnitLoad.DataSource = units;
            cboUnitLoad.DisplayMember = nameof(TransportUnit.LorryPlate);
            cboUnitLoad.ValueMember = nameof(TransportUnit.UnitId);

            // 3) Load grid
            LoadLoads();
        }

        /// <summary>
        /// Fetches all JobLoad records, binds them to the grid,
        /// then clears the detail form.
        /// </summary>
        private void LoadLoads()
        {
            // Re-populate dropdowns so they stay in sync
            cboJobLoad.DataSource = _jobSvc.GetAll().ToList();
            cboJobLoad.DisplayMember = nameof(Job.JobId);
            cboJobLoad.ValueMember = nameof(Job.JobId);

            cboUnitLoad.DataSource = _unitSvc.GetAll().ToList();
            cboUnitLoad.DisplayMember = nameof(TransportUnit.LorryPlate);
            cboUnitLoad.ValueMember = nameof(TransportUnit.UnitId);

            // Project each JobLoad into a LoadView DTO that includes UnitPlate
            var views = _loadSvc.GetAll()
                .Select(l => new LoadView
                {
                    JobLoadId = l.JobLoadId,
                    JobId = l.JobId,
                    UnitId = l.UnitId,
                    UnitPlate = _unitSvc.GetById(l.UnitId).LorryPlate,
                    Weight = l.Weight,
                    Volume = l.Volume,
                    PickupLocation = l.PickupLocation,
                    DropoffLocation = l.DropoffLocation
                })
                .ToList();

            // Bind to grid
            dgvJobLoads.DataSource = views;

            // Tidy up column headers / hide raw IDs
            dgvJobLoads.Columns[nameof(LoadView.JobLoadId)].HeaderText = "Load ID";
            dgvJobLoads.Columns[nameof(LoadView.JobId)].HeaderText = "Job ID";
            dgvJobLoads.Columns[nameof(LoadView.UnitPlate)].HeaderText = "Unit Plate";
            dgvJobLoads.Columns[nameof(LoadView.Weight)].HeaderText = "Weight";
            dgvJobLoads.Columns[nameof(LoadView.Volume)].HeaderText = "Volume";
            dgvJobLoads.Columns[nameof(LoadView.PickupLocation)].HeaderText = "Pickup Location";
            dgvJobLoads.Columns[nameof(LoadView.DropoffLocation)].HeaderText = "Dropoff Location";

            // 5) Clear the detail form for a fresh state
            ClearLoadFields();
        }

        /// <summary>
        /// When a row is picked, populate the detail fields.
        /// </summary>
        private void dgvJobLoads_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvJobLoads.SelectedRows.Count == 0)
            {
                ClearLoadFields();
                return;
            }

            // Cast to our DTO, LoadView
            var view = (LoadView)dgvJobLoads.SelectedRows[0].DataBoundItem!;
            _selectedLoadId = view.JobLoadId;

            // Populate detail fields from the LoadView
            cboJobLoad.SelectedValue = view.JobId;
            // Find the unit by its plate string
            cboUnitLoad.SelectedIndex = cboUnitLoad
                .FindStringExact(view.UnitPlate);
            txtWeight.Text = view.Weight.ToString("F2");
            txtVolume.Text = view.Volume.ToString("F2");
            txtPickupLocation.Text = view.PickupLocation;
            txtDropoffLocation.Text = view.DropoffLocation;
        }

        /// <summary>
        /// Resets all inputs to blank/new state.
        /// </summary>
        private void ClearLoadFields()
        {
            _selectedLoadId = -1;
            cboJobLoad.SelectedIndex =-1;
            cboJobLoad.SelectedIndex = -1;
            cboUnitLoad.SelectedIndex = -1;
            txtWeight.Clear();
            txtVolume.Clear();
            txtPickupLocation.Clear();
            txtDropoffLocation.Clear();
            dgvJobLoads.ClearSelection();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            // Basic validation
            if (cboJobLoad.SelectedValue == null || cboUnitLoad.SelectedValue == null ||
                !decimal.TryParse(txtWeight.Text, out var weight) ||
                !decimal.TryParse(txtVolume.Text, out var volume))
            {
                MessageBox.Show("Job, Unit, Weight and Volume are required.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_selectedLoadId == -1)
            {
                // CREATE new JobLoad
                var newLoad = new JobLoad
                {
                    JobId = Convert.ToInt32(cboJobLoad.SelectedValue),
                    UnitId = Convert.ToInt32(cboUnitLoad.SelectedValue),
                    Weight = weight,
                    Volume = volume,
                    PickupLocation = txtPickupLocation.Text.Trim(),
                    DropoffLocation = txtDropoffLocation.Text.Trim()
                };
                _loadSvc.Create(newLoad);
            }
            else
            {
                // UPDATE existing
                var existing = _loadSvc.GetById(_selectedLoadId);
                existing.JobId = Convert.ToInt32(cboJobLoad.SelectedValue);
                existing.UnitId = Convert.ToInt32(cboUnitLoad.SelectedValue);
                existing.Weight = weight;
                existing.Volume = volume;
                existing.PickupLocation = txtPickupLocation.Text.Trim();
                existing.DropoffLocation = txtDropoffLocation.Text.Trim();
                _loadSvc.Update(existing);
            }

            LoadLoads();

            AppEvents.OnDataChanged();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (_selectedLoadId == -1) return;

            var dr = MessageBox.Show(
                "Delete this load record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (dr == DialogResult.Yes)
            {
                _loadSvc.Delete(_selectedLoadId);
                LoadLoads();
            }

            AppEvents.OnDataChanged();
        }

        private void BtnRefresh_Click(object? sender, EventArgs e)
        {
            LoadLoads();
        }

    }
}
