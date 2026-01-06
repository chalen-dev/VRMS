namespace VRMS.Customer_side
{
    partial class CustomerVehicleCatalog
    {
        private System.ComponentModel.IContainer components = null;

        
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.FlowLayoutPanel flpVehicleGrid;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbTransmission;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.flpVehicleGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbTransmission = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.txtSearch);
            this.pnlHeader.Controls.Add(this.cmbCategory);
            this.pnlHeader.Controls.Add(this.cmbTransmission);
            this.pnlHeader.Controls.Add(this.btnApplyFilter);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 110;

            // Title
            this.lblTitle.Text = "Vehicle Catalog";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.AutoSize = true;

            this.txtSearch.Location = new System.Drawing.Point(25, 60);
            this.txtSearch.Size = new System.Drawing.Size(220, 25);
            this.txtSearch.Text = "Search make/model...";

            
            this.cmbCategory.Items.AddRange(new object[] { "All Categories", "Hatchback", "Sedan", "SUV", "Pickup", "Van" });
            this.cmbCategory.Location = new System.Drawing.Point(260, 60);
            this.cmbCategory.Size = new System.Drawing.Size(140, 25);
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            
            this.cmbTransmission.Items.AddRange(new object[] { "All Transmissions", "Manual", "Automatic" });
            this.cmbTransmission.Location = new System.Drawing.Point(410, 60);
            this.cmbTransmission.Size = new System.Drawing.Size(140, 25);
            this.cmbTransmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

           
            this.btnApplyFilter.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyFilter.ForeColor = System.Drawing.Color.White;
            this.btnApplyFilter.Text = "Apply Filters";
            this.btnApplyFilter.Location = new System.Drawing.Point(565, 58);
            this.btnApplyFilter.Size = new System.Drawing.Size(120, 30);

        
            this.flpVehicleGrid.AutoScroll = true;
            this.flpVehicleGrid.BackColor = System.Drawing.Color.White;
            this.flpVehicleGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpVehicleGrid.Padding = new System.Windows.Forms.Padding(15);

            // Main User Control
            this.Controls.Add(this.flpVehicleGrid);
            this.Controls.Add(this.pnlHeader);
            this.Size = new System.Drawing.Size(1031, 575);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}