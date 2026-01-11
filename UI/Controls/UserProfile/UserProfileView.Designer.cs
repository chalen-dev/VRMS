using System;
using System.Drawing;
using System.Windows.Forms;

namespace VRMS.Controls.UserProfile
{
    partial class UserProfileView
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelContainer = new System.Windows.Forms.Panel();
            panelForm = new System.Windows.Forms.Panel();
            btnSave = new System.Windows.Forms.Button();
            btnChangePassword = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            txtConfirmPassword = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            txtNewPassword = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            txtCurrentPassword = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            txtPhone = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtFullName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            panelProfileHeader = new System.Windows.Forms.Panel();
            panelProfileImage = new System.Windows.Forms.Panel();
            btnEditPhoto = new System.Windows.Forms.Button();
            picProfile = new System.Windows.Forms.PictureBox();
            lblProfileRole = new System.Windows.Forms.Label();
            lblProfileName = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panelContainer.SuspendLayout();
            panelForm.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panelProfileHeader.SuspendLayout();
            panelProfileImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.BackColor = System.Drawing.Color.White;
            panelContainer.Controls.Add(panelForm);
            panelContainer.Controls.Add(panelProfileHeader);
            panelContainer.Controls.Add(label1);
            panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContainer.Location = new System.Drawing.Point(0, 0);
            panelContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panelContainer.Name = "panelContainer";
            panelContainer.Padding = new System.Windows.Forms.Padding(27, 31, 27, 31);
            panelContainer.Size = new System.Drawing.Size(840, 760);
            panelContainer.TabIndex = 0;
            // 
            // panelForm
            // 
            panelForm.Controls.Add(btnSave);
            panelForm.Controls.Add(btnChangePassword);
            panelForm.Controls.Add(groupBox2);
            panelForm.Controls.Add(groupBox1);
            panelForm.Location = new System.Drawing.Point(27, 215);
            panelForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panelForm.Name = "panelForm";
            panelForm.Size = new System.Drawing.Size(787, 514);
            panelForm.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(13, 431);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(373, 62);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save Profile";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            btnChangePassword.FlatAppearance.BorderSize = 0;
            btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnChangePassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            btnChangePassword.ForeColor = System.Drawing.Color.White;
            btnChangePassword.Location = new System.Drawing.Point(400, 431);
            btnChangePassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new System.Drawing.Size(373, 62);
            btnChangePassword.TabIndex = 5;
            btnChangePassword.Text = "Confirm new Password";
            btnChangePassword.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtConfirmPassword);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtNewPassword);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtCurrentPassword);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            groupBox2.Location = new System.Drawing.Point(400, 15);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox2.Size = new System.Drawing.Size(373, 400);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Change Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            txtConfirmPassword.Location = new System.Drawing.Point(27, 300);
            txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '•';
            txtConfirmPassword.Size = new System.Drawing.Size(319, 30);
            txtConfirmPassword.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.Color.DimGray;
            label8.Location = new System.Drawing.Point(23, 272);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(130, 20);
            label8.TabIndex = 0;
            label8.Text = "Confirm Password:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            txtNewPassword.Location = new System.Drawing.Point(27, 208);
            txtNewPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '•';
            txtNewPassword.Size = new System.Drawing.Size(319, 30);
            txtNewPassword.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.DimGray;
            label7.Location = new System.Drawing.Point(23, 180);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(107, 20);
            label7.TabIndex = 0;
            label7.Text = "New Password:";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            txtCurrentPassword.Location = new System.Drawing.Point(27, 115);
            txtCurrentPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.PasswordChar = '•';
            txtCurrentPassword.Size = new System.Drawing.Size(319, 30);
            txtCurrentPassword.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.DimGray;
            label6.Location = new System.Drawing.Point(23, 88);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(125, 20);
            label6.TabIndex = 0;
            label6.Text = "Current Password:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            groupBox1.Location = new System.Drawing.Point(13, 15);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Size = new System.Drawing.Size(373, 400);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Information";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            txtPhone.Location = new System.Drawing.Point(27, 300);
            txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(319, 30);
            txtPhone.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.DimGray;
            label5.Location = new System.Drawing.Point(23, 272);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(111, 20);
            label5.TabIndex = 0;
            label5.Text = "Phone Number:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            txtEmail.Location = new System.Drawing.Point(27, 208);
            txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(319, 30);
            txtEmail.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.DimGray;
            label4.Location = new System.Drawing.Point(23, 180);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(49, 20);
            label4.TabIndex = 0;
            label4.Text = "Email:";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            txtFullName.Location = new System.Drawing.Point(27, 115);
            txtFullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(319, 30);
            txtFullName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.DimGray;
            label3.Location = new System.Drawing.Point(23, 88);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 20);
            label3.TabIndex = 0;
            label3.Text = "Full Name:";
            // 
            // txtUsername
            // 
            txtUsername.Enabled = false;
            txtUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            txtUsername.Location = new System.Drawing.Point(27, 54);
            txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new System.Drawing.Size(319, 30);
            txtUsername.TabIndex = 0;
            txtUsername.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.DimGray;
            label2.Location = new System.Drawing.Point(23, 26);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 20);
            label2.TabIndex = 0;
            label2.Text = "Username:";
            // 
            // panelProfileHeader
            // 
            panelProfileHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            panelProfileHeader.Controls.Add(panelProfileImage);
            panelProfileHeader.Controls.Add(lblProfileRole);
            panelProfileHeader.Controls.Add(lblProfileName);
            panelProfileHeader.Location = new System.Drawing.Point(27, 77);
            panelProfileHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panelProfileHeader.Name = "panelProfileHeader";
            panelProfileHeader.Size = new System.Drawing.Size(787, 123);
            panelProfileHeader.TabIndex = 1;
            // 
            // panelProfileImage
            // 
            panelProfileImage.BackColor = System.Drawing.Color.Transparent;
            panelProfileImage.Controls.Add(btnEditPhoto);
            panelProfileImage.Controls.Add(picProfile);
            panelProfileImage.Location = new System.Drawing.Point(19, 17);
            panelProfileImage.Name = "panelProfileImage";
            panelProfileImage.Size = new System.Drawing.Size(95, 95);
            panelProfileImage.TabIndex = 4;
            // 
            // btnEditPhoto
            // 
            btnEditPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            btnEditPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditPhoto.FlatAppearance.BorderSize = 0;
            btnEditPhoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            btnEditPhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            btnEditPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditPhoto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            btnEditPhoto.ForeColor = System.Drawing.Color.White;
            btnEditPhoto.Location = new System.Drawing.Point(67, 67);
            btnEditPhoto.Name = "btnEditPhoto";
            btnEditPhoto.Size = new System.Drawing.Size(26, 26);
            btnEditPhoto.TabIndex = 5;
            btnEditPhoto.Text = "✎";
            btnEditPhoto.UseVisualStyleBackColor = false;
            // 
            // picProfile
            // 
            picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            picProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            picProfile.Location = new System.Drawing.Point(0, 0);
            picProfile.Name = "picProfile";
            picProfile.Size = new System.Drawing.Size(95, 95);
            picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picProfile.TabIndex = 3;
            picProfile.TabStop = false;
            // 
            // lblProfileRole
            // 
            lblProfileRole.AutoSize = true;
            lblProfileRole.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblProfileRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            lblProfileRole.Location = new System.Drawing.Point(133, 65);
            lblProfileRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblProfileRole.Name = "lblProfileRole";
            lblProfileRole.Size = new System.Drawing.Size(53, 23);
            lblProfileRole.TabIndex = 2;
            lblProfileRole.Text = "(Role)";
            // 
            // lblProfileName
            // 
            lblProfileName.AutoSize = true;
            lblProfileName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lblProfileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            lblProfileName.Location = new System.Drawing.Point(131, 23);
            lblProfileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblProfileName.Name = "lblProfileName";
            lblProfileName.Size = new System.Drawing.Size(135, 32);
            lblProfileName.TabIndex = 1;
            lblProfileName.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            label1.Location = new System.Drawing.Point(27, 31);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(105, 28);
            label1.TabIndex = 0;
            label1.Text = "My Profile";
            // 
            // UserProfileView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panelContainer);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Size = new System.Drawing.Size(840, 760);
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            panelForm.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelProfileHeader.ResumeLayout(false);
            panelProfileHeader.PerformLayout();
            panelProfileImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox picProfile;

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelProfileHeader;
        private System.Windows.Forms.Label lblProfileRole;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnEditPhoto;
        private System.Windows.Forms.Panel panelProfileImage;
    }
}