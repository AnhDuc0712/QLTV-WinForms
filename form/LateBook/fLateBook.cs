using Microsoft.EntityFrameworkCore;
using QLTV;
using QLTV.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Ngducanh_Quanlysach
{
    public partial class fLateBook : Form
    {
        public fLateBook()
        {
            InitializeComponent();
        }

        private int TinhSoNgayTre(DateTime? hanTra, DateTime? ngayTraThucTe)
        {
            if (hanTra == null) return 0;
            if (ngayTraThucTe == null)
                return (DateTime.Now - hanTra.Value).Days;
            return (ngayTraThucTe.Value - hanTra.Value).Days;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Có thể xử lý khi người dùng click vào cell
        }

        private void LoadLateBooks(string keyword = "")
        {
            using (var db = new LibraryContext())
            {
                var lateBooksList = (
                    from br in db.BorrowReceipts
                    join bd in db.BorrowDetails on br.ReceiptId equals bd.ReceiptId
                    join u in db.Users on br.UserId equals u.UserId
                    join book in db.Books on bd.BookId equals book.BookId
                    where
                        (
                            (bd.ActualReturnDate == null && br.ReturnDate < DateTime.Now)
                            || (bd.ActualReturnDate != null && bd.ActualReturnDate > br.ReturnDate)
                        )
                        &&
                        (
                            string.IsNullOrEmpty(keyword)
                            || u.FullName.Contains(keyword)
                            || book.Title.Contains(keyword)
                        )
                    select new
                    {
                        HoTen = u.FullName,
                        TenSach = book.Title,
                        NgayMuon = br.BorrowDate,
                        HanTra = br.ReturnDate,
                        NgayTraThucTe = bd.ActualReturnDate,
                        TienPhat = bd.FineAmount
                    }
                ).ToList();

                var result = lateBooksList.Select(x => new
                {
                    x.HoTen,
                    x.TenSach,
                    x.NgayMuon,
                    x.HanTra,
                    x.NgayTraThucTe,
                    SoNgayTre = TinhSoNgayTre(x.HanTra, x.NgayTraThucTe),
                    x.TienPhat
                }).ToList();

                dataGridView1.DataSource = result;

                lblTotalLateBooks.Text = "Tổng số sách trễ hạn: " + result.Count;
                lblTotalUser.Text = "Tổng độc giả: " + db.Users.Count();

                if (dataGridView1.Columns.Count > 0)
                {
                    dataGridView1.Columns["HoTen"].HeaderText = "Họ tên";
                    dataGridView1.Columns["TenSach"].HeaderText = "Tên sách";
                    dataGridView1.Columns["NgayMuon"].HeaderText = "Ngày mượn";
                    dataGridView1.Columns["HanTra"].HeaderText = "Hạn trả";
                    dataGridView1.Columns["NgayTraThucTe"].HeaderText = "Ngày trả thực tế";
                    dataGridView1.Columns["SoNgayTre"].HeaderText = "Số ngày trễ";
                    dataGridView1.Columns["TienPhat"].HeaderText = "Tiền phạt";
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fLateBook_Load(object sender, EventArgs e)
        {
            LoadLateBooks();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string keyword = txtFind.Text.Trim();
            LoadLateBooks(keyword);
        }
    }
}
