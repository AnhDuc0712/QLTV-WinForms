using QLTV.Models; // Sửa lại namespace nếu cần
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLTV.form.Statistical
{
    public partial class fBorrowedBooks : Form
    {
        public fBorrowedBooks()
        {
            InitializeComponent();
        }

        private void fBorrowedBooks_Load(object sender, EventArgs e)
        {
            LoadBorrowedBooks();
        }

        private void LoadBorrowedBooks()
        {
            try
            {
                using (var db = new LibraryContext())
                {
                    var result = db.BorrowDetails
                        .Where(bd => bd.ActualReturnDate == null)
                        .GroupBy(bd => bd.BookId)
                        .Select(g => new
                        {
                            BookId = g.Key,
                            Title = g.First().Book.Title,
                            BorrowCount = g.Count()
                        })
                        .OrderByDescending(x => x.BorrowCount)
                        .ToList();

                    dataGridView1.DataSource = result;

                    // Tính tổng số lượt mượn đang có
                    int total = result.Sum(x => x.BorrowCount);
                    lblTotal.Text = $"Tổng số lượt mượn: {total}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
