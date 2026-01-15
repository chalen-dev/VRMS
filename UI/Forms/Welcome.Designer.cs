namespace VRMS.UI.Forms
{
    partial class Welcome
    {
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            panelLeft = new Panel();
            btnProceed = new Button();
            lblSubtitle = new Label();
            lblTitle = new Label();
            panelRight = new Panel();
            picCompanyLogo = new PictureBox();
            panelLogin = new Panel();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCompanyLogo).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(248, 250, 252);
            panelLeft.Controls.Add(btnProceed);
            panelLeft.Controls.Add(lblSubtitle);
            panelLeft.Controls.Add(lblTitle);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(534, 900);
            panelLeft.TabIndex = 2;
            // 
            // btnProceed
            // 
            btnProceed.BackColor = Color.FromArgb(37, 99, 235);
            btnProceed.FlatAppearance.BorderSize = 0;
            btnProceed.FlatStyle = FlatStyle.Flat;
            btnProceed.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnProceed.ForeColor = Color.White;
            btnProceed.Location = new Point(62, 438);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(160, 52);
            btnProceed.TabIndex = 0;
            btnProceed.Text = "Continue →";
            btnProceed.UseVisualStyleBackColor = false;
            btnProceed.Click += btnProceed_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblSubtitle.Location = new Point(62, 319);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(380, 88);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Manage vehicles, rentals, and customers efficiently using a modern desktop system.";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(60, 175);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 125);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Vehicle Rental\r\nManagement System";
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.FromArgb(30, 41, 59);
            panelRight.Controls.Add(picCompanyLogo);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(534, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(746, 900);
            panelRight.TabIndex = 1;
            // 
            // picCompanyLogo
            // 
            picCompanyLogo.Dock = DockStyle.Fill;
            picCompanyLogo.Image = (Image)resources.GetObject("picCompanyLogo.Image");
            picCompanyLogo.Location = new Point(0, 0);
            picCompanyLogo.Name = "picCompanyLogo";
            picCompanyLogo.Size = new Size(746, 900);
            picCompanyLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picCompanyLogo.TabIndex = 0;
            picCompanyLogo.TabStop = false;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.FromArgb(248, 250, 252);
            panelLogin.Location = new Point(-520, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(520, 900);
            panelLogin.TabIndex = 0;
            panelLogin.Visible = false;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1280, 900);
            Controls.Add(panelLogin);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VRMS - Welcome";
            WindowState = FormWindowState.Maximized;
            panelLeft.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCompanyLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Panel panelRight;
        private Panel panelLogin;
        private Label lblTitle;
        private Label lblSubtitle;
        private Button btnProceed;
        private PictureBox picCompanyLogo;
    }
}
