using System;
using System.Linq;
using System.Windows.Forms;
using QLTV.Models;
using QLTV;

namespace Ngducanh
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string repassword = txtConfirmPassword.Text.Trim();
            string fullname = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();

            lblError.Visible = false;

            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(fullname))
            {
                lblError.Text = "Vui lòng nhập đầy đủ các thông tin bắt buộc!";
                lblError.Visible = true;
                return;
            }
            if (!email.Contains("@") || !email.Contains("."))
            {
                lblError.Text = "Email không hợp lệ!";
                lblError.Visible = true;
                return;
            }
            if (phone.Length < 8 ||  !phone.All(char.IsDigit))
            {
                lblError.Text = "Số điện thoại phải từ trên 8 số!";
                lblError.Visible = true;
                return;
            }
            else if(phone.Length > 10 || !phone.All(char.IsDigit))
            {
                lblError.Text = " Số điên thoại phải ít hơn 10 số !";
                lblError.Visible = true;
                return;
            }
            if (repassword != password)
            {
                lblError.Text = "Mật khẩu không khớp!";
                lblError.Visible = true;
                return;
            }

            using (var db = new LibraryContext())
            {
                // Kiểm tra trùng Username, Email, Phone
                var existedUser = db.Users.FirstOrDefault(u =>
                                        u.Username == username ||
                                        u.Email == email ||
                                        u.Phone == phone);

                if (existedUser != null)
                {
                    if (existedUser.Username == username)
                        lblError.Text = "Tài khoản đã tồn tại!";
                    else if (existedUser.Email == email)
                        lblError.Text = "Email đã tồn tại!";
                    else
                        lblError.Text = "Số điện thoại đã tồn tại!";

                    lblError.Visible = true;
                    return;
                }

                var emp = new Employee
                {
                    Username = username,
                    Password = password,
                    FullName = fullname,
                    Email = email,
                    Phone = phone,
                    Address = address,
                    UserType = "Employee"
                };

                db.Users.Add(emp);
                db.SaveChanges();

                MessageBox.Show("Đăng ký thành công!");
                this.Close(); // Đóng form đăng ký
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
