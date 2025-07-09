namespace QLTV.form.Reader
{
    partial class fNewReader
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtUserType;
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
            lblUsername = new Label();
            lblUserType = new Label();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtUsername = new TextBox();
            txtUserType = new TextBox();
            btSave = new Button();
            btClose = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(160, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(246, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "THÊM MỚI ĐỘC GIẢ";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 11F);
            lblFullName.Location = new Point(40, 70);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(72, 25);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Họ tên:";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 11F);
            txtFullName.Location = new Point(140, 67);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(240, 32);
            txtFullName.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11F);
            lblEmail.Location = new Point(40, 120);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(62, 25);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(140, 117);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 32);
            txtEmail.TabIndex = 4;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 11F);
            lblPhone.Location = new Point(40, 170);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(103, 25);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Điện thoại:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 11F);
            txtPhone.Location = new Point(140, 167);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(240, 32);
            txtPhone.TabIndex = 6;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 11F);
            lblAddress.Location = new Point(40, 220);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(74, 25);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "Địa chỉ:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 11F);
            txtAddress.Location = new Point(140, 217);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(240, 32);
            txtAddress.TabIndex = 8;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 11F);
            lblUsername.Location = new Point(40, 270);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(96, 25);
            lblUsername.TabIndex = 11;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(140, 267);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(240, 32);
            txtUsername.TabIndex = 12;
            // 
            // lblUserType
            // 
            lblUserType.AutoSize = true;
            lblUserType.Font = new Font("Segoe UI", 11F);
            lblUserType.Location = new Point(40, 320);
            lblUserType.Name = "lblUserType";
            lblUserType.Size = new Size(92, 25);
            lblUserType.TabIndex = 13;
            lblUserType.Text = "User type:";
            // 
            // txtUserType
            // 
            txtUserType.Font = new Font("Segoe UI", 11F);
            txtUserType.Location = new Point(140, 317);
            txtUserType.Name = "txtUserType";
            txtUserType.Size = new Size(240, 32);
            txtUserType.TabIndex = 14;
            // 
            // btSave
            // 
            btSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btSave.Location = new Point(140, 370);
            btSave.Name = "btSave";
            btSave.Size = new Size(90, 38);
            btSave.TabIndex = 9;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            btSave.MouseEnter += btSave_MouseEnter;
            btSave.MouseLeave += btSave_MouseLeave;
            // 
            // btClose
            // 
            btClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btClose.Location = new Point(257, 370);
            btClose.Name = "btClose";
            btClose.Size = new Size(90, 38);
            btClose.TabIndex = 10;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            btClose.MouseEnter += btClose_MouseEnter;
            btClose.MouseLeave += btClose_MouseLeave;
            // 
            // fNewReader
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(680, 450);
            Controls.Add(lblTitle);
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblUserType);
            Controls.Add(txtUserType);
            Controls.Add(btSave);
            Controls.Add(btClose);
            Font = new Font("Segoe UI", 11F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "fNewReader";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm mới độc giả";
            Load += fNewReader_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
