using System.Reflection;
using VRMS.Enums;
using VRMS.Models.Fleet;
using VRMS.Models.Rentals;
using VRMS.Services.Fleet;
using VRMS.Services.Rental;
using VRMS.UI.ApplicationService;

namespace VRMS.UI.Controls.RentalCalendar
{
    public partial class CalendarView : UserControl
    {
        // ===============================
        // LAYOUT CONSTANTS
        // ===============================
        private const int DayColumnWidth = 45;     // Slightly wider for better spacing
        private const int RowHeight = 50;          // Increased from 40 to 50 (25% taller)
        private const int HeaderHeight = 45;       // Slightly taller header to match
        private const int DayStartHour = 8;        // 8 AM
        private const int DayEndHour = 20;         // 8 PM

        private readonly RentalService _rentalService =
            ApplicationServices.RentalService;

        private readonly VehicleService _vehicleService =
            ApplicationServices.VehicleService;

        // ===============================
        // STATE
        // ===============================
        private DateTime _currentDate;
        private List<Rental> _monthRentals = new();
        private List<MaintenanceRecord> _monthMaintenance = new();
        private List<Vehicle> _vehicles = new();
        private int CalendarLeftOffset =>
            0;

        public CalendarView()
        {
            InitializeComponent();

            _currentDate = new DateTime(
                DateTime.Today.Year,
                DateTime.Today.Month,
                DateTime.Today.Day
            );

            dtpMonthYear.Value = _currentDate;

            SetupVehicleDataGrid();
            EnableDoubleBuffering();

            // Position DGV correctly
            PositionDGV();
        }

        // ===============================
        // POSITION DGV TO MATCH CALENDAR
        // ===============================
        private void PositionDGV()
        {
            // Set DGV position to match calendar header
            dgvVehicles.Location = new Point(0, HeaderHeight);
            dgvVehicles.Height = pnlVehicleList.Height - HeaderHeight;

            // Configure row height
            dgvVehicles.RowTemplate.Height = RowHeight;
            foreach (DataGridViewRow row in dgvVehicles.Rows)
            {
                row.Height = RowHeight;
            }
        }

        // ===============================
        // VEHICLE DATA GRID SETUP
        // ===============================
        private void SetupVehicleDataGrid()
        {
            dgvVehicles.Rows.Clear();

            dgvVehicles.RowTemplate.Height = RowHeight;
            dgvVehicles.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f);

            _vehicles = _vehicleService.GetAllVehicles();

            foreach (var vehicle in _vehicles)
            {
                int rowIndex = dgvVehicles.Rows.Add(
                    vehicle.Year.ToString(),
                    vehicle.LicensePlate,
                    vehicle.Model
                );

                var row = dgvVehicles.Rows[rowIndex];
                row.Height = RowHeight;

                switch (vehicle.Status)
                {
                    case VehicleStatus.Available:
                        row.DefaultCellStyle.BackColor = Color.FromArgb(240, 255, 240);
                        break;

                    case VehicleStatus.Rented:
                        row.DefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
                        break;

                    case VehicleStatus.UnderMaintenance:
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 240, 240);
                        break;
                }

