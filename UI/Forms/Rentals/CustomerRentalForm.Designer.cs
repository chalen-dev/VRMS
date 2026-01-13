namespace VRMS.UI.Forms.Rentals
{
    partial class CustomerRentalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            label1 = new Label();
            label2 = new Label();
            lblTotal = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            label6 = new Label();
            dtPickup = new DateTimePicker();
            label7 = new Label();
            dtReturn = new DateTimePicker();
            pnlHeader = new Panel();
            lblHeaderTitle = new Label();
            btnSelectVehicle = new Button();
            lblSelectedVehicle = new Label();
            btnClearVehicle = new Button();
            panelVehicle = new Panel();
            lblVehicleFeatures = new Label();
            lblVehiclePrice = new Label();
            lblVehicleInfo = new Label();
            lblDailyRate = new Label();
            lblDays = new Label();
            lblTotalDays = new Label();
            lblDuration = new Label();
            pnlHeader.SuspendLayout();
            panelVehicle.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(26, 116);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Hello, Customer!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(26, 208);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 2;
            label2.Text = "Select Vehicle:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(46, 204, 113);
            lblTotal.Location = new Point(27, 423);
            lblTotal.Margin = new Padding(5, 0, 5, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(200, 41);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "Total: ₱0.00";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 204, 113);
            btnSave.Enabled = false;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(358, 575);
            btnSave.Margin = new Padding(5, 4, 5, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(266, 69);
            btnSave.TabIndex = 11;
            btnSave.Text = "Confirm Rental";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(189, 195, 199);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(44, 62, 80);
            btnCancel.Location = new Point(172, 575);
            btnCancel.Margin = new Padding(5, 4, 5, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(160, 69);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(26, 300);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 13;
            label6.Text = "Pickup Date:";
            // 
            // dtPickup
            // 
            dtPickup.Font = new Font("Segoe UI", 10F);
            dtPickup.Format = DateTimePickerFormat.Short;
            dtPickup.Location = new Point(26, 331);
            dtPickup.Margin = new Padding(5, 4, 5, 4);
            dtPickup.Name = "dtPickup";
            dtPickup.Size = new Size(266, 30);
            dtPickup.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(320, 300);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 15;
            label7.Text = "Return Date:";
            // 
            // dtReturn
            // 
            dtReturn.Font = new Font("Segoe UI", 10F);
            dtReturn.Format = DateTimePickerFormat.Short;
            dtReturn.Location = new Point(320, 331);
            dtReturn.Margin = new Padding(5, 4, 5, 4);
            dtReturn.Name = "dtReturn";
            dtReturn.Size = new Size(292, 30);
            dtReturn.TabIndex = 16;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(52, 73, 94);
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(5, 4, 5, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(646, 92);
            pnlHeader.TabIndex = 17;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(21, 23);
            lblHeaderTitle.Margin = new Padding(5, 0, 5, 0);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(237, 37);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Book Your Rental";
            // 
            // btnSelectVehicle
            // 
            btnSelectVehicle.BackColor = Color.FromArgb(52, 152, 219);
            btnSelectVehicle.FlatAppearance.BorderSize = 0;
            btnSelectVehicle.FlatStyle = FlatStyle.Flat;
            btnSelectVehicle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnSelectVehicle.ForeColor = Color.White;
            btnSelectVehicle.Location = new Point(0, 0);
            btnSelectVehicle.Margin = new Padding(5, 4, 5, 4);
            btnSelectVehicle.Name = "btnSelectVehicle";
            btnSelectVehicle.Size = new Size(160, 43);
            btnSelectVehicle.TabIndex = 20;
            btnSelectVehicle.Text = "Select Vehicle";
            btnSelectVehicle.UseVisualStyleBackColor = false;
            btnSelectVehicle.Click += btnSelectVehicle_Click;
            // 
            // lblSelectedVehicle
            // 
            lblSelectedVehicle.AutoSize = true;
            lblSelectedVehicle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectedVehicle.ForeColor = Color.FromArgb(44, 62, 80);
            lblSelectedVehicle.Location = new Point(167, 8);
            lblSelectedVehicle.Margin = new Padding(5, 0, 5, 0);
            lblSelectedVehicle.Name = "lblSelectedVehicle";
            lblSelectedVehicle.Size = new Size(118, 23);
            lblSelectedVehicle.TabIndex = 21;
            lblSelectedVehicle.Text = "Not selected...";
            lblSelectedVehicle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnClearVehicle
            // 
            btnClearVehicle.BackColor = Color.FromArgb(231, 76, 60);
            btnClearVehicle.FlatAppearance.BorderSize = 0;
            btnClearVehicle.FlatStyle = FlatStyle.Flat;
            btnClearVehicle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClearVehicle.ForeColor = Color.White;
            btnClearVehicle.Location = new Point(434, 0);
            btnClearVehicle.Margin = new Padding(5, 4, 5, 4);
            btnClearVehicle.Name = "btnClearVehicle";
            btnClearVehicle.Size = new Size(152, 43);
            btnClearVehicle.TabIndex = 23;
            btnClearVehicle.Text = "Clear Selection";
            btnClearVehicle.UseVisualStyleBackColor = false;
            btnClearVehicle.Visible = false;
            // 
            // panelVehicle
            // 
            panelVehicle.BackColor = Color.White;
            panelVehicle.BorderStyle = BorderStyle.FixedSingle;
            panelVehicle.Controls.Add(lblVehicleFeatures);
            panelVehicle.Controls.Add(lblVehiclePrice);
            panelVehicle.Controls.Add(lblVehicleInfo);
            panelVehicle.Controls.Add(btnSelectVehicle);
            panelVehicle.Controls.Add(lblSelectedVehicle);
            panelVehicle.Controls.Add(btnClearVehicle);
            panelVehicle.Location = new Point(26, 236);
            panelVehicle.Margin = new Padding(5, 4, 5, 4);
            panelVehicle.Name = "panelVehicle";
            panelVehicle.Size = new Size(586, 42);
            panelVehicle.TabIndex = 25;
            // 
            // lblVehicleFeatures
            // 
            lblVehicleFeatures.AutoSize = true;
            lblVehicleFeatures.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVehicleFeatures.ForeColor = Color.DimGray;
            lblVehicleFeatures.Location = new Point(331, 12);
            lblVehicleFeatures.Margin = new Padding(5, 0, 5, 0);
            lblVehicleFeatures.Name = "lblVehicleFeatures";
            lblVehicleFeatures.Size = new Size(0, 19);
            lblVehicleFeatures.TabIndex = 26;
            // 
            // lblVehiclePrice
            // 
            lblVehiclePrice.AutoSize = true;
            lblVehiclePrice.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVehiclePrice.ForeColor = Color.FromArgb(46, 204, 113);
            lblVehiclePrice.Location = new Point(331, 12);
            lblVehiclePrice.Margin = new Padding(5, 0, 5, 0);
            lblVehiclePrice.Name = "lblVehiclePrice";
            lblVehiclePrice.Size = new Size(0, 20);
            lblVehiclePrice.TabIndex = 25;
            // 
            // lblVehicleInfo
            // 
            lblVehicleInfo.AutoSize = true;
            lblVehicleInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVehicleInfo.ForeColor = Color.FromArgb(44, 62, 80);
            lblVehicleInfo.Location = new Point(331, 12);
            lblVehicleInfo.Margin = new Padding(5, 0, 5, 0);
            lblVehicleInfo.Name = "lblVehicleInfo";
            lblVehicleInfo.Size = new Size(0, 20);
            lblVehicleInfo.TabIndex = 24;
            // 
            // lblDailyRate
            // 
            lblDailyRate.AutoSize = true;
            lblDailyRate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDailyRate.ForeColor = Color.DimGray;
            lblDailyRate.Location = new Point(27, 474);
            lblDailyRate.Margin = new Padding(5, 0, 5, 0);
            lblDailyRate.Name = "lblDailyRate";
            lblDailyRate.Size = new Size(80, 20);
            lblDailyRate.TabIndex = 26;
            lblDailyRate.Text = "Daily Rate:";
            lblDailyRate.Visible = false;
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDays.ForeColor = Color.DimGray;
            lblDays.Location = new Point(172, 474);
            lblDays.Margin = new Padding(5, 0, 5, 0);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(44, 20);
            lblDays.TabIndex = 27;
            lblDays.Text = "Days:";
            lblDays.Visible = false;
            // 
            // lblTotalDays
            // 
            lblTotalDays.AutoSize = true;
            lblTotalDays.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDays.ForeColor = Color.FromArgb(44, 62, 80);
            lblTotalDays.Location = new Point(218, 474);
            lblTotalDays.Margin = new Padding(5, 0, 5, 0);
            lblTotalDays.Name = "lblTotalDays";
            lblTotalDays.Size = new Size(17, 20);
            lblTotalDays.TabIndex = 28;
            lblTotalDays.Text = "0";
            lblTotalDays.Visible = false;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDuration.ForeColor = Color.DimGray;
            lblDuration.Location = new Point(321, 474);
            lblDuration.Margin = new Padding(5, 0, 5, 0);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(70, 20);
            lblDuration.TabIndex = 29;
            lblDuration.Text = "Duration:";
            lblDuration.Visible = false;
            // 
            // CustomerRentalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(646, 670);
            Controls.Add(lblDuration);
            Controls.Add(lblTotalDays);
            Controls.Add(lblDays);
            Controls.Add(lblDailyRate);
            Controls.Add(panelVehicle);
            Controls.Add(pnlHeader);
            Controls.Add(dtReturn);
            Controls.Add(label7);
            Controls.Add(dtPickup);
            Controls.Add(label6);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblTotal);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomerRentalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Your Rental";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panelVehicle.ResumeLayout(false);
            panelVehicle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtPickup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtReturn;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Button btnSelectVehicle;
        private System.Windows.Forms.Label lblSelectedVehicle;
        private System.Windows.Forms.Button btnClearVehicle;
        private System.Windows.Forms.Panel panelVehicle;
        private System.Windows.Forms.Label lblVehicleInfo;
        private System.Windows.Forms.Label lblVehicleFeatures;
        private System.Windows.Forms.Label lblVehiclePrice;
        private System.Windows.Forms.Label lblDailyRate;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblTotalDays;
        private System.Windows.Forms.Label lblDuration;
    }
}