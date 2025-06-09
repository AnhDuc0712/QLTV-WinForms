namespace Ngducanh
{
    partial class LoginForm
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
            panel1 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            lblError = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            btnRegister = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(lblError);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(btnRegister);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(400, 250);
            panel1.TabIndex = 0;
            // 
            // label3 - Quên mật khẩu
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            label3.ForeColor = System.Drawing.Color.Blue;
            label3.Location = new System.Drawing.Point(30, 147);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(120, 20);
            label3.TabIndex = 7;
            label3.Text = "Quên mật khẩu?";
            label3.Cursor = System.Windows.Forms.Cursors.Hand;
            label3.Click += label3_Click;
            // 
            // lblError - Báo lỗi
            // 
            lblError.AutoSize = true;
            lblError.BackColor = System.Drawing.Color.White;
            lblError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblError.ForeColor = System.Drawing.Color.Red;
            lblError.Location = new System.Drawing.Point(160, 147); // Ngay bên phải "Quên mật khẩu?"
            lblError.Name = "lblError";
            lblError.Size = new System.Drawing.Size(0, 20);
            lblError.TabIndex = 8;
            lblError.Visible = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204);
            lblTitle.Location = new System.Drawing.Point(0, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(400, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐĂNG NHẬP HỆ THỐNG THƯ VIỆN";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            label1.Location = new System.Drawing.Point(30, 65);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(86, 23);
            label1.TabIndex = 1;
            label1.Text = "Tài khoản:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtUsername.Location = new System.Drawing.Point(120, 62);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(230, 30);
            txtUsername.TabIndex = 2;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            label2.Location = new System.Drawing.Point(30, 110);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 23);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtPassword.Location = new System.Drawing.Point(120, 107);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(230, 30);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.FromArgb(0, 153, 51);
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.Location = new System.Drawing.Point(120, 183);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(110, 36);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = System.Drawing.Color.WhiteSmoke;
            btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnRegister.ForeColor = System.Drawing.Color.FromArgb(0, 153, 51);
            btnRegister.Location = new System.Drawing.Point(253, 183);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(110, 36);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(400, 250); // vừa panel, không dư
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            Text = "Đăng nhập hệ thống thư viện";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblError;
    }
}
