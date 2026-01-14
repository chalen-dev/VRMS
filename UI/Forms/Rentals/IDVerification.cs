using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VRMS.UI.Forms.Rentals
{
    public partial class IDVerification : Form
    {
        // Properties
        public string SelectedIDType => cmbIDType.SelectedItem?.ToString();
        public byte[] IDImageData { get; private set; }
        public bool IsConsentGiven => chkConsent.Checked;
        public bool IsVerified { get; private set; }

        // State tracking
        private bool _hasImage = false;
        private Image _originalImage;
        private VerificationStatus _currentStatus = VerificationStatus.NotVerified;

        private enum VerificationStatus
        {
            NotVerified,
            Pending,
            Verified
        }

        public IDVerification()
        {
            InitializeComponent();
            InitializeUI();
            WireEvents();
        }

        private void InitializeUI()
        {
            // Set initial states
            cmbIDType.SelectedIndex = 0; // Select "Driver's License" by default
            UpdateStatus(VerificationStatus.NotVerified);
            UpdateButtonStates();

            // Set tooltips
            toolTip.SetToolTip(btnCapture, "Use webcam to capture ID photo");
            toolTip.SetToolTip(btnUpload, "Upload ID image from computer");
            toolTip.SetToolTip(btnRetake, "Discard current image and take new one");
            toolTip.SetToolTip(btnViewOriginal, "View full-size original image");
            toolTip.SetToolTip(chkConsent, "Required for processing your ID verification");
        }

        private void WireEvents()
        {
            btnCapture.Click += BtnCapture_Click;
            btnUpload.Click += BtnUpload_Click;
            btnRetake.Click += BtnRetake_Click;
            btnViewOriginal.Click += BtnViewOriginal_Click;
            btnConfirm.Click += BtnConfirm_Click;
            btnCancel.Click += BtnCancel_Click;
            chkConsent.CheckedChanged += ChkConsent_CheckedChanged;
            cmbIDType.SelectedIndexChanged += CmbIDType_SelectedIndexChanged;
        }

        #region Button Click Handlers

        private void BtnCapture_Click(object sender, EventArgs e)
        {
            // In a real application, you would open a webcam capture dialog
            // For now, we'll simulate by opening a file dialog
            MessageBox.Show("Webcam capture would open here. For demo, use Upload instead.",
                "Capture ID",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    LoadIDImage(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnRetake_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Discard current ID image and capture new one?",
                "Confirm Retake",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearIDImage();
            }
        }

        private void BtnViewOriginal_Click(object sender, EventArgs e)
        {
            if (_originalImage != null)
            {
                using (var viewer = new Form())
                {
                    viewer.Text = "Original ID Image";
                    viewer.StartPosition = FormStartPosition.CenterParent;
                    viewer.Size = new Size(800, 600);
                    viewer.FormBorderStyle = FormBorderStyle.FixedDialog;
                    viewer.MaximizeBox = false;

                    var pictureBox = new PictureBox
                    {
                        Dock = DockStyle.Fill,
                        Image = _originalImage,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        BackColor = Color.Black
                    };

                    viewer.Controls.Add(pictureBox);
                    viewer.ShowDialog(this);
                }
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            // Mark as verified
            IsVerified = true;
            UpdateStatus(VerificationStatus.Verified);

            // Convert image to byte array for storage
            if (_originalImage != null)
            {
                using (var ms = new MemoryStream())
                {
                    _originalImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    IDImageData = ms.ToArray();
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion

        #region Event Handlers

        private void ChkConsent_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButtonStates();
        }

        private void CmbIDType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // You could add specific validation or UI updates based on ID type
            UpdateButtonStates();
        }

        #endregion

        #region Image Management

        private void LoadIDImage(string filePath)
        {
            try
            {
                // Load and resize for preview
                _originalImage = Image.FromFile(filePath);

                // Create preview image (resized)
                var previewImage = ResizeImage(_originalImage, picIDPreview.Size);

                // Show preview
                picIDPreview.Image = previewImage;
                picIDPreview.Visible = true;
                lblPreviewPlaceholder.Visible = false;
                lblPreviewStatus.Visible = true;

                // Update state
                _hasImage = true;
                UpdateStatus(VerificationStatus.Pending);
                UpdateButtonStates();

                // Show success message
                lblStatus.Text = "🟡 Pending Verification";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load image: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ClearIDImage()
        {
            // Dispose of images
            if (picIDPreview.Image != null)
            {
                picIDPreview.Image.Dispose();
                picIDPreview.Image = null;
            }

            if (_originalImage != null)
            {
                _originalImage.Dispose();
                _originalImage = null;
            }

            // Reset UI
            picIDPreview.Visible = false;
            lblPreviewPlaceholder.Visible = true;
            lblPreviewStatus.Visible = false;

            // Update state
            _hasImage = false;
            UpdateStatus(VerificationStatus.NotVerified);
            UpdateButtonStates();

            IDImageData = null;
        }

        private Image ResizeImage(Image image, Size size)
        {
            // Calculate aspect ratio
            double ratioX = (double)size.Width / image.Width;
            double ratioY = (double)size.Height / image.Height;
            double ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(image.Width * ratio);
            int newHeight = (int)(image.Height * ratio);

            // Create new bitmap
            Bitmap newImage = new Bitmap(newWidth, newHeight);

            using (Graphics graphics = Graphics.FromImage(newImage))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return newImage;
        }

        #endregion

        #region State Management

        private void UpdateStatus(VerificationStatus status)
        {
            _currentStatus = status;

            switch (status)
            {
                case VerificationStatus.NotVerified:
                    lblStatus.Text = "🔴 Not Verified";
                    lblStatus.ForeColor = Color.FromArgb(231, 76, 60); // Red
                    break;
                case VerificationStatus.Pending:
                    lblStatus.Text = "🟡 Pending";
                    lblStatus.ForeColor = Color.FromArgb(243, 156, 18); // Orange
                    break;
                case VerificationStatus.Verified:
                    lblStatus.Text = "🟢 Verified";
                    lblStatus.ForeColor = Color.FromArgb(46, 204, 113); // Green
                    break;
            }
        }

        private void UpdateButtonStates()
        {
            // Update action buttons based on state
            btnCapture.Enabled = !_hasImage;
            btnUpload.Enabled = !_hasImage;
            btnRetake.Enabled = _hasImage;
            btnViewOriginal.Enabled = _hasImage;

            // Update confirm button
            btnConfirm.Enabled = _hasImage && chkConsent.Checked && cmbIDType.SelectedIndex >= 0;

            // Show/hide buttons based on state
            btnCapture.Visible = !_hasImage;
            btnUpload.Visible = !_hasImage;
            btnRetake.Visible = _hasImage;
            btnViewOriginal.Visible = _hasImage;
        }

        private bool ValidateInputs()
        {
            // Check ID type
            if (cmbIDType.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an ID type.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cmbIDType.Focus();
                return false;
            }

            // Check image
            if (!_hasImage || _originalImage == null)
            {
                MessageBox.Show("Please capture or upload an ID image.",
                    "Missing ID Image",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            // Check consent
            if (!chkConsent.Checked)
            {
                MessageBox.Show("You must consent to ID verification to proceed.",
                    "Consent Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                chkConsent.Focus();
                return false;
            }

            return true;
        }

        #endregion

        #region Public Methods

        public void PreloadData(string idType, byte[] existingImage = null)
        {
            // Set ID type
            if (!string.IsNullOrEmpty(idType))
            {
                int index = cmbIDType.FindString(idType);
                if (index >= 0)
                    cmbIDType.SelectedIndex = index;
            }

            // Load existing image
            if (existingImage != null && existingImage.Length > 0)
            {
                try
                {
                    using (var ms = new MemoryStream(existingImage))
                    {
                        _originalImage = Image.FromStream(ms);
                        var previewImage = ResizeImage(_originalImage, picIDPreview.Size);
                        picIDPreview.Image = previewImage;
                        picIDPreview.Visible = true;
                        lblPreviewPlaceholder.Visible = false;
                        lblPreviewStatus.Visible = true;
                        _hasImage = true;
                        UpdateStatus(VerificationStatus.Verified);
                        UpdateButtonStates();
                        chkConsent.Checked = true; // Assume consent if preloading
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load existing image: {ex.Message}",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        #endregion

        #region Form Events

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Clean up images
            if (picIDPreview.Image != null)
            {
                picIDPreview.Image.Dispose();
                picIDPreview.Image = null;
            }

            if (_originalImage != null)
            {
                _originalImage.Dispose();
                _originalImage = null;
            }

            base.OnFormClosing(e);
        }

        #endregion
    }
}