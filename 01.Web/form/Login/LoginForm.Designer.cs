﻿using Siticone.Desktop.UI.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ngducanh
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private SiticoneShadowForm shadowForm;
        private SiticoneControlBox siticoneControlBox1;
        private SiticoneElipse siticoneElipse1;
        private SiticonePanel panel1;
        private SiticonePanel panel2;
        private SiticoneTextBox txtUsername;
        private SiticoneTextBox txtPassword;
        private SiticoneButton btnLogin;
        private SiticoneButton btnRegister;
        private SiticoneCheckBox checkBox1;
        private Label lblTitle;
        private Label lblForgot;
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
            panel1 = new SiticonePanel();
            panel2 = new SiticonePanel();
            lblTitle = new Label();
            txtUsername = new SiticoneTextBox();
            txtPassword = new SiticoneTextBox();
            checkBox1 = new SiticoneCheckBox();
            btnLogin = new SiticoneButton();
            btnRegister = new SiticoneButton();
            lblForgot = new Label();
            lblError = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            // panel1
            // 
            panel1.BorderRadius = 20;
            panel1.Controls.Add(siticoneControlBox1);
            panel1.Controls.Add(panel2);
            panel1.FillColor = Color.FromArgb(247, 249, 251); // #F7F9FB (Trắng xám nhạt)
            panel1.Location = new Point(15, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 340);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(lblTitle);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(btnRegister);
            panel2.Controls.Add(lblForgot);
            panel2.Location = new Point(30, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(360, 290);
            panel2.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            lblTitle.Location = new Point(60, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(261, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Đăng Nhập Hệ Thống";
            // 
            // txtUsername
            // 
            txtUsername.BorderRadius = 10;
            txtUsername.DefaultText = "";
            txtUsername.FillColor = Color.FromArgb(232, 236, 239); // #E8ECEF (Xám bạc)
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            txtUsername.Location = new Point(40, 40);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.PlaceholderText = "Tên đăng nhập";
            txtUsername.SelectedText = "";
            txtUsername.Size = new Size(280, 40);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BorderRadius = 10;
            txtPassword.DefaultText = "";
            txtPassword.FillColor = Color.FromArgb(232, 236, 239); // #E8ECEF (Xám bạc)
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            txtPassword.Location = new Point(40, 90);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "Mật khẩu";
            txtPassword.SelectedText = "";
            txtPassword.Size = new Size(280, 40);
            txtPassword.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.CheckedState.BorderRadius = 0;
            checkBox1.CheckedState.BorderThickness = 0;
            checkBox1.CheckedState.FillColor = Color.FromArgb(42, 46, 69); // #2A2E45 (Xanh đen sâu thẳm)
            checkBox1.Font = new Font("Segoe UI", 9F);
            checkBox1.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            checkBox1.Location = new Point(40, 140);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(129, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Remember Me";
            checkBox1.UncheckedState.BorderRadius = 0;
            checkBox1.UncheckedState.BorderThickness = 0;
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 10;
            btnLogin.FillColor = Color.FromArgb(42, 46, 69); // #2A2E45 (Xanh đen sâu thẳm)
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.FromArgb(255, 215, 0); // #FFD700 (Vàng ánh kim)
            btnLogin.HoverState.FillColor = Color.FromArgb(60, 64, 87); // Tối hơn #2A2E45 khi hover
            btnLogin.Location = new Point(40, 170);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(280, 45);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "ĐĂNG NHẬP";
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BorderColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            btnRegister.BorderRadius = 10;
            btnRegister.BorderThickness = 1;
            btnRegister.FillColor = Color.Transparent;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegister.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            btnRegister.HoverState.FillColor = Color.FromArgb(232, 236, 239); // #E8ECEF khi hover
            btnRegister.Location = new Point(40, 225);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(280, 40);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "ĐĂNG KÝ";
            btnRegister.Click += btnRegister_Click;
            // 
            // lblForgot
            // 
            lblForgot.AutoSize = true;
            lblForgot.Cursor = Cursors.Hand;
            lblForgot.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblForgot.ForeColor = Color.FromArgb(42, 46, 69); // #2A2E45 (Xanh đen sâu thẳm)
            lblForgot.Location = new Point(40, 270);
            lblForgot.Name = "lblForgot";
            lblForgot.Size = new Size(125, 20);
            lblForgot.TabIndex = 6;
            lblForgot.Text = "Quên mật khẩu?";
            lblForgot.Click += lblForgot_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblError.ForeColor = Color.FromArgb(255, 0, 0); // Giữ màu đỏ để nổi bật lỗi
            lblError.Location = new Point(110, 410);
            lblError.Name = "lblError";
            lblError.Size = new Size(200, 20);
            lblError.TabIndex = 999;
            lblError.Visible = false;
            // 
            // LoginForm
            // 
            BackColor = Color.FromArgb(247, 249, 251); // #F7F9FB (Trắng xám nhạt)
            ClientSize = new Size(450, 370);
            Controls.Add(panel1);
            Controls.Add(lblError);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load_1;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }


    }
}