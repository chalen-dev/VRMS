using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VRMS.Enums;
using VRMS.Forms;
using VRMS.Models.Fleet;

// Repositories
using VRMS.Repositories.Fleet;
using VRMS.Repositories.Rentals;

// Services
using VRMS.Services.Customer;
using VRMS.Services.Fleet;
using VRMS.Services.Rental;

namespace VRMS.Controls
{
    public partial class VehiclesView : UserControl
    {
        // =========================
        // SERVICES
        // =========================
        private readonly VehicleService _vehicleService;
        private readonly DriversLicenseService _driversLicenseService;
        private readonly CustomerService _customerService;
        private readonly ReservationService _reservationService;
        private readonly RentalService _rentalService;

        // =========================
        // UI-ONLY REPO (TEMPORARY)
        // =========================
        private readonly VehicleImageRepository _vehicleImageRepo;

        // =========================
        // CONSTRUCTOR
        // =========================
        public VehiclesView()
        {
            InitializeComponent();

            // -------------------------
            // Repositories
            // -------------------------
            var vehicleRepo = new VehicleRepository();
            var categoryRepo = new VehicleCategoryRepository();
            var featureRepo = new VehicleFeatureRepository();
            var featureMapRepo = new VehicleFeatureMappingRepository();
            var imageRepo = new VehicleImageRepository();
            var maintenanceRepo = new MaintenanceRepository();

            var reservationRepo = new ReservationRepository();
            var rentalRepo = new RentalRepository();

            _vehicleImageRepo = imageRepo;

            // -------------------------
            // Services
            // -------------------------
            _vehicleService = new VehicleService(
                vehicleRepo,
                categoryRepo,
                featureRepo,
                featureMapRepo,
                imageRepo,
                maintenanceRepo
            );

            _driversLicenseService = new DriversLicenseService();
            _customerService = new CustomerService(_driversLicenseService);

            _reservationService = new ReservationService(
                _customerService,
                _vehicleService,
                reservationRepo
            );

            _rentalService = new RentalService(
                _reservationService,
                _vehicleService,
                rentalRepo,
                null
            );

            // -------------------------
            // Events
            // -------------------------
            Load += VehiclesView_Load;
            dgvVehicles.SelectionChanged += DgvVehicles_SelectionChanged;
        }

        // =========================
        // LOAD
        // =========================
        private void VehiclesView_Load(object? sender, EventArgs e)
        {
            ConfigureGrid();
            LoadVehicles();
        }

        private void ConfigureGrid()
        {
            dgvVehicles.AutoGenerateColumns = false;
            dgvVehicles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehicles.MultiSelect = false;
            dgvVehicles.ReadOnly = true;
            dgvVehicles.Columns.Clear();

            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Make",
                DataPropertyName = "Make"
            });

            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Model",
                DataPropertyName = "Model"
            });

            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Year",
                DataPropertyName = "Year"
            });

            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Plate No.",
                DataPropertyName = "LicensePlate"
            });

            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Transmission",
                DataPropertyName = "Transmission"
            });

            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Fuel",
                DataPropertyName = "FuelType"
            });

            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "Status"
            });

            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Odometer",
                DataPropertyName = "Odometer"
            });
        }

        private void LoadVehicles()
        {
            dgvVehicles.DataSource = null;
            dgvVehicles.DataSource = _vehicleService.GetAllVehicles();

            lblVehicleCount.Text =
                $"Total: {dgvVehicles.Rows.Count} vehicles";

            ClearVehiclePreview();
        }

        // =========================
        // SELECTION
        // =========================
        private void DgvVehicles_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvVehicles.SelectedRows.Count == 0)
            {
                ClearVehiclePreview();
                return;
            }

            if (dgvVehicles.SelectedRows[0].DataBoundItem is not Vehicle vehicle)
            {
                ClearVehiclePreview();
                return;
            }

            LoadVehiclePreview(vehicle);
        }

        // =========================
        // PREVIEW
        // =========================
        private void LoadVehiclePreview(Vehicle vehicle)
        {
            lblMakeModel.Text = $"{vehicle.Make} {vehicle.Model}";
            lblPlateValue.Text = vehicle.LicensePlate;
            lblMileageValue.Text = $"{vehicle.Odometer:N0} km";
            lblYearColorValue.Text = $"{vehicle.Year}/{vehicle.Color}";
            lblDailyRateValue.Text = vehicle.FuelEfficiency.ToString("N2");

            lblStatusValue.Text = vehicle.Status.ToString();
            lblStatusValue.ForeColor = vehicle.Status switch
            {
                VehicleStatus.Available => Color.FromArgb(46, 204, 113),
                VehicleStatus.Rented => Color.FromArgb(231, 76, 60),
                VehicleStatus.UnderMaintenance => Color.FromArgb(243, 156, 18),
                VehicleStatus.Reserved => Color.FromArgb(155, 89, 182),
                _ => Color.Gray
            };

            LoadVehicleImage(vehicle.Id);
        }

        private void LoadVehicleImage(int vehicleId)
        {
            try
            {
                var images = _vehicleImageRepo.GetByVehicle(vehicleId);

                if (images == null || images.Count == 0)
                {
                    picVehiclePreview.Image = null;
                    return;
                }

                // DB stores RELATIVE path: Vehicles/{id}/{file}
                var relativePath = images[0].ImagePath;

                var fullPath = Path.Combine(
                    AppContext.BaseDirectory,
                    "Storage",
                    relativePath
                );

                if (!File.Exists(fullPath))
                {
                    picVehiclePreview.Image = null;
                    return;
                }

                // Prevent file locking
                using var fs = new FileStream(
                    fullPath,
                    FileMode.Open,
                    FileAccess.Read
                );

                picVehiclePreview.Image = Image.FromStream(fs);
            }
            catch
            {
                picVehiclePreview.Image = null;
            }
        }

        private void ClearVehiclePreview()
        {
            picVehiclePreview.Image = null;

            lblMakeModel.Text = "—";
            lblPlateValue.Text = "—";
            lblMileageValue.Text = "—";
            lblYearColorValue.Text = "—";
            lblDailyRateValue.Text = "—";
            lblStatusValue.Text = "—";
        }

        // =========================
        // ADD
        // =========================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var addForm = new AddVehicleForm(_vehicleService)
            {
                StartPosition = FormStartPosition.CenterParent
            };

            if (addForm.ShowDialog(this) == DialogResult.OK)
                LoadVehicles();
        }

        // =========================
        // EDIT
        // =========================
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvVehicles.SelectedRows.Count == 0)
                return;

            if (dgvVehicles.SelectedRows[0].DataBoundItem is not Vehicle vehicle)
                return;

            using var editForm =
                new EditVehicleForm(vehicle.Id, _vehicleService)
                {
                    StartPosition = FormStartPosition.CenterParent
                };

            if (editForm.ShowDialog(this) == DialogResult.OK)
                LoadVehicles();
        }
    }
}
