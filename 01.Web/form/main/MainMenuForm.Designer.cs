using Siticone.Desktop.UI.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ngducanh
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private SiticoneElipse elipse;
        private SiticonePanel panelMenu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuMain = new MenuStrip();
            mnuGiaoDienChinh = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            mnuSach = new ToolStripMenuItem();
            mnuXemDanhSachSach = new ToolStripMenuItem();
            mnuTheLoai = new ToolStripMenuItem();
            mnuXemDanhSachTheLoai = new ToolStripMenuItem();
            mnuTacGia = new ToolStripMenuItem();
            mnuXemDanhSachTacGia = new ToolStripMenuItem();
            mnuDocGia = new ToolStripMenuItem();
            mnuHienThiDanhSachDocGia = new ToolStripMenuItem();
            mnuBaoCao = new ToolStripMenuItem();
            mnuSachDangMuon = new ToolStripMenuItem();
            mnuSachTreHanNhieuNhat = new ToolStripMenuItem();
            mnuMuonTra = new ToolStripMenuItem();
            mnuLapPhieuMuon = new ToolStripMenuItem();
            mnuLapPhieuTra = new ToolStripMenuItem();
            mnuLocPhieu = new ToolStripMenuItem();
            headerPanel = new SiticonePanel();
            lblTitle = new Label();
            menuContainer = new SiticonePanel();
            elipse = new SiticoneElipse(components);
            menuMain.SuspendLayout();
            headerPanel.SuspendLayout();
            menuContainer.SuspendLayout();
            SuspendLayout();
            // 
            // menuMain
            // 
            menuMain.BackColor = Color.FromArgb(22, 27, 34);
            menuMain.Dock = DockStyle.Fill;
            menuMain.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            menuMain.ForeColor = Color.WhiteSmoke;
            menuMain.ImageScalingSize = new Size(24, 24);
            menuMain.Items.AddRange(new ToolStripItem[] { mnuGiaoDienChinh, mnuSach, mnuTheLoai, mnuTacGia, mnuDocGia, mnuBaoCao, mnuMuonTra });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Padding = new Padding(15, 5, 15, 5);
            menuMain.Size = new Size(1343, 60);
            menuMain.TabIndex = 0;
            menuMain.ItemClicked += menuMain_ItemClicked;
            // 
            // mnuGiaoDienChinh
            // 
            mnuGiaoDienChinh.BackColor = Color.Transparent;
            mnuGiaoDienChinh.DropDownItems.AddRange(new ToolStripItem[] { mnuThoat });
            mnuGiaoDienChinh.ForeColor = Color.WhiteSmoke;
            mnuGiaoDienChinh.Name = "mnuGiaoDienChinh";
            mnuGiaoDienChinh.Size = new Size(182, 50);
            mnuGiaoDienChinh.Text = "🏠 Giao Diện Chính";
            mnuGiaoDienChinh.MouseEnter += mnuGiaoDienChinh_MouseEnter;
            // 
            // mnuThoat
            // 
            mnuThoat.BackColor = Color.FromArgb(28, 31, 38);
            mnuThoat.Font = new Font("Segoe UI", 9F);
            mnuThoat.ForeColor = Color.WhiteSmoke;
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(156, 26);
            mnuThoat.Text = "🚪 Thoát";
            mnuThoat.MouseEnter += mnuThoat_MouseEnter;
            // 
            // mnuSach
            // 
            mnuSach.BackColor = Color.Transparent;
            mnuSach.DropDownItems.AddRange(new ToolStripItem[] { mnuXemDanhSachSach });
            mnuSach.ForeColor = Color.WhiteSmoke;
            mnuSach.Name = "mnuSach";
            mnuSach.Size = new Size(160, 50);
            mnuSach.Text = "📚 Quản Lý Sách";
            mnuSach.MouseEnter += mnuSach_MouseEnter;
            // 
            // mnuXemDanhSachSach
            // 
            mnuXemDanhSachSach.BackColor = Color.FromArgb(28, 31, 38);
            mnuXemDanhSachSach.Font = new Font("Segoe UI", 9F);
            mnuXemDanhSachSach.ForeColor = Color.WhiteSmoke;
            mnuXemDanhSachSach.Name = "mnuXemDanhSachSach";
            mnuXemDanhSachSach.Size = new Size(257, 26);
            mnuXemDanhSachSach.Text = "📖 Xem Danh Sách Sách";
            mnuXemDanhSachSach.Click += mnuXemDanhSachSach_Click_1;
            mnuXemDanhSachSach.MouseEnter += mnuXemDanhSachSach_MouseEnter;
            // 
            // mnuTheLoai
            // 
            mnuTheLoai.BackColor = Color.Transparent;
            mnuTheLoai.DropDownItems.AddRange(new ToolStripItem[] { mnuXemDanhSachTheLoai });
            mnuTheLoai.ForeColor = Color.WhiteSmoke;
            mnuTheLoai.Name = "mnuTheLoai";
            mnuTheLoai.Size = new Size(190, 50);
            mnuTheLoai.Text = "🏷️ Quản Lý Thể Loại";
            mnuTheLoai.MouseEnter += mnuTheLoai_MouseEnter;
            // 
            // mnuXemDanhSachTheLoai
            // 
            mnuXemDanhSachTheLoai.BackColor = Color.FromArgb(28, 31, 38);
            mnuXemDanhSachTheLoai.Font = new Font("Segoe UI", 9F);
            mnuXemDanhSachTheLoai.ForeColor = Color.WhiteSmoke;
            mnuXemDanhSachTheLoai.Name = "mnuXemDanhSachTheLoai";
            mnuXemDanhSachTheLoai.Size = new Size(282, 26);
            mnuXemDanhSachTheLoai.Text = "📄 Xem Danh Sách Thể Loại";
            mnuXemDanhSachTheLoai.MouseEnter += mnuXemDanhSachTheLoai_MouseEnter;
            // 
            // mnuTacGia
            // 
            mnuTacGia.BackColor = Color.Transparent;
            mnuTacGia.DropDownItems.AddRange(new ToolStripItem[] { mnuXemDanhSachTacGia });
            mnuTacGia.ForeColor = Color.WhiteSmoke;
            mnuTacGia.Name = "mnuTacGia";
            mnuTacGia.Size = new Size(180, 50);
            mnuTacGia.Text = "✍️ Quản Lý Tác Giả";
            mnuTacGia.Click += mnuTacGia_Click;
            mnuTacGia.MouseEnter += mnuTacGia_MouseEnter;
            // 
            // mnuXemDanhSachTacGia
            // 
            mnuXemDanhSachTacGia.BackColor = Color.FromArgb(28, 31, 38);
            mnuXemDanhSachTacGia.Font = new Font("Segoe UI", 9F);
            mnuXemDanhSachTacGia.ForeColor = Color.WhiteSmoke;
            mnuXemDanhSachTacGia.Name = "mnuXemDanhSachTacGia";
            mnuXemDanhSachTacGia.Size = new Size(273, 26);
            mnuXemDanhSachTacGia.Text = "📄 Xem Danh Sách Tác Giả";
            mnuXemDanhSachTacGia.Click += mnuXemDanhSachTacGia_Click_1;
            mnuXemDanhSachTacGia.MouseEnter += mnuXemDanhSachTacGia_MouseEnter;
            // 
            // mnuDocGia
            // 
            mnuDocGia.BackColor = Color.Transparent;
            mnuDocGia.DropDownItems.AddRange(new ToolStripItem[] { mnuHienThiDanhSachDocGia });
            mnuDocGia.ForeColor = Color.WhiteSmoke;
            mnuDocGia.Name = "mnuDocGia";
            mnuDocGia.Size = new Size(185, 50);
            mnuDocGia.Text = "👤 Quản Lý Độc Giả";
            mnuDocGia.Click += mnuDocGia_Click;
            mnuDocGia.MouseEnter += mnuDocGia_MouseEnter;
            // 
            // mnuHienThiDanhSachDocGia
            // 
            mnuHienThiDanhSachDocGia.BackColor = Color.FromArgb(28, 31, 38);
            mnuHienThiDanhSachDocGia.Font = new Font("Segoe UI", 9F);
            mnuHienThiDanhSachDocGia.ForeColor = Color.WhiteSmoke;
            mnuHienThiDanhSachDocGia.Name = "mnuHienThiDanhSachDocGia";
            mnuHienThiDanhSachDocGia.Size = new Size(304, 26);
            mnuHienThiDanhSachDocGia.Text = "📋 Hiển Thị Danh Sách Độc Giả";
            mnuHienThiDanhSachDocGia.Click += mnuHienThiDanhSachDocGia_Click;
            mnuHienThiDanhSachDocGia.MouseEnter += mnuHienThiDanhSachDocGia_MouseEnter;
            // 
            // mnuBaoCao
            // 
            mnuBaoCao.BackColor = Color.Transparent;
            mnuBaoCao.DropDownItems.AddRange(new ToolStripItem[] { mnuSachDangMuon, mnuSachTreHanNhieuNhat });
            mnuBaoCao.ForeColor = Color.WhiteSmoke;
            mnuBaoCao.Name = "mnuBaoCao";
            mnuBaoCao.Size = new Size(211, 50);
            mnuBaoCao.Text = "📊 Thống Kê - Báo Cáo";
            mnuBaoCao.MouseEnter += mnuBaoCao_MouseEnter;
            // 
            // mnuSachDangMuon
            // 
            mnuSachDangMuon.BackColor = Color.FromArgb(28, 31, 38);
            mnuSachDangMuon.Font = new Font("Segoe UI", 9F);
            mnuSachDangMuon.ForeColor = Color.WhiteSmoke;
            mnuSachDangMuon.Name = "mnuSachDangMuon";
            mnuSachDangMuon.Size = new Size(285, 26);
            mnuSachDangMuon.Text = "📕 Sách Đang Mượn";
            mnuSachDangMuon.Click += mnuSachDangMuon_Click;
            mnuSachDangMuon.MouseEnter += mnuSachDangMuon_MouseEnter;
            // 
            // mnuSachTreHanNhieuNhat
            // 
            mnuSachTreHanNhieuNhat.BackColor = Color.FromArgb(28, 31, 38);
            mnuSachTreHanNhieuNhat.Font = new Font("Segoe UI", 9F);
            mnuSachTreHanNhieuNhat.ForeColor = Color.WhiteSmoke;
            mnuSachTreHanNhieuNhat.Name = "mnuSachTreHanNhieuNhat";
            mnuSachTreHanNhieuNhat.Size = new Size(285, 26);
            mnuSachTreHanNhieuNhat.Text = "⏰ Sách Trễ Hạn/Nhiều Nhất";
            mnuSachTreHanNhieuNhat.MouseEnter += mnuSachTreHanNhieuNhat_MouseEnter;
            // 
            // mnuMuonTra
            // 
            mnuMuonTra.BackColor = Color.Transparent;
            mnuMuonTra.DropDownItems.AddRange(new ToolStripItem[] { mnuLapPhieuMuon, mnuLapPhieuTra, mnuLocPhieu });
            mnuMuonTra.ForeColor = Color.WhiteSmoke;
            mnuMuonTra.Name = "mnuMuonTra";
            mnuMuonTra.Size = new Size(204, 50);
            mnuMuonTra.Text = "🔄 Quản Lý Mượn/Trả";
            mnuMuonTra.MouseEnter += mnuMuonTra_MouseEnter;
            // 
            // mnuLapPhieuMuon
            // 
            mnuLapPhieuMuon.BackColor = Color.FromArgb(28, 31, 38);
            mnuLapPhieuMuon.Font = new Font("Segoe UI", 9F);
            mnuLapPhieuMuon.ForeColor = Color.WhiteSmoke;
            mnuLapPhieuMuon.Name = "mnuLapPhieuMuon";
            mnuLapPhieuMuon.Size = new Size(347, 26);
            mnuLapPhieuMuon.Text = "📤 Lập Phiếu Mượn Sách";
            mnuLapPhieuMuon.MouseEnter += mnuLapPhieuMuon_MouseEnter;
            // 
            // mnuLapPhieuTra
            // 
            mnuLapPhieuTra.BackColor = Color.FromArgb(28, 31, 38);
            mnuLapPhieuTra.Font = new Font("Segoe UI", 9F);
            mnuLapPhieuTra.ForeColor = Color.WhiteSmoke;
            mnuLapPhieuTra.Name = "mnuLapPhieuTra";
            mnuLapPhieuTra.Size = new Size(347, 26);
            mnuLapPhieuTra.Text = "📥 Lập Phiếu Trả Sách";
            mnuLapPhieuTra.MouseEnter += mnuLapPhieuTra_MouseEnter;
            // 
            // mnuLocPhieu
            // 
            mnuLocPhieu.BackColor = Color.FromArgb(28, 31, 38);
            mnuLocPhieu.Font = new Font("Segoe UI", 9F);
            mnuLocPhieu.ForeColor = Color.WhiteSmoke;
            mnuLocPhieu.Name = "mnuLocPhieu";
            mnuLocPhieu.Size = new Size(347, 26);
            mnuLocPhieu.Text = "🔍 Lọc Theo Độc Giả/Sách/Trạng Thái";
            mnuLocPhieu.Click += mnuLocPhieu_Click;
            mnuLocPhieu.MouseEnter += mnuLocPhieu_MouseEnter;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.Transparent;
            headerPanel.BorderRadius = 10;
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.FillColor = Color.FromArgb(22, 27, 34);
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.ShadowDecoration.Depth = 10;
            headerPanel.ShadowDecoration.Enabled = true;
            headerPanel.Size = new Size(1343, 90);
            headerPanel.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(41, 121, 255);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1343, 90);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📚 HỆ THỐNG QUẢN LÝ THƯ VIỆN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.Transparent;
            menuContainer.BorderRadius = 8;
            menuContainer.Controls.Add(menuMain);
            menuContainer.Dock = DockStyle.Top;
            menuContainer.FillColor = Color.FromArgb(22, 27, 34);
            menuContainer.Location = new Point(0, 90);
            menuContainer.Name = "menuContainer";
            menuContainer.ShadowDecoration.Depth = 8;
            menuContainer.ShadowDecoration.Enabled = true;
            menuContainer.Size = new Size(1343, 60);
            menuContainer.TabIndex = 0;
            // 
            // elipse
            // 
            elipse.BorderRadius = 15;
            elipse.TargetControl = this;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 17, 23);
            ClientSize = new Size(1343, 789);
            Controls.Add(menuContainer);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuMain;
            Name = "MainMenuForm";
            Text = "Quản Lý Thư Viện";
            Load += MainMenuForm_Load;
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            headerPanel.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            menuContainer.PerformLayout();
            ResumeLayout(false);

        }

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuGiaoDienChinh;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuSach;
        private System.Windows.Forms.ToolStripMenuItem mnuTheLoai;
        private System.Windows.Forms.ToolStripMenuItem mnuTacGia;
        private System.Windows.Forms.ToolStripMenuItem mnuXemDanhSachTacGia;
        private System.Windows.Forms.ToolStripMenuItem mnuDocGia;
        private System.Windows.Forms.ToolStripMenuItem mnuHienThiDanhSachDocGia;
        private System.Windows.Forms.ToolStripMenuItem mnuMuonTra;
        private System.Windows.Forms.ToolStripMenuItem mnuLapPhieuMuon;
        private System.Windows.Forms.ToolStripMenuItem mnuLapPhieuTra;
        private System.Windows.Forms.ToolStripMenuItem mnuLocPhieu;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuSachDangMuon;
        private System.Windows.Forms.ToolStripMenuItem mnuSachTreHanNhieuNhat;
        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private Siticone.Desktop.UI.WinForms.SiticonePanel menuContainer;
        private System.Windows.Forms.ToolStripMenuItem mnuXemDanhSachSach;
        private System.Windows.Forms.ToolStripMenuItem mnuXemDanhSachTheLoai;

        private void mnuGiaoDienChinh_MouseEnter(object sender, EventArgs e)
        {
            mnuGiaoDienChinh.ForeColor = Color.FromArgb(41, 121, 255);
        }

        private void mnuThoat_MouseEnter(object sender, EventArgs e)
        {
            mnuThoat.ForeColor = Color.FromArgb(41, 121, 255);
        }

        private void mnuSach_MouseEnter(object sender, EventArgs e)
        {
            mnuSach.ForeColor = Color.FromArgb(41, 121, 255);
        }

        private void mnuXemDanhSachSach_MouseEnter(object sender, EventArgs e)
        {
            mnuXemDanhSachSach.ForeColor = Color.FromArgb(41, 121, 255);
        }

        private void mnuTheLoai_MouseEnter(object sender, EventArgs e)
        {
            mnuTheLoai.ForeColor = Color.FromArgb(41, 121, 255);
        }

        private void mnuXemDanhSachTheLoai_MouseEnter(object sender, EventArgs e)
        {
            mnuXemDanhSachTheLoai.ForeColor = Color.FromArgb(41, 121, 255);
        }

        private void mnuTacGia_MouseEnter(object sender, EventArgs e)
        {
            mnuTacGia.ForeColor = Color.FromArgb(41, 121, 255);
        }

        private void mnuXemDanhSachTacGia_MouseEnter(object sender, EventArgs e)
        {
            mnuXemDanhSachTacGia.ForeColor = Color.FromArgb(41, 121, 255);
        }

        private void mnuDocGia_MouseEnter(object sender, EventArgs e)
        {
            mnuDocGia.ForeColor = Color.FromArgb(41, 121, 255);
        }

        private void mnuHienThiDanhSachDocGia_MouseEnter(object sender, EventArgs e)
        {
            mnuHienThiDanhSachDocGia.ForeColor = Color.FromArgb(41, 121, 255);
        }

        private void mnuBaoCao_MouseEnter(object sender, EventArgs e)
        {
            mnuBaoCao.ForeColor = Color.FromArgb(41, 121, 255);
        }

        private void mnuSachDangMuon_MouseEnter(object sender, EventArgs e)
        {
            mnuSachDangMuon.ForeColor = Color.FromArgb(41, 121, 255);
        }

        private void mnuSachTreHanNhieuNhat_MouseEnter(object sender, EventArgs e)
        {
            mnuSachTreHanNhieuNhat.ForeColor = Color.FromArgb(41, 121, 255);
        }

        private void mnuMuonTra_MouseEnter(object sender, EventArgs e)
        {
            mnuMuonTra.ForeColor = Color.FromArgb(41, 121, 255);
        }

        private void mnuLapPhieuMuon_MouseEnter(object sender, EventArgs e)
        {
            mnuLapPhieuMuon.ForeColor = Color.FromArgb(41, 121, 255);
        }

        private void mnuLapPhieuTra_MouseEnter(object sender, EventArgs e)
        {
            mnuLapPhieuTra.ForeColor = Color.FromArgb(41, 121, 255);
        }

        private void mnuLocPhieu_MouseEnter(object sender, EventArgs e)
        {
            mnuLocPhieu.ForeColor = Color.FromArgb(41, 121, 255);
        }

        }
    }

    // Custom ToolStrip Renderer for Siticone styling
    public class SiticoneToolStripRenderer : ToolStripProfessionalRenderer
    {
        public SiticoneToolStripRenderer() : base(new SiticoneColorTable()) { }
    }

    public class SiticoneColorTable : ProfessionalColorTable
    {
        public override Color MenuItemSelected => Color.FromArgb(28, 31, 38);
        public override Color MenuItemBorder => Color.Transparent;
        public override Color MenuItemPressedGradientBegin => Color.FromArgb(28, 31, 38);
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(28, 31, 38);
        public override Color ToolStripDropDownBackground => Color.FromArgb(22, 27, 34);
    }

