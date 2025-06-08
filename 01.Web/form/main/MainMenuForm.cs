using QLTV.form.Reader;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Ngducanh
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            mnuXemDanhSachTacGia.Click += mnuXemDanhSachTacGia_Click;
            mnuThemSuaXoaTacGia.Click += mnuThemSuaXoaTacGia_Click;
            mnuTimTacGia.Click += mnuTimTacGia_Click;
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

        private void MainMenuForm_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                ClientRectangle, Color.White, Color.PaleGoldenrod, 90F))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }
        }

        private void mnuDocGia_Click(object sender, EventArgs e)
        {
            //fManageReader f = new fManageReader();
            ////f.MdiParent = this;
            //f.Show();
        }

        private void mnuXemDanhSachTacGia_Click_1(object sender, EventArgs e)
        {

        }

        private void mnuHienThiDanhSachDocGia_Click(object sender, EventArgs e)
        {
            fManageReader f = new fManageReader();
            //f.MdiParent = this;
            f.Show();
        }
    }
}
