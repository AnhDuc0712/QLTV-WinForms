using QLTV.form.Reader;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Ngducanh
{
    public partial class MainMenuForm : Form
    {
        private string _username;
        private Label lblUsername; // Thêm biến Label

        // Constructor mặc định (nếu cần)
        public MainMenuForm()
        {
            InitializeComponent();
        }

        // Constructor nhận username
        public MainMenuForm(string username)
        {
            InitializeComponent();
            _username = username;

            // Hiển thị username lên title cửa sổ
            this.Text = $"Thư viện - Xin chào: {_username}";
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            // Hiển thị username lên form bằng Label (thêm động, không cần kéo thả)
            if (!string.IsNullOrEmpty(_username))
            {
                lblUsername = new Label();
                lblUsername.Text = $"👤 {_username}";
                lblUsername.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                lblUsername.ForeColor = Color.DarkSlateBlue;
                lblUsername.AutoSize = true;
                lblUsername.BackColor = Color.Transparent;
                lblUsername.Location = new Point(this.Width - 230, 15); // Góc phải phía trên, có thể chỉnh lại cho hợp

                // Cho label nổi lên trên các control khác
                this.Controls.Add(lblUsername);
                lblUsername.BringToFront();
            }

            mnuXemDanhSachTacGia.Click += mnuXemDanhSachTacGia_Click;
            mnuThemSuaXoaTacGia.Click += mnuThemSuaXoaTacGia_Click;
            mnuTimTacGia.Click += mnuTimTacGia_Click;
        }

        private void MainMenuForm_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                ClientRectangle, Color.White, Color.PaleGoldenrod, 90F))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }
        }

        private void mnuXemDanhSachTacGia_Click(object sender, EventArgs e)
        {
            this.Hide(); // ẩn MainMenuForm

            var f = new fManageAuthor();
            f.FormClosed += (s, args) => this.Show(); // hiển thị lại sau khi form kia đóng
            f.Show();
        }

        private void mnuThemSuaXoaTacGia_Click(object sender, EventArgs e)
        {
            var f = new fManageAuthor();
            f.ShowDialog();
        }

        private void mnuTimTacGia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng tìm kiếm đang được phát triển.", "Thông báo");
        }

        private void mnuDocGia_Click(object sender, EventArgs e)
        {
            // fManageReader f = new fManageReader();
            // f.Show();
        }

        private void mnuXemDanhSachTacGia_Click_1(object sender, EventArgs e)
        {
            // Không cần thiết nếu không sử dụng
        }

        private void mnuHienThiDanhSachDocGia_Click(object sender, EventArgs e)
        {
            fManageReader f = new fManageReader();
            f.Show();
        }
    }
}
