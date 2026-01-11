using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VRMS.Enums;
using VRMS.Models.Fleet;
using VRMS.Repositories.Fleet;
using VRMS.Services.Fleet;
using VRMS.UI.Forms;

namespace VRMS.Forms
{
    public partial class AddVehicleForm : Form
    {
        private readonly VehicleService _vehicleService;

        // =========================
        // SAVE BUTTON COLORS
        // =========================
        private readonly Color _saveEnabledColor =
            Color.FromArgb(46, 204, 113); // green
        private readonly Color _saveDisabledColor =
            Color.FromArgb(189, 195, 199); // gray
        private readonly Color _saveDisabledTextColor =
            Color.FromArgb(120, 120, 120);

        public AddVehicleForm(VehicleService vehicleService)
        {
            InitializeComponent();
            _vehicleService = vehicleService;

            HookEvents();
            Load += AddVehicleForm_Load;
        }

        // =========================
        // EVENT WIRING
        // =========================
        private void HookEvents()
        {
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (_, __) => Close();
            btnAddImage.Click += BtnSelectImage_Click;
            btnRemoveImage.Click += BtnRemoveImage_Click;
            btnAddCategory.Click += BtnAddCategory_Click;

            lstImages.SelectedIndexChanged += LstImages_SelectedIndexChanged;

            txtMake.TextChanged += ValidateFormState;
            txtModel.TextChanged += ValidateFormState;
            txtPlate.TextChanged += ValidateFormState;
            txtVIN.TextChanged += ValidateFormState;
            cbCategory.SelectedIndexChanged += ValidateFormState;
        }

        // =========================
        // FORM LOAD
        // =========================
        private void AddVehicleForm_Load(object? sender, EventArgs e)
        {
            cbTransmission.DataSource =
                Enum.GetValues(typeof(TransmissionType));

            cbFuel.DataSource =
                Enum.GetValues(typeof(FuelType));

            cbStatus.DataSource =
                new[] { VehicleStatus.Available };
            cbStatus.SelectedItem = VehicleStatus.Available;

            LoadCategories();
            UpdateSaveButtonState();
        }

        private void LoadCategories()
        {
            cbCategory.DataSource = null;
            cbCategory.DataSource = _vehicleService.GetAllCategories();
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
        }

        // =========================
        // SAVE VEHICLE
        // =========================
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            try
            {
                ValidateForm();

                decimal fuelEfficiency =
                    decimal.Parse(txtFuelEfficiency.Text);

                var vehicle = new Vehicle
                {
                    VehicleCode =
                        $"VEH-{DateTime.UtcNow:yyyyMMddHHmmss}",
                    Make = txtMake.Text.Trim(),
                    Model = txtModel.Text.Trim(),
                    Year = (int)numYear.Value,
                    Color = txtColor.Text.Trim(),
                    LicensePlate = txtPlate.Text.Trim(),
                    VIN = txtVIN.Text.Trim(),

                    Transmission =
                        (TransmissionType)cbTransmission.SelectedItem!,
                    FuelType =
                        (FuelType)cbFuel.SelectedItem!,
                    SeatingCapacity = (int)numSeats.Value,
                    Odometer = (int)numMileage.Value,

                    FuelEfficiency = fuelEfficiency,
                    CargoCapacity = (int)numCargoCapacity.Value,
                    VehicleCategoryId =
                        (int)cbCategory.SelectedValue
                };

                // -------------------------
                // CREATE VEHICLE
                // -------------------------
                int vehicleId =
                    _vehicleService.CreateVehicle(vehicle);

                // -------------------------
                // SAVE IMAGES
                // -------------------------
                foreach (string path in lstImages.Items)
                {
                    using var stream = File.OpenRead(path);
                    _vehicleService.AddVehicleImage(
                        vehicleId,
                        stream,
                        Path.GetFileName(path));
                }

                // -------------------------
                // SAVE FEATURES (STATIC)
                // -------------------------
                var featureRepo =
                    new VehicleFeatureRepository();
                var featureMapRepo =
                    new VehicleFeatureMappingRepository();
                var features = featureRepo.GetAll();

                void SaveFeature(CheckBox chk, string name)
                {
                    if (!chk.Checked) return;

                    var feature =
                        features.FirstOrDefault(
                            f => f.Name.Equals(
                                name,
                                StringComparison.OrdinalIgnoreCase));

                    if (feature != null)
                        featureMapRepo.Add(
                            vehicleId,
                            feature.Id);
                }

                SaveFeature(chkAC, "Air Conditioning");
                SaveFeature(chkGPS, "GPS Navigation");
                SaveFeature(chkBluetooth, "Bluetooth Connectivity");
                SaveFeature(chkChildSeat, "Child Seat Availability");
                SaveFeature(chkInsuranceIncluded, "Insurance Coverage Included");

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Add Vehicle Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================
        // VALIDATION
        // =========================
        private void ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtMake.Text))
                throw new InvalidOperationException(
                    "Make is required.");

