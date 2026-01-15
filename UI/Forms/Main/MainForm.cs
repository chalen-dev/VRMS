using System.Reflection;
using VRMS.Controls;
using VRMS.Controls.UserProfile;
using VRMS.Repositories.Reports;
using VRMS.Services.Account;
using VRMS.Services.Reports;
using VRMS.UI.ApplicationService;
using VRMS.UI.Controls.Admin;
using VRMS.UI.Controls.CustomersView;
using VRMS.UI.Controls.History;
using VRMS.UI.Controls.RentalCalendar;
using VRMS.UI.Controls.RentalsView;
using VRMS.UI.Controls.Reports;
using VRMS.UI.Controls.VehiclesView;

namespace VRMS.UI.Forms.Main
{
    public partial class MainForm : Form
    {
        private Button activeButton = null;
        private readonly UserService _userService;

        // THEME COLORS
        private readonly Color normalColor = Color.Transparent;
        private readonly Color hoverColor = Color.FromArgb(46, 204, 113);
        private readonly Color activeColor = Color.FromArgb(39, 174, 96);

        public MainForm()
        {
            InitializeComponent();
            _userService = ApplicationServices.UserService;
            logoPictureBox.Image = LoadEmbeddedImage("VRMS.Assets.company_logo.png");

            SetupForm();
        }

        private bool IsCustomer()
        {
            return Program.CurrentUserRole.Equals("Customer", StringComparison.OrdinalIgnoreCase);
        }

        private bool IsAdmin()
        {
            return Program.CurrentUserRole.Equals("Admin", StringComparison.OrdinalIgnoreCase);
        }

        private void SetupForm()
        {
            if (lbluserInfo != null)
            {
                lbluserInfo.Text =
                    $"Welcome,\n{Program.CurrentUsername}\n({Program.CurrentUserRole})";
            }

            if (mainHeader != null)
            {
                mainHeader.SetUser(Program.CurrentUsername, Program.CurrentUserRole);
                mainHeader.UserInfoClicked += MainHeader_UserInfoClicked;
            }

            Text = $"Vehicle Rental System - {Program.CurrentUsername}";

            ApplyRoleBasedVisibility();
            SetupButtonEvents();
            LoadDefaultView();
        }

        private void ApplyRoleBasedVisibility()
        {
            if (IsCustomer())
            {
                btnCustomers.Visible = false;
                btnReports.Visible = false;
                btnAdmin.Visible = false;
            }

            if (!IsAdmin())
            {
                btnAdmin.Visible = false;
            }
        }

        private void LoadDefaultView()
        {
            if (IsCustomer())
            {
                ActivateButton(btnVehicles);
                return;
            }

            ActivateButton(btnDashboard);
            ShowView(
                new DashboardView(),
                "Dashboard",
                "Overview and Key Metrics"
            );
        }

        private void MainHeader_UserInfoClicked(object sender, EventArgs e)
        {
            NavigateToUserProfile();
        }

        private void SetupButtonEvents()
        {
            Button[] navButtons =
            {
                btnDashboard,
                btnVehicles,
                btnCustomers,
                btnRentals,
                btnRentalsCalendar,
                btnHistory,
                btnReports,
                btnAdmin
            };

            foreach (Button button in navButtons)
            {
                if (button == null) continue;

                button.BackColor = normalColor;
                button.FlatAppearance.BorderSize = 0;
                button.Click += NavButton_Click;

                button.MouseEnter += (s, e) =>
                {
                    if (button != activeButton)
                        button.BackColor = hoverColor;
                };

                button.MouseLeave += (s, e) =>
                {
                    if (button != activeButton)
                        button.BackColor = normalColor;
                };
            }

            if (btnLogout != null)
            {
                btnLogout.Click += (s, e) => Logout();
            }
        }

        private void NavButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null) return;
            if (clickedButton == activeButton) return;

            ActivateButton(clickedButton);
            HandleNavigation(clickedButton);
        }

        private void ActivateButton(Button button)
        {
            if (activeButton != null)
            {
                activeButton.BackColor = normalColor;
            }

            button.BackColor = activeColor;
            activeButton = button;
        }

        private void HandleNavigation(Button button)
        {
            switch (button.Name)
            {
                case "btnDashboard":
                    ShowView(
                        new DashboardView(),
                        "Dashboard",
                        "Overview and Key Metrics"
                    );
                    break;

                case "btnVehicles":
                    ShowView(
                        new VehiclesView(),
                        "Vehicles",
                        "Manage Fleet Inventory"
                    );
                    break;

                case "btnCustomers":
                    ShowView(
                        new CustomersView(),
                        "Customers",
                        "Customer Database"
                    );
                    break;

                case "btnRentals":
                    ShowView(
                        new RentalsView(),
                        "Rentals",
                        "Active and Completed Rentals"
                    );
                    break;

                case "btnRentalsCalendar":
                    ShowView(
                        new CalendarView(),
                        "Rental Calendar",
                        "Vehicle availability and bookings"
                    );
                    break;

                case "btnHistory":
                    ShowView(
                        new History(),
                        "History",
                        "Reservations & Rental Records"
                    );
                    break;

                case "btnReports":
                    {
                        var reportsRepo = new ReportsRepository();
                        var reportsService = new ReportsService(reportsRepo);

                        ShowView(
                            new ReportsView(reportsService),
                            "Reports",
                            "Analytics and Insights"
                        );
                        break;
                    }

                case "btnAdmin":
                    if (!IsAdmin())
                    {
                        MessageBox.Show(
                            "You do not have permission to access this section.",
                            "Access Denied",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return;
                    }

                    ShowView(
                        new AdminUserManagement(), // Changed from AdminView to AdminUserManagement
                        "Administration",
                        "User & System Management"
                    );
                    break;
            }
        }

        // =====================================================
        // USER PROFILE
        // =====================================================

        private void NavigateToUserProfile()
        {
            ShowView(
                new UserProfileView(
                    _userService,
                    Program.CurrentUserId
                ),
                "My Profile",
                "Manage your account settings"
            );

            if (activeButton != null)
            {
                activeButton.BackColor = normalColor;
                activeButton = null;
            }
        }

        // =====================================================
        // VIEW HANDLING
        // =====================================================

        private void ShowView(UserControl view, string title = "", string subtitle = "")
        {
            if (view == null) return;

            contentPanel.Controls.Clear();
            view.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(view);

            if (mainHeader != null)
            {
                mainHeader.SetTitle(title, subtitle);
            }
        }

        private void Logout()
        {
            if (MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            Hide();
            new Welcome().Show();
        }

        // =====================================================
        // CLEANUP
        // =====================================================

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (mainHeader != null)
            {
                mainHeader.UserInfoClicked -= MainHeader_UserInfoClicked;
            }

            base.OnFormClosed(e);
        }

        private static Image LoadEmbeddedImage(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();

            using var stream = assembly.GetManifestResourceStream(resourceName);
            if (stream == null)
                throw new InvalidOperationException($"Embedded resource not found: {resourceName}");

            return Image.FromStream(stream);
        }
    }
}