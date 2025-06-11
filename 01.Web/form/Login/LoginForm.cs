using System;
using System.Linq;
using System.Windows.Forms;
using QLTV.Models;
using QLTV;


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

                var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
                if (user != null)
                {
                    lblError.Visible = false;
                    this.Hide();
                    // Gửi tên đầy đủ qua MainMenuForm, có thể dùng user.Username nếu chỉ muốn hiển thị tài khoản
                    MainMenuForm mainMenu = new MainMenuForm(user.FullName);
                    mainMenu.ShowDialog();
                    this.Show();
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
            RegisterForm regForm = new RegisterForm();
            regForm.ShowDialog();
        }

        // Nếu vẫn còn lỗi LoginForm_Load thì thêm hàm này vào cho yên tâm!
        private void LoginForm_Load(object sender, EventArgs e) { }

        // Sự kiện "Quên mật khẩu"
        private void label3_Click(object sender, EventArgs e)
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
    }
}
