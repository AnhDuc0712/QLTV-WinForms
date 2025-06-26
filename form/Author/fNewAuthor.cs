using QLTV;
using QLTV.Models;

namespace Ngducanh
{
    public partial class fNewAuthor : Form
    {
        private LibraryContext _context = new LibraryContext();

        public fNewAuthor()
        {
            InitializeComponent();
        }

        private void fNewAuthor_Load(object sender, EventArgs e)
        {
            txtName.Focus(); // Tự động focus vào ô nhập
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập tên tác giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Author newAuthor = new Author
            {
                Name = name
            };

            _context.Authors.Add(newAuthor);
            _context.SaveChanges();

            MessageBox.Show("Thêm tác giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
