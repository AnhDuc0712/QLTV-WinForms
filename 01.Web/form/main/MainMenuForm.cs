using Ngducanh_Quanlysach;
using QLTV.form.Reader;
using QLTV.Models;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

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
            mnuThemSuaXoaSach.Click += mnuThemSuaXoaSach_Click;
            mnuTimSach.Click += mnuTimSach_Click;
            mnuHienThiSachSoLuong.Click += mnuHienThiSachSoLuong_Click;

            // ====== Gán sự kiện cho các menu QUẢN LÝ THE LOAI ======
            mnuXemDanhSachTheLoai.Click += mnuXemDanhSachTheLoai_Click;
            mnuThemSuaXoaTheLoai.Click += mnuThemSuaXoaTheLoai_Click;
            mnuTimTheLoai.Click += mnuTimTheLoai_Click;


            // ====== Gán sự kiện cho các menu QUẢN LÝ TÁC GIẢ ======
            mnuXemDanhSachTacGia.Click += mnuXemDanhSachTacGia_Click;
            mnuThemSuaXoaTacGia.Click += mnuThemSuaXoaTacGia_Click;
            mnuTimTacGia.Click += mnuTimTacGia_Click;

            // ====== Gán sự kiện cho menu Thoát ======
            mnuThoat.Click += mnuThoat_Click;
        }

        // --- SỰ KIỆN MENU QUẢN LÝ SÁCH ---
        private void mnuXemDanhSachSach_Click(object sender, EventArgs e)
        {
            var f = new fBookManager();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized; // tuỳ, hoặc Normal
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
            var f = new fManageCategory();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized; // tuỳ, hoặc Normal
            f.Show();
        }
        private void mnuThemSuaXoaTheLoai_Click(object sender, EventArgs e)
        {
            var f = new fManageCategory();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized; // tuỳ, hoặc Normal
            f.Show();
        }
        private void mnuTimTheLoai_Click(object sender, EventArgs e)
        {
            var f = new fManageCategory();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized; // tuỳ, hoặc Normal
            f.Show();
        }



        // --- SỰ KIỆN MENU QUẢN LÝ TÁC GIẢ ---
        private void mnuXemDanhSachTacGia_Click(object sender, EventArgs e)
        {
            var f = new fManageAuthor();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog(this);
        }

        private void mnuThemSuaXoaTacGia_Click(object sender, EventArgs e)
        {
            var f = new fManageAuthor();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog(this);
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

        private void mnuHienThiDanhSachDocGia_Click(object sender, EventArgs e)
        {
            fManageReader f = new fManageReader();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog(this);
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
    }
}
