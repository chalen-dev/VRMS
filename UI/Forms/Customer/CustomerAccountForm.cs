using System;
using System.Windows.Forms;
using VRMS.Enums;
using VRMS.Repositories.Accounts;
using VRMS.Services.Account;
using VRMS.Services.Validation;

// 🔒 ALIAS THE MODEL TYPE (NO AMBIGUITY POSSIBLE)
using CustomerModel = VRMS.Models.Customers.Customer;

namespace VRMS.UI.Forms.Customers
{
    public partial class CustomerAccountForm : Form
    {
        private readonly CustomerModel _customer;
        private readonly CustomerAccountService _accountService;

        // =====================================================
        // CONSTRUCTOR
        // =====================================================
        public CustomerAccountForm(
            CustomerModel customer,
            CustomerAccountService accountService)
        {
            InitializeComponent();

            _customer = customer;
            _accountService = accountService;

            btnCreate.Click += btnCreate_Click;
            btnResetPassword.Click += btnResetPassword_Click;
            btnDisable.Click += btnDisable_Click;
            btnClose.Click += btnClose_Click;

            InitializeDataGridView();
            LoadCustomerAccount();
        }

        // =====================================================
        // DATAGRIDVIEW SETUP
        // =====================================================

        private void InitializeDataGridView()
        {
            dgvCustomerAccounts.Columns.Clear();
            dgvCustomerAccounts.AutoGenerateColumns = false;
            dgvCustomerAccounts.MultiSelect = false;
            dgvCustomerAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomerAccounts.ReadOnly = true;
            dgvCustomerAccounts.AllowUserToAddRows = false;

            dgvCustomerAccounts.Columns.Add("CustomerId", "ID");
            dgvCustomerAccounts.Columns.Add("CustomerName", "Customer Name");
            dgvCustomerAccounts.Columns.Add("Username", "Username");
            dgvCustomerAccounts.Columns.Add("AccountStatus", "Status");
            dgvCustomerAccounts.Columns.Add("LastLogin", "Last Login");

            dgvCustomerAccounts.Columns["CustomerId"].Width = 60;
            dgvCustomerAccounts.Columns["CustomerName"].Width = 160;
            dgvCustomerAccounts.Columns["Username"].Width = 120;
            dgvCustomerAccounts.Columns["AccountStatus"].Width = 80;
            dgvCustomerAccounts.Columns["LastLogin"].Width = 130;

            dgvCustomerAccounts.SelectionChanged += dgvCustomerAccounts_SelectionChanged;
        }

        // =====================================================
        // LOAD ACCOUNT (SINGLE CUSTOMER)
        // =====================================================

        private void LoadCustomerAccount()
        {
            dgvCustomerAccounts.Rows.Clear();

            var account = _accountService.GetByCustomerId(_customer.Id);

            if (account == null)
            {
                UpdateFormState(AccountStatus.NotCreated);
                return;
            }

            dgvCustomerAccounts.Rows.Add(
                _customer.Id,
                $"{_customer.FirstName} {_customer.LastName}",
                account.Username,
                account.IsEnabled ? "Active" : "Disabled",
                account.LastLoginAt?.ToString("yyyy-MM-dd HH:mm") ?? "—"
            );

            dgvCustomerAccounts.Rows[0].Selected = true;

            UpdateFormState(
                account.IsEnabled
                    ? AccountStatus.Active
                    : AccountStatus.Disabled
            );
        }


        // =====================================================
        // FORM STATE
        // =====================================================

        private void UpdateFormState(AccountStatus status)
        {
            bool hasAccount = status != AccountStatus.NotCreated;

            txtUsername.Text = hasAccount ? txtUsername.Text : "";
            chkAccountEnabled.Checked = status == AccountStatus.Active;

            lblAccountState.Text = status switch
            {
                AccountStatus.Active => "Login Account: Active",
                AccountStatus.Disabled => "Login Account: Disabled",
                _ => "Login Account: Not Created"
            };

            btnCreate.Enabled = status == AccountStatus.NotCreated;
            btnResetPassword.Enabled = hasAccount;
            btnDisable.Enabled = status == AccountStatus.Active;
        }


        // =====================================================
        // DGV EVENTS
        // =====================================================

        private void dgvCustomerAccounts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomerAccounts.SelectedRows.Count == 0)
                return;

            var row = dgvCustomerAccounts.SelectedRows[0];

            txtUsername.Text = row.Cells["Username"].Value?.ToString() ?? "";

            string status = row.Cells["AccountStatus"].Value?.ToString() ?? "Disabled";
            bool isActive = status == "Active";

            chkAccountEnabled.Checked = isActive;
            lblAccountState.Text =
                $"Login Account: {(isActive ? "Active" : "Disabled")}";

            btnCreate.Enabled = false;
            btnResetPassword.Enabled = true;
            btnDisable.Enabled = isActive;
        }

        // =====================================================
        // BUTTON ACTIONS
        // =====================================================

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                AccountValidator.ValidateUsername(txtUsername.Text);
                AccountValidator.ValidatePassword(
                    txtPassword.Text,
                    txtConfirmPassword.Text);

                _accountService.CreateAccount(
                    _customer.Id,
                    txtUsername.Text.Trim(),
                    txtPassword.Text
                );

                MessageBox.Show(
                    "Customer login account created.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadCustomerAccount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (dgvCustomerAccounts.SelectedRows.Count == 0)
                return;

            try
            {
                AccountValidator.ValidatePassword(
                    txtPassword.Text,
                    txtConfirmPassword.Text);

                int accountId = Convert.ToInt32(
                    dgvCustomerAccounts.SelectedRows[0]
                        .Cells["CustomerId"].Value);

                _accountService.ResetPassword(
                    accountId,
                    txtPassword.Text
                );

                MessageBox.Show(
                    "Password has been reset.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                txtPassword.Clear();
                txtConfirmPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void btnDisable_Click(object sender, EventArgs e)
        {
            if (dgvCustomerAccounts.SelectedRows.Count == 0)
                return;

            if (MessageBox.Show(
                    "Disable this customer account?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                int accountId = Convert.ToInt32(
                    dgvCustomerAccounts.SelectedRows[0]
                        .Cells["CustomerId"].Value);

                _accountService.DisableAccount(accountId);

                MessageBox.Show(
                    "Account has been disabled.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadCustomerAccount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void splitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            // optional layout logic
        }
    }
}
