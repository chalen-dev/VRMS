namespace VRMS.UI.Forms
{
    partial class Welcome
    {
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            panelRight = new Panel();
            panelLeft = new Panel();
            btnProceed = new Button();
            lblSubtitle = new Label();
            lblTitle = new Label();
            panelLogin = new Panel();
            panelLeft.SuspendLayout();
            SuspendLayout();
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.FromArgb(30, 41, 59);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(0, 0);
            panelRight.Margin = new Padding(3, 4, 3, 4);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(1280, 900);
            panelRight.TabIndex = 0;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(248, 250, 252);
            panelLeft.Controls.Add(btnProceed);
            panelLeft.Controls.Add(lblSubtitle);
            panelLeft.Controls.Add(lblTitle);
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(3, 4, 3, 4);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(520, 900);
            panelLeft.TabIndex = 1;
            // 
            // btnProceed
            // 
            btnProceed.BackColor = Color.FromArgb(37, 99, 235);
            btnProceed.FlatAppearance.BorderSize = 0;
            btnProceed.FlatStyle = FlatStyle.Flat;
            btnProceed.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnProceed.ForeColor = Color.White;
            btnProceed.Location = new Point(62, 438);
            btnProceed.Margin = new Padding(3, 4, 3, 4);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(160, 52);
            btnProceed.TabIndex = 2;
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
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Vehicle Rental\r\nManagement System";
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.FromArgb(248, 250, 252);
            panelLogin.Location = new Point(-520, 0);
            panelLogin.Margin = new Padding(3, 4, 3, 4);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(520, 900);
            panelLogin.TabIndex = 2;
            panelLogin.Visible = false;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1280, 900);
            Controls.Add(panelLogin);
            Controls.Add(panelLeft);
            Controls.Add(panelRight);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VRMS - Welcome";
            WindowState = FormWindowState.Maximized;
            panelLeft.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnProceed;
    }
}