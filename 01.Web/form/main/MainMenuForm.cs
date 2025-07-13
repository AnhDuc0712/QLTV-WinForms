using Ngducanh_Quanlysach;
using QLTV.form.Borrow;
using QLTV.form.Reader;

using QLTV.form.Statistical;


using QLTV.form.BorrowReturn;

using QLTV.Models;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using QLTV.form.Borrow;


namespace Ngducanh
{
    public partial class MainMenuForm : Form
    {
        private string _username;
        private Label lblUsername;
        private List<Category> categoryList = new List<Category>();

        public MainMenuForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            // 🔥 Mở rộng form toàn màn hình
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public MainMenuForm(string username)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            _username = username;
            this.Text = $"Thư viện - Xin chào: {_username}";
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            // Hiển thị username lên form bằng Label (thêm động, không cần kéo thả)
            if (!string.IsNullOrEmpty(_username))
            {
                lblUsername = new Label
                {
                    Text = $"👤 {_username}",
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    ForeColor = Color.DarkSlateBlue,
                    AutoSize = true,
                    BackColor = Color.Transparent,
                    Location = new Point(this.Width - 230, 15)
                };
                this.Controls.Add(lblUsername);
                lblUsername.BringToFront();
            }

            // ====== Gán sự kiện cho các menu QUẢN LÝ SÁCH ======
            mnuXemDanhSachSach.Click += mnuXemDanhSachSach_Click;


            // ====== Gán sự kiện cho các menu QUẢN LÝ THỂ LOẠI ======
            mnuXemDanhSachTheLoai.Click += mnuXemDanhSachTheLoai_Click;


            // ====== Gán sự kiện cho các menu QUẢN LÝ TÁC GIẢ ======
            mnuXemDanhSachTacGia.Click += mnuXemDanhSachTacGia_Click;

            mnuSachTreHanNhieuNhat.Click += mnuSachTreHanNhieuNhat_Click;
            mnuLapPhieuMuon.Click += (s, e) => OpenNewBorrowReceiptForm();
            mnuLapPhieuTra.Click += (s, e) => OpenReturnBookForm();



            // ====== Gán sự kiện cho menu Thoát ======
            mnuThoat.Click += mnuThoat_Click;


        }

        // --- SỰ KIỆN MENU LỌC ĐỘC GIẢ/SÁCH/TRẠNG THÁI ---


        // --- SỰ KIỆN MENU QUẢN LÝ SÁCH ---
        private void mnuXemDanhSachSach_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close(); // hoặc child.Hide();
            }

            var f = new fBookManager();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Normal;
            f.Show();
        }

        private void mnuThemSuaXoaSach_Click(object sender, EventArgs e)
        {
            var f = new fBookManager();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog(this);
        }

        private void mnuTimSach_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng tìm kiếm sách đang phát triển.", "Thông báo");
        }

        private void mnuHienThiSachSoLuong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng hiển thị số lượng sách đang phát triển.", "Thông báo");
        }

        // --- SỰ KIỆN MENU QUẢN LÝ THỂ LOẠI ---
        private void mnuXemDanhSachTheLoai_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close(); // hoặc child.Hide();
            }

            var f = new fManageCategory();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
        private void mnuThemSuaXoaTheLoai_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close(); // hoặc child.Hide();
            }

            var f = new fManageCategory();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
        private void mnuTimTheLoai_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close(); // hoặc child.Hide();
            }

            var f = new fManageCategory();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        // --- SỰ KIỆN MENU QUẢN LÝ TÁC GIẢ ---
        private void mnuXemDanhSachTacGia_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close(); // hoặc child.Hide();
            }

            var f = new fManageAuthor();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized; // tuỳ, hoặc Normal
            f.Show();
        }

        private void mnuThemSuaXoaTacGia_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close(); // hoặc child.Hide();
            }

            var f = new fManageAuthor();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized; // tuỳ, hoặc Normal
            f.Show();
        }

        private void mnuTimTacGia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng tìm kiếm tác giả đang phát triển.", "Thông báo");
        }

        // --- CÁC MENU KHÁC ---
        private void mnuDocGia_Click(object sender, EventArgs e)
        {
            // fManageReader f = new fManageReader();
            // f.ShowDialog(this);
        }



        // sự kiện hiển thị danh sách độc giả 
        private void mnuHienThiDanhSachDocGia_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close(); // hoặc child.Hide();
            }

            fManageReader f = new fManageReader();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized; // tuỳ, hoặc Normal
            f.Show();

        }

        // --- SỰ KIỆN THOÁT ---
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (LoginForm loginForm = new LoginForm())
            {
                loginForm.StartPosition = FormStartPosition.CenterScreen;
                loginForm.ShowDialog();
            }
            this.Close();
        }


        // --- Các sự kiện không cần thiết ---
        private void mnuXemDanhSachTacGia_Click_1(object sender, EventArgs e) { }
        private void mnuTacGia_Click(object sender, EventArgs e) { }
        private void mnuSach_Click(object sender, EventArgs e) { }

        private void MainMenuForm_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                ClientRectangle, Color.White, Color.PaleGoldenrod, 90F))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }
        }



        //Sách đang mượn/ số lượng
        private void mnuSachDangMuon_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close(); // hoặc child.Hide();
            }

            fBorrowedBooks f = new fBorrowedBooks();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized; // tuỳ, hoặc Normal
            f.Show();

        }

        // --- THỐNG KÊ SÁCH TRỄ HẠN ---
        private void mnuSachTreHanNhieuNhat_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close(); // hoặc child.Hide();
            }

            var f = new fLateBook();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
        private void mnuLocPhieu_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close(); // hoặc child.Hide();
            }

            // Mở form lọc phiếu mượn theo độc giả/sách/trạng thái
            var f = new mnuLocDocGiaSachTrangThai(); // nếu form bạn đặt tên khác thì sửa lại tên này
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
        // Mở form Tạo phiếu mượn
        private void OpenNewBorrowReceiptForm()
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close(); // hoặc child.Hide();
            }
            var form = new fNewBorrowReceipt();
            form.MdiParent = this; // nếu form chính là MDI
            form.Show();
        }

        // Mở form Trả sách
        private void OpenReturnBookForm()
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close(); // hoặc child.Hide();
            }
            var form = new fReturnBook();
            FormWindowState state = FormWindowState.Normal; // hoặc Normal tuỳ ý
            form.MdiParent = this; // nếu form chính là MDI
            form.Show();
        }

        private void menuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuXemDanhSachSach_Click_1(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void mnuLapPhieuTra_Click(object sender, EventArgs e)
        {

        }

    }
}
