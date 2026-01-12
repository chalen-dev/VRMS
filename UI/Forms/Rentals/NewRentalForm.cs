using VRMS.Enums;
using VRMS.Forms.Payments;
using VRMS.Models.Fleet;
using VRMS.Services.Billing;
using VRMS.Services.Customer;
using VRMS.Services.Fleet;
using VRMS.Services.Rental;

namespace VRMS.UI.Forms.Rentals
{
    public partial class NewRentalForm : Form
    {
        private readonly CustomerService _customerService;
        private readonly VehicleService _vehicleService;
        private readonly ReservationService _reservationService;
        private readonly RentalService _rentalService;
        private readonly RateService _rateService;

        public NewRentalForm(
            CustomerService customerService,
            VehicleService vehicleService,
            ReservationService reservationService,
            RentalService rentalService,
            RateService rateService) 
        {
            InitializeComponent();

            _customerService = customerService;
            _vehicleService = vehicleService;
            _reservationService = reservationService;
            _rentalService = rentalService;
            _rateService = rateService; // ADD
            
            dtPickup.ValueChanged += (_, __) => RecalculateTotal();         // ADD
            dtReturn.ValueChanged += (_, __) => RecalculateTotal();         // ADD

            Load += NewRentalForm_Load;
            btnCancel.Click += (_, __) => Close();
        }

        // -------------------------------
        // LOAD DATA
        // -------------------------------
        private void NewRentalForm_Load(object? sender, EventArgs e)
        {
            LoadCustomers();
            LoadVehicles();
            LoadFuelLevels();
            RecalculateTotal(); 
        }

        private void LoadCustomers()
        {
            cbCustomer.DataSource = null;
            cbCustomer.DataSource = _customerService.GetAllCustomers();
            cbCustomer.DisplayMember = "FullName"; // or build manually
            cbCustomer.ValueMember = "Id";
        }

        private void LoadVehicles()
        {
            cbVehicle.DataSource = null;
            cbVehicle.DataSource =
                _vehicleService
                    .GetAllVehicles()
                    .FindAll(v => v.Status == VehicleStatus.Available);

            cbVehicle.DisplayMember = "DisplayName";
            cbVehicle.ValueMember = "Id";

            // Make sure something is selected so SelectedIndexChanged fires / UI shows an odometer
            if (cbVehicle.Items.Count > 0 && cbVehicle.SelectedIndex == -1)
                cbVehicle.SelectedIndex = 0;

            // Populate odometer for the currently selected vehicle
            UpdateOdometerFromSelectedVehicle();
        }

        
        private void LoadFuelLevels()
        {
            cbFuel.DataSource =
                Enum.GetValues(typeof(FuelLevel))
                    .Cast<FuelLevel>()
                    .Select(f => new
                    {
                        Value = f,
                        Text = VRMS.Helpers.FuelLevelHelper.ToDisplay(f)
                    })
                    .ToList();

            cbFuel.DisplayMember = "Text";
            cbFuel.ValueMember = "Value";

            cbFuel.SelectedValue = FuelLevel.Full;
        }
        
        private decimal _lastCalculatedTotal = 0m;

        private void RecalculateTotal()
        {
            if (cbVehicle.SelectedItem is not Vehicle vehicle)
                return;

            if (dtReturn.Value <= dtPickup.Value)
            {
                lblTotal.Text = "Total: ₱0.00";
                _lastCalculatedTotal = 0m;
                return;
            }

            // -------- BASE RENTAL (AUTHORITATIVE) --------
            decimal baseRental =
                _rateService.CalculateRentalCost(
                    dtPickup.Value,
                    dtReturn.Value,
                    vehicle.VehicleCategoryId);

            // -------- SECURITY DEPOSIT --------
            var category =
                _vehicleService.GetCategoryById(
                    vehicle.VehicleCategoryId);

            decimal securityDeposit =
                category.SecurityDeposit;

            // -------- TOTAL DUE TODAY --------
            decimal totalDueToday =
                baseRental + securityDeposit;

            _lastCalculatedTotal = totalDueToday;

            lblTotal.Text =
                $"Total Due Today: ₱{totalDueToday:N2}";
        }

        
        private void CbVehicle_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdateOdometerFromSelectedVehicle();
            RecalculateTotal(); 
        }

        private void UpdateOdometerFromSelectedVehicle()
        {
            // Ensure user can't type into the odometer field
            txtOdometer.ReadOnly = true;
            txtOdometer.TabStop = false;

            if (cbVehicle.SelectedItem is Vehicle v)
            {
                txtOdometer.Text = v.Odometer.ToString();
            }
            else
            {
                txtOdometer.Text = string.Empty;
            }
        }


        // -------------------------------
        // SAVE / NEXT STEP
        // -------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCustomer.SelectedItem is not Models.Customers.Customer customer)
                    throw new InvalidOperationException(
                        "Please select a customer.");

                if (cbVehicle.SelectedItem is not Vehicle vehicle)
                    throw new InvalidOperationException(
                        "Please select a vehicle.");

                if (!int.TryParse(txtOdometer.Text, out int odometer))
                    throw new InvalidOperationException(
                        "Invalid odometer value.");

                if (dtReturn.Value.Date <= dtPickup.Value.Date)
                    throw new InvalidOperationException(
                        "Return date must be after pickup date.");

                // UI-friendly strings
                string customerName =
                    $"{customer.FirstName} {customer.LastName}";

                string vehicleName =
                    $"{vehicle.Make} {vehicle.Model} ({vehicle.LicensePlate})";

                decimal estimatedTotal = _lastCalculatedTotal;

                using var paymentForm =
                    new RentalDownPayment(
                        customerName,
                        vehicleName,
                        estimatedTotal);

                if (paymentForm.ShowDialog() == DialogResult.OK)
                {
                    // Create reservation (Pending)
                    int reservationId =
                        _reservationService.CreateReservation(
                            customer.Id,
                            vehicle.Id,
                            dtPickup.Value.Date,
                            dtReturn.Value.Date
                        );

                    // Confirm reservation
                    _reservationService.ConfirmReservation(reservationId);
                    
                    // Get selected fuel level
                    FuelLevel startFuelLevel =
                        (FuelLevel)cbFuel.SelectedValue;
                    
                    // Start rental
                    int rentalId =
                        _rentalService.StartRental(
                            reservationId,
                            dtPickup.Value,
                            startFuelLevel
                        );

                    MessageBox.Show(
                        "Rental successfully created.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                    Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Cannot Proceed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
