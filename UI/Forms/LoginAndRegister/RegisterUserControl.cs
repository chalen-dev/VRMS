using System;
using System.Windows.Forms;
using VRMS.Services.Account;
using VRMS.Enums;
using VRMS.UI.ApplicationService;

namespace VRMS.Controls
{
    public partial class RegisterUserControl : UserControl
    {
        // Event listened to by Welcome form
        public event EventHandler GoBackToLoginRequest;

        private readonly UserService _userService;

        public RegisterUserControl()
            : this(ApplicationServices.UserService)
        {
        }

        internal RegisterUserControl(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        // ----------------------------
        // BUTTON EVENTS
        // ----------------------------

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GoBackToLogin();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Friendly protection in case a customer reaches this screen
            MessageBox.Show(
                "This registration page is intended for staff use only.\n\n" +
                "If you are a customer, please ask a staff member to assist you.",
                "Staff Registration",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirm = txtConfirmPass.Text;

            // ----------------------------
            // VALIDATION
            // ----------------------------

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirm))
            {
                MessageBox.Show(
                    "Please fill in all required fields.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show(
                    "Passwords do not match!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            try
            {
                // ----------------------------
                // CREATE STAFF USER
                // ----------------------------

                _userService.CreateUser(
                    username,
                    password,
                    UserRole.RentalAgent,
                    true
                );

                MessageBox.Show(
                    "Staff registration successful! You may now log in.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                GoBackToLogin();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Registration Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Registration error: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ----------------------------
        // NAVIGATION
        // ----------------------------

        public void GoBackToLogin()
        {
            ClearForm();
            GoBackToLoginRequest?.Invoke(this, EventArgs.Empty);
        }

        private void ClearForm()
        {
            txtUsername.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtConfirmPass.Clear();
            txtUsername.Focus();
        }
    }
}
