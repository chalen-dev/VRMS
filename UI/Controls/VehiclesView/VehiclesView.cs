using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VRMS.Enums;
using VRMS.Forms;
using VRMS.Models.Fleet;
using VRMS.Repositories.Billing;

// Repositories
using VRMS.Repositories.Fleet;
using VRMS.Repositories.Rentals;

// Services
using VRMS.Services.Customer;
using VRMS.Services.Fleet;
using VRMS.Services.Rental;

// FOR AddCategoryForm
using VRMS.UI.Forms;

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
        // UI-ONLY REPO
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
            var rateConfigRepo = new RateConfigurationRepository();

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
                maintenanceRepo,
                rateConfigRepo
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

            flowLayoutPanelFeatures.AutoSize = true;
            flowLayoutPanelFeatures.WrapContents = true;
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

            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Make", DataPropertyName = "Make" });
            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Model", DataPropertyName = "Model" });
            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Year", DataPropertyName = "Year" });
            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Plate No.", DataPropertyName = "LicensePlate" });
            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Transmission", DataPropertyName = "Transmission" });
            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Fuel", DataPropertyName = "FuelType" });
            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", DataPropertyName = "Status" });
            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Odometer", DataPropertyName = "Odometer" });
        }

        private void LoadVehicles()
        {
            dgvVehicles.DataSource = null;
            dgvVehicles.DataSource = _vehicleService.GetAllVehicles();
            lblVehicleCount.Text = $"Total: {dgvVehicles.Rows.Count} vehicles";
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

            try
            {
                var category = _vehicleService.GetCategoryById(vehicle.VehicleCategoryId);
                lblCategoryValue.Text = category.Name;
            }
            catch
            {
                lblCategoryValue.Text = "Unknown";
            }

            lblStatusValue.Text = vehicle.Status.ToString();
            lblStatusValue.ForeColor = GetStatusColor(vehicle.Status);

            LoadVehicleImage(vehicle.Id);
            LoadVehicleFeatures(vehicle.Id);
        }

        private Color GetStatusColor(VehicleStatus status) => status switch
        {
            VehicleStatus.Available => Color.FromArgb(46, 204, 113),
            VehicleStatus.Rented => Color.FromArgb(231, 76, 60),
            VehicleStatus.UnderMaintenance => Color.FromArgb(243, 156, 18),
            VehicleStatus.Reserved => Color.FromArgb(155, 89, 182),
            VehicleStatus.OutOfService => Color.FromArgb(149, 165, 166),
            VehicleStatus.Retired => Color.FromArgb(52, 73, 94),
            _ => Color.Gray
        };

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

                var fullPath = Path.Combine(
                    AppContext.BaseDirectory,
                    "Storage",
                    images[0].ImagePath
                );

                if (!File.Exists(fullPath))
                {
                    picVehiclePreview.Image = null;
                    return;
                }

                using var fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
                picVehiclePreview.Image = Image.FromStream(fs);
            }
            catch
            {
                picVehiclePreview.Image = null;
            }
        }

        private void LoadVehicleFeatures(int vehicleId)
        {
            flowLayoutPanelFeatures.Controls.Clear();

            try
            {
                var features = _vehicleService.GetVehicleFeatures(vehicleId);
                if (features == null || features.Count == 0)
                {
                    flowLayoutPanelFeatures.Controls.Add(new Label
                    {
                        Text = "No features available",
                        ForeColor = Color.Gray,
                        Font = new Font("Segoe UI", 8F, FontStyle.Italic),
                        AutoSize = true
                    });
                    return;
                }

                foreach (var feature in features)
                {
                    flowLayoutPanelFeatures.Controls.Add(CreateFeatureBadge(feature.Name));
                }

                lblFeaturesTitle.Text = $"Features ({features.Count})";
            }
            catch (Exception ex)
            {
                flowLayoutPanelFeatures.Controls.Add(new Label
                {
                    Text = ex.Message,
                    ForeColor = Color.Red,
                    AutoSize = true
                });
            }
        }

        private Control CreateFeatureBadge(string name)
        {
            var panel = new Panel
            {
                AutoSize = true,
                BackColor = Color.FromArgb(236, 240, 241),
                Padding = new Padding(6, 3, 6, 3),
                Margin = new Padding(2)
            };

            panel.Controls.Add(new Label
            {
                Text = $"✓ {name}",
                AutoSize = true,
                Font = new Font("Segoe UI", 8F)
            });

            return panel;
        }

        private void ClearVehiclePreview()
        {
            picVehiclePreview.Image = null;
            lblMakeModel.Text = lblPlateValue.Text = lblMileageValue.Text =
            lblYearColorValue.Text = lblDailyRateValue.Text =
            lblStatusValue.Text = lblCategoryValue.Text = "—";

            flowLayoutPanelFeatures.Controls.Clear();
            lblFeaturesTitle.Text = "Features";
        }

        // =========================
        // ADD VEHICLE
        // =========================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var form = new AddVehicleForm(_vehicleService)
            {
                StartPosition = FormStartPosition.CenterParent
            };

            if (form.ShowDialog(this) == DialogResult.OK)
                LoadVehicles();
        }

        // =========================
        // EDIT VEHICLE
        // =========================
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvVehicles.SelectedRows.Count == 0) return;
            if (dgvVehicles.SelectedRows[0].DataBoundItem is not Vehicle vehicle) return;

            using var form = new EditVehicleForm(vehicle.Id, _vehicleService)
            {
                StartPosition = FormStartPosition.CenterParent
            };

            if (form.ShowDialog(this) == DialogResult.OK)
                LoadVehicles();
        }

        
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            using var form = new AddCategoryForm(_vehicleService)
            {
                StartPosition = FormStartPosition.CenterParent
            };

            form.ShowDialog(this);
        }
    }
}
