
namespace Ngducanh
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Mã do Windows Form Designer tạo ra

        private void InitializeComponent()
        {
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
            headerPanel = new Panel();
            lblTitle = new Label();
            menuContainer = new Panel();
            menuMain.SuspendLayout();
            headerPanel.SuspendLayout();
            menuContainer.SuspendLayout();
            SuspendLayout();
            // 
            // menuMain
            // 
            menuMain.BackColor = Color.White;
            menuMain.Dock = DockStyle.Fill;
            menuMain.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            menuMain.ForeColor = Color.Black;
            menuMain.ImageScalingSize = new Size(20, 20);
            menuMain.Items.AddRange(new ToolStripItem[] { mnuGiaoDienChinh, mnuSach, mnuTheLoai, mnuTacGia, mnuDocGia, mnuBaoCao, mnuMuonTra });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Padding = new Padding(10, 5, 10, 5);
            menuMain.Size = new Size(1520, 53);
            menuMain.TabIndex = 0;
            menuMain.Text = "menuMain";
            // 
            // mnuGiaoDienChinh
            // 
            mnuGiaoDienChinh.BackColor = Color.LightGray;
            mnuGiaoDienChinh.DropDownItems.AddRange(new ToolStripItem[] { mnuThoat });
            mnuGiaoDienChinh.ForeColor = Color.Black;
            mnuGiaoDienChinh.Name = "mnuGiaoDienChinh";
            mnuGiaoDienChinh.Size = new Size(191, 43);
            mnuGiaoDienChinh.Text = "📂 Giao Diện Chính";
            // 
            // mnuThoat
            // 
            mnuThoat.BackColor = Color.White;
            mnuThoat.Font = new Font("Times New Roman", 10F);
            mnuThoat.ForeColor = Color.Black;
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(151, 26);
            mnuThoat.Text = "❌ Thoát";
            // 
            // mnuSach
            // 
            mnuSach.BackColor = Color.LightGray;
            mnuSach.DropDownItems.AddRange(new ToolStripItem[] { mnuXemDanhSachSach });
            mnuSach.ForeColor = Color.Black;
            mnuSach.Name = "mnuSach";
            mnuSach.Size = new Size(170, 43);
            mnuSach.Text = "📚 Quản Lý Sách";
            // 
            // mnuXemDanhSachSach
            // 
            mnuXemDanhSachSach.BackColor = Color.White;
            mnuXemDanhSachSach.Font = new Font("Times New Roman", 10F);
            mnuXemDanhSachSach.ForeColor = Color.Black;
            mnuXemDanhSachSach.Name = "mnuXemDanhSachSach";
            mnuXemDanhSachSach.Size = new Size(257, 26);
            mnuXemDanhSachSach.Text = "📖 Xem Danh Sách Sách";
            // 
            // mnuTheLoai
            // 
            mnuTheLoai.BackColor = Color.LightGray;
            mnuTheLoai.DropDownItems.AddRange(new ToolStripItem[] { mnuXemDanhSachTheLoai });
            mnuTheLoai.ForeColor = Color.Black;
            mnuTheLoai.Name = "mnuTheLoai";
            mnuTheLoai.Size = new Size(251, 43);
            mnuTheLoai.Text = "🏷️ Quản Lý Thể Loại Sách";
            // 
            // mnuXemDanhSachTheLoai
            // 
            mnuXemDanhSachTheLoai.BackColor = Color.White;
            mnuXemDanhSachTheLoai.Font = new Font("Times New Roman", 10F);
            mnuXemDanhSachTheLoai.ForeColor = Color.Black;
            mnuXemDanhSachTheLoai.Name = "mnuXemDanhSachTheLoai";
            mnuXemDanhSachTheLoai.Size = new Size(285, 26);
            mnuXemDanhSachTheLoai.Text = "📄 Xem Danh Sách Thể Loại";
            // 
            // mnuTacGia
            // 
            mnuTacGia.BackColor = Color.LightGray;
            mnuTacGia.DropDownItems.AddRange(new ToolStripItem[] { mnuXemDanhSachTacGia });
            mnuTacGia.ForeColor = Color.Black;
            mnuTacGia.Name = "mnuTacGia";
            mnuTacGia.Size = new Size(198, 43);
            mnuTacGia.Text = "✍️ Quản Lý Tác Giả";
            mnuTacGia.Click += mnuTacGia_Click;
            // 
            // mnuXemDanhSachTacGia
            // 
            mnuXemDanhSachTacGia.BackColor = Color.White;
            mnuXemDanhSachTacGia.Font = new Font("Times New Roman", 10F);
            mnuXemDanhSachTacGia.ForeColor = Color.Black;
            mnuXemDanhSachTacGia.Name = "mnuXemDanhSachTacGia";
            mnuXemDanhSachTacGia.Size = new Size(277, 26);
            mnuXemDanhSachTacGia.Text = "📄 Xem Danh Sách Tác Giả";
            mnuXemDanhSachTacGia.Click += mnuXemDanhSachTacGia_Click_1;
            // 
            // mnuDocGia
            // 
            mnuDocGia.BackColor = Color.LightGray;
            mnuDocGia.DropDownItems.AddRange(new ToolStripItem[] { mnuHienThiDanhSachDocGia });
            mnuDocGia.ForeColor = Color.Black;
            mnuDocGia.Name = "mnuDocGia";
            mnuDocGia.Size = new Size(199, 43);
            mnuDocGia.Text = "👤 Quản Lý Độc Giả";
            mnuDocGia.Click += mnuDocGia_Click;
            // 
            // mnuHienThiDanhSachDocGia
            // 
            mnuHienThiDanhSachDocGia.BackColor = Color.White;
            mnuHienThiDanhSachDocGia.Font = new Font("Times New Roman", 10F);
            mnuHienThiDanhSachDocGia.ForeColor = Color.Black;
            mnuHienThiDanhSachDocGia.Name = "mnuHienThiDanhSachDocGia";
            mnuHienThiDanhSachDocGia.Size = new Size(308, 26);
            mnuHienThiDanhSachDocGia.Text = "📋 Hiển Thị Danh Sách Độc Giả";
            mnuHienThiDanhSachDocGia.Click += mnuHienThiDanhSachDocGia_Click;
            // 
            // mnuBaoCao
            // 
            mnuBaoCao.BackColor = Color.LightGray;
            mnuBaoCao.DropDownItems.AddRange(new ToolStripItem[] { mnuSachDangMuon, mnuSachTreHanNhieuNhat });
            mnuBaoCao.ForeColor = Color.Black;
            mnuBaoCao.Name = "mnuBaoCao";
            mnuBaoCao.Size = new Size(221, 43);
            mnuBaoCao.Text = "📊 Thống Kê - Báo Cáo";
            // 
            // mnuSachDangMuon
            // 
            mnuSachDangMuon.BackColor = Color.White;
            mnuSachDangMuon.Font = new Font("Times New Roman", 10F);
            mnuSachDangMuon.ForeColor = Color.Black;
            mnuSachDangMuon.Name = "mnuSachDangMuon";
            mnuSachDangMuon.Size = new Size(284, 26);
            mnuSachDangMuon.Text = "📕 Sách Đang Mượn";
            mnuSachDangMuon.Click += mnuSachDangMuon_Click;
            // 
            // mnuSachTreHanNhieuNhat
            // 
            mnuSachTreHanNhieuNhat.BackColor = Color.White;
            mnuSachTreHanNhieuNhat.Font = new Font("Times New Roman", 10F);
            mnuSachTreHanNhieuNhat.ForeColor = Color.Black;
            mnuSachTreHanNhieuNhat.Name = "mnuSachTreHanNhieuNhat";
            mnuSachTreHanNhieuNhat.Size = new Size(284, 26);
            mnuSachTreHanNhieuNhat.Text = "⏰ Sách Trễ Hạn/Nhiều Nhất";
            // 
            // mnuMuonTra
            // 
            mnuMuonTra.BackColor = Color.LightGray;
            mnuMuonTra.DropDownItems.AddRange(new ToolStripItem[] { mnuLapPhieuMuon, mnuLapPhieuTra, mnuLocPhieu });
            mnuMuonTra.ForeColor = Color.Black;
            mnuMuonTra.Name = "mnuMuonTra";
            mnuMuonTra.Size = new Size(262, 43);
            mnuMuonTra.Text = "🔄 Quản Lý Mượn/Trả Sách";
            // 
            // mnuLapPhieuMuon
            // 
            mnuLapPhieuMuon.BackColor = Color.White;
            mnuLapPhieuMuon.Font = new Font("Times New Roman", 10F);
            mnuLapPhieuMuon.ForeColor = Color.Black;
            mnuLapPhieuMuon.Name = "mnuLapPhieuMuon";
            mnuLapPhieuMuon.Size = new Size(351, 26);
            mnuLapPhieuMuon.Text = "📤 Lập Phiếu Mượn Sách";
            // 
            // mnuLapPhieuTra
            // 
            mnuLapPhieuTra.BackColor = Color.White;
            mnuLapPhieuTra.Font = new Font("Times New Roman", 10F);
            mnuLapPhieuTra.ForeColor = Color.Black;
            mnuLapPhieuTra.Name = "mnuLapPhieuTra";
            mnuLapPhieuTra.Size = new Size(351, 26);
            mnuLapPhieuTra.Text = "📥 Lập Phiếu Trả Sách";
            // 
            // mnuLocPhieu
            // 
            mnuLocPhieu.BackColor = Color.White;
            mnuLocPhieu.Font = new Font("Times New Roman", 10F);
            mnuLocPhieu.ForeColor = Color.Black;
            mnuLocPhieu.Name = "mnuLocPhieu";
            mnuLocPhieu.Size = new Size(351, 26);
            mnuLocPhieu.Text = "\U0001f9e9 Lọc Theo Độc Giả/Sách/Trạng Thái";
            mnuLocPhieu.Click += mnuLocPhieu_Click;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.LightGray;
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1522, 80);
            headerPanel.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1522, 80);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📚 HỆ THỐNG QUẢN LÝ THƯ VIỆN 📚";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuContainer
            // 
            menuContainer.BorderStyle = BorderStyle.FixedSingle;
            menuContainer.Controls.Add(menuMain);
            menuContainer.Dock = DockStyle.Top;
            menuContainer.Location = new Point(0, 80);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(1522, 55);
            menuContainer.TabIndex = 0;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1522, 697);
            Controls.Add(menuContainer);
            Controls.Add(headerPanel);
            ForeColor = Color.Black;
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

        #endregion


        private MenuStrip menuMain;
        private ToolStripMenuItem mnuGiaoDienChinh;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuSach;
        private ToolStripMenuItem mnuTheLoai;
        private ToolStripMenuItem mnuTacGia;
        private ToolStripMenuItem mnuXemDanhSachTacGia;
        private ToolStripSeparator separator4;
        private ToolStripMenuItem mnuDocGia;
        private ToolStripMenuItem mnuHienThiDanhSachDocGia;
        private ToolStripMenuItem mnuMuonTra;
        private ToolStripMenuItem mnuLapPhieuMuon;
        private ToolStripMenuItem mnuLapPhieuTra;
        private ToolStripMenuItem mnuLocPhieu;
        private ToolStripMenuItem mnuBaoCao;
        private ToolStripMenuItem mnuSachDangMuon;
        private ToolStripMenuItem mnuSachTreHanNhieuNhat;

        private Panel headerPanel;
        private Label lblTitle;
        private Panel menuContainer;
        private ToolStripMenuItem mnuXemDanhSachSach;
        private ToolStripMenuItem mnuXemDanhSachTheLoai;
    }
}
