namespace Ngducanh
{
    partial class RegisterForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel = new Panel();
            label6 = new Label();
            txtAddress = new TextBox();
            lblTitle = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            txtFullName = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtPhone = new TextBox();
            btnRegister = new Button();
            btnCancel = new Button();
            lblError = new Label();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.White;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(label6);
            panel.Controls.Add(txtAddress);
            panel.Controls.Add(lblTitle);
            panel.Controls.Add(label1);
            panel.Controls.Add(txtUsername);
            panel.Controls.Add(label2);
            panel.Controls.Add(txtPassword);
            panel.Controls.Add(label3);
            panel.Controls.Add(txtFullName);
            panel.Controls.Add(label4);
            panel.Controls.Add(txtEmail);
            panel.Controls.Add(label5);
            panel.Controls.Add(txtPhone);
            panel.Controls.Add(btnRegister);
            panel.Controls.Add(btnCancel);
            panel.Controls.Add(lblError);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(450, 350);
            panel.TabIndex = 0;
            panel.Paint += panel1_Paint;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(30, 259);
            label6.Name = "label6";
            label6.Size = new Size(93, 23);
            label6.TabIndex = 9;
            label6.Text = "Địa chỉ:";
            label6.Click += label6_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(150, 259);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 27);
            txtAddress.TabIndex = 14;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 102, 204);
            lblTitle.Location = new Point(0, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(450, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐĂNG KÝ TÀI KHOẢN THƯ VIỆN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(30, 55);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 1;
            label1.Text = "Tài khoản:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(150, 52);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 30);
            txtUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(30, 95);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(150, 92);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 30);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(30, 135);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 5;
            label3.Text = "Họ và tên:";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 10F);
            txtFullName.Location = new Point(150, 132);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(250, 30);
            txtFullName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(30, 175);
            label4.Name = "label4";
            label4.Size = new Size(55, 23);
            label4.TabIndex = 7;
            label4.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(150, 172);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 30);
            txtEmail.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(30, 215);
            label5.Name = "label5";
            label5.Size = new Size(93, 23);
            label5.TabIndex = 9;
            label5.Text = "Điện thoại:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.Location = new Point(150, 212);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 30);
            txtPhone.TabIndex = 10;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(0, 153, 51);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(100, 299);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(110, 36);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.WhiteSmoke;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(0, 153, 51);
            btnCancel.Location = new Point(251, 299);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 36);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(100, 315);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 13;
            lblError.Visible = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(450, 350);
            Controls.Add(panel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký tài khoản thư viện";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblError;
        private TextBox txtAddress;
        private Label label6;
    }
}
