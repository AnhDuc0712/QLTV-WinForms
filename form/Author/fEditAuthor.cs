using QLTV;
using QLTV.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Ngducanh
{
    public partial class fEditAuthor : Form
    {
        private int _authorId;
        private LibraryContext _context = new LibraryContext();
        private Author _author;

        public fEditAuthor(int authorId)
        {
            InitializeComponent();
            _authorId = authorId;
        }

        private void fEditAuthor_Load(object sender, EventArgs e)
        {
            _author = _context.Authors.FirstOrDefault(a => a.AuthorId == _authorId);
            if (_author == null)
            {
                MessageBox.Show("Không tìm thấy tác giả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtName.Text = _author.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập tên tác giả!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _author.Name = name;
            _context.SaveChanges();

            MessageBox.Show("Cập nhật tác giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
