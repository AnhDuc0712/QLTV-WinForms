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
            dtpNgayMuon.Value = DateTime.Now;
            dtpHanTra.Value = DateTime.Now.AddDays(7); // Mặc định 7 ngày
            lblTitle.Values.ExtraText = $" - {DateTime.Now:hh:mm tt zzz, dddd, MMMM dd, yyyy}"; // 04:27 PM +07, Saturday, June 21, 2025
            UpdateReceiptCount();
        }

        private void LoadDocGia()
        {
            var docGias = db.Users.ToList();
            cbDocGia.DataSource = docGias;
            cbDocGia.DisplayMember = "FullName";
            cbDocGia.ValueMember = "UserId";
            cbDocGia.DropDownStyle = ComboBoxStyle.DropDown; // Cho phép nhập tay
          
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
                cbDocGia.SelectedValue = id;
                if ((int?)cbDocGia.SelectedValue != id)
                {
                    MessageBox.Show("Không tìm thấy độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã độc giả hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        lstSach.SelectedItems.Clear();
                        lstSach.SelectedIndex = i;
                        return;
                    }
                }
                MessageBox.Show("Không tìm thấy sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã sách hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTaoPhieuMuon_Click(object sender, EventArgs e)
        {
            if (cbDocGia.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn độc giả.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedBooks = lstSach.SelectedItems.Cast<Book>().ToList();
            if (!selectedBooks.Any())
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sách để mượn.", "Thiếu sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpNgayMuon.Value.Date > dtpHanTra.Value.Date)
            {
                MessageBox.Show("Hạn trả phải sau ngày mượn!", "Ngày không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var userId = (int)cbDocGia.SelectedValue;

            using (var context = new LibraryContext())
            {
                var receipt = new BorrowReceipt
                {
                    UserId = userId,
                    BorrowDate = dtpNgayMuon.Value.Date,
                    ReturnDate = dtpHanTra.Value.Date,
                    Status = "Borrowed"
                };

                context.BorrowReceipts.Add(receipt);
                context.SaveChanges(); // Cần để có ReceiptId

                foreach (var book in selectedBooks)
                {
                    var detail = new BorrowDetail
                    {
                        ReceiptId = receipt.ReceiptId,
                        BookId = book.BookId,
                        ActualReturnDate = null,
                        FineAmount = null
                    };

                    context.BorrowDetails.Add(detail);

                    // Trừ số lượng sách
                    book.StockQuantity -= 1;
                    context.Books.Update(book);
                }

                context.SaveChanges();

                MessageBox.Show("Tạo phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateReceiptCount(); // Cập nhật số lượng sau khi tạo phiếu
                this.Close();
            }
        }

        private void UpdateReceiptCount()
        {
            try
            {
                using var ctx = new LibraryContext();
                int count = ctx.BorrowReceipts.Count();
                lblReceiptCount.Values.Text = $"Số phiếu: {count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tính số lượng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}