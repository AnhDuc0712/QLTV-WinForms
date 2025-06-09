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

            try
            {
                using (var db = new LibraryContext())
                {
                    var user = new User()
                    {
                        FullName = txtFullName.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Phone = txtPhone.Text.Trim(),
                        Address = txtAddress.Text.Trim()
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
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
