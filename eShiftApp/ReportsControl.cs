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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace eShiftApp
{
    /// <summary>
    /// UserControl for generating various data reports and exporting to PDF.
    /// </summary>
    public partial class ReportsControl : UserControl
    {
        // Services to fetch data
        private readonly ICustomerService _custSvc = new CustomerService();
        private readonly IJobService _jobSvc = new JobService();
        private readonly IJobLoadService _loadSvc = new JobLoadService();
        private readonly ITransportUnitService _unitSvc = new TransportUnitService();

        public ReportsControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            // Populate the report‐type dropdown
            cmbReportType.Items.AddRange(new[]
            {
                "All Customers",
                "All Jobs",
                "All Loads",
                "All Units"
            });
            cmbReportType.SelectedIndex = 0;

            // Wire button handlers
            btnGenerate.Click += BtnGenerate_Click;
            btnExportPdf.Click += BtnExportPdf_Click;

            // Auto‐load & auto‐refresh
            this.Load += (s, e) => LoadReportData();
            AppEvents.DataChanged += LoadReportData;
        }

        /// <summary>
        /// Populates dgvReport based on the current cmbReportType selection.
        /// </summary>
        private void LoadReportData()
        {
            dgvReport.DataSource = null;

            switch (cmbReportType.SelectedItem as string)
            {
                case "All Customers":
                    var custs = _custSvc.GetAll()
                                .Select(c => new { c.CustomerId, c.Name, c.Email })
                                .ToList();
                    dgvReport.DataSource = custs;
                    break;

                case "All Jobs":
                    var jobs = _jobSvc.GetAll()
                                .Select(j => new {
                                    j.JobId,
                                    Customer = _custSvc.GetById(j.CustomerId)?.Name,
                                    j.Status,
                                    Created = j.CreatedDate.ToString("g")
                                })
                                .ToList();
                    dgvReport.DataSource = jobs;
                    break;

                case "All Loads":
                    var loads = _loadSvc.GetAll()
                                .Select(l => new {
                                    l.JobLoadId,
                                    l.JobId,
                                    UnitPlate = _unitSvc.GetById(l.UnitId)?.LorryPlate,
                                    l.Weight,
                                    l.Volume,
                                    l.PickupLocation,
                                    l.DropoffLocation
                                })
                                .ToList();
                    dgvReport.DataSource = loads;
                    break;

                case "All Units":
                    var units = _unitSvc.GetAll()
                                .Select(u => new {
                                    u.UnitId,
                                    u.LorryPlate,
                                    u.DriverName,
                                    u.AssistantName,
                                    u.ContainerId
                                })
                                .ToList();
                    dgvReport.DataSource = units;
                    break;

                default:
                    MessageBox.Show("Unknown report type.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            dgvReport.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        /// <summary>
        /// Runs when the user clicks “Generate”: fetches the selected dataset
        /// and binds it to the DataGridView.
        /// </summary>
        private void BtnGenerate_Click(object? sender, EventArgs e)
        {
            // Clear any prior data
            dgvReport.DataSource = null;

            switch (cmbReportType.SelectedItem as string)
            {
                case "All Customers":
                    // Fetch domain objects and project to anonymous types
                    var custs = _custSvc.GetAll()
                        .Select(c => new {
                            c.CustomerId,
                            c.Name,
                            c.Email
                        })
                        .ToList();
                    dgvReport.DataSource = custs;
                    break;

                case "All Jobs":
                    var jobs = _jobSvc.GetAll()
                        .Select(j => new {
                            j.JobId,
                            Customer = _custSvc.GetById(j.CustomerId)?.Name,
                            j.Status,
                            Created = j.CreatedDate.ToString("g")
                        })
                        .ToList();
                    dgvReport.DataSource = jobs;
                    break;

                case "All Loads":
                    var loads = _loadSvc.GetAll()
                        .Select(l => new {
                            l.JobLoadId,
                            l.JobId,
                            UnitPlate = _unitSvc.GetById(l.UnitId)?.LorryPlate,
                            Weight = l.Weight,
                            Volume = l.Volume,
                            l.PickupLocation,
                            l.DropoffLocation
                        })
                        .ToList();
                    dgvReport.DataSource = loads;
                    break;

                case "All Units":
                    var units = _unitSvc.GetAll()
                        .Select(u => new {
                            u.UnitId,
                            u.LorryPlate,
                            u.DriverName,
                            u.AssistantName,
                            u.ContainerId
                        })
                        .ToList();
                    dgvReport.DataSource = units;
                    break;

                default:
                    MessageBox.Show("Unknown report type.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // Auto‐resize columns and show grid
            dgvReport.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        /// <summary>
        /// Exports whatever is currently in dgvReport to a simple PDF table.
        /// </summary>
        private void BtnExportPdf_Click(object? sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Export",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var sfd = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                FileName = $"{cmbReportType.SelectedItem}.pdf"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                // Create the PDF document and writer
                using var doc = new Document(PageSize.A4.Rotate(), 10, 10, 20, 20);
                using var fs = new FileStream(sfd.FileName, FileMode.Create);
                PdfWriter.GetInstance(doc, fs);
                doc.Open();

                // Add a title
                var title = new Paragraph(
                    $"{cmbReportType.SelectedItem} — {DateTime.Now:g}",
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)
                );
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);
                doc.Add(new Paragraph(" "));  // blank line

                // Build a PDF table with same number of columns
                var colCount = dgvReport.Columns.Count;
                var table = new PdfPTable(colCount) { WidthPercentage = 100 };

                // Add headers
                foreach (DataGridViewColumn col in dgvReport.Columns)
                {
                    var cell = new PdfPCell(new Phrase(col.HeaderText))
                    {
                        BackgroundColor = BaseColor.LIGHT_GRAY
                    };
                    table.AddCell(cell);
                }

                // Add each row’s cells
                foreach (DataGridViewRow row in dgvReport.Rows)
                {
                    if (row.IsNewRow) continue;
                    foreach (DataGridViewCell gridCell in row.Cells)
                    {
                        var text = gridCell.Value?.ToString() ?? "";
                        table.AddCell(new Phrase(text));
                    }
                }

                // Add table to document and close
                doc.Add(table);
                doc.Close();

                MessageBox.Show("PDF exported successfully!", "Export",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Export failed:\n{ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Allow MainForm to refresh this view when shown
        public void RefreshData() => LoadReportData();
    }
}