                row.DefaultCellStyle.ForeColor = Color.Black;
                row.Cells[1].ToolTipText = $"Status: {vehicle.Status}";
            }
        }


        // ===============================
        // VEHICLE HEADER PAINT
        // ===============================
        private void pnlVehicleHeader_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = pnlVehicleHeader.ClientRectangle;

            // Fill background
            using Brush headerBrush = new SolidBrush(Color.FromArgb(240, 240, 240));
            g.FillRectangle(headerBrush, rect);

            // Draw border
            using Pen borderPen = new Pen(Color.LightGray);
            g.DrawRectangle(borderPen, rect);

            // Draw header text with slightly larger font
            using Font headerFont = new Font(Font.FontFamily, 10, FontStyle.Bold);
            TextRenderer.DrawText(
                g,
                "VEHICLES",
                headerFont,
                rect,
                Color.Black,
                TextFormatFlags.HorizontalCenter |
                TextFormatFlags.VerticalCenter
            );
        }

        // ===============================
        // EVENT HANDLERS
        // ===============================
        private void btnPrev_Click(object sender, EventArgs e)
        {
            _currentDate = _currentDate.AddMonths(-1);
            dtpMonthYear.Value = _currentDate;
            pnlCalendarCanvas.Invalidate();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _currentDate = _currentDate.AddMonths(1);
            dtpMonthYear.Value = _currentDate;
            pnlCalendarCanvas.Invalidate();
        }

        private void dtpMonthYear_ValueChanged(object sender, EventArgs e)
        {
            _currentDate = dtpMonthYear.Value;
            pnlCalendarCanvas.Invalidate();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Category filtering will be reintroduced once
            // category names are resolved from VehicleCategoryService.
            SetupVehicleDataGrid();
            pnlCalendarCanvas.Invalidate();
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sort functionality - can be enhanced based on your needs
            pnlCalendarCanvas.Invalidate();
        }

        // ===============================
        // DOUBLE BUFFERING
        // ===============================
        private void EnableDoubleBuffering()
        {
            typeof(Panel)
                .GetProperty(
                    "DoubleBuffered",
                    BindingFlags.Instance | BindingFlags.NonPublic
                )
                ?.SetValue(pnlCalendarCanvas, true);
        }

        // ===============================
        // PAINT EVENTS
        // ===============================
        private void pnlCalendarCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            DrawMonthView(g);
        }

        private void pnlCalendarCanvas_Resize(object sender, EventArgs e)
        {
            pnlCalendarCanvas.Invalidate();
        }

        // ===============================
        // MONTH VIEW DRAWING
        // ===============================
        private void DrawMonthView(Graphics g)
        {
            int daysInMonth = DateTime.DaysInMonth(
                _currentDate.Year,
                _currentDate.Month
            );
            LoadMonthData();

            DrawDayHeaders(g, daysInMonth);
            DrawGrid(g, daysInMonth);
            DrawMonthRentals(g);
            DrawMonthMaintenance(g);
        }
        
        private void LoadMonthData()
        {
            _vehicles = _vehicleService.GetAllVehicles();
            _monthRentals.Clear();
            _monthMaintenance.Clear();

            var monthStart =
                new DateTime(_currentDate.Year, _currentDate.Month, 1);

            var monthEnd =
                monthStart.AddMonths(1).AddDays(-1);

            // ---------------- RENTALS ----------------
            var rentals = _rentalService.GetAllRentals();

            foreach (var r in rentals)
            {
                var rentalEnd =
                    r.ActualReturnDate ?? r.ExpectedReturnDate;

                if (rentalEnd < monthStart || r.PickupDate > monthEnd)
                    continue;

                _monthRentals.Add(r);
            }

            // ---------------- MAINTENANCE ----------------
            foreach (var v in _vehicles)
            {
                var maints =
                    _vehicleService.GetMaintenanceByVehicle(v.Id);

                foreach (var m in maints)
                {
                    var maintEnd = m.EndDate ?? monthEnd;

                    if (maintEnd < monthStart || m.StartDate > monthEnd)
                        continue;

                    _monthMaintenance.Add(m);
                }
            }
        }


        private void DrawDayHeaders(Graphics g, int daysInMonth)
        {
            using Brush headerBrush = new SolidBrush(Color.FromArgb(240, 240, 240));
            using Pen borderPen = new Pen(Color.LightGray);
            using Font dayFont = new Font(Font.FontFamily, 9, FontStyle.Bold);
            using Font dateFont = new Font(Font.FontFamily, 10, FontStyle.Regular);

            for (int day = 1; day <= daysInMonth; day++)
            {
                int x = CalendarLeftOffset + (day - 1) * DayColumnWidth;

                Rectangle rect = new Rectangle(
                    x,
                    0,
                    DayColumnWidth,
                    HeaderHeight
                );

                g.FillRectangle(headerBrush, rect);
                g.DrawRectangle(borderPen, rect);

                DateTime date = new DateTime(
                    _currentDate.Year,
                    _currentDate.Month,
                    day
                );

                // Highlight weekends
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    using Brush weekendBrush = new SolidBrush(Color.FromArgb(255, 240, 240));
                    g.FillRectangle(weekendBrush, rect);
                }

                // Highlight today
                if (date.Date == DateTime.Today)
                {
                    using Pen todayPen = new Pen(Color.Red, 2);
                    g.DrawRectangle(todayPen, rect);
                }

                // Draw day name (abbreviated)
                Rectangle dayNameRect = new Rectangle(x, 2, DayColumnWidth, 18);
                TextRenderer.DrawText(
                    g,
                    date.ToString("ddd"),
                    dayFont,
                    dayNameRect,
                    Color.Black,
                    TextFormatFlags.HorizontalCenter |
                    TextFormatFlags.Top
                );

                // Draw date number
                Rectangle dateRect = new Rectangle(x, 20, DayColumnWidth, 23);
                TextRenderer.DrawText(
                    g,
                    day.ToString(),
                    dateFont,
                    dateRect,
                    Color.Black,
                    TextFormatFlags.HorizontalCenter |
                    TextFormatFlags.Top
                );
            }
        }

        private void DrawGrid(Graphics g, int daysInMonth)
        {
            int totalHeight = pnlCalendarCanvas.Height;
            int totalWidth = daysInMonth * DayColumnWidth;
            int rowCount = dgvVehicles.Rows.Count;

            using Pen pen = new Pen(Color.LightGray);

            // Vertical day lines (start from x = 0, no first column for vehicle names)
            for (int i = 0; i <= daysInMonth; i++)
            {
                int x = CalendarLeftOffset + i * DayColumnWidth;
                int bottomY = HeaderHeight + (rowCount * RowHeight);
                g.DrawLine(pen, x, HeaderHeight, x, bottomY);
            }

            // Horizontal rows
            for (int i = 0; i <= rowCount; i++)
            {
                int y = HeaderHeight + (i * RowHeight);
                g.DrawLine(pen, 0, y, totalWidth, y);
            }
        }

        private void DrawMonthRentals(Graphics g)
        {
            using Pen borderPen = new Pen(Color.DimGray);
            using Font rentalFont = new Font(Font.FontFamily, 9);

            foreach (var r in _monthRentals)
            {
                int vehicleRow =
                    _vehicles.FindIndex(v => v.Id == r.VehicleId);

                if (vehicleRow < 0)
                    continue;

                var start =
                    r.PickupDate < new DateTime(_currentDate.Year, _currentDate.Month, 1)
                        ? 1
                        : r.PickupDate.Day;

                var endDate =
                    r.ActualReturnDate ?? r.ExpectedReturnDate;

                var end =
                    endDate > new DateTime(_currentDate.Year, _currentDate.Month,
                        DateTime.DaysInMonth(_currentDate.Year, _currentDate.Month))
                        ? DateTime.DaysInMonth(_currentDate.Year, _currentDate.Month)
                        : endDate.Day;

                int duration = end - start + 1;

                int x = CalendarLeftOffset + (start - 1) * DayColumnWidth;
                int y = HeaderHeight + vehicleRow * RowHeight;
                int width = duration * DayColumnWidth;
                int height = RowHeight - 8;

                Rectangle rect = new Rectangle(
                    x + 3,
                    y + 4,
                    width - 6,
                    height
                );

                using Brush fill =
                    new SolidBrush(Color.FromArgb(
                        200,
                        Color.SkyBlue.R,
                        Color.SkyBlue.G,
                        Color.SkyBlue.B
                    ));

                g.FillRectangle(fill, rect);
                g.DrawRectangle(Pens.DimGray, rect);

                TextRenderer.DrawText(
                    g,
                    $"Rental #{r.Id}",
                    rentalFont,
                    rect,
                    Color.Black,
                    TextFormatFlags.HorizontalCenter |
                    TextFormatFlags.VerticalCenter |
                    TextFormatFlags.EndEllipsis
                );
            }

        }

        private void DrawMonthMaintenance(Graphics g)
        {
            using Pen borderPen = new Pen(Color.DarkRed, 1);
            using Font maintFont = new Font(Font.FontFamily, 9, FontStyle.Bold);

            foreach (var m in _monthMaintenance)
            {
                int vehicleRow =
                    _vehicles.FindIndex(v => v.Id == m.VehicleId);

                if (vehicleRow < 0)
                    continue;

                int start =
                    m.StartDate < new DateTime(_currentDate.Year, _currentDate.Month, 1)
                        ? 1
                        : m.StartDate.Day;

                var endDate =
                    m.EndDate ??
                    new DateTime(_currentDate.Year, _currentDate.Month,
                        DateTime.DaysInMonth(_currentDate.Year, _currentDate.Month));

                int end =
                    endDate.Day;

                int duration = end - start + 1;

                int x = CalendarLeftOffset + (start - 1) * DayColumnWidth;
                int y = HeaderHeight + vehicleRow * RowHeight;
                int width = duration * DayColumnWidth;
                int height = RowHeight - 8;

                Rectangle rect = new Rectangle(
                    x + 3,
                    y + 4,
                    width - 6,
                    height
                );

                using Brush fill =
                    new SolidBrush(Color.FromArgb(200, Color.OrangeRed));

                g.FillRectangle(fill, rect);
                g.DrawRectangle(Pens.DarkRed, rect);

                TextRenderer.DrawText(
                    g,
                    "MAINT",
                    maintFont,
                    rect,
                    Color.White,
                    TextFormatFlags.HorizontalCenter |
                    TextFormatFlags.VerticalCenter
                );
            }

        }

        private void dgvVehicles_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Ensure row height stays consistent
            dgvVehicles.Rows[e.RowIndex].Height = RowHeight;
        }

        private void pnlVehicleList_Resize(object sender, EventArgs e)
        {
            // Reposition DGV when panel resizes
            PositionDGV();
        }
    }
}