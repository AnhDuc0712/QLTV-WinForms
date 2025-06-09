using System;
using System.Windows.Forms;
using QLTV.Models;

namespace QLTV.form.Reader
{
    public partial class fEditReader : Form
    {
        private int _userId;
        public fEditReader(int userId)
        {
            InitializeComponent();
            _userId = userId;
            this.Load += fEditReader_Load; // Gán sự kiện Load!
        }

        private void fEditReader_Load(object sender, EventArgs e)
        {
            using (var db = new LibraryContext())
            {
                var user = db.Users.Find(_userId);
                if (user != null)
                {
                    txtFullName.Text = user.FullName;
                    txtEmail.Text = user.Email;
                    txtPhone.Text = user.Phone;
                    txtAddress.Text = user.Address;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy độc giả!");
                    this.Close();
                }
            }
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

            try
            {
                using (var db = new LibraryContext())
                {
                    var user = db.Users.Find(_userId);
                    if (user != null)
                    {
                        user.FullName = txtFullName.Text.Trim();
                        user.Email = txtEmail.Text.Trim();
                        user.Phone = txtPhone.Text.Trim();
                        user.Address = txtAddress.Text.Trim();
                        db.SaveChanges();
                    }
                }
                MessageBox.Show("Cập nhật thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
