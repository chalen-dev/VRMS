namespace VRMS.UI.Forms.Rentals
{
    partial class IDVerification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Form Controls
        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;

        private Panel panelMain;
        private ComboBox cmbIDType;
        private Label lblIDType;

        private Panel panelImageContainer;
        private Panel panelIDPreview;
        private PictureBox picIDPreview;
        private Label lblPreviewPlaceholder;
        private Label lblPreviewStatus;

        private Panel panelCapture;
        private Button btnCapture;
        private Button btnUpload;
        private Button btnRetake;
        private Button btnViewOriginal;

        private CheckBox chkConsent;
        private Label lblPrivacyNotice;

        private Panel panelStatus;
        private Label lblStatus;
        private PictureBox picStatusIcon;

        private Panel panelActions;
        private Button btnConfirm;
        private Button btnCancel;

        private OpenFileDialog openFileDialog;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IDVerification));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblPrivacyNotice = new System.Windows.Forms.Label();
            this.chkConsent = new System.Windows.Forms.CheckBox();
            this.panelCapture = new System.Windows.Forms.Panel();
            this.btnViewOriginal = new System.Windows.Forms.Button();
            this.btnRetake = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnCapture = new System.Windows.Forms.Button();
            this.panelImageContainer = new System.Windows.Forms.Panel();
            this.panelIDPreview = new System.Windows.Forms.Panel();
            this.lblPreviewStatus = new System.Windows.Forms.Label();
            this.lblPreviewPlaceholder = new System.Windows.Forms.Label();
            this.picIDPreview = new System.Windows.Forms.PictureBox();
            this.lblIDType = new System.Windows.Forms.Label();
            this.cmbIDType = new System.Windows.Forms.ComboBox();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.picStatusIcon = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelCapture.SuspendLayout();
            this.panelImageContainer.SuspendLayout();
            this.panelIDPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.picIDPreview).BeginInit();
            this.panelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.picStatusIcon).BeginInit();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(700, 90);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(269, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🔐 Identity Verification";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblSubtitle.Location = new System.Drawing.Point(22, 56);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(656, 25);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Please provide a valid government-issued ID for rental verification purposes.";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.lblPrivacyNotice);
            this.panelMain.Controls.Add(this.chkConsent);
            this.panelMain.Controls.Add(this.panelCapture);
            this.panelMain.Controls.Add(this.panelImageContainer);
            this.panelMain.Controls.Add(this.lblIDType);
            this.panelMain.Controls.Add(this.cmbIDType);
            this.panelMain.Controls.Add(this.panelStatus);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 90);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(25);
            this.panelMain.Size = new System.Drawing.Size(700, 410);
            this.panelMain.TabIndex = 1;
            // 
            // lblPrivacyNotice
            // 
            this.lblPrivacyNotice.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivacyNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblPrivacyNotice.Location = new System.Drawing.Point(35, 315);
            this.lblPrivacyNotice.Name = "lblPrivacyNotice";
            this.lblPrivacyNotice.Size = new System.Drawing.Size(630, 30);
            this.lblPrivacyNotice.TabIndex = 6;
            this.lblPrivacyNotice.Text = "🛡 Your ID will be used only for verification and securely deleted after the rent" +
    "al period.";
            this.lblPrivacyNotice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkConsent
            // 
            this.chkConsent.AutoSize = true;
            this.chkConsent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConsent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkConsent.Location = new System.Drawing.Point(35, 285);
            this.chkConsent.Name = "chkConsent";
            this.chkConsent.Size = new System.Drawing.Size(309, 24);
            this.chkConsent.TabIndex = 5;
            this.chkConsent.Text = "I consent to ID collection for verification";
            this.chkConsent.UseVisualStyleBackColor = true;
            // 
            // panelCapture
            // 
            this.panelCapture.Controls.Add(this.btnViewOriginal);
            this.panelCapture.Controls.Add(this.btnRetake);
            this.panelCapture.Controls.Add(this.btnUpload);
            this.panelCapture.Controls.Add(this.btnCapture);
            this.panelCapture.Location = new System.Drawing.Point(360, 90);
            this.panelCapture.Name = "panelCapture";
            this.panelCapture.Size = new System.Drawing.Size(300, 170);
            this.panelCapture.TabIndex = 4;
            // 
            // btnViewOriginal
            // 
            this.btnViewOriginal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnViewOriginal.FlatAppearance.BorderSize = 0;
            this.btnViewOriginal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOriginal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOriginal.ForeColor = System.Drawing.Color.White;
            this.btnViewOriginal.Location = new System.Drawing.Point(10, 130);
            this.btnViewOriginal.Name = "btnViewOriginal";
            this.btnViewOriginal.Size = new System.Drawing.Size(280, 30);
            this.btnViewOriginal.TabIndex = 3;
            this.btnViewOriginal.Text = "👁️ View Original";
            this.btnViewOriginal.UseVisualStyleBackColor = false;
            this.btnViewOriginal.Visible = false;
            // 
            // btnRetake
            // 
            this.btnRetake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnRetake.FlatAppearance.BorderSize = 0;
            this.btnRetake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetake.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetake.ForeColor = System.Drawing.Color.White;
            this.btnRetake.Location = new System.Drawing.Point(10, 90);
            this.btnRetake.Name = "btnRetake";
            this.btnRetake.Size = new System.Drawing.Size(280, 30);
            this.btnRetake.TabIndex = 2;
            this.btnRetake.Text = "🔄 Retake";
            this.btnRetake.UseVisualStyleBackColor = false;
            this.btnRetake.Visible = false;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(10, 50);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(280, 30);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "⬆️ Upload Image";
            this.btnUpload.UseVisualStyleBackColor = false;
            // 
            // btnCapture
            // 
            this.btnCapture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCapture.FlatAppearance.BorderSize = 0;
            this.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapture.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.ForeColor = System.Drawing.Color.White;
            this.btnCapture.Location = new System.Drawing.Point(10, 10);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(280, 30);
            this.btnCapture.TabIndex = 0;
            this.btnCapture.Text = "📷 Capture Photo";
            this.btnCapture.UseVisualStyleBackColor = false;
            // 
            // panelImageContainer
            // 
            this.panelImageContainer.Controls.Add(this.panelIDPreview);
            this.panelImageContainer.Location = new System.Drawing.Point(35, 90);
            this.panelImageContainer.Name = "panelImageContainer";
            this.panelImageContainer.Size = new System.Drawing.Size(300, 170);
            this.panelImageContainer.TabIndex = 3;
            // 
            // panelIDPreview
            // 
            this.panelIDPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelIDPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIDPreview.Controls.Add(this.lblPreviewStatus);
            this.panelIDPreview.Controls.Add(this.lblPreviewPlaceholder);
            this.panelIDPreview.Controls.Add(this.picIDPreview);
            this.panelIDPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIDPreview.Location = new System.Drawing.Point(0, 0);
            this.panelIDPreview.Name = "panelIDPreview";
            this.panelIDPreview.Size = new System.Drawing.Size(300, 170);
            this.panelIDPreview.TabIndex = 0;
            // 
            // lblPreviewStatus
            // 
            this.lblPreviewStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblPreviewStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviewStatus.ForeColor = System.Drawing.Color.White;
            this.lblPreviewStatus.Location = new System.Drawing.Point(0, 140);
            this.lblPreviewStatus.Name = "lblPreviewStatus";
            this.lblPreviewStatus.Size = new System.Drawing.Size(298, 28);
            this.lblPreviewStatus.TabIndex = 2;
            this.lblPreviewStatus.Text = "✅ Captured";
            this.lblPreviewStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPreviewStatus.Visible = false;
            // 
            // lblPreviewPlaceholder
            // 
            this.lblPreviewPlaceholder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPreviewPlaceholder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviewPlaceholder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblPreviewPlaceholder.Location = new System.Drawing.Point(0, 0);
            this.lblPreviewPlaceholder.Name = "lblPreviewPlaceholder";
            this.lblPreviewPlaceholder.Size = new System.Drawing.Size(298, 168);
            this.lblPreviewPlaceholder.TabIndex = 1;
            this.lblPreviewPlaceholder.Text = "No ID image captured";
            this.lblPreviewPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picIDPreview
            // 
            this.picIDPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picIDPreview.Location = new System.Drawing.Point(0, 0);
            this.picIDPreview.Name = "picIDPreview";
            this.picIDPreview.Size = new System.Drawing.Size(298, 168);
            this.picIDPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIDPreview.TabIndex = 0;
            this.picIDPreview.TabStop = false;
            this.picIDPreview.Visible = false;
            // 
            // lblIDType
            // 
            this.lblIDType.AutoSize = true;
            this.lblIDType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblIDType.Location = new System.Drawing.Point(31, 28);
            this.lblIDType.Name = "lblIDType";
            this.lblIDType.Size = new System.Drawing.Size(68, 21);
            this.lblIDType.TabIndex = 2;
            this.lblIDType.Text = "ID Type:";
            // 
            // cmbIDType
            // 
            this.cmbIDType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIDType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIDType.FormattingEnabled = true;
            this.cmbIDType.Items.AddRange(new object[] {
            "Driver\'s License",
            "Passport",
            "National ID",
            "Other Government ID"});
            this.cmbIDType.Location = new System.Drawing.Point(105, 28);
            this.cmbIDType.Name = "cmbIDType";
            this.cmbIDType.Size = new System.Drawing.Size(230, 28);
            this.cmbIDType.TabIndex = 1;
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelStatus.Controls.Add(this.picStatusIcon);
            this.panelStatus.Controls.Add(this.lblStatus);
            this.panelStatus.Location = new System.Drawing.Point(360, 28);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(300, 40);
            this.panelStatus.TabIndex = 0;
            // 
            // picStatusIcon
            // 
            this.picStatusIcon.Location = new System.Drawing.Point(10, 8);
            this.picStatusIcon.Name = "picStatusIcon";
            this.picStatusIcon.Size = new System.Drawing.Size(24, 24);
            this.picStatusIcon.TabIndex = 1;
            this.picStatusIcon.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(40, 10);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(113, 21);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "🔴 Not Verified";
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelActions.Controls.Add(this.btnCancel);
            this.panelActions.Controls.Add(this.btnConfirm);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(0, 440);
            this.panelActions.Name = "panelActions";
            this.panelActions.Padding = new System.Windows.Forms.Padding(10);
            this.panelActions.Size = new System.Drawing.Size(700, 60);
            this.panelActions.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(10, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(590, 10);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 40);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "✅ Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp|All files|*.*";
            this.openFileDialog.Title = "Select ID Image";
            // 
            // IDVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IDVerification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ID Verification";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelCapture.ResumeLayout(false);
            this.panelImageContainer.ResumeLayout(false);
            this.panelIDPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.picIDPreview).EndInit();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.picStatusIcon).EndInit();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}