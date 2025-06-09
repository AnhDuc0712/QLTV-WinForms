using System.Drawing;
using System.Windows.Forms;

namespace Ngducanh
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel headerPanel;
        private Label lblTitle;
        private Label lblUserName;
        private Panel menuContainer;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            headerPanel = new Panel();
            lblTitle = new Label();
            lblUserName = new Label();
            menuContainer = new Panel();
            menuMain = new MenuStrip();
            mnuGiaoDienChinh = new ToolStripMenuItem();
            mnuDangKy = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            mnuSach = new ToolStripMenuItem();
            mnuXemDanhSachSach = new ToolStripMenuItem();
            mnuThemSuaXoaSach = new ToolStripMenuItem();
            mnuLocDanhMucTacGia = new ToolStripMenuItem();
            mnuTimSach = new ToolStripMenuItem();
            mnuHienThiSachSoLuong = new ToolStripMenuItem();
            mnuTheLoai = new ToolStripMenuItem();
            mnuXemDanhSachTheLoai = new ToolStripMenuItem();
            mnuThemSuaXoaTheLoai = new ToolStripMenuItem();
            mnuTimTheLoai = new ToolStripMenuItem();
            mnuTacGia = new ToolStripMenuItem();
            mnuXemDanhSachTacGia = new ToolStripMenuItem();
            mnuThemSuaXoaTacGia = new ToolStripMenuItem();
            mnuTimTacGia = new ToolStripMenuItem();
            mnuDocGia = new ToolStripMenuItem();
            mnuThemSuaXoaDocGia = new ToolStripMenuItem();
            mnuTimKiemDocGia = new ToolStripMenuItem();
            mnuHienThiDanhSachDocGia = new ToolStripMenuItem();
            mnuBaoCao = new ToolStripMenuItem();
            mnuSachDangMuon = new ToolStripMenuItem();
            mnuSachTreHanNhieuNhat = new ToolStripMenuItem();
            mnuSoLuongSachMuon = new ToolStripMenuItem();
            mnuMuonTra = new ToolStripMenuItem();
            mnuLapPhieuMuon = new ToolStripMenuItem();
            mnuChonDocGia = new ToolStripMenuItem();
            mnuChonSachMuon = new ToolStripMenuItem();
            mnuNgayMuonTra = new ToolStripMenuItem();
            mnuLapPhieuTra = new ToolStripMenuItem();
            mnuChonDocGiaSachDangMuon = new ToolStripMenuItem();
            mnuXacNhanTra = new ToolStripMenuItem();
            mnuGhiNhanPhat = new ToolStripMenuItem();
            mnuLocPhieu = new ToolStripMenuItem();
            headerPanel.SuspendLayout();
            menuContainer.SuspendLayout();
            menuMain.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.LightGray;
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Controls.Add(lblUserName);
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
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblUserName.ForeColor = Color.FromArgb(0, 102, 204);
            lblUserName.Location = new Point(1272, 15);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(0, 25);
            lblUserName.TabIndex = 1;
            lblUserName.TextAlign = ContentAlignment.TopRight;
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
            // menuMain
            // 
            menuMain.ImageScalingSize = new Size(20, 20);
            menuMain.Items.AddRange(new ToolStripItem[] { mnuGiaoDienChinh, mnuSach, mnuTheLoai, mnuTacGia, mnuDocGia, mnuBaoCao, mnuMuonTra });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(1520, 28);
            menuMain.TabIndex = 0;
            // 
            // mnuGiaoDienChinh
            // 
            mnuGiaoDienChinh.DropDownItems.AddRange(new ToolStripItem[] { mnuDangKy, mnuDangNhap, mnuThoat });
            mnuGiaoDienChinh.Name = "mnuGiaoDienChinh";
            mnuGiaoDienChinh.Size = new Size(155, 24);
            mnuGiaoDienChinh.Text = "📂 Giao Diện Chính";
            // 
            // mnuDangKy
            // 
            mnuDangKy.Name = "mnuDangKy";
            mnuDangKy.Size = new Size(224, 26);
            mnuDangKy.Text = "📝 Đăng Ký";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(224, 26);
            mnuDangNhap.Text = "🔑 Đăng Nhập";
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(224, 26);
            mnuThoat.Text = "❌ Thoát";
            // 
            // mnuSach
            // 
            mnuSach.DropDownItems.AddRange(new ToolStripItem[] { mnuXemDanhSachSach, mnuThemSuaXoaSach, mnuLocDanhMucTacGia, mnuTimSach, mnuHienThiSachSoLuong });
            mnuSach.Name = "mnuSach";
            mnuSach.Size = new Size(135, 24);
            mnuSach.Text = "📚 Quản Lý Sách";
            // 
            // mnuXemDanhSachSach
            // 
            mnuXemDanhSachSach.Name = "mnuXemDanhSachSach";
            mnuXemDanhSachSach.Size = new Size(301, 26);
            mnuXemDanhSachSach.Text = "📖 Xem Danh Sách Sách";
            // 
            // mnuThemSuaXoaSach
            // 
            mnuThemSuaXoaSach.Name = "mnuThemSuaXoaSach";
            mnuThemSuaXoaSach.Size = new Size(301, 26);
            mnuThemSuaXoaSach.Text = "➕✏️🗑️ Thêm/Sửa/Xóa Sách";
            // 
            // mnuLocDanhMucTacGia
            // 
            mnuLocDanhMucTacGia.Name = "mnuLocDanhMucTacGia";
            mnuLocDanhMucTacGia.Size = new Size(301, 26);
            mnuLocDanhMucTacGia.Text = "📚 Lọc Theo Danh Mục/Tác Giả";
            // 
            // mnuTimSach
            // 
            mnuTimSach.Name = "mnuTimSach";
            mnuTimSach.Size = new Size(301, 26);
            mnuTimSach.Text = "🔍 Tìm Kiếm Sách";
            // 
            // mnuHienThiSachSoLuong
            // 
            mnuHienThiSachSoLuong.Name = "mnuHienThiSachSoLuong";
            mnuHienThiSachSoLuong.Size = new Size(301, 26);
            mnuHienThiSachSoLuong.Text = "📋 Hiển Thị Sách và Số Lượng";
            // 
            // mnuTheLoai
            // 
            mnuTheLoai.DropDownItems.AddRange(new ToolStripItem[] { mnuXemDanhSachTheLoai, mnuThemSuaXoaTheLoai, mnuTimTheLoai });
            mnuTheLoai.Name = "mnuTheLoai";
            mnuTheLoai.Size = new Size(195, 24);
            mnuTheLoai.Text = "🏷️ Quản Lý Thể Loại Sách";
            // 
            // mnuXemDanhSachTheLoai
            // 
            mnuXemDanhSachTheLoai.Name = "mnuXemDanhSachTheLoai";
            mnuXemDanhSachTheLoai.Size = new Size(319, 26);
            mnuXemDanhSachTheLoai.Text = "📄 Xem Danh Sách Thể Loại";
            // 
            // mnuThemSuaXoaTheLoai
            // 
            mnuThemSuaXoaTheLoai.Name = "mnuThemSuaXoaTheLoai";
            mnuThemSuaXoaTheLoai.Size = new Size(319, 26);
            mnuThemSuaXoaTheLoai.Text = "➕✏️🗑️ Thêm/Sửa/Xóa Thể Loại";
            // 
            // mnuTimTheLoai
            // 
            mnuTimTheLoai.Name = "mnuTimTheLoai";
            mnuTimTheLoai.Size = new Size(319, 26);
            mnuTimTheLoai.Text = "🔍 Tìm Kiếm Thể Loại";
            // 
            // mnuTacGia
            // 
            mnuTacGia.DropDownItems.AddRange(new ToolStripItem[] { mnuXemDanhSachTacGia, mnuThemSuaXoaTacGia, mnuTimTacGia });
            mnuTacGia.Name = "mnuTacGia";
            mnuTacGia.Size = new Size(151, 24);
            mnuTacGia.Text = "✍️ Quản Lý Tác Giả";
            // 
            // mnuXemDanhSachTacGia
            // 
            mnuXemDanhSachTacGia.Name = "mnuXemDanhSachTacGia";
            mnuXemDanhSachTacGia.Size = new Size(310, 26);
            mnuXemDanhSachTacGia.Text = "📄 Xem Danh Sách Tác Giả";
            // 
            // mnuThemSuaXoaTacGia
            // 
            mnuThemSuaXoaTacGia.Name = "mnuThemSuaXoaTacGia";
            mnuThemSuaXoaTacGia.Size = new Size(310, 26);
            mnuThemSuaXoaTacGia.Text = "➕✏️🗑️ Thêm/Sửa/Xóa Tác Giả";
            // 
            // mnuTimTacGia
            // 
            mnuTimTacGia.Name = "mnuTimTacGia";
            mnuTimTacGia.Size = new Size(310, 26);
            mnuTimTacGia.Text = "🔍 Tìm Kiếm/Lọc Tác Giả";
            // 
            // mnuDocGia
            // 
            mnuDocGia.DropDownItems.AddRange(new ToolStripItem[] { mnuThemSuaXoaDocGia, mnuTimKiemDocGia, mnuHienThiDanhSachDocGia });
            mnuDocGia.Name = "mnuDocGia";
            mnuDocGia.Size = new Size(157, 24);
            mnuDocGia.Text = "👤 Quản Lý Độc Giả";
            // 
            // mnuThemSuaXoaDocGia
            // 
            mnuThemSuaXoaDocGia.Name = "mnuThemSuaXoaDocGia";
            mnuThemSuaXoaDocGia.Size = new Size(316, 26);
            mnuThemSuaXoaDocGia.Text = "➕✏️🗑️ Thêm/Sửa/Xóa Độc Giả";
            // 
            // mnuTimKiemDocGia
            // 
            mnuTimKiemDocGia.Name = "mnuTimKiemDocGia";
            mnuTimKiemDocGia.Size = new Size(316, 26);
            mnuTimKiemDocGia.Text = "🔍 Tìm Kiếm Độc Giả";
            // 
            // mnuHienThiDanhSachDocGia
            // 
            mnuHienThiDanhSachDocGia.Name = "mnuHienThiDanhSachDocGia";
            mnuHienThiDanhSachDocGia.Size = new Size(316, 26);
            mnuHienThiDanhSachDocGia.Text = "📋 Hiển Thị Danh Sách Độc Giả";
            // 
            // mnuBaoCao
            // 
            mnuBaoCao.DropDownItems.AddRange(new ToolStripItem[] { mnuSachDangMuon, mnuSachTreHanNhieuNhat, mnuSoLuongSachMuon });
            mnuBaoCao.Name = "mnuBaoCao";
            mnuBaoCao.Size = new Size(181, 24);
            mnuBaoCao.Text = "📊 Thống Kê - Báo Cáo";
            // 
            // mnuSachDangMuon
            // 
            mnuSachDangMuon.Name = "mnuSachDangMuon";
            mnuSachDangMuon.Size = new Size(284, 26);
            mnuSachDangMuon.Text = "📕 Sách Đang Mượn";
            // 
            // mnuSachTreHanNhieuNhat
            // 
            mnuSachTreHanNhieuNhat.Name = "mnuSachTreHanNhieuNhat";
            mnuSachTreHanNhieuNhat.Size = new Size(284, 26);
            mnuSachTreHanNhieuNhat.Text = "⏰ Sách Trễ Hạn/Nhiều Nhất";
            // 
            // mnuSoLuongSachMuon
            // 
            mnuSoLuongSachMuon.Name = "mnuSoLuongSachMuon";
            mnuSoLuongSachMuon.Size = new Size(284, 26);
            mnuSoLuongSachMuon.Text = "📈 Số Lượng Sách Mượn";
            // 
            // mnuMuonTra
            // 
            mnuMuonTra.DropDownItems.AddRange(new ToolStripItem[] { mnuLapPhieuMuon, mnuLapPhieuTra, mnuLocPhieu });
            mnuMuonTra.Name = "mnuMuonTra";
            mnuMuonTra.Size = new Size(204, 24);
            mnuMuonTra.Text = "🔄 Quản Lý Mượn/Trả Sách";
            // 
            // mnuLapPhieuMuon
            // 
            mnuLapPhieuMuon.DropDownItems.AddRange(new ToolStripItem[] { mnuChonDocGia, mnuChonSachMuon, mnuNgayMuonTra });
            mnuLapPhieuMuon.Name = "mnuLapPhieuMuon";
            mnuLapPhieuMuon.Size = new Size(346, 26);
            mnuLapPhieuMuon.Text = "📤 Lập Phiếu Mượn Sách";
            // 
            // mnuChonDocGia
            // 
            mnuChonDocGia.Name = "mnuChonDocGia";
            mnuChonDocGia.Size = new Size(229, 26);
            mnuChonDocGia.Text = "👤 Chọn Độc Giả";
            // 
            // mnuChonSachMuon
            // 
            mnuChonSachMuon.Name = "mnuChonSachMuon";
            mnuChonSachMuon.Size = new Size(229, 26);
            mnuChonSachMuon.Text = "📚 Chọn Sách Mượn";
            // 
            // mnuNgayMuonTra
            // 
            mnuNgayMuonTra.Name = "mnuNgayMuonTra";
            mnuNgayMuonTra.Size = new Size(229, 26);
            mnuNgayMuonTra.Text = "📅 Ngày Mượn/Trả";
            // 
            // mnuLapPhieuTra
            // 
            mnuLapPhieuTra.DropDownItems.AddRange(new ToolStripItem[] { mnuChonDocGiaSachDangMuon, mnuXacNhanTra, mnuGhiNhanPhat });
            mnuLapPhieuTra.Name = "mnuLapPhieuTra";
            mnuLapPhieuTra.Size = new Size(346, 26);
            mnuLapPhieuTra.Text = "📥 Lập Phiếu Trả Sách";
            // 
            // mnuChonDocGiaSachDangMuon
            // 
            mnuChonDocGiaSachDangMuon.Name = "mnuChonDocGiaSachDangMuon";
            mnuChonDocGiaSachDangMuon.Size = new Size(349, 26);
            mnuChonDocGiaSachDangMuon.Text = "👤📚 Chọn Độc Giả/Sách Đang Mượn";
            // 
            // mnuXacNhanTra
            // 
            mnuXacNhanTra.Name = "mnuXacNhanTra";
            mnuXacNhanTra.Size = new Size(349, 26);
            mnuXacNhanTra.Text = "✔️ Xác Nhận Trả";
            // 
            // mnuGhiNhanPhat
            // 
            mnuGhiNhanPhat.Name = "mnuGhiNhanPhat";
            mnuGhiNhanPhat.Size = new Size(349, 26);
            mnuGhiNhanPhat.Text = "⚠️ Ghi Nhận Phạt";
            // 
            // mnuLocPhieu
            // 
            mnuLocPhieu.Name = "mnuLocPhieu";
            mnuLocPhieu.Size = new Size(346, 26);
            mnuLocPhieu.Text = "📚 Lọc Theo Độc Giả/Sách/Trạng Thái";
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
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            menuContainer.ResumeLayout(false);
            menuContainer.PerformLayout();
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuMain;
        private ToolStripMenuItem mnuGiaoDienChinh;
        private ToolStripMenuItem mnuDangKy;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuSach;
        private ToolStripMenuItem mnuXemDanhSachSach;
        private ToolStripMenuItem mnuThemSuaXoaSach;
        private ToolStripMenuItem mnuLocDanhMucTacGia;
        private ToolStripMenuItem mnuTimSach;
        private ToolStripMenuItem mnuHienThiSachSoLuong;
        private ToolStripMenuItem mnuTheLoai;
        private ToolStripMenuItem mnuXemDanhSachTheLoai;
        private ToolStripMenuItem mnuThemSuaXoaTheLoai;
        private ToolStripMenuItem mnuTimTheLoai;
        private ToolStripMenuItem mnuTacGia;
        private ToolStripMenuItem mnuXemDanhSachTacGia;
        private ToolStripMenuItem mnuThemSuaXoaTacGia;
        private ToolStripMenuItem mnuTimTacGia;
        private ToolStripMenuItem mnuDocGia;
        private ToolStripMenuItem mnuThemSuaXoaDocGia;
        private ToolStripMenuItem mnuTimKiemDocGia;
        private ToolStripMenuItem mnuHienThiDanhSachDocGia;
        private ToolStripMenuItem mnuBaoCao;
        private ToolStripMenuItem mnuSachDangMuon;
        private ToolStripMenuItem mnuSachTreHanNhieuNhat;
        private ToolStripMenuItem mnuSoLuongSachMuon;
        private ToolStripMenuItem mnuMuonTra;
        private ToolStripMenuItem mnuLapPhieuMuon;
        private ToolStripMenuItem mnuChonDocGia;
        private ToolStripMenuItem mnuChonSachMuon;
        private ToolStripMenuItem mnuNgayMuonTra;
        private ToolStripMenuItem mnuLapPhieuTra;
        private ToolStripMenuItem mnuChonDocGiaSachDangMuon;
        private ToolStripMenuItem mnuXacNhanTra;
        private ToolStripMenuItem mnuGhiNhanPhat;
        private ToolStripMenuItem mnuLocPhieu;
    }
}
