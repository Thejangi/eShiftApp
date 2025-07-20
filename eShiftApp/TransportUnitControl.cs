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
    public partial class TransportUnitControl : UserControl
    {
        // Service for persisting TransportUnit records
        private readonly ITransportUnitService _unitService = new TransportUnitService();
        // Tracks the currently selected UnitId (-1 means “new”)
        private int _selectedUnitId = -1;

        public TransportUnitControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            AppEvents.DataChanged += RefreshData;
            this.Load += (s, e) => RefreshData();

            // When the control loads, populate grid and setup dropdowns (if any)
            this.Load += TransportUnitControl_Load;
            // When the user picks a row in the grid
            dgvUnits.SelectionChanged += DgvUnits_SelectionChanged;
            // CRUD buttons
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnRefresh.Click += BtnRefresh_Click;
        }

        public void RefreshData() => LoadUnits();

        /// <summary>
        /// Runs when the control first appears:
        /// Loads all TransportUnit records into the grid.
        /// </summary>
        private void TransportUnitControl_Load(object? sender, EventArgs e)
        {
            LoadUnits();
        }

        /// <summary>
        /// Fetches all units from the service, binds to dgvUnits,
        /// and clears the detail form.
        /// </summary>
        private void LoadUnits()
        {
            // Get all units and bind
            var list = _unitService.GetAll().ToList();
            dgvUnits.DataSource = list;

            // Clear detail fields after binding
            ClearUnitFields();
        }

        /// <summary>
        /// Resets the detail form to “new record” state.
        /// </summary>
        private void ClearUnitFields()
        {
            _selectedUnitId = -1;
            // Assuming you have a txtUnitId TextBox to show/edit the UnitId
            txtLorryPlate.Clear();
            txtDriverName.Clear();
            txtAssistant.Clear();
            txtContainerId.Clear();
            dgvUnits.ClearSelection();
        }

        /// <summary>
        /// When a row is selected in dgvUnits, populate the detail fields.
        /// </summary>
        private void DgvUnits_SelectionChanged(object? sender, EventArgs e)
        {
            // If no row is selected, reset the form
            if (dgvUnits.SelectedRows.Count == 0)
            {
                ClearUnitFields();
                return;
            }

            // Cast the bound item back to TransportUnit
            var unit = (TransportUnit)dgvUnits.SelectedRows[0].DataBoundItem!;
            _selectedUnitId = unit.UnitId;

            // Fill the form controls
            txtLorryPlate.Text = unit.LorryPlate;
            txtDriverName.Text = unit.DriverName;
            txtAssistant.Text = unit.AssistantName;
            txtContainerId.Text = unit.ContainerId;
        }

        /// <summary>
        /// Creates a new TransportUnit when none is selected—or updates the existing one.
        /// </summary>
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(txtLorryPlate.Text) ||
                string.IsNullOrWhiteSpace(txtDriverName.Text) ||
                string.IsNullOrWhiteSpace(txtContainerId.Text))
            {
                MessageBox.Show(
                    "Lorry Plate, Driver Name, and Container ID are required.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Gather values from the form
            var plate = txtLorryPlate.Text.Trim();
            var driver = txtDriverName.Text.Trim();
            var assistant = txtAssistant.Text.Trim();
            var container = txtContainerId.Text.Trim();

            if (_selectedUnitId == -1)
            {
                // CREATE new TransportUnit
                var newUnit = new TransportUnit
                {
                    LorryPlate = plate,
                    DriverName = driver,
                    AssistantName = assistant,
                    ContainerId = container
                };
                _unitService.Create(newUnit);
            }
            else
            {
                // UPDATE existing TransportUnit
                var existing = _unitService.GetById(_selectedUnitId);
                existing.LorryPlate = plate;
                existing.DriverName = driver;
                existing.AssistantName = assistant;
                existing.ContainerId = container;
                _unitService.Update(existing);
            }

            // Refresh grid & clear form
            LoadUnits();

            AppEvents.OnDataChanged();
        }

        /// <summary>
        /// Deletes the selected TransportUnit after user confirmation.
        /// </summary>
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            // Nothing to delete if no unit selected
            if (_selectedUnitId == -1)
                return;

            var result = MessageBox.Show(
                "Are you sure you want to delete this transport unit?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Remove from database
                _unitService.Delete(_selectedUnitId);
                // Refresh grid and clear the form
                LoadUnits();
            }

            AppEvents.OnDataChanged();
        }

        /// <summary>
        /// Reloads all TransportUnit records from the database.
        /// </summary>
        private void BtnRefresh_Click(object? sender, EventArgs e)
        {
            LoadUnits();
        }

    }
}
