namespace VRMS.UI.Forms
{
    partial class Welcome
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.PictureBox picCompany;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelRight = new System.Windows.Forms.Panel();
            panelLeft = new System.Windows.Forms.Panel();
            panelLogin = new System.Windows.Forms.Panel();

            lblTitle = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            btnProceed = new System.Windows.Forms.Button();
            picCompany = new System.Windows.Forms.PictureBox();

            ((System.ComponentModel.ISupportInitialize)(picCompany)).BeginInit();
            panelLeft.SuspendLayout();
            SuspendLayout();

            // panelRight
            panelRight.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            panelRight.Dock = System.Windows.Forms.DockStyle.Fill;

            // panelLeft
            panelLeft.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            panelLeft.Controls.Add(picCompany);
            panelLeft.Controls.Add(lblTitle);
            panelLeft.Controls.Add(lblSubtitle);
            panelLeft.Controls.Add(btnProceed);
            panelLeft.Location = new System.Drawing.Point(0, 0);
            panelLeft.Size = new System.Drawing.Size(520, 900);

            // picCompany
            picCompany.Image = global::VRMS.Properties.Resources.CompanyLogo;
            picCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picCompany.Location = new System.Drawing.Point(60, 40);
            picCompany.Size = new System.Drawing.Size(220, 110);
            picCompany.TabStop = false;

            // lblTitle
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTitle.Location = new System.Drawing.Point(60, 180);
            lblTitle.Size = new System.Drawing.Size(400, 120);
            lblTitle.Text = "Vehicle Rental\r\nManagement System";

            // lblSubtitle
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblSubtitle.Location = new System.Drawing.Point(62, 320);
            lblSubtitle.Size = new System.Drawing.Size(380, 90);
            lblSubtitle.Text =
                "Manage vehicles, rentals, and customers efficiently using a modern desktop system.";

            // btnProceed
            btnProceed.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProceed.ForeColor = System.Drawing.Color.White;
            btnProceed.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnProceed.Location = new System.Drawing.Point(62, 440);
            btnProceed.Size = new System.Drawing.Size(160, 52);
            btnProceed.Text = "Continue →";
            btnProceed.Click += btnProceed_Click;

            // panelLogin
            panelLogin.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            panelLogin.Location = new System.Drawing.Point(-520, 0);
            panelLogin.Size = new System.Drawing.Size(520, 900);
            panelLogin.Visible = false;

            // Welcome
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1280, 900);
            Controls.Add(panelLogin);
            Controls.Add(panelLeft);
            Controls.Add(panelRight);
            Name = "Welcome";
            Text = "VRMS - Welcome";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;

            panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(picCompany)).EndInit();
            ResumeLayout(false);
        }
    }
}
