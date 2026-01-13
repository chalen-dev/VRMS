using System;
using System.Drawing;
using System.Windows.Forms;

namespace VRMS.Controls
{
    public partial class CustomersRentalsView : UserControl
    {
        // 🔔 Event for navigation
        public event EventHandler ProceedRentRequested;

        public CustomersRentalsView()
        {
            InitializeComponent();
            InitializeGrid();
            InitializeStatusFilter();
            InitializeDefaultState();
            WireUiEvents();
        }

        // =========================
        // GRID SETUP (OPTIONAL)
        // =========================
        private void InitializeGrid()
        {
            dgvRentals.Rows.Clear();
            dgvRentals.Columns.Clear();
            dgvRentals.AutoGenerateColumns = false;

            dgvRentals.Columns.Add("Vehicle", "Vehicle");
            dgvRentals.Columns.Add("Plate", "Plate No.");
            dgvRentals.Columns.Add("Category", "Category");
            dgvRentals.Columns.Add("Transmission", "Transmission");
            dgvRentals.Columns.Add("Fuel", "Fuel");
            dgvRentals.Columns.Add("Pickup", "Pickup Location");
            dgvRentals.Columns.Add("Period", "Rental Period");
            dgvRentals.Columns.Add("Amount", "Amount");
            dgvRentals.Columns.Add("Status", "Status");
            dgvRentals.Columns.Add("Payment", "Payment");

            dgvRentals.Columns["Amount"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
            dgvRentals.Columns["Amount"].DefaultCellStyle.Format =
                "₱ #,##0.00";
        }

        // =========================
        // STATUS FILTER
        // =========================
        private void InitializeStatusFilter()
        {
            cbStatusFilter.Items.Clear();
            cbStatusFilter.Items.AddRange(new object[]
            {
                "All",
                "Active",
                "Returned",
                "Pending",
                "Cancelled"
            });

            cbStatusFilter.SelectedIndex = 0;
        }

        // =========================
        // DEFAULT STATE
        // =========================
        private void InitializeDefaultState()
        {
            pbVehicle.Image = null;

            lblDetailVehicle.Text = "Start a new rental anytime";
            lblDetailDates.Text = "Period: —";
            lblDetailAmount.Text = "Total: ₱ 0.00";

            // ✅ ALWAYS ENABLED
            btnProceedRent.Enabled = true;
            btnViewDetails.Enabled = false;
        }

        // =========================
        // EVENTS
        // =========================
        private void WireUiEvents()
        {
            btnRefresh.Click += (_, __) => InitializeDefaultState();
            btnViewDetails.Click += (_, __) => ShowComingSoon();

            // ✅ Proceed Rent always clickable
            btnProceedRent.Click += (_, __) =>
            {
                ProceedRentRequested?.Invoke(this, EventArgs.Empty);
            };
        }

        private void ShowComingSoon()
        {
            MessageBox.Show(
                "This feature will be implemented soon.",
                "Coming Soon",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
