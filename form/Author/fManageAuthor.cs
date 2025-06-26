using System;
using System.Linq;
using System.Windows.Forms;
using QLTV;
using QLTV.Models;

namespace Ngducanh
{
    public partial class fManageAuthor : Form
    {
        private LibraryContext _context = new LibraryContext();

        public fManageAuthor()
        {
            InitializeComponent();
        }

        private void fManageAuthor_Load(object sender, EventArgs e)
        {
            LoadAuthors();
        }

        // Hàm nạp danh sách tác giả (toàn bộ hoặc theo từ khóa)
        private void LoadAuthors(string keyword = "")
        {
            var authors = _context.Authors
                .Where(a => a.Name.Contains(keyword))
                .Select(a => new
                {
                    a.AuthorId,
                    a.Name
                }).ToList();

            dgvAuthors.DataSource = authors;
            dgvAuthors.Columns[0].HeaderText = "Mã tác giả";
            dgvAuthors.Columns[1].HeaderText = "Tên tác giả";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var f = new fNewAuthor();
            f.FormClosed += (s, args) => LoadAuthors(txtSearch.Text);
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAuthors.CurrentRow != null)
            {
                int authorId = (int)dgvAuthors.CurrentRow.Cells["AuthorId"].Value;
                var f = new fEditAuthor(authorId);
                f.FormClosed += (s, args) => LoadAuthors(txtSearch.Text);
                f.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAuthors.CurrentRow != null)
            {
                int authorId = (int)dgvAuthors.CurrentRow.Cells["AuthorId"].Value;
                var author = _context.Authors.Find(authorId);

                if (author != null && MessageBox.Show("Xóa tác giả này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _context.Authors.Remove(author);
                    _context.SaveChanges();
                    LoadAuthors(txtSearch.Text);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadAuthors(txtSearch.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAuthors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
