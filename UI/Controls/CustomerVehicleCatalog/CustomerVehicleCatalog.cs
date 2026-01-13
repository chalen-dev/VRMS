using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VRMS.Enums;
using VRMS.Models.Customers;
using VRMS.Repositories.Billing;
using VRMS.Services.Fleet;
using VRMS.Services.Rental;

namespace VRMS.UI.Controls.CustomerVehicleCatalog;

public partial class CustomerVehicleCatalog : UserControl
{
    // ===== UI COLORS =====
    private readonly Color _successColor = Color.FromArgb(46, 204, 113);
    private readonly Color _dangerColor = Color.FromArgb(231, 76, 60);
    private readonly Color _warningColor = Color.FromArgb(241, 196, 15);
    private readonly Color _primaryColor = Color.FromArgb(30, 60, 90);

    private readonly VehicleService _vehicleService;
    private readonly ReservationService _reservationService;
    private readonly Customer _customer;

    private readonly List<VehicleListItem> _allVehicles = new();
    private List<VehicleListItem> _filteredVehicles = new();
    private VehicleListItem? _selected;

    public CustomerVehicleCatalog(
        VehicleService vehicleService,
        ReservationService reservationService,
        Customer customer)
    {
        _vehicleService = vehicleService;
        _reservationService = reservationService;
        _customer = customer;

        InitializeComponent();
        InitializeComboBoxes();
        LoadCategories();
        WireEvents();

        LoadVehicles();
        ApplyFilters();
    }

    private void InitializeComboBoxes()
    {
        // Sort already has items from designer, but ensuring index
        cmbSort.SelectedIndex = 0;

        cmbStatus.Items.Clear();
        cmbStatus.Items.Add("📋 All Status");
        foreach (VehicleStatus status in Enum.GetValues(typeof(VehicleStatus)))
        {
            cmbStatus.Items.Add(status.ToString());
        }
        cmbStatus.SelectedIndex = 0;
    }

    private void LoadCategories()
    {
        cmbCategory.Items.Clear();
        cmbCategory.Items.Add("🚗 All Categories");

        var categories = _vehicleService.GetAllCategories();
        foreach (var c in categories)
        {
            cmbCategory.Items.Add(c.Name);
        }
        cmbCategory.SelectedIndex = 0;
    }

    private void LoadVehicles()
    {
        _allVehicles.Clear();
        var categories = _vehicleService.GetAllCategories().ToDictionary(c => c.Id);
        var vehicles = _vehicleService.GetAllVehicles();

        foreach (var v in vehicles)
        {
            var categoryName = categories.TryGetValue(v.VehicleCategoryId, out var cat) ? cat.Name : "Unknown";
            decimal dailyRate = 0m;
            try { dailyRate = new RateConfigurationRepository().GetByCategory(v.VehicleCategoryId).DailyRate; } catch { }

            _allVehicles.Add(new VehicleListItem
            {
                VehicleId = v.Id,
                Name = $"{v.Make} {v.Model}",
                Category = categoryName,
                Status = v.Status,
                DailyRate = dailyRate,
                Plate = v.LicensePlate,
                Year = v.Year
            });
        }
    }

    private void WireEvents()
    {
        txtSearch.TextChanged += (s, e) => ApplyFilters();
        cmbStatus.SelectedIndexChanged += (s, e) => ApplyFilters();
        cmbCategory.SelectedIndexChanged += (s, e) => ApplyFilters();
        cmbSort.SelectedIndexChanged += (s, e) => ApplyFilters();
        chkAvailableOnly.CheckedChanged += (s, e) => ApplyFilters();

        dgvVehicles.SelectionChanged += OnVehicleSelected;
        btnClearFilters.Click += OnClearFiltersClick;
        btnRent.Click += OnRentClick;
        btnRentNow.Click += OnRentClick;

        AttachHoverEffects();
    }

