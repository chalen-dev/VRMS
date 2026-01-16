namespace VRMS.UI.Controls.RentalCalendar
{
    partial class CalendarView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            dtpMonthYear = new DateTimePicker();
            btnNext = new Button();
            btnPrev = new Button();
            lblTitle = new Label();
            pnlMain = new Panel();
            splitContainer = new SplitContainer();
            pnlVehicleList = new Panel();
            dgvVehicles = new DataGridView();
            colYear = new DataGridViewTextBoxColumn();
            colLicense = new DataGridViewTextBoxColumn();
            colModel = new DataGridViewTextBoxColumn();
            pnlVehicleHeader = new Panel();
            pnlCalendarCanvas = new Panel();
            hScrollCalendar = new HScrollBar();
            toolTip = new ToolTip(components);
            pnlHeader.SuspendLayout();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            pnlVehicleList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.BorderStyle = BorderStyle.FixedSingle;
            pnlHeader.Controls.Add(dtpMonthYear);
            pnlHeader.Controls.Add(btnNext);
            pnlHeader.Controls.Add(btnPrev);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1371, 66);
            pnlHeader.TabIndex = 0;
            // 
            // dtpMonthYear
            // 
            dtpMonthYear.CustomFormat = "MMMM yyyy";
            dtpMonthYear.Format = DateTimePickerFormat.Custom;
            dtpMonthYear.Location = new Point(171, 17);
            dtpMonthYear.Margin = new Padding(3, 4, 3, 4);
            dtpMonthYear.Name = "dtpMonthYear";
            dtpMonthYear.ShowUpDown = true;
            dtpMonthYear.Size = new Size(171, 27);
            dtpMonthYear.TabIndex = 7;
            dtpMonthYear.ValueChanged += dtpMonthYear_ValueChanged;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(350, 17);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(34, 31);
            btnNext.TabIndex = 6;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(130, 17);
            btnPrev.Margin = new Padding(3, 4, 3, 4);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(34, 31);
            btnPrev.TabIndex = 5;
            btnPrev.Text = "<";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(11, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(115, 32);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Calendar";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(splitContainer);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 66);
            pnlMain.Margin = new Padding(3, 4, 3, 4);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1371, 734);
            pnlMain.TabIndex = 1;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.FixedPanel = FixedPanel.Panel1;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Margin = new Padding(3, 4, 3, 4);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(pnlVehicleList);
            splitContainer.Panel1MinSize = 250;
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(pnlCalendarCanvas);
            splitContainer.Panel2.Controls.Add(hScrollCalendar);
            splitContainer.Size = new Size(1371, 734);
            splitContainer.SplitterDistance = 286;
            splitContainer.SplitterWidth = 5;
            splitContainer.TabIndex = 0;
            // 
            // pnlVehicleList
            // 
            pnlVehicleList.Controls.Add(dgvVehicles);
            pnlVehicleList.Controls.Add(pnlVehicleHeader);
            pnlVehicleList.Dock = DockStyle.Fill;
            pnlVehicleList.Location = new Point(0, 0);
            pnlVehicleList.Margin = new Padding(3, 4, 3, 4);
            pnlVehicleList.Name = "pnlVehicleList";
            pnlVehicleList.Size = new Size(286, 734);
            pnlVehicleList.TabIndex = 0;
            pnlVehicleList.Resize += pnlVehicleList_Resize;
            // 
            // dgvVehicles
            // 
            dgvVehicles.AllowUserToAddRows = false;
            dgvVehicles.AllowUserToDeleteRows = false;
            dgvVehicles.AllowUserToResizeRows = false;
            dgvVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVehicles.BackgroundColor = Color.White;
            dgvVehicles.BorderStyle = BorderStyle.None;
            dgvVehicles.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvVehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVehicles.ColumnHeadersHeight = 29;
            dgvVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVehicles.ColumnHeadersVisible = false;
            dgvVehicles.Columns.AddRange(new DataGridViewColumn[] { colYear, colLicense, colModel });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvVehicles.DefaultCellStyle = dataGridViewCellStyle2;
            dgvVehicles.Dock = DockStyle.Fill;
            dgvVehicles.Location = new Point(0, 45);
            dgvVehicles.Margin = new Padding(3, 4, 3, 4);
            dgvVehicles.MultiSelect = false;
            dgvVehicles.Name = "dgvVehicles";
            dgvVehicles.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvVehicles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvVehicles.RowHeadersVisible = false;
            dgvVehicles.RowHeadersWidth = 51;
            dgvVehicles.RowTemplate.Height = 50;
            dgvVehicles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehicles.Size = new Size(286, 689);
            dgvVehicles.TabIndex = 0;
            dgvVehicles.RowPrePaint += dgvVehicles_RowPrePaint;
            // 
            // colYear
            // 
            colYear.DataPropertyName = "Year";
            colYear.FillWeight = 30F;
            colYear.HeaderText = "Year";
            colYear.MinimumWidth = 55;
            colYear.Name = "colYear";
            colYear.ReadOnly = true;
            // 
            // colLicense
            // 
            colLicense.DataPropertyName = "LicensePlate";
            colLicense.FillWeight = 40F;
            colLicense.HeaderText = "License";
            colLicense.MinimumWidth = 85;
            colLicense.Name = "colLicense";
            colLicense.ReadOnly = true;
            // 
            // colModel
            // 
            colModel.DataPropertyName = "Model";
            colModel.FillWeight = 60F;
            colModel.HeaderText = "Model";
            colModel.MinimumWidth = 110;
            colModel.Name = "colModel";
            colModel.ReadOnly = true;
            // 
            // pnlVehicleHeader
            // 
            pnlVehicleHeader.BackColor = Color.FromArgb(240, 240, 240);
            pnlVehicleHeader.Dock = DockStyle.Top;
            pnlVehicleHeader.Location = new Point(0, 0);
            pnlVehicleHeader.Margin = new Padding(3, 4, 3, 4);
            pnlVehicleHeader.Name = "pnlVehicleHeader";
            pnlVehicleHeader.Size = new Size(286, 45);
            pnlVehicleHeader.TabIndex = 1;
            pnlVehicleHeader.Paint += pnlVehicleHeader_Paint;
            // 
            // pnlCalendarCanvas
            // 
            pnlCalendarCanvas.BackColor = Color.White;
            pnlCalendarCanvas.Dock = DockStyle.Fill;
            pnlCalendarCanvas.Location = new Point(0, 0);
            pnlCalendarCanvas.Margin = new Padding(3, 4, 3, 4);
            pnlCalendarCanvas.Name = "pnlCalendarCanvas";
            pnlCalendarCanvas.Size = new Size(1080, 716);
            pnlCalendarCanvas.TabIndex = 0;
            pnlCalendarCanvas.Paint += pnlCalendarCanvas_Paint;
            pnlCalendarCanvas.Resize += pnlCalendarCanvas_Resize;
            // 
            // hScrollCalendar
            // 
            hScrollCalendar.Dock = DockStyle.Bottom;
            hScrollCalendar.LargeChange = 300;
            hScrollCalendar.Location = new Point(0, 716);
            hScrollCalendar.Maximum = 300;
            hScrollCalendar.Name = "hScrollCalendar";
            hScrollCalendar.Size = new Size(1080, 18);
            hScrollCalendar.SmallChange = 45;
            hScrollCalendar.TabIndex = 1;
            hScrollCalendar.Scroll += hScrollCalendar_Scroll;
            // 
            // CalendarView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlMain);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CalendarView";
            Size = new Size(1371, 800);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlMain.ResumeLayout(false);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            pnlVehicleList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private DateTimePicker dtpMonthYear;
        private Button btnNext;
        private Button btnPrev;
        private Label lblTitle;
        private Panel pnlMain;
        private SplitContainer splitContainer;
        private Panel pnlVehicleList;
        private DataGridView dgvVehicles;
        private DataGridViewTextBoxColumn colYear;
        private DataGridViewTextBoxColumn colLicense;
        private DataGridViewTextBoxColumn colModel;
        private Panel pnlCalendarCanvas;
        private ToolTip toolTip;
        private Panel pnlVehicleHeader;
        private HScrollBar hScrollCalendar;
    }
}