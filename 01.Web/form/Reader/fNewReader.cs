using System;
using System.Windows.Forms;
using QLTV.Models;

namespace QLTV.form.Reader
{
    public partial class fNewReader : Form
    {
        public fNewReader()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Hãy nhập họ tên!");
                txtFullName.Focus(); return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Hãy nhập email!");
                txtEmail.Focus(); return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Hãy nhập điện thoại!");
                txtPhone.Focus(); return;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Hãy nhập địa chỉ!");
                txtAddress.Focus(); return;
            }
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Hãy nhập tên đăng nhập!");
                txtUsername.Focus(); return;
            }
            if (string.IsNullOrWhiteSpace(txtUserType.Text))
            {
                MessageBox.Show("Hãy nhập loại người dùng!");
                txtUserType.Focus(); return;
            }

            try
            {
                using (var db = new LibraryContext())
                {
                    var user = new User()
                    {
                        FullName = txtFullName.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Phone = txtPhone.Text.Trim(),
                        Address = txtAddress.Text.Trim(),
                        Username = txtUsername.Text.Trim(),
                        UserType = txtUserType.Text.Trim(),
                        Password = null 
                    };
                    db.Users.Add(user);
                    db.SaveChanges();
                }
                MessageBox.Show("Thêm thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
        }


        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fNewReader_Load(object sender, EventArgs e)
        {
            txtUserType.Text = "Customer";
            txtUserType.ReadOnly = true; // Nếu không cho người dùng sửa

        }
        private void btSave_MouseEnter(object sender, EventArgs e)
        {
            btSave.BackColor = System.Drawing.Color.FromArgb(60, 64, 87);
        }
        private void btSave_MouseLeave(object sender, EventArgs e)
        {
            btSave.BackColor = System.Drawing.Color.FromArgb(42, 46, 69);
        }
        private void btClose_MouseEnter(object sender, EventArgs e)
        {
            btClose.BackColor = System.Drawing.Color.FromArgb(200, 204, 207);
        }
        private void btClose_MouseLeave(object sender, EventArgs e)
        {
            btClose.BackColor = System.Drawing.Color.FromArgb(232, 236, 239);
        }

    }
}
