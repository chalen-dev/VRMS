namespace Vehicle_Rental_Management_System
{
    partial class Welcome
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelOverlay;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Panel pnlDecorativeLine;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));

            this.panelOverlay = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.btnProceed = new System.Windows.Forms.Button();
            this.pnlDecorativeLine = new System.Windows.Forms.Panel();

            this.panelOverlay.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelOverlay
            // 
            this.panelOverlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            // Using a slightly more refined dark transparency (80% opacity)
            this.panelOverlay.BackColor = System.Drawing.Color.FromArgb(200, 20, 30, 35);
            this.panelOverlay.Controls.Add(this.pnlDecorativeLine);
            this.panelOverlay.Controls.Add(this.btnProceed);
            this.panelOverlay.Controls.Add(this.lblSystemName);
            this.panelOverlay.Controls.Add(this.lblWelcome);
            this.panelOverlay.Location = new System.Drawing.Point(315, 180);
            this.panelOverlay.Name = "panelOverlay";
            this.panelOverlay.Size = new System.Drawing.Size(650, 360);
            this.panelOverlay.TabIndex = 0;

            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.lblWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(650, 70);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "WELCOME TO";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;

            // 
            // lblSystemName
            // 
            this.lblSystemName.BackColor = System.Drawing.Color.Transparent;
            this.lblSystemName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSystemName.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSystemName.ForeColor = System.Drawing.Color.White;
            this.lblSystemName.Location = new System.Drawing.Point(0, 70);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(650, 140);
            this.lblSystemName.TabIndex = 2;
            this.lblSystemName.Text = "VEHICLE RENTAL\r\nMANAGEMENT";
            this.lblSystemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // pnlDecorativeLine
            // 
            this.pnlDecorativeLine.BackColor = System.Drawing.Color.FromArgb(46, 204, 113); // Accent color (Emerald Green)
            this.pnlDecorativeLine.Location = new System.Drawing.Point(225, 205);
            this.pnlDecorativeLine.Name = "pnlDecorativeLine";
            this.pnlDecorativeLine.Size = new System.Drawing.Size(200, 3);
            this.pnlDecorativeLine.TabIndex = 4;

            // 
            // btnProceed
            // 
            this.btnProceed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnProceed.BackColor = System.Drawing.Color.FromArgb(46, 79, 79);
            this.btnProceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProceed.FlatAppearance.BorderSize = 0;
            this.btnProceed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(60, 100, 100);
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnProceed.ForeColor = System.Drawing.Color.White;
            this.btnProceed.Location = new System.Drawing.Point(215, 260);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(220, 55);
            this.btnProceed.TabIndex = 3;
            this.btnProceed.Text = "GET STARTED →";
            this.btnProceed.UseVisualStyleBackColor = false;

            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelOverlay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; // Optional: Makes it look like a modern splash screen
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Rental Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            this.panelOverlay.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}