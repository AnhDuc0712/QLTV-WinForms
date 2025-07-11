﻿using Siticone.Desktop.UI.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ngducanh
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private SiticoneShadowForm shadowForm;
        private SiticoneElipse siticoneElipse1;
        private SiticoneControlBox siticoneControlBox1;
        private SiticonePanel panelMain;
        private SiticonePanel panelBody;
        private SiticoneTextBox txtFullName;
        private SiticoneTextBox txtUsername;
        private SiticoneTextBox txtPassword;
        private SiticoneTextBox txtConfirmPassword;
        private SiticoneTextBox txtEmail;
        private SiticoneTextBox txtPhone;
        private SiticoneTextBox txtAddress;
        private SiticoneButton btnRegister;
        private SiticoneButton btnCancel;
        private Label lblTitle;
        private Label lblError;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            shadowForm = new SiticoneShadowForm(components);
            siticoneElipse1 = new SiticoneElipse(components);
            siticoneControlBox1 = new SiticoneControlBox();
            panelMain = new SiticonePanel();
            panelBody = new SiticonePanel();
            lblTitle = new Label();
            txtFullName = new SiticoneTextBox();
            txtUsername = new SiticoneTextBox();
            txtPassword = new SiticoneTextBox();
            txtConfirmPassword = new SiticoneTextBox();
            txtEmail = new SiticoneTextBox();
            txtPhone = new SiticoneTextBox();
            txtAddress = new SiticoneTextBox();
            lblError = new Label();
            btnRegister = new SiticoneButton();
            btnCancel = new SiticoneButton();
            panelMain.SuspendLayout();
            panelBody.SuspendLayout();
            SuspendLayout();
            // 
            // shadowForm
            // 
            shadowForm.TargetForm = this;
            // 
            // siticoneElipse1
            // 
            siticoneElipse1.TargetControl = this;
            // 
            // siticoneControlBox1
            // 
            siticoneControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            siticoneControlBox1.FillColor = Color.FromArgb(247, 249, 251); // #F7F9FB (Trắng xám nhạt)
            siticoneControlBox1.IconColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            siticoneControlBox1.Location = new Point(387, 4);
            siticoneControlBox1.Name = "siticoneControlBox1";
            siticoneControlBox1.Size = new Size(30, 30);
            siticoneControlBox1.TabIndex = 0;
            // 
            // panelMain
            // 
            panelMain.BorderRadius = 20;
            panelMain.Controls.Add(siticoneControlBox1);
            panelMain.Controls.Add(panelBody);
            panelMain.FillColor = Color.FromArgb(247, 249, 251); // #F7F9FB (Trắng xám nhạt)
            panelMain.Location = new Point(15, 15);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(420, 580);
            panelMain.TabIndex = 0;
            // 
            // panelBody
            // 
            panelBody.BackColor = Color.Transparent;
            panelBody.Controls.Add(lblTitle);
            panelBody.Controls.Add(txtFullName);
            panelBody.Controls.Add(txtUsername);
            panelBody.Controls.Add(txtPassword);
            panelBody.Controls.Add(txtConfirmPassword);
            panelBody.Controls.Add(txtEmail);
            panelBody.Controls.Add(txtPhone);
            panelBody.Controls.Add(txtAddress);
            panelBody.Controls.Add(lblError);
            panelBody.Controls.Add(btnRegister);
            panelBody.Controls.Add(btnCancel);
            panelBody.Location = new Point(30, 40);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(360, 520);
            panelBody.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            lblTitle.Location = new Point(140, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(110, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Đăng Ký";
            // 
            // txtFullName
            // 
            txtFullName.BorderRadius = 10;
            txtFullName.DefaultText = "";
            txtFullName.FillColor = Color.FromArgb(232, 236, 239); // #E8ECEF (Xám bạc)
            txtFullName.Font = new Font("Segoe UI", 10F);
            txtFullName.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            txtFullName.Location = new Point(40, 40);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.PasswordChar = '\0';
            txtFullName.PlaceholderText = "Họ tên đầy đủ";
            txtFullName.SelectedText = "";
            txtFullName.Size = new Size(280, 40);
            txtFullName.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.BorderRadius = 10;
            txtUsername.DefaultText = "";
            txtUsername.FillColor = Color.FromArgb(232, 236, 239); // #E8ECEF (Xám bạc)
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            txtUsername.Location = new Point(40, 90);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.PlaceholderText = "Tên đăng nhập";
            txtUsername.SelectedText = "";
            txtUsername.Size = new Size(280, 40);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BorderRadius = 10;
            txtPassword.DefaultText = "";
            txtPassword.FillColor = Color.FromArgb(232, 236, 239); // #E8ECEF (Xám bạc)
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            txtPassword.Location = new Point(40, 140);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "Mật khẩu";
            txtPassword.SelectedText = "";
            txtPassword.Size = new Size(280, 40);
            txtPassword.TabIndex = 3;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderRadius = 10;
            txtConfirmPassword.DefaultText = "";
            txtConfirmPassword.FillColor = Color.FromArgb(232, 236, 239); // #E8ECEF (Xám bạc)
            txtConfirmPassword.Font = new Font("Segoe UI", 10F);
            txtConfirmPassword.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            txtConfirmPassword.Location = new Point(40, 190);
            txtConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.PlaceholderText = "Nhập lại mật khẩu";
            txtConfirmPassword.SelectedText = "";
            txtConfirmPassword.Size = new Size(280, 40);
            txtConfirmPassword.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.BorderRadius = 10;
            txtEmail.DefaultText = "";
            txtEmail.FillColor = Color.FromArgb(232, 236, 239); // #E8ECEF (Xám bạc)
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            txtEmail.Location = new Point(40, 240);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PlaceholderText = "Email";
            txtEmail.SelectedText = "";
            txtEmail.Size = new Size(280, 40);
            txtEmail.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.BorderRadius = 10;
            txtPhone.DefaultText = "";
            txtPhone.FillColor = Color.FromArgb(232, 236, 239); // #E8ECEF (Xám bạc)
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            txtPhone.Location = new Point(40, 290);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.PasswordChar = '\0';
            txtPhone.PlaceholderText = "Số điện thoại";
            txtPhone.SelectedText = "";
            txtPhone.Size = new Size(280, 40);
            txtPhone.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.BorderRadius = 10;
            txtAddress.DefaultText = "";
            txtAddress.FillColor = Color.FromArgb(232, 236, 239); // #E8ECEF (Xám bạc)
            txtAddress.Font = new Font("Segoe UI", 10F);
            txtAddress.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            txtAddress.Location = new Point(40, 340);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.PasswordChar = '\0';
            txtAddress.PlaceholderText = "Địa chỉ";
            txtAddress.SelectedText = "";
            txtAddress.Size = new Size(280, 40);
            txtAddress.TabIndex = 7;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblError.ForeColor = Color.FromArgb(255, 0, 0); // Giữ màu đỏ để nổi bật lỗi
            lblError.Location = new Point(40, 385);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 8;
            lblError.Visible = false;
            // 
            // btnRegister
            // 
            btnRegister.BorderRadius = 10;
            btnRegister.FillColor = Color.FromArgb(42, 46, 69); // #2A2E45 (Xanh đen sâu thẳm)
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegister.ForeColor = Color.FromArgb(255, 215, 0); // #FFD700 (Vàng ánh kim)
            btnRegister.HoverState.FillColor = Color.FromArgb(60, 64, 87); // Tối hơn #2A2E45 khi hover
            btnRegister.Location = new Point(40, 410);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(130, 45);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "ĐĂNG KÝ";
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.BorderRadius = 10;
            btnCancel.FillColor = Color.FromArgb(232, 236, 239); // #E8ECEF (Xám bạc)
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            btnCancel.HoverState.FillColor = Color.FromArgb(200, 204, 207); // Tối hơn #E8ECEF khi hover
            btnCancel.Location = new Point(190, 410);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 45);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "QUAY LẠI";
            btnCancel.Click += btnCancel_Click;
            // 
            // RegisterForm
            // 
            BackColor = Color.FromArgb(247, 249, 251); // #F7F9FB (Trắng xám nhạt)
            ClientSize = new Size(450, 610);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panelMain.ResumeLayout(false);
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ResumeLayout(false);
        }
    }
}