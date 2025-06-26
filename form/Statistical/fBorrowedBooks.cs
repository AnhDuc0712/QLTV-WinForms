using QLTV.Models;
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
                            BorrowCount = g.Count(),
                            Readers = string.Join(", ",
                                g.Select(x => x.BorrowReceipt.User.FullName).Distinct())
                        })
                        .OrderByDescending(x => x.BorrowCount)
                        .ToList();

                    dataGridView1.DataSource = result;

                    // Tổng số lượt mượn
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
            // Không cần xử lý gì cho label này
        }
    }
}
