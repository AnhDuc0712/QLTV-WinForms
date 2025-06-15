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
            string fullname = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();


            lblError.Visible = false;

            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(fullname))
            {
                lblError.Text = "Vui lòng nhập đầy đủ các trường bắt buộc!";
                lblError.Visible = true;
                return;
            }

            using (var db = new LibraryContext())
            {
                // Kiểm tra tài khoản trùng
                if (db.Users.Any(u => u.Username == username))
                {
                    lblError.Text = "Tài khoản đã tồn tại!";
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
                    Address = address,  // Thêm dòng này
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
    }
}