    private void ApplyFilters()
    {
        IEnumerable<VehicleListItem> result = _allVehicles;

        // Search logic
        var q = txtSearch.Text.Trim();
        if (!string.IsNullOrEmpty(q))
            result = result.Where(v => v.Name.Contains(q, StringComparison.OrdinalIgnoreCase) ||
                                     v.Plate.Contains(q, StringComparison.OrdinalIgnoreCase));

        // Status logic
        if (cmbStatus.SelectedIndex > 0)
        {
            var selectedStatus = cmbStatus.SelectedItem.ToString();
            result = result.Where(v => v.Status.ToString() == selectedStatus);
        }

        // Category logic
        if (cmbCategory.SelectedIndex > 0)
        {
            var cat = cmbCategory.SelectedItem.ToString();
            result = result.Where(v => v.Category == cat);
        }

        if (chkAvailableOnly.Checked)
            result = result.Where(v => v.Status == VehicleStatus.Available);

        // Sort logic
        result = cmbSort.SelectedIndex switch
        {
            0 => result.OrderBy(v => v.Name),
            1 => result.OrderByDescending(v => v.Name),
            2 => result.OrderBy(v => v.DailyRate),
            3 => result.OrderByDescending(v => v.DailyRate),
            4 => result.OrderByDescending(v => v.Year),
            5 => result.OrderBy(v => v.Year),
            _ => result
        };

        _filteredVehicles = result.ToList();
        dgvVehicles.DataSource = null;
        dgvVehicles.DataSource = _filteredVehicles;
        UpdateHeaderInfo();
    }

    private void OnVehicleSelected(object sender, EventArgs e)
    {
        if (dgvVehicles.SelectedRows.Count == 0)
        {
            panelVehicleDetails.Visible = false;
            panelNoSelection.Visible = true;
            _selected = null;
            return;
        }

        _selected = dgvVehicles.SelectedRows[0].DataBoundItem as VehicleListItem;
        if (_selected == null) return;

        panelNoSelection.Visible = false;
        panelVehicleDetails.Visible = true;

        lblMakeModel.Text = _selected.Name;
        lblCategoryValue.Text = _selected.Category;
        lblRateValue.Text = $"₱{_selected.DailyRate:N0}/day";
        lblPlateValue.Text = _selected.Plate;
        lblYearValue.Text = _selected.Year.ToString();
        lblStatusValue.Text = _selected.Status.ToString();
        lblStatusValue.ForeColor = GetStatusColor(_selected.Status);

        btnRentNow.Enabled = _selected.Status == VehicleStatus.Available;
        btnRent.Enabled = btnRentNow.Enabled;

        LoadVehicleImage(_selected.VehicleId);
    }

    private void LoadVehicleImage(int vehicleId)
    {
        picVehicle.Image = null;
        var images = _vehicleService.GetVehicleImages(vehicleId);

        string path = images.Count > 0
            ? Path.Combine(AppContext.BaseDirectory, "Storage", images[0].ImagePath)
            : Path.Combine(AppContext.BaseDirectory, "Assets", "img_placeholder.png");

        if (File.Exists(path))
        {
            using var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            picVehicle.Image = new Bitmap(Image.FromStream(fs));
        }
    }

    private void OnRentClick(object sender, EventArgs e)
    {
        if (_selected == null || _selected.Status != VehicleStatus.Available) return;

        try
        {
            _reservationService.CreateReservation(_customer.Id, _selected.VehicleId, DateTime.Today, DateTime.Today.AddDays(1));
            MessageBox.Show("Reservation submitted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadVehicles();
            ApplyFilters();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void OnClearFiltersClick(object sender, EventArgs e)
    {
        txtSearch.Clear();
        cmbStatus.SelectedIndex = 0;
        cmbCategory.SelectedIndex = 0;
        cmbSort.SelectedIndex = 0;
        chkAvailableOnly.Checked = false;
        ApplyFilters();
    }

    private void UpdateHeaderInfo()
    {
        lblVehicleCount.Text = $"Total: {_filteredVehicles.Count} vehicles";
    }

    private Color GetStatusColor(VehicleStatus status) => status switch
    {
        VehicleStatus.Available => _successColor,
        VehicleStatus.Rented => _dangerColor,
        VehicleStatus.UnderMaintenance => _warningColor,
        _ => Color.Gray
    };

    private void AttachHoverEffects()
    {
        foreach (var btn in new[] { btnRent, btnRentNow, btnClearFilters })
        {
            btn.MouseEnter += (s, e) => { if (btn.Enabled) btn.BackColor = Color.FromArgb(40, btn.BackColor); };
            btn.MouseLeave += (s, e) => { btn.BackColor = (btn == btnClearFilters) ? Color.White : _successColor; };
        }
    }
}

internal sealed class VehicleListItem
{
    public int VehicleId { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Category { get; init; } = string.Empty;
    public VehicleStatus Status { get; set; }
    public decimal DailyRate { get; init; }
    public string Plate { get; init; } = string.Empty;
    public int Year { get; init; }
}