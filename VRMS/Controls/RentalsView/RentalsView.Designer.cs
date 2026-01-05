namespace Vehicle_Rental_Management_System.Controls
{
    partial class RentalsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNewRental = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgvRentals = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblDetailAmount = new System.Windows.Forms.Label();
            this.lblDetailDates = new System.Windows.Forms.Label();
            this.lblDetailCustomer = new System.Windows.Forms.Label();
            this.lblDetailVehicle = new System.Windows.Forms.Label();
            this.pbVehicle = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbStatusFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVehicle)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(341, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Rental Operations";
            // 
            // btnNewRental
            // 
            this.btnNewRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnNewRental.FlatAppearance.BorderSize = 0;
            this.btnNewRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRental.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNewRental.ForeColor = System.Drawing.Color.White;
            this.btnNewRental.Location = new System.Drawing.Point(24, 75);
            this.btnNewRental.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewRental.Name = "btnNewRental";
            this.btnNewRental.Size = new System.Drawing.Size(160, 45);
            this.btnNewRental.TabIndex = 1;
            this.btnNewRental.Text = "➕ New Rental";
            this.btnNewRental.UseVisualStyleBackColor = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(192, 75);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(160, 45);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "↩ Return Vehicle";
            this.btnReturn.UseVisualStyleBackColor = false;
            // 
            // dgvRentals
            // 
            this.dgvRentals.AllowUserToAddRows = false;
            this.dgvRentals.AllowUserToResizeRows = false;
            this.dgvRentals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRentals.BackgroundColor = System.Drawing.Color.White;
            this.dgvRentals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRentals.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRentals.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRentals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRentals.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRentals.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRentals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRentals.EnableHeadersVisualStyles = false;
            this.dgvRentals.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRentals.Location = new System.Drawing.Point(0, 0);
            this.dgvRentals.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRentals.MultiSelect = false;
            this.dgvRentals.Name = "dgvRentals";
            this.dgvRentals.ReadOnly = true;
            this.dgvRentals.RowHeadersVisible = false;
            this.dgvRentals.RowHeadersWidth = 51;
            this.dgvRentals.RowTemplate.Height = 35;
            this.dgvRentals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentals.Size = new System.Drawing.Size(1072, 608);
            this.dgvRentals.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 130);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvRentals);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.lblDetailAmount);
            this.splitContainer1.Panel2.Controls.Add(this.lblDetailDates);
            this.splitContainer1.Panel2.Controls.Add(this.lblDetailCustomer);
            this.splitContainer1.Panel2.Controls.Add(this.lblDetailVehicle);
            this.splitContainer1.Panel2.Controls.Add(this.pbVehicle);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(15);
            this.splitContainer1.Size = new System.Drawing.Size(1631, 608);
            this.splitContainer1.SplitterDistance = 1072;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 4;
            // 
            // lblDetailAmount
            // 
            this.lblDetailAmount.AutoSize = true;
            this.lblDetailAmount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDetailAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblDetailAmount.Location = new System.Drawing.Point(36, 430);
            this.lblDetailAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailAmount.Name = "lblDetailAmount";
            this.lblDetailAmount.Size = new System.Drawing.Size(111, 25);
            this.lblDetailAmount.TabIndex = 4;
            this.lblDetailAmount.Text = "Total: ₱ 0.0";
            // 
            // lblDetailDates
            // 
            this.lblDetailDates.AutoSize = true;
            this.lblDetailDates.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetailDates.ForeColor = System.Drawing.Color.DimGray;
            this.lblDetailDates.Location = new System.Drawing.Point(36, 390);
            this.lblDetailDates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailDates.Name = "lblDetailDates";
            this.lblDetailDates.Size = new System.Drawing.Size(155, 23);
            this.lblDetailDates.TabIndex = 3;
            this.lblDetailDates.Text = "Period: Select entry";
            // 
            // lblDetailCustomer
            // 
            this.lblDetailCustomer.AutoSize = true;
            this.lblDetailCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblDetailCustomer.Location = new System.Drawing.Point(36, 350);
            this.lblDetailCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailCustomer.Name = "lblDetailCustomer";
            this.lblDetailCustomer.Size = new System.Drawing.Size(149, 25);
            this.lblDetailCustomer.TabIndex = 2;
            this.lblDetailCustomer.Text = "Customer Name";
            // 
            // lblDetailVehicle
            // 
            this.lblDetailVehicle.AutoSize = true;
            this.lblDetailVehicle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDetailVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblDetailVehicle.Location = new System.Drawing.Point(32, 305);
            this.lblDetailVehicle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailVehicle.Name = "lblDetailVehicle";
            this.lblDetailVehicle.Size = new System.Drawing.Size(166, 32);
            this.lblDetailVehicle.TabIndex = 1;
            this.lblDetailVehicle.Text = "Vehicle Name";
            // 
            // pbVehicle
            // 
            this.pbVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbVehicle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbVehicle.Location = new System.Drawing.Point(19, 19);
            this.pbVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.pbVehicle.Name = "pbVehicle";
            this.pbVehicle.Size = new System.Drawing.Size(511, 260);
            this.pbVehicle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVehicle.TabIndex = 0;
            this.pbVehicle.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnViewDetails);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.cbStatusFilter);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnNewRental);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1631, 130);
            this.panel1.TabIndex = 5;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnViewDetails.FlatAppearance.BorderSize = 0;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Location = new System.Drawing.Point(360, 75);
            this.btnViewDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(160, 45);
            this.btnViewDetails.TabIndex = 5;
            this.btnViewDetails.Text = "🔍 View Details";
            this.btnViewDetails.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(1376, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(233, 30);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.Text = "Search rentals...";
            // 
            // cbStatusFilter
            // 
            this.cbStatusFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatusFilter.FormattingEnabled = true;
            this.cbStatusFilter.Location = new System.Drawing.Point(1376, 75);
            this.cbStatusFilter.Name = "cbStatusFilter";
            this.cbStatusFilter.Size = new System.Drawing.Size(233, 31);
            this.cbStatusFilter.TabIndex = 3;
            // 
            // RentalsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RentalsView";
            this.Size = new System.Drawing.Size(1631, 738);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbVehicle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNewRental;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgvRentals;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDetailAmount;
        private System.Windows.Forms.Label lblDetailDates;
        private System.Windows.Forms.Label lblDetailCustomer;
        private System.Windows.Forms.Label lblDetailVehicle;
        private System.Windows.Forms.PictureBox pbVehicle;
        private System.Windows.Forms.ComboBox cbStatusFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnViewDetails;
    }
}