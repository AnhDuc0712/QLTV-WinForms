using Microsoft.EntityFrameworkCore;
using QLTV.Models;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace QLTV.form.BorrowReturn
{
    public partial class fReturnBook : Form
    {
        private BindingList<ReturnBookViewModel> bookList;

        public fReturnBook()
        {
            InitializeComponent();
            dgvBooks.CellClick += dgvBooks_CellClick;
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
            dtpNgayTra.ValueChanged += (s, ev) => btnLoad.PerformClick();
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
                        NgàyTrảThựcTế = null,
                        TiềnPhạt = 0,
                        ĐãTrả = false
                    }).ToList();

                foreach (var book in books)
                {
                    if (book.HạnTrả.HasValue)
                    {
                        var overdueDays = (dtpNgayTra.Value - book.HạnTrả.Value).Days;
                        if (overdueDays > 0)
                        {
                            book.TiềnPhạt = overdueDays * 1000;
                        }
                    }
                }

                bookList = new BindingList<ReturnBookViewModel>(books);
                dgvBooks.DataSource = bookList;

                // Thêm cột nếu chưa có
                if (!dgvBooks.Columns.Contains("ĐãTrả"))
                {
                    var checkCol = new DataGridViewCheckBoxColumn();
                    checkCol.Name = "ĐãTrả";
                    checkCol.HeaderText = "Đã Trả";
                    checkCol.DataPropertyName = "ĐãTrả";
                    checkCol.TrueValue = true;
                    checkCol.FalseValue = false;
                    checkCol.ReadOnly = true;
                    dgvBooks.Columns.Add(checkCol);
                }

                UpdateTotalFine();
            }
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvBooks.Columns[e.ColumnIndex].Name != "ĐãTrả") return;

            var book = bookList[e.RowIndex];
            if (!book.ĐãTrả)
            {
                book.ĐãTrả = true;
                ToolTip tt = new ToolTip();
                tt.Show($"Đã trả sách. Phạt: {book.TiềnPhạt:N0} VNĐ", dgvBooks, 500, 0, 2000);
            }

            UpdateTotalFine();
            dgvBooks.Refresh();
        }

        private void UpdateTotalFine()
        {
            decimal totalFine = bookList.Where(b => !b.ĐãTrả).Sum(b => b.TiềnPhạt ?? 0);
            lblFineTotal.Text = $"💰 Tổng tiền phạt: {totalFine:N0} VNĐ";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (bookList.All(b => !b.ĐãTrả))
            {
                MessageBox.Show("Không có sách nào để xác nhận trả!", "Thông báo");
                return;
            }

            using (var db = new LibraryContext())
            {
                decimal totalFine = 0;

                foreach (var book in bookList.Where(b => b.ĐãTrả))
                {
                    var detail = db.BorrowDetails
                        .Include(d => d.BorrowReceipt)
                        .FirstOrDefault(x => x.ReceiptId == book.ReceiptId && x.BookId == book.BookId);

                    if (detail != null && detail.ActualReturnDate == null)
                    {
                        detail.ActualReturnDate = dtpNgayTra.Value;
                        TimeSpan timeSpan = detail.ActualReturnDate.Value - (detail.BorrowReceipt.ReturnDate ?? DateTime.Now);
                        int lateDays = Math.Max(0, timeSpan.Days);
                        detail.FineAmount = lateDays * 1000;
                        totalFine += detail.FineAmount ?? 0;

                        var bookDb = db.Books.FirstOrDefault(b => b.BookId == book.BookId);
                        if (bookDb != null)
                        {
                            bookDb.StockQuantity += 1;
                            db.Books.Update(bookDb);
                        }
                    }
                }

                db.SaveChanges();
                MessageBox.Show($"Đã xác nhận trả sách!\nTổng tiền phạt: {totalFine:N0} VNĐ", "Thông báo");
                btnLoad.PerformClick();
            }
        }
    }
}
