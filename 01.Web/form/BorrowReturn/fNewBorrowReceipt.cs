using QLTV.Models;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QLTV.form.BorrowReturn
{
    public partial class fNewBorrowReceipt : Form
    {
        private LibraryContext db = new LibraryContext();

        public fNewBorrowReceipt()
        {
            InitializeComponent();
        }

        private void fNewBorrowReceipt_Load(object sender, EventArgs e)
        {
            LoadDocGia();
            LoadSach();
        }

        private void LoadDocGia()
        {
            var docGias = db.Users.ToList();

            cbDocGia.DataSource = docGias;
            cbDocGia.DisplayMember = "FullName";
            cbDocGia.ValueMember = "UserId";

            cbDocGia.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbDocGia.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void LoadSach()
        {
            var books = db.Books.Where(b => b.StockQuantity > 0).ToList();
            lstSach.DataSource = books;
            lstSach.DisplayMember = "Title";
            lstSach.ValueMember = "BookId";
        }

        private void btnTimDocGia_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTimDocGia.Text, out int id))
            {
                // Tìm và chọn đúng UserId từ DataSource
                cbDocGia.SelectedValue = id;

                if ((int?)cbDocGia.SelectedValue != id)
                {
                    MessageBox.Show("Không tìm thấy độc giả!", "Thông báo");
                }
            }
        }

        private void btnTimSach_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTimSach.Text, out int id))
            {
                for (int i = 0; i < lstSach.Items.Count; i++)
                {
                    var item = lstSach.Items[i] as Book;
                    if (item != null && item.BookId == id)
                    {
                        lstSach.SelectedItems.Clear(); // xoá chọn cũ (nếu có)
                        lstSach.SelectedIndex = i;
                        return;
                    }
                }

                MessageBox.Show("Không tìm thấy sách!", "Thông báo");
            }
        }


        private void btnTaoPhieuMuon_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu
            if (cbDocGia.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn độc giả.", "Thiếu thông tin");
                return;
            }

            var selectedBooks = lstSach.SelectedItems.Cast<Book>().ToList();
            if (!selectedBooks.Any())
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sách để mượn.", "Thiếu sách");
                return;
            }

            if (dtpNgayMuon.Value.Date > dtpHanTra.Value.Date)
            {
                MessageBox.Show("Hạn trả phải sau ngày mượn!", "Ngày không hợp lệ");
                return;
            }

            var userId = (int)cbDocGia.SelectedValue;

            // Tạo phiếu mượn
            var receipt = new BorrowReceipt
            {
                UserId = userId,
                BorrowDate = dtpNgayMuon.Value.Date,
                ReturnDate = dtpHanTra.Value.Date,
                Status = "Borrowed"
            };

            db.BorrowReceipts.Add(receipt);
            db.SaveChanges(); // cần để có ReceiptId

            foreach (var book in selectedBooks)
            {
                var detail = new BorrowDetail
                {
                    ReceiptId = receipt.ReceiptId,
                    BookId = book.BookId,
                    ActualReturnDate = null,
                    FineAmount = null
                };

                db.BorrowDetails.Add(detail);

                // Trừ số lượng sách
                book.StockQuantity -= 1;
                db.Books.Update(book);
            }

            db.SaveChanges();

            MessageBox.Show("Tạo phiếu mượn thành công!", "Thông báo");
            this.Close(); // Đóng form nếu cần
        }
    }
}
