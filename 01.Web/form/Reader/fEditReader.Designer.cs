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

            lblTitle.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(431, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(196, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🔧SỬA ĐỘC GIẢ";

            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;

            lblFullName.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(40, 70);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(74, 24);

            lblFullName.TabIndex = 1;
            lblFullName.Text = "Họ tên:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;

            lblEmail.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold | FontStyle.Italic);
            lblEmail.Location = new Point(50, 124);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(62, 24);

            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;

            lblPhone.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold | FontStyle.Italic);
            lblPhone.Location = new Point(467, 67);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(108, 24);

            lblPhone.TabIndex = 5;
            lblPhone.Text = "Điện thoại:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;

            lblAddress.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold | FontStyle.Italic);
            lblAddress.Location = new Point(467, 128);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(75, 24);

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

            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 32);
            txtEmail.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 11F);

            txtPhone.Location = new Point(586, 67);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(247, 32);

            txtPhone.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 11F);

            txtAddress.Location = new Point(586, 121);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(555, 32);

            txtAddress.TabIndex = 8;
            // 
            // btSave
            // 

            btSave.BackColor = Color.FromArgb(192, 255, 192);
            btSave.FlatStyle = FlatStyle.Flat;
            btSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btSave.Location = new Point(571, 217);
            btSave.Name = "btSave";
            btSave.Size = new Size(102, 58);
            btSave.TabIndex = 9;
            btSave.Text = "Lưu 💾";

            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 

            btClose.BackColor = Color.FromArgb(224, 224, 224);
            btClose.FlatStyle = FlatStyle.Flat;
            btClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btClose.Location = new Point(381, 217);
            btClose.Name = "btClose";
            btClose.Size = new Size(106, 58);
            btClose.TabIndex = 10;
            btClose.Text = "Đóng ❌";

            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // fEditReader
            // 

            BackColor = Color.DarkGray;
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

            Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);

            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "fEditReader";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sửa độc giả";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
