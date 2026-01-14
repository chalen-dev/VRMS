namespace VRMS.UI.Forms.Payments
{
    partial class RefundForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // ===== FORM CONTROLS =====
        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelMain;
        private Panel panelTransactionInfo;
        private Label lblTransactionIdTitle;
        private Label lblTransactionIdValue;
        private Label lblCustomerTitle;
        private Label lblCustomerValue;
        private Label lblVehicleTitle;
        private Label lblVehicleValue;
        private Label lblOriginalAmountTitle;
        private Label lblOriginalAmountValue;
        private Label lblPaymentMethodTitle;
        private Label lblPaymentMethodValue;
        private Label lblTransactionDateTitle;
        private Label lblTransactionDateValue;

        private Panel panelRefundDetails;
        private Label lblRefundAmountTitle;
        private NumericUpDown numRefundAmount;
        private Label lblRefundReasonTitle;
        private ComboBox cmbRefundReason;
        private CheckBox chkPartialRefund;
        private Label lblDeductionsTitle;
        private NumericUpDown numDeductions;
        private Label lblFinalAmountTitle;
        private Label lblFinalAmountValue;

        private Panel panelActions;
        private Button btnProcessRefund;
        private Button btnCancel;
        private Button btnCalculate;

        private Panel panelSummary;
        private Label lblRefundSummaryTitle;
        private Label lblOriginalAmountLabel;
        private Label lblOriginalAmountSummary;
        private Label lblDeductionsLabel;
        private Label lblDeductionsSummary;
        private Label lblRefundAmountLabel;
        private Label lblRefundAmountSummary;

        private ToolTip toolTip;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            panelMain = new Panel();
            panelSummary = new Panel();
            lblRefundAmountSummary = new Label();
            lblRefundAmountLabel = new Label();
            lblDeductionsSummary = new Label();
            lblDeductionsLabel = new Label();
            lblOriginalAmountSummary = new Label();
            lblOriginalAmountLabel = new Label();
            lblRefundSummaryTitle = new Label();
            panelRefundDetails = new Panel();
            lblFinalAmountValue = new Label();
            lblFinalAmountTitle = new Label();
            numDeductions = new NumericUpDown();
            lblDeductionsTitle = new Label();
            chkPartialRefund = new CheckBox();
            cmbRefundReason = new ComboBox();
            lblRefundReasonTitle = new Label();
            numRefundAmount = new NumericUpDown();
            lblRefundAmountTitle = new Label();
            panelTransactionInfo = new Panel();
            lblTransactionDateValue = new Label();
            lblTransactionDateTitle = new Label();
            lblPaymentMethodValue = new Label();
            lblPaymentMethodTitle = new Label();
            lblOriginalAmountValue = new Label();
            lblOriginalAmountTitle = new Label();
            lblVehicleValue = new Label();
            lblVehicleTitle = new Label();
            lblCustomerValue = new Label();
            lblCustomerTitle = new Label();
            lblTransactionIdValue = new Label();
            lblTransactionIdTitle = new Label();
            panelActions = new Panel();
            btnCalculate = new Button();
            btnCancel = new Button();
            btnProcessRefund = new Button();
            toolTip = new ToolTip(components);
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelSummary.SuspendLayout();
            panelRefundDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDeductions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRefundAmount).BeginInit();
            panelTransactionInfo.SuspendLayout();
            panelActions.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(30, 60, 90);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(900, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(249, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "💸 Process Refund";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(200, 200, 200);
            lblSubtitle.Location = new Point(33, 52);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(188, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Issue refund for transaction";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(panelSummary);
            panelMain.Controls.Add(panelRefundDetails);
            panelMain.Controls.Add(panelTransactionInfo);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 80);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(30, 20, 30, 20);
            panelMain.Size = new Size(900, 520);
            panelMain.TabIndex = 1;
            // 
            // panelSummary
            // 
            panelSummary.BackColor = Color.FromArgb(248, 249, 250);
            panelSummary.BorderStyle = BorderStyle.FixedSingle;
            panelSummary.Controls.Add(lblRefundAmountSummary);
            panelSummary.Controls.Add(lblRefundAmountLabel);
            panelSummary.Controls.Add(lblDeductionsSummary);
            panelSummary.Controls.Add(lblDeductionsLabel);
            panelSummary.Controls.Add(lblOriginalAmountSummary);
            panelSummary.Controls.Add(lblOriginalAmountLabel);
            panelSummary.Controls.Add(lblRefundSummaryTitle);
            panelSummary.Dock = DockStyle.Fill;
            panelSummary.Location = new Point(30, 320);
            panelSummary.Name = "panelSummary";
            panelSummary.Padding = new Padding(20, 15, 20, 15);
            panelSummary.Size = new Size(840, 180);
            panelSummary.TabIndex = 2;
            // 
            // lblRefundAmountSummary
            // 
            lblRefundAmountSummary.AutoSize = true;
            lblRefundAmountSummary.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblRefundAmountSummary.ForeColor = Color.FromArgb(46, 204, 113);
            lblRefundAmountSummary.Location = new Point(140, 125);
            lblRefundAmountSummary.Name = "lblRefundAmountSummary";
            lblRefundAmountSummary.Size = new Size(62, 28);
            lblRefundAmountSummary.TabIndex = 6;
            lblRefundAmountSummary.Text = "₱0.00";
            // 
            // lblRefundAmountLabel
            // 
            lblRefundAmountLabel.AutoSize = true;
            lblRefundAmountLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblRefundAmountLabel.ForeColor = Color.FromArgb(30, 60, 90);
            lblRefundAmountLabel.Location = new Point(20, 130);
            lblRefundAmountLabel.Name = "lblRefundAmountLabel";
            lblRefundAmountLabel.Size = new Size(121, 20);
            lblRefundAmountLabel.TabIndex = 5;
            lblRefundAmountLabel.Text = "Refund Amount:";
            // 
            // lblDeductionsSummary
            // 
            lblDeductionsSummary.AutoSize = true;
            lblDeductionsSummary.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblDeductionsSummary.ForeColor = Color.FromArgb(231, 76, 60);
            lblDeductionsSummary.Location = new Point(140, 90);
            lblDeductionsSummary.Name = "lblDeductionsSummary";
            lblDeductionsSummary.Size = new Size(51, 23);
            lblDeductionsSummary.TabIndex = 4;
            lblDeductionsSummary.Text = "₱0.00";
            // 
            // lblDeductionsLabel
            // 
            lblDeductionsLabel.AutoSize = true;
            lblDeductionsLabel.Font = new Font("Segoe UI", 9F);
            lblDeductionsLabel.ForeColor = Color.FromArgb(100, 100, 100);
            lblDeductionsLabel.Location = new Point(20, 93);
            lblDeductionsLabel.Name = "lblDeductionsLabel";
            lblDeductionsLabel.Size = new Size(87, 20);
            lblDeductionsLabel.TabIndex = 3;
            lblDeductionsLabel.Text = "Deductions:";
            // 
            // lblOriginalAmountSummary
            // 
            lblOriginalAmountSummary.AutoSize = true;
            lblOriginalAmountSummary.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblOriginalAmountSummary.ForeColor = Color.FromArgb(30, 60, 90);
            lblOriginalAmountSummary.Location = new Point(140, 55);
            lblOriginalAmountSummary.Name = "lblOriginalAmountSummary";
            lblOriginalAmountSummary.Size = new Size(82, 23);
            lblOriginalAmountSummary.TabIndex = 2;
            lblOriginalAmountSummary.Text = "₱5,000.00";
            // 
            // lblOriginalAmountLabel
            // 
            lblOriginalAmountLabel.AutoSize = true;
            lblOriginalAmountLabel.Font = new Font("Segoe UI", 9F);
            lblOriginalAmountLabel.ForeColor = Color.FromArgb(100, 100, 100);
            lblOriginalAmountLabel.Location = new Point(20, 58);
            lblOriginalAmountLabel.Name = "lblOriginalAmountLabel";
            lblOriginalAmountLabel.Size = new Size(122, 20);
            lblOriginalAmountLabel.TabIndex = 1;
            lblOriginalAmountLabel.Text = "Original Amount:";
            // 
            // lblRefundSummaryTitle
            // 
            lblRefundSummaryTitle.AutoSize = true;
            lblRefundSummaryTitle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblRefundSummaryTitle.ForeColor = Color.FromArgb(30, 60, 90);
            lblRefundSummaryTitle.Location = new Point(20, 15);
            lblRefundSummaryTitle.Name = "lblRefundSummaryTitle";
            lblRefundSummaryTitle.Size = new Size(161, 25);
            lblRefundSummaryTitle.TabIndex = 0;
            lblRefundSummaryTitle.Text = "Refund Summary";
            // 
            // panelRefundDetails
            // 
            panelRefundDetails.BackColor = Color.White;
            panelRefundDetails.Controls.Add(lblFinalAmountValue);
            panelRefundDetails.Controls.Add(lblFinalAmountTitle);
            panelRefundDetails.Controls.Add(numDeductions);
            panelRefundDetails.Controls.Add(lblDeductionsTitle);
            panelRefundDetails.Controls.Add(chkPartialRefund);
            panelRefundDetails.Controls.Add(cmbRefundReason);
            panelRefundDetails.Controls.Add(lblRefundReasonTitle);
            panelRefundDetails.Controls.Add(numRefundAmount);
            panelRefundDetails.Controls.Add(lblRefundAmountTitle);
            panelRefundDetails.Dock = DockStyle.Top;
            panelRefundDetails.Location = new Point(30, 180);
            panelRefundDetails.Name = "panelRefundDetails";
            panelRefundDetails.Size = new Size(840, 140);
            panelRefundDetails.TabIndex = 1;
            // 
            // lblFinalAmountValue
            // 
            lblFinalAmountValue.AutoSize = true;
            lblFinalAmountValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblFinalAmountValue.ForeColor = Color.FromArgb(231, 76, 60);
            lblFinalAmountValue.Location = new Point(680, 62);
            lblFinalAmountValue.Name = "lblFinalAmountValue";
            lblFinalAmountValue.Size = new Size(62, 28);
            lblFinalAmountValue.TabIndex = 10;
            lblFinalAmountValue.Text = "₱0.00";
            // 
            // lblFinalAmountTitle
            // 
            lblFinalAmountTitle.AutoSize = true;
            lblFinalAmountTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblFinalAmountTitle.ForeColor = Color.FromArgb(30, 60, 90);
            lblFinalAmountTitle.Location = new Point(530, 67);
            lblFinalAmountTitle.Name = "lblFinalAmountTitle";
            lblFinalAmountTitle.Size = new Size(117, 23);
            lblFinalAmountTitle.TabIndex = 9;
            lblFinalAmountTitle.Text = "Final Amount:";
            // 
            // numDeductions
            // 
            numDeductions.DecimalPlaces = 2;
            numDeductions.Font = new Font("Segoe UI", 9F);
            numDeductions.Location = new Point(680, 27);
            numDeductions.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numDeductions.Name = "numDeductions";
            numDeductions.Size = new Size(140, 27);
            numDeductions.TabIndex = 8;
            numDeductions.TextAlign = HorizontalAlignment.Right;
            numDeductions.ThousandsSeparator = true;
            // 
            // lblDeductionsTitle
            // 
            lblDeductionsTitle.AutoSize = true;
            lblDeductionsTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDeductionsTitle.ForeColor = Color.FromArgb(30, 60, 90);
            lblDeductionsTitle.Location = new Point(530, 30);
            lblDeductionsTitle.Name = "lblDeductionsTitle";
            lblDeductionsTitle.Size = new Size(113, 20);
            lblDeductionsTitle.TabIndex = 7;
            lblDeductionsTitle.Text = "Deductions (₱):";
            // 
            // chkPartialRefund
            // 
            chkPartialRefund.AutoSize = true;
            chkPartialRefund.Font = new Font("Segoe UI", 9F);
            chkPartialRefund.Location = new Point(181, 91);
            chkPartialRefund.Name = "chkPartialRefund";
            chkPartialRefund.Size = new Size(123, 24);
            chkPartialRefund.TabIndex = 6;
            chkPartialRefund.Text = "Partial Refund";
            chkPartialRefund.UseVisualStyleBackColor = true;
            // 
            // cmbRefundReason
            // 
            cmbRefundReason.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRefundReason.Font = new Font("Segoe UI", 9F);
            cmbRefundReason.FormattingEnabled = true;
            cmbRefundReason.Items.AddRange(new object[] { "Customer Cancellation", "Vehicle Unavailable", "Service Issue", "Double Payment", "Overcharged", "Other" });
            cmbRefundReason.Location = new Point(181, 58);
            cmbRefundReason.Name = "cmbRefundReason";
            cmbRefundReason.Size = new Size(270, 28);
            cmbRefundReason.TabIndex = 3;
            // 
            // lblRefundReasonTitle
            // 
            lblRefundReasonTitle.AutoSize = true;
            lblRefundReasonTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblRefundReasonTitle.ForeColor = Color.FromArgb(30, 60, 90);
            lblRefundReasonTitle.Location = new Point(31, 61);
            lblRefundReasonTitle.Name = "lblRefundReasonTitle";
            lblRefundReasonTitle.Size = new Size(115, 20);
            lblRefundReasonTitle.TabIndex = 2;
            lblRefundReasonTitle.Text = "Refund Reason:";
            // 
            // numRefundAmount
            // 
            numRefundAmount.DecimalPlaces = 2;
            numRefundAmount.Font = new Font("Segoe UI", 9F);
            numRefundAmount.Location = new Point(181, 23);
            numRefundAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numRefundAmount.Name = "numRefundAmount";
            numRefundAmount.Size = new Size(140, 27);
            numRefundAmount.TabIndex = 1;
            numRefundAmount.TextAlign = HorizontalAlignment.Right;
            numRefundAmount.ThousandsSeparator = true;
            // 
            // lblRefundAmountTitle
            // 
            lblRefundAmountTitle.AutoSize = true;
            lblRefundAmountTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblRefundAmountTitle.ForeColor = Color.FromArgb(30, 60, 90);
            lblRefundAmountTitle.Location = new Point(31, 26);
            lblRefundAmountTitle.Name = "lblRefundAmountTitle";
            lblRefundAmountTitle.Size = new Size(121, 20);
            lblRefundAmountTitle.TabIndex = 0;
            lblRefundAmountTitle.Text = "Refund Amount:";
            // 
            // panelTransactionInfo
            // 
            panelTransactionInfo.BackColor = Color.FromArgb(248, 249, 250);
            panelTransactionInfo.BorderStyle = BorderStyle.FixedSingle;
            panelTransactionInfo.Controls.Add(lblTransactionDateValue);
            panelTransactionInfo.Controls.Add(lblTransactionDateTitle);
            panelTransactionInfo.Controls.Add(lblPaymentMethodValue);
            panelTransactionInfo.Controls.Add(lblPaymentMethodTitle);
            panelTransactionInfo.Controls.Add(lblOriginalAmountValue);
            panelTransactionInfo.Controls.Add(lblOriginalAmountTitle);
            panelTransactionInfo.Controls.Add(lblVehicleValue);
            panelTransactionInfo.Controls.Add(lblVehicleTitle);
            panelTransactionInfo.Controls.Add(lblCustomerValue);
            panelTransactionInfo.Controls.Add(lblCustomerTitle);
            panelTransactionInfo.Controls.Add(lblTransactionIdValue);
            panelTransactionInfo.Controls.Add(lblTransactionIdTitle);
            panelTransactionInfo.Dock = DockStyle.Top;
            panelTransactionInfo.Location = new Point(30, 20);
            panelTransactionInfo.Name = "panelTransactionInfo";
            panelTransactionInfo.Padding = new Padding(20, 15, 20, 15);
            panelTransactionInfo.Size = new Size(840, 160);
            panelTransactionInfo.TabIndex = 0;
            // 
            // lblTransactionDateValue
            // 
            lblTransactionDateValue.AutoSize = true;
            lblTransactionDateValue.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTransactionDateValue.ForeColor = Color.FromArgb(30, 60, 90);
            lblTransactionDateValue.Location = new Point(630, 120);
            lblTransactionDateValue.Name = "lblTransactionDateValue";
            lblTransactionDateValue.Size = new Size(82, 20);
            lblTransactionDateValue.TabIndex = 11;
            lblTransactionDateValue.Text = "2024-01-15";
            // 
            // lblTransactionDateTitle
            // 
            lblTransactionDateTitle.AutoSize = true;
            lblTransactionDateTitle.Font = new Font("Segoe UI", 9F);
            lblTransactionDateTitle.ForeColor = Color.FromArgb(100, 100, 100);
            lblTransactionDateTitle.Location = new Point(490, 120);
            lblTransactionDateTitle.Name = "lblTransactionDateTitle";
            lblTransactionDateTitle.Size = new Size(123, 20);
            lblTransactionDateTitle.TabIndex = 10;
            lblTransactionDateTitle.Text = "Transaction Date:";
            // 
            // lblPaymentMethodValue
            // 
            lblPaymentMethodValue.AutoSize = true;
            lblPaymentMethodValue.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPaymentMethodValue.ForeColor = Color.FromArgb(46, 204, 113);
            lblPaymentMethodValue.Location = new Point(630, 90);
            lblPaymentMethodValue.Name = "lblPaymentMethodValue";
            lblPaymentMethodValue.Size = new Size(51, 20);
            lblPaymentMethodValue.TabIndex = 9;
            lblPaymentMethodValue.Text = "GCash";
            // 
            // lblPaymentMethodTitle
            // 
            lblPaymentMethodTitle.AutoSize = true;
            lblPaymentMethodTitle.Font = new Font("Segoe UI", 9F);
            lblPaymentMethodTitle.ForeColor = Color.FromArgb(100, 100, 100);
            lblPaymentMethodTitle.Location = new Point(490, 90);
            lblPaymentMethodTitle.Name = "lblPaymentMethodTitle";
            lblPaymentMethodTitle.Size = new Size(124, 20);
            lblPaymentMethodTitle.TabIndex = 8;
            lblPaymentMethodTitle.Text = "Payment Method:";
            // 
            // lblOriginalAmountValue
            // 
            lblOriginalAmountValue.AutoSize = true;
            lblOriginalAmountValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblOriginalAmountValue.ForeColor = Color.FromArgb(46, 204, 113);
            lblOriginalAmountValue.Location = new Point(630, 55);
            lblOriginalAmountValue.Name = "lblOriginalAmountValue";
            lblOriginalAmountValue.Size = new Size(100, 28);
            lblOriginalAmountValue.TabIndex = 7;
            lblOriginalAmountValue.Text = "₱5,000.00";
            // 
            // lblOriginalAmountTitle
            // 
            lblOriginalAmountTitle.AutoSize = true;
            lblOriginalAmountTitle.Font = new Font("Segoe UI", 9F);
            lblOriginalAmountTitle.ForeColor = Color.FromArgb(100, 100, 100);
            lblOriginalAmountTitle.Location = new Point(490, 60);
            lblOriginalAmountTitle.Name = "lblOriginalAmountTitle";
            lblOriginalAmountTitle.Size = new Size(122, 20);
            lblOriginalAmountTitle.TabIndex = 6;
            lblOriginalAmountTitle.Text = "Original Amount:";
            // 
            // lblVehicleValue
            // 
            lblVehicleValue.AutoSize = true;
            lblVehicleValue.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblVehicleValue.ForeColor = Color.FromArgb(30, 60, 90);
            lblVehicleValue.Location = new Point(180, 90);
            lblVehicleValue.Name = "lblVehicleValue";
            lblVehicleValue.Size = new Size(104, 20);
            lblVehicleValue.TabIndex = 5;
            lblVehicleValue.Text = "Toyota Camry";
            // 
            // lblVehicleTitle
            // 
            lblVehicleTitle.AutoSize = true;
            lblVehicleTitle.Font = new Font("Segoe UI", 9F);
            lblVehicleTitle.ForeColor = Color.FromArgb(100, 100, 100);
            lblVehicleTitle.Location = new Point(20, 90);
            lblVehicleTitle.Name = "lblVehicleTitle";
            lblVehicleTitle.Size = new Size(59, 20);
            lblVehicleTitle.TabIndex = 4;
            lblVehicleTitle.Text = "Vehicle:";
            // 
            // lblCustomerValue
            // 
            lblCustomerValue.AutoSize = true;
            lblCustomerValue.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCustomerValue.ForeColor = Color.FromArgb(30, 60, 90);
            lblCustomerValue.Location = new Point(180, 60);
            lblCustomerValue.Name = "lblCustomerValue";
            lblCustomerValue.Size = new Size(119, 20);
            lblCustomerValue.TabIndex = 3;
            lblCustomerValue.Text = "John D. (ID: 123)";
            // 
            // lblCustomerTitle
            // 
            lblCustomerTitle.AutoSize = true;
            lblCustomerTitle.Font = new Font("Segoe UI", 9F);
            lblCustomerTitle.ForeColor = Color.FromArgb(100, 100, 100);
            lblCustomerTitle.Location = new Point(20, 60);
            lblCustomerTitle.Name = "lblCustomerTitle";
            lblCustomerTitle.Size = new Size(75, 20);
            lblCustomerTitle.TabIndex = 2;
            lblCustomerTitle.Text = "Customer:";
            // 
            // lblTransactionIdValue
            // 
            lblTransactionIdValue.AutoSize = true;
            lblTransactionIdValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTransactionIdValue.ForeColor = Color.FromArgb(30, 60, 90);
            lblTransactionIdValue.Location = new Point(180, 20);
            lblTransactionIdValue.Name = "lblTransactionIdValue";
            lblTransactionIdValue.Size = new Size(56, 28);
            lblTransactionIdValue.TabIndex = 1;
            lblTransactionIdValue.Text = "5678";
            // 
            // lblTransactionIdTitle
            // 
            lblTransactionIdTitle.AutoSize = true;
            lblTransactionIdTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTransactionIdTitle.ForeColor = Color.FromArgb(30, 60, 90);
            lblTransactionIdTitle.Location = new Point(20, 25);
            lblTransactionIdTitle.Name = "lblTransactionIdTitle";
            lblTransactionIdTitle.Size = new Size(116, 23);
            lblTransactionIdTitle.TabIndex = 0;
            lblTransactionIdTitle.Text = "Transaction #:";
            // 
            // panelActions
            // 
            panelActions.BackColor = Color.White;
            panelActions.Controls.Add(btnCalculate);
            panelActions.Controls.Add(btnCancel);
            panelActions.Controls.Add(btnProcessRefund);
            panelActions.Dock = DockStyle.Bottom;
            panelActions.Location = new Point(0, 520);
            panelActions.Name = "panelActions";
            panelActions.Padding = new Padding(30, 20, 30, 20);
            panelActions.Size = new Size(900, 80);
            panelActions.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.FromArgb(52, 152, 219);
            btnCalculate.FlatAppearance.BorderSize = 0;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(30, 20);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(120, 40);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "\U0001f9ee Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(108, 117, 125);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(750, 20);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "❌ Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnProcessRefund
            // 
            btnProcessRefund.BackColor = Color.FromArgb(46, 204, 113);
            btnProcessRefund.FlatAppearance.BorderSize = 0;
            btnProcessRefund.FlatStyle = FlatStyle.Flat;
            btnProcessRefund.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnProcessRefund.ForeColor = Color.White;
            btnProcessRefund.Location = new Point(600, 20);
            btnProcessRefund.Name = "btnProcessRefund";
            btnProcessRefund.Size = new Size(120, 40);
            btnProcessRefund.TabIndex = 0;
            btnProcessRefund.Text = "💸 Process Refund";
            btnProcessRefund.UseVisualStyleBackColor = false;
            // 
            // RefundForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 600);
            Controls.Add(panelActions);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RefundForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Process Refund";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelSummary.ResumeLayout(false);
            panelSummary.PerformLayout();
            panelRefundDetails.ResumeLayout(false);
            panelRefundDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDeductions).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRefundAmount).EndInit();
            panelTransactionInfo.ResumeLayout(false);
            panelTransactionInfo.PerformLayout();
            panelActions.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
    }
}