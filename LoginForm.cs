using System;
using System.Linq; // dùng cho FirstOrDefault
using System.Windows.Forms;

namespace Ngducanh
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            // Không cần tạo lại control!
            // Có thể chỉnh thêm thuộc tính cho đẹp ở đây nếu muốn
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
                    this.Hide();
                    MainMenuForm mainMenu = new MainMenuForm();
                    mainMenu.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
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
    }
}
