using System;
using System.Windows.Forms;

namespace VRMS.UI.Forms.Payments
{
    public partial class RefundForm : Form
    {
        // ===== STATE =====
        private readonly int _transactionId;
        private readonly decimal _originalAmount;

        public RefundForm(
            int transactionId,
            string customer,
            string vehicle,
            decimal originalAmount,
            string paymentMethod,
            DateTime transactionDate
        )
        {
            InitializeComponent();

            _transactionId = transactionId;
            _originalAmount = originalAmount;

            LoadTransactionInfo(
                transactionId,
                customer,
                vehicle,
                originalAmount,
                paymentMethod,
                transactionDate
            );

            InitializeRefundUI();
            WireEvents();
        }

        // =====================================================
        // INITIAL LOAD
        // =====================================================

        private void LoadTransactionInfo(
            int transactionId,
            string customer,
            string vehicle,
            decimal originalAmount,
            string paymentMethod,
            DateTime transactionDate
        )
        {
            lblTransactionIdValue.Text = transactionId.ToString();
            lblCustomerValue.Text = customer;
            lblVehicleValue.Text = vehicle;

            lblOriginalAmountValue.Text = $"₱{originalAmount:N2}";
            lblOriginalAmountSummary.Text = $"₱{originalAmount:N2}";

            lblPaymentMethodValue.Text = paymentMethod;
            lblTransactionDateValue.Text = transactionDate.ToString("yyyy-MM-dd");

            numRefundAmount.Maximum = originalAmount;
            numRefundAmount.Value = originalAmount;
        }

        private void InitializeRefundUI()
        {
            cmbRefundReason.SelectedIndex = 0;

            numDeductions.Value = 0;
            chkPartialRefund.Checked = false;

            UpdateFinalAmounts();
        }

        private void WireEvents()
        {
            btnCalculate.Click += (s, e) => UpdateFinalAmounts();
            btnProcessRefund.Click += OnProcessRefund;
            btnCancel.Click += (s, e) => Close();

            chkPartialRefund.CheckedChanged += (s, e) =>
            {
                numRefundAmount.Enabled = chkPartialRefund.Checked;
            };

            numRefundAmount.ValueChanged += (s, e) => UpdateFinalAmounts();
            numDeductions.ValueChanged += (s, e) => UpdateFinalAmounts();
        }

        // =====================================================
        // CALCULATIONS
        // =====================================================

        private void UpdateFinalAmounts()
        {
            decimal refundBase = chkPartialRefund.Checked
                ? numRefundAmount.Value
                : _originalAmount;

            decimal deductions = numDeductions.Value;
            decimal finalAmount = refundBase - deductions;

            if (finalAmount < 0)
                finalAmount = 0;

            lblFinalAmountValue.Text = $"₱{finalAmount:N2}";

            // Summary panel
            lblOriginalAmountSummary.Text = $"₱{_originalAmount:N2}";
            lblDeductionsSummary.Text = $"₱{deductions:N2}";
            lblRefundAmountSummary.Text = $"₱{finalAmount:N2}";
        }

        // =====================================================
        // PROCESS REFUND
        // =====================================================

        private void OnProcessRefund(object sender, EventArgs e)
        {
            decimal finalAmount =
                (chkPartialRefund.Checked ? numRefundAmount.Value : _originalAmount)
                - numDeductions.Value;

            if (finalAmount <= 0)
            {
                MessageBox.Show(
                    "Final refund amount must be greater than zero.",
                    "Invalid Amount",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (cmbRefundReason.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Please select a refund reason.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (MessageBox.Show(
                $"Confirm refund of ₱{finalAmount:N2}?",
                "Confirm Refund",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) != DialogResult.Yes)
                return;

            // TODO: Call refund service / stored procedure here
            // Example:
            // _refundService.ProcessRefund(...);

            MessageBox.Show(
                "Refund processed successfully.",
                "Refund Complete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
