using QLTV.Models;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QLTV.form.Borrow
{
    public partial class mnuLocDocGiaSachTrangThai : Form
    {
        public mnuLocDocGiaSachTrangThai()
        {
            InitializeComponent();
            this.Load += fFilterBorrow_Load;
            btnFilter.Click += btnFilter_Click;
            // 🔥 Mở rộng form toàn màn hình
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void fFilterBorrow_Load(object sender, EventArgs e)
        {
            using (var db = new LibraryContext())
            {
                // Độc giả
                var readers = db.Users.ToList();
                cbReader.DataSource = readers;
                cbReader.DisplayMember = "FullName";
                cbReader.ValueMember = "UserId";
                cbReader.SelectedIndex = -1;
                cbReader.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbReader.AutoCompleteSource = AutoCompleteSource.ListItems;

                // Sách
                var books = db.Books.ToList();
                cbBook.DataSource = books;
                cbBook.DisplayMember = "Title";
                cbBook.ValueMember = "BookId";
                cbBook.SelectedIndex = -1;
                cbBook.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbBook.AutoCompleteSource = AutoCompleteSource.ListItems;

                // Trạng thái
                cbStatus.Items.Clear();
                cbStatus.Items.Add("Tất cả");
                cbStatus.Items.Add("Đang mượn");
                cbStatus.Items.Add("Đã trả");
                cbStatus.SelectedIndex = 0;
            }

            // DataGridView style
            dgvResult.EnableHeadersVisualStyles = false;
            dgvResult.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumSlateBlue;
            dgvResult.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvResult.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dgvResult.DefaultCellStyle.Font = new Font("Segoe UI", 11F);
            dgvResult.DefaultCellStyle.BackColor = Color.White;
            dgvResult.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int? userId = cbReader.SelectedIndex >= 0 ? (int?)cbReader.SelectedValue : null;
            int? bookId = cbBook.SelectedIndex >= 0 ? (int?)cbBook.SelectedValue : null;
            string status = cbStatus.SelectedItem.ToString();

            using (var db = new LibraryContext())
            {
                var query = from br in db.BorrowReceipts
                            join bd in db.BorrowDetails on br.ReceiptId equals bd.ReceiptId
                            join u in db.Users on br.UserId equals u.UserId
                            join b in db.Books on bd.BookId equals b.BookId
                            select new
                            {
                                MãPhiếu = br.ReceiptId,
                                ĐộcGiả = u.FullName,
                                Sách = b.Title,
                                NgàyMượn = br.BorrowDate,
                                NgàyTrảHạn = br.ReturnDate,
                                NgàyTrảThựcTế = bd.ActualReturnDate,
                                TrạngThái = br.Status == "Borrowed" ? "Đang mượn" : "Đã trả"
                            };

                if (userId.HasValue)
                    query = query.Where(x => x.ĐộcGiả == ((User)cbReader.SelectedItem).FullName);
                if (bookId.HasValue)
                    query = query.Where(x => x.Sách == ((Book)cbBook.SelectedItem).Title);
                if (status == "Đang mượn")
                    query = query.Where(x => x.TrạngThái == "Đang mượn");
                else if (status == "Đã trả")
                    query = query.Where(x => x.TrạngThái == "Đã trả");

                dgvResult.DataSource = query.ToList();
            }
        }

        private void dgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
