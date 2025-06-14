using Microsoft.EntityFrameworkCore;
using QLTV.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLTV.form.BorrowReturn
{
    public partial class fReturnBook : Form
    {
        public fReturnBook()
        {
            InitializeComponent();
        }

        public class ReturnBookViewModel
        {
            public int ReceiptId { get; set; }
            public int BookId { get; set; }
            public string TênSách { get; set; }
            public DateTime? NgàyMượn { get; set; }
            public DateTime? HạnTrả { get; set; }
            public DateTime? NgàyTrảThựcTế { get; set; }
            public decimal? TiềnPhạt { get; set; }
            public bool ĐãTrả { get; set; } = false;
        }

        private void fReturnBook_Load(object sender, EventArgs e)
        {
            dtpNgayTra.Value = DateTime.Now;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUserId.Text.Trim(), out int userId))
            {
                MessageBox.Show("Mã độc giả không hợp lệ!", "Lỗi");
                return;
            }

            using (var db = new LibraryContext())
            {
                var books = db.BorrowDetails
                    .Include(bd => bd.BorrowReceipt)
                    .Include(bd => bd.Book)
                    .Where(bd => bd.BorrowReceipt.UserId == userId && bd.ActualReturnDate == null)
                    .Select(bd => new ReturnBookViewModel
                    {
                        ReceiptId = bd.ReceiptId,
                        BookId = bd.BookId,
                        TênSách = bd.Book.Title,
                        NgàyMượn = bd.BorrowReceipt.BorrowDate,
                        HạnTrả = bd.BorrowReceipt.ReturnDate,
                        NgàyTrảThựcTế = bd.ActualReturnDate,
                        TiềnPhạt = bd.FineAmount,
                        ĐãTrả = false
                    })
                    .ToList();

                dgvBooks.DataSource = books;

                if (dgvBooks.Columns["ĐãTrả"] != null)
                    dgvBooks.Columns["ĐãTrả"].ReadOnly = false;

                // Cập nhật tổng tiền phạt ban đầu
                decimal totalFine = books
                    .Where(b => b.NgàyTrảThựcTế != null && b.TiềnPhạt != null)
                    .Sum(b => b.TiềnPhạt ?? 0);

                lblFineTotal.Text = $"💰 Tổng tiền phạt: {totalFine:N0} VNĐ";
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (dgvBooks.Rows.Count == 0)
            {
                MessageBox.Show("Không có sách nào để xác nhận trả!", "Thông báo");
                return;
            }

            using (var db = new LibraryContext())
            {
                decimal totalFine = 0;

                foreach (DataGridViewRow row in dgvBooks.Rows)
                {
                    if (row.IsNewRow) continue;

                    bool isReturned = Convert.ToBoolean(row.Cells["ĐãTrả"].Value);
                    if (!isReturned) continue;

                    int receiptId = Convert.ToInt32(row.Cells["ReceiptId"].Value);
                    int bookId = Convert.ToInt32(row.Cells["BookId"].Value);

                    var detail = db.BorrowDetails
                        .Include(d => d.BorrowReceipt)
                        .FirstOrDefault(x => x.ReceiptId == receiptId && x.BookId == bookId);

                    if (detail != null && detail.ActualReturnDate == null)
                    {
                        detail.ActualReturnDate = dtpNgayTra.Value;

                        TimeSpan timeSpan = detail.ActualReturnDate.Value - (detail.BorrowReceipt.ReturnDate ?? DateTime.Now);
                        int lateDays = Math.Max(0, timeSpan.Days);
                        detail.FineAmount = lateDays * 1000;
                        totalFine += detail.FineAmount ?? 0;

                        var book = db.Books.FirstOrDefault(b => b.BookId == bookId);
                        if (book != null)
                        {
                            book.StockQuantity += 1;
                            db.Books.Update(book);
                        }
                    }
                }

                db.SaveChanges();

                // ✅ Hiển thị tổng tiền phạt ngay sau xác nhận
                MessageBox.Show($"Đã xác nhận trả sách!\nTổng tiền phạt: {totalFine:N0} VNĐ", "Thông báo");

                // ✅ Load lại danh sách và cập nhật tổng tiền phạt trên giao diện
                btnLoad_Click(null, null);
                lblFineTotal.Text = $"💰 Tổng tiền phạt: {totalFine:N0} VNĐ";
            }
        }
    }
}
