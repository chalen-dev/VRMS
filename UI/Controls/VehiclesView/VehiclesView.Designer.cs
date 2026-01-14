namespace VRMS.Controls
{
    partial class VehiclesView
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
            panelHeader = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            lblVehicleCount = new System.Windows.Forms.Label();
            panelToolbar = new System.Windows.Forms.Panel();
            btnUnderMaintenance = new System.Windows.Forms.Button();
            btnAddCategory = new System.Windows.Forms.Button();
            panelSearch = new System.Windows.Forms.Panel();
            txtSearch = new System.Windows.Forms.TextBox();
            cmbStatusFilter = new System.Windows.Forms.ComboBox();
            btnRetire = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            splitContainerMain = new System.Windows.Forms.SplitContainer();
            panelVehicleList = new System.Windows.Forms.Panel();
            dgvVehicles = new System.Windows.Forms.DataGridView();
            panelStatusFilter = new System.Windows.Forms.Panel();
            cmbAdvancedFilter = new System.Windows.Forms.ComboBox();
            lblStatusFilter = new System.Windows.Forms.Label();
            panelVehicleDetails = new System.Windows.Forms.Panel();
            panelFeatures = new System.Windows.Forms.Panel();
            flowLayoutPanelFeatures = new System.Windows.Forms.FlowLayoutPanel();
            lblFeaturesTitle = new System.Windows.Forms.Label();
            panelVehicleInfo = new System.Windows.Forms.Panel();
            lblMileageValue = new System.Windows.Forms.Label();
            lblMileage = new System.Windows.Forms.Label();
            lblPlateValue = new System.Windows.Forms.Label();
            lblPlate = new System.Windows.Forms.Label();
            lblDailyRateValue = new System.Windows.Forms.Label();
            lblDailyRate = new System.Windows.Forms.Label();
            lblYearColorValue = new System.Windows.Forms.Label();
            lblYearColor = new System.Windows.Forms.Label();
            lblCategoryValue = new System.Windows.Forms.Label();
            lblStatusValue = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();
            lblCategory = new System.Windows.Forms.Label();
            lblMakeModel = new System.Windows.Forms.Label();
            lblDetailsTitle = new System.Windows.Forms.Label();
            panelPreviewHeader = new System.Windows.Forms.Panel();
            lblVehicleDetails = new System.Windows.Forms.Label();
            picVehiclePreview = new System.Windows.Forms.PictureBox();
            panelHeader.SuspendLayout();
            panelToolbar.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            panelVehicleList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).BeginInit();
            panelStatusFilter.SuspendLayout();
            panelVehicleDetails.SuspendLayout();
            panelFeatures.SuspendLayout();
            panelVehicleInfo.SuspendLayout();
            panelPreviewHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picVehiclePreview).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)60)), ((int)((byte)90)));
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(lblVehicleCount);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Location = new System.Drawing.Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new System.Drawing.Size(1491, 70);
            panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(20, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(127, 41);
            label1.TabIndex = 0;
            label1.Text = "Vehicles";
            // 
            // lblVehicleCount
            // 
            lblVehicleCount.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            lblVehicleCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblVehicleCount.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)200)), ((int)((byte)200)), ((int)((byte)200)));
            lblVehicleCount.Location = new System.Drawing.Point(1291, 15);
            lblVehicleCount.Name = "lblVehicleCount";
            lblVehicleCount.Size = new System.Drawing.Size(180, 40);
            lblVehicleCount.TabIndex = 1;
            lblVehicleCount.Text = "Total: 0 vehicles";
            lblVehicleCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelToolbar
            // 
            panelToolbar.BackColor = System.Drawing.Color.White;
            panelToolbar.Controls.Add(btnUnderMaintenance);
            panelToolbar.Controls.Add(btnAddCategory);
            panelToolbar.Controls.Add(panelSearch);
            panelToolbar.Controls.Add(cmbStatusFilter);
            panelToolbar.Controls.Add(btnRetire);
            panelToolbar.Controls.Add(btnDelete);
            panelToolbar.Controls.Add(btnEdit);
            panelToolbar.Controls.Add(btnAdd);
            panelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            panelToolbar.Location = new System.Drawing.Point(0, 70);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            panelToolbar.Size = new System.Drawing.Size(1491, 60);
            panelToolbar.TabIndex = 1;
            // 
            // btnUnderMaintenance
            // 
            btnUnderMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnUnderMaintenance.BackColor = System.Drawing.Color.Gold;
            btnUnderMaintenance.FlatAppearance.BorderSize = 0;
            btnUnderMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUnderMaintenance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnUnderMaintenance.ForeColor = System.Drawing.Color.White;
            btnUnderMaintenance.Location = new System.Drawing.Point(756, 10);
            btnUnderMaintenance.Name = "btnUnderMaintenance";
            btnUnderMaintenance.Size = new System.Drawing.Size(184, 40);
            btnUnderMaintenance.TabIndex = 9;
            btnUnderMaintenance.Text = "🔧 Under Maintenance";
            btnUnderMaintenance.UseVisualStyleBackColor = false;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)((byte)128)), ((int)((byte)128)), ((int)((byte)255)));
            btnAddCategory.FlatAppearance.BorderSize = 0;
            btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnAddCategory.ForeColor = System.Drawing.Color.White;
            btnAddCategory.Location = new System.Drawing.Point(1329, 11);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new System.Drawing.Size(119, 40);
            btnAddCategory.TabIndex = 7;
            btnAddCategory.Text = "➕ Categories";
            btnAddCategory.UseVisualStyleBackColor = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // panelSearch
            // 
            panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)249)), ((int)((byte)250)));
            panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Location = new System.Drawing.Point(15, 10);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new System.Drawing.Size(415, 40);
            panelSearch.TabIndex = 6;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtSearch.Location = new System.Drawing.Point(35, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍 Search vehicles...";
            txtSearch.Size = new System.Drawing.Size(310, 23);
            txtSearch.TabIndex = 1;
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbStatusFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Items.AddRange(new object[] { "🚗 All Vehicles", "✅ Available", "🔧 Under Maintenance", "🚗 Rented", "📅 Reserved", "♻ Retired" });
            cmbStatusFilter.Location = new System.Drawing.Point(462, 18);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new System.Drawing.Size(160, 28);
            cmbStatusFilter.TabIndex = 5;
            // 
            // btnRetire
            // 
            btnRetire.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnRetire.BackColor = System.Drawing.Color.FromArgb(((int)((byte)150)), ((int)((byte)150)), ((int)((byte)150)));
            btnRetire.FlatAppearance.BorderSize = 0;
            btnRetire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRetire.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnRetire.ForeColor = System.Drawing.Color.White;
            btnRetire.Location = new System.Drawing.Point(637, 10);
            btnRetire.Name = "btnRetire";
            btnRetire.Size = new System.Drawing.Size(100, 40);
            btnRetire.TabIndex = 8;
            btnRetire.Text = "♻ Retire";
            btnRetire.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)((byte)231)), ((int)((byte)76)), ((int)((byte)60)));
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.Location = new System.Drawing.Point(1008, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(100, 40);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "🗑 Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)((byte)243)), ((int)((byte)156)), ((int)((byte)18)));
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnEdit.ForeColor = System.Drawing.Color.White;
            btnEdit.Location = new System.Drawing.Point(1116, 10);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(90, 40);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "✏ Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)((byte)46)), ((int)((byte)204)), ((int)((byte)113)));
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.Location = new System.Drawing.Point(1213, 11);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(110, 40);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "➕ Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // splitContainerMain
            // 
            splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainerMain.Location = new System.Drawing.Point(0, 130);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.Controls.Add(panelVehicleList);
            splitContainerMain.Panel1.Controls.Add(panelStatusFilter);
            splitContainerMain.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(panelVehicleDetails);
            splitContainerMain.Panel2.Padding = new System.Windows.Forms.Padding(10);
            splitContainerMain.Size = new System.Drawing.Size(1491, 670);
            splitContainerMain.SplitterDistance = 1108;
            splitContainerMain.SplitterWidth = 8;
            splitContainerMain.TabIndex = 2;
            // 
            // panelVehicleList
            // 
            panelVehicleList.BackColor = System.Drawing.Color.White;
            panelVehicleList.Controls.Add(dgvVehicles);
            panelVehicleList.Dock = System.Windows.Forms.DockStyle.Fill;
            panelVehicleList.Location = new System.Drawing.Point(10, 40);
            panelVehicleList.Name = "panelVehicleList";
            panelVehicleList.Padding = new System.Windows.Forms.Padding(10);
            panelVehicleList.Size = new System.Drawing.Size(1088, 620);
            panelVehicleList.TabIndex = 1;
            // 
            // dgvVehicles
            // 
            dgvVehicles.AllowUserToAddRows = false;
            dgvVehicles.AllowUserToDeleteRows = false;
            dgvVehicles.AllowUserToResizeRows = false;
            dgvVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvVehicles.BackgroundColor = System.Drawing.Color.White;
            dgvVehicles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvVehicles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVehicles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)60)), ((int)((byte)90)));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)60)), ((int)((byte)90)));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvVehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVehicles.ColumnHeadersHeight = 40;
            dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)236)), ((int)((byte)240)), ((int)((byte)241)));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvVehicles.DefaultCellStyle = dataGridViewCellStyle2;
            dgvVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvVehicles.EnableHeadersVisualStyles = false;
            dgvVehicles.GridColor = System.Drawing.Color.WhiteSmoke;
            dgvVehicles.Location = new System.Drawing.Point(10, 10);
            dgvVehicles.MultiSelect = false;
            dgvVehicles.Name = "dgvVehicles";
            dgvVehicles.ReadOnly = true;
            dgvVehicles.RowHeadersVisible = false;
            dgvVehicles.RowHeadersWidth = 51;
            dgvVehicles.RowTemplate.Height = 35;
            dgvVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvVehicles.Size = new System.Drawing.Size(1068, 600);
            dgvVehicles.TabIndex = 0;
            // 
            // panelStatusFilter
            // 
            panelStatusFilter.BackColor = System.Drawing.Color.White;
            panelStatusFilter.Controls.Add(cmbAdvancedFilter);
            panelStatusFilter.Controls.Add(lblStatusFilter);
            panelStatusFilter.Dock = System.Windows.Forms.DockStyle.Top;
            panelStatusFilter.Location = new System.Drawing.Point(10, 10);
            panelStatusFilter.Name = "panelStatusFilter";
            panelStatusFilter.Size = new System.Drawing.Size(1088, 30);
            panelStatusFilter.TabIndex = 0;
            // 
            // cmbAdvancedFilter
            // 
            cmbAdvancedFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbAdvancedFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbAdvancedFilter.Font = new System.Drawing.Font("Segoe UI", 8F);
            cmbAdvancedFilter.FormattingEnabled = true;
            cmbAdvancedFilter.Items.AddRange(new object[] { "⚙ Advanced Filters", "📍 By Location", "📅 By Year", "💰 By Price Range", "📊 By Category", "⛽ By Fuel Type", "⚙ By Transmission" });
            cmbAdvancedFilter.Location = new System.Drawing.Point(60, 3);
            cmbAdvancedFilter.Name = "cmbAdvancedFilter";
            cmbAdvancedFilter.Size = new System.Drawing.Size(150, 25);
            cmbAdvancedFilter.TabIndex = 1;
            // 
            // lblStatusFilter
            // 
            lblStatusFilter.AutoSize = true;
            lblStatusFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            lblStatusFilter.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)60)), ((int)((byte)90)));
            lblStatusFilter.Location = new System.Drawing.Point(10, 6);
            lblStatusFilter.Name = "lblStatusFilter";
            lblStatusFilter.Size = new System.Drawing.Size(49, 20);
            lblStatusFilter.TabIndex = 0;
            lblStatusFilter.Text = "Filter:";
            // 
            // panelVehicleDetails
            // 
            panelVehicleDetails.BackColor = System.Drawing.Color.White;
            panelVehicleDetails.Controls.Add(panelFeatures);
            panelVehicleDetails.Controls.Add(panelVehicleInfo);
            panelVehicleDetails.Controls.Add(panelPreviewHeader);
            panelVehicleDetails.Controls.Add(picVehiclePreview);
            panelVehicleDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            panelVehicleDetails.Location = new System.Drawing.Point(10, 10);
            panelVehicleDetails.Name = "panelVehicleDetails";
            panelVehicleDetails.Size = new System.Drawing.Size(355, 650);
            panelVehicleDetails.TabIndex = 0;
            // 
            // panelFeatures
            // 
            panelFeatures.AutoScroll = true;
            panelFeatures.BackColor = System.Drawing.Color.White;
            panelFeatures.Controls.Add(flowLayoutPanelFeatures);
            panelFeatures.Controls.Add(lblFeaturesTitle);
            panelFeatures.Dock = System.Windows.Forms.DockStyle.Fill;
            panelFeatures.Location = new System.Drawing.Point(0, 530);
            panelFeatures.Name = "panelFeatures";
            panelFeatures.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            panelFeatures.Size = new System.Drawing.Size(355, 120);
            panelFeatures.TabIndex = 7;
            // 
            // flowLayoutPanelFeatures
            // 
            flowLayoutPanelFeatures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            flowLayoutPanelFeatures.AutoScroll = true;
            flowLayoutPanelFeatures.AutoSize = true;
            flowLayoutPanelFeatures.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanelFeatures.BackColor = System.Drawing.Color.Transparent;
            flowLayoutPanelFeatures.Location = new System.Drawing.Point(10, 35);
            flowLayoutPanelFeatures.MaximumSize = new System.Drawing.Size(330, 80);
            flowLayoutPanelFeatures.MinimumSize = new System.Drawing.Size(330, 30);
            flowLayoutPanelFeatures.Name = "flowLayoutPanelFeatures";
            flowLayoutPanelFeatures.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            flowLayoutPanelFeatures.Size = new System.Drawing.Size(330, 30);
            flowLayoutPanelFeatures.TabIndex = 1;
            // 
            // lblFeaturesTitle
            // 
            lblFeaturesTitle.AutoSize = true;
            lblFeaturesTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            lblFeaturesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)60)), ((int)((byte)90)));
            lblFeaturesTitle.Location = new System.Drawing.Point(10, 10);
            lblFeaturesTitle.Name = "lblFeaturesTitle";
            lblFeaturesTitle.Size = new System.Drawing.Size(75, 23);
            lblFeaturesTitle.TabIndex = 0;
            lblFeaturesTitle.Text = "Features";
            // 
            // panelVehicleInfo
            // 
            panelVehicleInfo.BackColor = System.Drawing.Color.White;
            panelVehicleInfo.Controls.Add(lblMileageValue);
            panelVehicleInfo.Controls.Add(lblMileage);
            panelVehicleInfo.Controls.Add(lblPlateValue);
            panelVehicleInfo.Controls.Add(lblPlate);
            panelVehicleInfo.Controls.Add(lblDailyRateValue);
            panelVehicleInfo.Controls.Add(lblDailyRate);
            panelVehicleInfo.Controls.Add(lblYearColorValue);
            panelVehicleInfo.Controls.Add(lblYearColor);
            panelVehicleInfo.Controls.Add(lblCategoryValue);
            panelVehicleInfo.Controls.Add(lblStatusValue);
            panelVehicleInfo.Controls.Add(lblStatus);
            panelVehicleInfo.Controls.Add(lblCategory);
            panelVehicleInfo.Controls.Add(lblMakeModel);
            panelVehicleInfo.Controls.Add(lblDetailsTitle);
            panelVehicleInfo.Dock = System.Windows.Forms.DockStyle.Top;
            panelVehicleInfo.Location = new System.Drawing.Point(0, 290);
            panelVehicleInfo.Name = "panelVehicleInfo";
            panelVehicleInfo.Padding = new System.Windows.Forms.Padding(10);
            panelVehicleInfo.Size = new System.Drawing.Size(355, 240);
            panelVehicleInfo.TabIndex = 6;
            // 
            // lblMileageValue
            // 
            lblMileageValue.AutoSize = true;
            lblMileageValue.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            lblMileageValue.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)60)), ((int)((byte)90)));
            lblMileageValue.Location = new System.Drawing.Point(85, 200);
            lblMileageValue.Name = "lblMileageValue";
            lblMileageValue.Size = new System.Drawing.Size(79, 20);
            lblMileageValue.TabIndex = 13;
            lblMileageValue.Text = "25,450 km";
            // 
            // lblMileage
            // 
            lblMileage.AutoSize = true;
            lblMileage.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblMileage.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)100)), ((int)((byte)100)));
            lblMileage.Location = new System.Drawing.Point(10, 200);
            lblMileage.Name = "lblMileage";
            lblMileage.Size = new System.Drawing.Size(66, 20);
            lblMileage.TabIndex = 12;
            lblMileage.Text = "Mileage:";
            // 
            // lblPlateValue
            // 
            lblPlateValue.AutoSize = true;
            lblPlateValue.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            lblPlateValue.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)60)), ((int)((byte)90)));
            lblPlateValue.Location = new System.Drawing.Point(85, 170);
            lblPlateValue.Name = "lblPlateValue";
            lblPlateValue.Size = new System.Drawing.Size(74, 20);
            lblPlateValue.TabIndex = 11;
            lblPlateValue.Text = "ABC-1234";
            // 
            // lblPlate
            // 
            lblPlate.AutoSize = true;
            lblPlate.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblPlate.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)100)), ((int)((byte)100)));
            lblPlate.Location = new System.Drawing.Point(10, 170);
            lblPlate.Name = "lblPlate";
            lblPlate.Size = new System.Drawing.Size(72, 20);
            lblPlate.TabIndex = 10;
            lblPlate.Text = "Plate No.:";
            // 
            // lblDailyRateValue
            // 
            lblDailyRateValue.AutoSize = true;
            lblDailyRateValue.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            lblDailyRateValue.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)46)), ((int)((byte)204)), ((int)((byte)113)));
            lblDailyRateValue.Location = new System.Drawing.Point(85, 140);
            lblDailyRateValue.Name = "lblDailyRateValue";
            lblDailyRateValue.Size = new System.Drawing.Size(53, 20);
            lblDailyRateValue.TabIndex = 9;
            lblDailyRateValue.Text = "$65.00";
            // 
            // lblDailyRate
            // 
            lblDailyRate.AutoSize = true;
            lblDailyRate.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblDailyRate.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)100)), ((int)((byte)100)));
            lblDailyRate.Location = new System.Drawing.Point(10, 140);
            lblDailyRate.Name = "lblDailyRate";
            lblDailyRate.Size = new System.Drawing.Size(80, 20);
            lblDailyRate.TabIndex = 8;
            lblDailyRate.Text = "Daily Rate:";
            // 
            // lblYearColorValue
            // 
            lblYearColorValue.AutoSize = true;
            lblYearColorValue.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            lblYearColorValue.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)60)), ((int)((byte)90)));
            lblYearColorValue.Location = new System.Drawing.Point(85, 110);
            lblYearColorValue.Name = "lblYearColorValue";
            lblYearColorValue.Size = new System.Drawing.Size(74, 20);
            lblYearColorValue.TabIndex = 7;
            lblYearColorValue.Text = "2024/Red";
            // 
            // lblYearColor
            // 
            lblYearColor.AutoSize = true;
            lblYearColor.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblYearColor.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)100)), ((int)((byte)100)));
            lblYearColor.Location = new System.Drawing.Point(10, 110);
            lblYearColor.Name = "lblYearColor";
            lblYearColor.Size = new System.Drawing.Size(82, 20);
            lblYearColor.TabIndex = 6;
            lblYearColor.Text = "Year/Color:";
            // 
            // lblCategoryValue
            // 
            lblCategoryValue.AutoSize = true;
            lblCategoryValue.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            lblCategoryValue.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)60)), ((int)((byte)90)));
            lblCategoryValue.Location = new System.Drawing.Point(85, 80);
            lblCategoryValue.Name = "lblCategoryValue";
            lblCategoryValue.Size = new System.Drawing.Size(51, 20);
            lblCategoryValue.TabIndex = 5;
            lblCategoryValue.Text = "Sedan";
            // 
            // lblStatusValue
            // 
            lblStatusValue.AutoSize = true;
            lblStatusValue.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            lblStatusValue.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)231)), ((int)((byte)76)), ((int)((byte)60)));
            lblStatusValue.Location = new System.Drawing.Point(85, 50);
            lblStatusValue.Name = "lblStatusValue";
            lblStatusValue.Size = new System.Drawing.Size(57, 20);
            lblStatusValue.TabIndex = 4;
            lblStatusValue.Text = "Rented";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)100)), ((int)((byte)100)));
            lblStatus.Location = new System.Drawing.Point(10, 50);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(52, 20);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)100)), ((int)((byte)100)));
            lblCategory.Location = new System.Drawing.Point(10, 80);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new System.Drawing.Size(72, 20);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            // 
            // lblMakeModel
            // 
            lblMakeModel.AutoSize = true;
            lblMakeModel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            lblMakeModel.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)44)), ((int)((byte)62)), ((int)((byte)80)));
            lblMakeModel.Location = new System.Drawing.Point(10, 15);
            lblMakeModel.Name = "lblMakeModel";
            lblMakeModel.Size = new System.Drawing.Size(131, 25);
            lblMakeModel.TabIndex = 1;
            lblMakeModel.Text = "Toyota Camry";
            // 
            // lblDetailsTitle
            // 
            lblDetailsTitle.AutoSize = true;
            lblDetailsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            lblDetailsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)60)), ((int)((byte)90)));
            lblDetailsTitle.Location = new System.Drawing.Point(10, -10);
            lblDetailsTitle.Name = "lblDetailsTitle";
            lblDetailsTitle.Size = new System.Drawing.Size(0, 23);
            lblDetailsTitle.TabIndex = 0;
            // 
            // panelPreviewHeader
            // 
            panelPreviewHeader.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)249)), ((int)((byte)250)));
            panelPreviewHeader.Controls.Add(lblVehicleDetails);
            panelPreviewHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelPreviewHeader.Location = new System.Drawing.Point(0, 250);
            panelPreviewHeader.Name = "panelPreviewHeader";
            panelPreviewHeader.Size = new System.Drawing.Size(355, 40);
            panelPreviewHeader.TabIndex = 5;
            // 
            // lblVehicleDetails
            // 
            lblVehicleDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            lblVehicleDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            lblVehicleDetails.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)60)), ((int)((byte)90)));
            lblVehicleDetails.Location = new System.Drawing.Point(0, 0);
            lblVehicleDetails.Name = "lblVehicleDetails";
            lblVehicleDetails.Size = new System.Drawing.Size(355, 40);
            lblVehicleDetails.TabIndex = 0;
            lblVehicleDetails.Text = "🚗 Vehicle Details";
            lblVehicleDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picVehiclePreview
            // 
            picVehiclePreview.BackColor = System.Drawing.Color.White;
            picVehiclePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picVehiclePreview.Dock = System.Windows.Forms.DockStyle.Top;
            picVehiclePreview.Location = new System.Drawing.Point(0, 0);
            picVehiclePreview.Name = "picVehiclePreview";
            picVehiclePreview.Size = new System.Drawing.Size(355, 250);
            picVehiclePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picVehiclePreview.TabIndex = 0;
            picVehiclePreview.TabStop = false;
            // 
            // VehiclesView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(splitContainerMain);
            Controls.Add(panelToolbar);
            Controls.Add(panelHeader);
            Size = new System.Drawing.Size(1491, 800);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelToolbar.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            panelVehicleList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).EndInit();
            panelStatusFilter.ResumeLayout(false);
            panelStatusFilter.PerformLayout();
            panelVehicleDetails.ResumeLayout(false);
            panelFeatures.ResumeLayout(false);
            panelFeatures.PerformLayout();
            panelVehicleInfo.ResumeLayout(false);
            panelVehicleInfo.PerformLayout();
            panelPreviewHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picVehiclePreview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label label1;
        private Panel panelToolbar;
        private SplitContainer splitContainerMain;
        private Panel panelVehicleList;
        private DataGridView dgvVehicles;
        private Panel panelVehicleDetails;
        private PictureBox picVehiclePreview;
        private Panel panelStatusFilter;
        private Label lblStatusFilter;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
        private ComboBox cmbStatusFilter;
        private Panel panelSearch;
        private TextBox txtSearch;
        private Label lblVehicleCount;
        private Panel panelPreviewHeader;
        private Label lblVehicleDetails;
        private Panel panelVehicleInfo;
        private Label lblMakeModel;
        private Label lblDetailsTitle;
        private Label lblMileageValue;
        private Label lblMileage;
        private Label lblPlateValue;
        private Label lblPlate;
        private Label lblDailyRateValue;
        private Label lblDailyRate;
        private Label lblYearColorValue;
        private Label lblYearColor;
        private Label lblCategoryValue;
        private Label lblStatusValue;
        private Label lblStatus;
        private Label lblCategory;
        private Panel panelFeatures;
        private Label lblFeaturesTitle;
        private FlowLayoutPanel flowLayoutPanelFeatures;
        private Button btnAddCategory;
        private Button btnRetire;
        private ComboBox cmbAdvancedFilter;
        private Button btnUnderMaintenance;
    }
}