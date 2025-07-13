using Microsoft.EntityFrameworkCore;
using QLTV;
using QLTV.Models;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Ngducanh_Quanlysach
{
    public partial class fLateBook : Form
    {
        public fLateBook()
        {
            InitializeComponent();
            btnFind.MouseEnter += BtnFind_MouseEnter;
            btnFind.MouseLeave += BtnFind_MouseLeave;
            // 🔥 Mở rộng form toàn màn hình
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.StartPosition = FormStartPosition.CenterScreen;
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
        private void BtnFind_MouseEnter(object sender, EventArgs e)
        {
            btnFind.BackColor = Color.FromArgb(60, 64, 87);  // màu hover
        }

        private void BtnFind_MouseLeave(object sender, EventArgs e)
        {
            btnFind.BackColor = Color.FromArgb(42, 46, 69);  // màu bình thường
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
                    TienPhat = TinhSoNgayTre(x.HanTra, x.NgayTraThucTe) * 1000
                }).ToList();

                dataGridView1.DataSource = result;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                lblTotalLateBooks.Text = "Tổng số sách trễ hạn: " + result.Count;
                lblTotalUser.Text = "Tổng độc giả: " + db.Users.Count();

                if (dataGridView1.Columns.Count > 0)
                {
                    dataGridView1.Columns["HoTen"].HeaderText = "Họ tên";
                    dataGridView1.Columns["TenSach"].HeaderText = "Tên sách";
                    dataGridView1.Columns["NgayMuon"].HeaderText = "Ngày mượn";
                    dataGridView1.Columns["HanTra"].HeaderText = "Hạn trả";
                    dataGridView1.Columns["NgayTraThucTe"].Visible = false;
                    dataGridView1.Columns["SoNgayTre"].HeaderText = "Số ngày trễ";
                    dataGridView1.Columns["TienPhat"].HeaderText = "Tiền phạt";
                    var ci = new CultureInfo("vi-VN");
                    dataGridView1.Columns["TienPhat"].DefaultCellStyle.Format = "C0";
                    dataGridView1.Columns["TienPhat"].DefaultCellStyle.Format = "#,##0 \"VNĐ\"";
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