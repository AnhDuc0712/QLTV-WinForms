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
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(434, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(280, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "➕THÊM MỚI ĐỘC GIẢ";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Viner Hand ITC", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(40, 70);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(82, 29);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Họ tên:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Viner Hand ITC", 10.8F, FontStyle.Bold | FontStyle.Italic);
            lblEmail.Location = new Point(40, 110);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(76, 29);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Viner Hand ITC", 10.8F, FontStyle.Bold | FontStyle.Italic);
            lblPhone.Location = new Point(434, 73);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(117, 29);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Điện thoại:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Viner Hand ITC", 10.8F, FontStyle.Bold | FontStyle.Italic);
            lblAddress.Location = new Point(451, 117);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(81, 29);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "Địa chỉ:";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 11F);
            txtFullName.Location = new Point(140, 67);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(240, 32);
            txtFullName.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(140, 107);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 32);
            txtEmail.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 11F);
            txtPhone.Location = new Point(563, 66);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(240, 32);
            txtPhone.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 11F);
            txtAddress.Location = new Point(563, 110);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(565, 32);
            txtAddress.TabIndex = 8;
            // 
            // btSave
            // 
            btSave.BackColor = Color.LightGreen;
            btSave.FlatStyle = FlatStyle.Flat;
            btSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btSave.Location = new Point(572, 218);
            btSave.Name = "btSave";
            btSave.Size = new Size(105, 51);
            btSave.TabIndex = 9;
            btSave.Text = "Lưu 💾";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.BackColor = Color.LightGray;
            btClose.FlatStyle = FlatStyle.Flat;
            btClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btClose.Location = new Point(409, 218);
            btClose.Name = "btClose";
            btClose.Size = new Size(103, 51);
            btClose.TabIndex = 10;
            btClose.Text = "Đóng ❌";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // fNewReader
            // 
            BackColor = Color.DarkGray;
            ClientSize = new Size(1202, 390);
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
