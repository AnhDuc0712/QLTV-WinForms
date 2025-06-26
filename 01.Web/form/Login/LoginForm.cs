using System;
using System.Linq;
using System.Windows.Forms;
using QLTV.Models;
using QLTV;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Ngducanh
{
    public partial class LoginForm : Form
    {
        public string Username { get; set; }

        public LoginForm()
        {

            InitializeComponent();
        }

        // Sự kiện đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var db = new LibraryContext())
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                var emp = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
                if (emp != null)
                {
                    lblError.Visible = false;
                    this.Hide();

                    // Show MainMenuForm, chỉ mở 1 form duy nhất
                    using (var mainMenu = new MainMenuForm(emp.FullName))
                    {
                        mainMenu.ShowDialog();
                    }

                    // Khi MainMenuForm đóng thì đóng luôn LoginForm (thoát app)
                    this.Close();
                }
                else
                {
                    lblError.Text = "Sai tài khoản hoặc mật khẩu!";
                    lblError.Visible = true;
                }
            }
        }

        // Sự kiện đăng ký
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var regForm = new RegisterForm())
            {
                regForm.ShowDialog();
            }
            this.Show();
        }

        // Nếu vẫn còn lỗi LoginForm_Load thì thêm hàm này vào cho yên tâm!
        private void LoginForm_Load(object sender, EventArgs e) { }

        // Sự kiện "Quên mật khẩu"
        private void lblForgot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ quản trị viên để lấy lại mật khẩu.", "Quên mật khẩu");
        }

        // Ẩn lỗi khi nhập lại
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}