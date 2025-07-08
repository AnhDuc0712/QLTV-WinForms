using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLTV.form.Reader
{
    partial class fEditReader
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblFullName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            btSave = new Button();
            btClose = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold); // Chuyển font sang Segoe UI để đồng bộ
            lblTitle.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            lblTitle.Location = new Point(431, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(196, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🔧 SỬA ĐỘC GIẢ";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold); // Chuyển font sang Segoe UI
            lblFullName.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            lblFullName.Location = new Point(40, 70);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(74, 24);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Họ tên:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold); // Chuyển font sang Segoe UI
            lblEmail.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            lblEmail.Location = new Point(50, 124);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(62, 24);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold); // Chuyển font sang Segoe UI
            lblPhone.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            lblPhone.Location = new Point(467, 67);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(108, 24);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Điện thoại:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold); // Chuyển font sang Segoe UI
            lblAddress.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            lblAddress.Location = new Point(467, 128);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(75, 24);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "Địa chỉ:";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.FromArgb(232, 236, 239); // #E8ECEF (Xám bạc)
            txtFullName.Font = new Font("Segoe UI", 11F);
            txtFullName.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            txtFullName.Location = new Point(140, 67);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(240, 32);
            txtFullName.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(232, 236, 239); // #E8ECEF (Xám bạc)
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            txtEmail.Location = new Point(140, 121);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 32);
            txtEmail.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(232, 236, 239); // #E8ECEF (Xám bạc)
            txtPhone.Font = new Font("Segoe UI", 11F);
            txtPhone.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            txtPhone.Location = new Point(586, 67);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(247, 32);
            txtPhone.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(232, 236, 239); // #E8ECEF (Xám bạc)
            txtAddress.Font = new Font("Segoe UI", 11F);
            txtAddress.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            txtAddress.Location = new Point(586, 121);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(555, 32);
            txtAddress.TabIndex = 8;
            // 
            // btSave
            // 
            btSave.BackColor = Color.FromArgb(42, 46, 69); // #2A2E45 (Xanh đen sâu thẳm)
            btSave.FlatStyle = FlatStyle.Flat;
            btSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btSave.ForeColor = Color.FromArgb(255, 215, 0); // #FFD700 (Vàng ánh kim)
            btSave.Location = new Point(571, 217);
            btSave.Name = "btSave";
            btSave.Size = new Size(102, 58);
            btSave.TabIndex = 9;
            btSave.Text = "Lưu 💾";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            btSave.MouseEnter += (s, e) => btSave.BackColor = Color.FromArgb(60, 64, 87); // Tối hơn #2A2E45 khi hover
            btSave.MouseLeave += (s, e) => btSave.BackColor = Color.FromArgb(42, 46, 69); // Trở lại #2A2E45 khi không hover
            // 
            // btClose
            // 
            btClose.BackColor = Color.FromArgb(232, 236, 239); // #E8ECEF (Xám bạc)
            btClose.FlatStyle = FlatStyle.Flat;
            btClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btClose.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            btClose.Location = new Point(381, 217);
            btClose.Name = "btClose";
            btClose.Size = new Size(106, 58);
            btClose.TabIndex = 10;
            btClose.Text = "Đóng ❌";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            btClose.MouseEnter += (s, e) => btClose.BackColor = Color.FromArgb(200, 204, 207); // Tối hơn #E8ECEF khi hover
            btClose.MouseLeave += (s, e) => btClose.BackColor = Color.FromArgb(232, 236, 239); // Trở lại #E8ECEF khi không hover
            // 
            // fEditReader
            // 
            BackColor = Color.FromArgb(247, 249, 251); // #F7F9FB (Trắng xám nhạt)
            ClientSize = new Size(1175, 396);
            Controls.Add(lblTitle);
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(btSave);
            Controls.Add(btClose);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold); // Chuyển font sang Segoe UI
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "fEditReader";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sửa độc giả";
            Load += fEditReader_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}