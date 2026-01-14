using System;
using System.Windows.Forms;
using VRMS.UI.Forms.Payments;

namespace VRMS.UI.Controls.History
{
    public partial class History : UserControl
    {
        public History()
        {
            InitializeComponent();
            InitializeUI();
        }

        // =====================================================
        // INIT
        // =====================================================

        private void InitializeUI()
        {
            WireEvents();
        }

        private void WireEvents()
        {
            btnRefund.Click += OnRefundClick;

            btnCancel.Click += (s, e) =>
            {
                MessageBox.Show("Cancel clicked", "Info");
            };

            btnViewReceipt.Click += (s, e) =>
            {
                MessageBox.Show("View receipt clicked", "Info");
            };

            btnPrint.Click += (s, e) =>
            {
                MessageBox.Show("Print clicked", "Info");
            };
        }

        // =====================================================
        // REFUND BUTTON
        // =====================================================

        private void OnRefundClick(object sender, EventArgs e)
        {
            // 🔹 TEMP SAMPLE DATA (NO SELECTION LOGIC)
            int transactionId = 5678;
            string customer = "John D. (ID: 123)";
            string vehicle = "Toyota Camry 2023";
            decimal originalAmount = 5000m;
            string paymentMethod = "GCash";
            DateTime transactionDate = DateTime.Today;

            var refundForm = new RefundForm(
                transactionId,
                customer,
                vehicle,
                originalAmount,
                paymentMethod,
                transactionDate
            );

            refundForm.ShowDialog(this);
        }
    }
}
