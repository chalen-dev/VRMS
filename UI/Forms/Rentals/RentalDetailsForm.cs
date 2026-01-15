using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VRMS.Enums;
using VRMS.Services.Customer;
using VRMS.Services.Fleet;
using VRMS.Services.Rental;
using VRMS.UI.ApplicationService;

namespace VRMS.Forms
{
    public partial class RentalDetailsForm : Form
    {
        private readonly int _rentalId;

        private readonly RentalService _rentalService;
        private readonly CustomerService _customerService;
        private readonly VehicleService _vehicleService;

        private static readonly string PlaceholderImagePath =
            Path.Combine(AppContext.BaseDirectory, "Assets", "img_placeholder.png");

        // =====================================================
        // MAIN CONSTRUCTOR
        // =====================================================

        public RentalDetailsForm(int rentalId)
        {
            InitializeComponent();

            _rentalId = rentalId;

            _rentalService = ApplicationServices.RentalService;
            _customerService = ApplicationServices.CustomerService;
            _vehicleService = ApplicationServices.VehicleService;

            Load += RentalDetailsForm_Load;
            btnClose.Click += (_, __) => Close();
        }

        // =====================================================
        // DESIGNER SUPPORT ONLY
        // =====================================================

        public RentalDetailsForm()
        {
            InitializeComponent();
            btnClose.Click += (_, __) => Close();
        }

        // =====================================================
        // LOAD
        // =====================================================

        private void RentalDetailsForm_Load(object sender, EventArgs e)
        {
            ConfigureDamageGrid();
            LoadRentalDetails();
        }

        // =====================================================
        // LOAD RENTAL DATA
        // =====================================================

        private void LoadRentalDetails()
        {
            var rental = _rentalService.GetRentalById(_rentalId);
            var vehicle = _vehicleService.GetVehicleById(rental.VehicleId);

            string customerName = "Walk-in";

            if (rental.CustomerId.HasValue)
            {
                var customer =
                    _customerService.GetCustomerById(rental.CustomerId.Value);

                customerName = $"{customer.FirstName} {customer.LastName}";
            }

            // -----------------------------
            // SUMMARY
            // -----------------------------

            lblRentalID.Text = $"Rental ID: {rental.Id}";
            lblCustomer.Text = $"Customer: {customerName}";
            lblVehicle.Text =
                $"Vehicle: {vehicle.Make} {vehicle.Model} ({vehicle.LicensePlate})";

            lblTotalDate.Text =
                rental.Status == RentalStatus.Completed || rental.Status == RentalStatus.Late
                    ? $"Returned: {rental.ActualReturnDate:MMM dd, yyyy}"
                    : $"Expected Return: {rental.ExpectedReturnDate:MMM dd, yyyy}";

            // -----------------------------
            // DAMAGES (EMPTY FOR NOW)
            // -----------------------------

            dgvDamages.Rows.Clear();

            // -----------------------------
            // PHOTO EVIDENCE
            // -----------------------------

            LoadEvidenceImages(vehicle.Id);
        }

        // =====================================================
        // DAMAGE GRID
        // =====================================================

        private void ConfigureDamageGrid()
        {
            dgvDamages.AutoGenerateColumns = false;
            dgvDamages.Columns.Clear();

            dgvDamages.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Description",
                    Width = 350
                });

            dgvDamages.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Estimated Cost",
                    Width = 150
                });
        }

        // =====================================================
        // MULTI IMAGE LOADER
        // =====================================================

        private void LoadEvidenceImages(int vehicleId)
        {
            // Clear main image
            if (pbEvidence.Image != null)
            {
                pbEvidence.Image.Dispose();
                pbEvidence.Image = null;
            }

            // Clear thumbnails
            flpEvidence.Controls.Clear();

            var images = _vehicleService.GetVehicleImages(vehicleId);

            // NO IMAGES → PLACEHOLDER
            if (images == null || images.Count == 0)
            {
                LoadMainImage(PlaceholderImagePath);
                return;
            }

            foreach (var img in images)
            {
                string imagePath = Path.Combine(
                    AppContext.BaseDirectory,
                    "Storage",
                    img.ImagePath);

                if (!File.Exists(imagePath))
                    continue;

                PictureBox thumb = new PictureBox
                {
                    Width = 100,
                    Height = 100,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BorderStyle = BorderStyle.FixedSingle,
                    Cursor = Cursors.Hand,
                    Margin = new Padding(6)
                };

                using (var fs = new FileStream(
                    imagePath,
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.ReadWrite))
                {
                    thumb.Image = Image.FromStream(fs);
                }

                thumb.Click += (_, __) => LoadMainImage(imagePath);

                flpEvidence.Controls.Add(thumb);
            }

            // Load first image by default
            LoadMainImage(
                Path.Combine(
                    AppContext.BaseDirectory,
                    "Storage",
                    images.First().ImagePath));
        }

        // =====================================================
        // MAIN IMAGE LOADER (SAFE)
        // =====================================================

        private void LoadMainImage(string imagePath)
        {
            if (!File.Exists(imagePath))
                return;

            if (pbEvidence.Image != null)
            {
                pbEvidence.Image.Dispose();
                pbEvidence.Image = null;
            }

            using var fs = new FileStream(
                imagePath,
                FileMode.Open,
                FileAccess.Read,
                FileShare.ReadWrite);

            pbEvidence.Image = Image.FromStream(fs);
        }
    }
}