            if (string.IsNullOrWhiteSpace(txtModel.Text))
                throw new InvalidOperationException(
                    "Model is required.");

            if (string.IsNullOrWhiteSpace(txtPlate.Text))
                throw new InvalidOperationException(
                    "License plate is required.");

            if (string.IsNullOrWhiteSpace(txtVIN.Text))
                throw new InvalidOperationException(
                    "VIN is required.");

            if (txtVIN.Text.Length < 8)
                throw new InvalidOperationException(
                    "VIN is too short.");

            if (numMileage.Value < 0)
                throw new InvalidOperationException(
                    "Mileage cannot be negative.");

            if (!decimal.TryParse(
                    txtFuelEfficiency.Text,
                    out var eff) || eff <= 0)
                throw new InvalidOperationException(
                    "Fuel efficiency must be a positive number (km/L).");

            if (numCargoCapacity.Value < 0)
                throw new InvalidOperationException(
                    "Cargo capacity cannot be negative.");

            if (cbCategory.SelectedItem == null)
                throw new InvalidOperationException(
                    "Category is required.");
        }

        private void ValidateFormState(object? sender, EventArgs e)
        {
            UpdateSaveButtonState();
        }

        private void UpdateSaveButtonState()
        {
            bool isValid =
                !string.IsNullOrWhiteSpace(txtMake.Text) &&
                !string.IsNullOrWhiteSpace(txtModel.Text) &&
                !string.IsNullOrWhiteSpace(txtPlate.Text) &&
                !string.IsNullOrWhiteSpace(txtVIN.Text) &&
                cbCategory.SelectedItem != null;

            btnSave.Enabled = isValid;

            if (isValid)
            {
                btnSave.BackColor = _saveEnabledColor;
                btnSave.ForeColor = Color.White;
                btnSave.Cursor = Cursors.Hand;
            }
            else
            {
                btnSave.BackColor = _saveDisabledColor;
                btnSave.ForeColor = _saveDisabledTextColor;
                btnSave.Cursor = Cursors.Default;
            }
        }

        // =========================
        // IMAGE HANDLING
        // =========================
        private void BtnSelectImage_Click(object? sender, EventArgs e)
        {
            using OpenFileDialog dlg = new()
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png",
                Multiselect = true
            };

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            foreach (var file in dlg.FileNames)
            {
                if (!lstImages.Items.Contains(file))
                    lstImages.Items.Add(file);
            }
        }

        private void LstImages_SelectedIndexChanged(
            object? sender, EventArgs e)
        {
            if (lstImages.SelectedItem is string path &&
                File.Exists(path))
                picVehicleImage.ImageLocation = path;
        }

        private void BtnRemoveImage_Click(
            object? sender, EventArgs e)
        {
            if (lstImages.SelectedItem == null)
                return;

            int index = lstImages.SelectedIndex;
            lstImages.Items.RemoveAt(index);
            picVehicleImage.Image = null;
        }

        // =========================
        // ADD CATEGORY
        // =========================
        private void BtnAddCategory_Click(
            object? sender, EventArgs e)
        {
            using var form =
                new AddCategoryForm(_vehicleService)
                {
                    StartPosition =
                        FormStartPosition.CenterParent
                };

            if (form.ShowDialog(this) == DialogResult.OK)
                LoadCategories();
        }
    }
}
