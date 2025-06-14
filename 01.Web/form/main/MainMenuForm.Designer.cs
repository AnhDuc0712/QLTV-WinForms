
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
            mnuGiaoDienChinh.DropDownItems.AddRange(new ToolStripItem[] { mnuDangKy, mnuDangNhap, mnuThoat });
            mnuGiaoDienChinh.ForeColor = Color.Black;
            mnuGiaoDienChinh.Name = "mnuGiaoDienChinh";
            mnuGiaoDienChinh.Size = new Size(191, 43);
            mnuGiaoDienChinh.Text = "📂 Giao Diện Chính";
            // 
            // mnuDangKy
            // 
            mnuDangKy.BackColor = Color.White;
            mnuDangKy.Font = new Font("Times New Roman", 10F);
            mnuDangKy.ForeColor = Color.Black;
            mnuDangKy.Name = "mnuDangKy";
            mnuDangKy.Size = new Size(187, 26);
            mnuDangKy.Text = "📝 Đăng Ký";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.BackColor = Color.White;
            mnuDangNhap.Font = new Font("Times New Roman", 10F);
            mnuDangNhap.ForeColor = Color.Black;
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(187, 26);
            mnuDangNhap.Text = "🔑 Đăng Nhập";
            // 
            // mnuThoat
            // 
            mnuThoat.BackColor = Color.White;
            mnuThoat.Font = new Font("Times New Roman", 10F);
            mnuThoat.ForeColor = Color.Black;
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(187, 26);
            mnuThoat.Text = "❌ Thoát";
            // 
            // mnuSach
            // 
            mnuSach.BackColor = Color.LightGray;
            mnuSach.DropDownItems.AddRange(new ToolStripItem[] { mnuXemDanhSachSach, mnuThemSuaXoaSach, mnuLocDanhMucTacGia, mnuTimSach, mnuHienThiSachSoLuong });
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
            mnuXemDanhSachSach.Size = new Size(309, 26);
            mnuXemDanhSachSach.Text = "📖 Xem Danh Sách Sách";
            // 
            // mnuThemSuaXoaSach
            // 
            mnuThemSuaXoaSach.BackColor = Color.White;
            mnuThemSuaXoaSach.Font = new Font("Times New Roman", 10F);
            mnuThemSuaXoaSach.ForeColor = Color.Black;
            mnuThemSuaXoaSach.Name = "mnuThemSuaXoaSach";
            mnuThemSuaXoaSach.Size = new Size(309, 26);
            mnuThemSuaXoaSach.Text = "➕✏️🗑️ Thêm/Sửa/Xóa Sách";
            // 
            // mnuLocDanhMucTacGia
            // 
            mnuLocDanhMucTacGia.BackColor = Color.White;
            mnuLocDanhMucTacGia.Font = new Font("Times New Roman", 10F);
            mnuLocDanhMucTacGia.ForeColor = Color.Black;
            mnuLocDanhMucTacGia.Name = "mnuLocDanhMucTacGia";
            mnuLocDanhMucTacGia.Size = new Size(309, 26);
            mnuLocDanhMucTacGia.Text = "\U0001f9e9 Lọc Theo Danh Mục/Tác Giả";
            // 
            // mnuTimSach
            // 
            mnuTimSach.BackColor = Color.White;
            mnuTimSach.Font = new Font("Times New Roman", 10F);
            mnuTimSach.ForeColor = Color.Black;
            mnuTimSach.Name = "mnuTimSach";
            mnuTimSach.Size = new Size(309, 26);
            mnuTimSach.Text = "🔍 Tìm Kiếm Sách";
            // 
            // mnuHienThiSachSoLuong
            // 
            mnuHienThiSachSoLuong.BackColor = Color.White;
            mnuHienThiSachSoLuong.Font = new Font("Times New Roman", 10F);
            mnuHienThiSachSoLuong.ForeColor = Color.Black;
            mnuHienThiSachSoLuong.Name = "mnuHienThiSachSoLuong";
            mnuHienThiSachSoLuong.Size = new Size(309, 26);
            mnuHienThiSachSoLuong.Text = "📋 Hiển Thị Sách và Số Lượng";
            // 
            // mnuTheLoai
            // 
            mnuTheLoai.BackColor = Color.LightGray;
            mnuTheLoai.DropDownItems.AddRange(new ToolStripItem[] { mnuXemDanhSachTheLoai, mnuThemSuaXoaTheLoai, mnuTimTheLoai });
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
            mnuXemDanhSachTheLoai.Size = new Size(310, 26);
            mnuXemDanhSachTheLoai.Text = "📄 Xem Danh Sách Thể Loại";
            // 
            // mnuThemSuaXoaTheLoai
            // 
            mnuThemSuaXoaTheLoai.BackColor = Color.White;
            mnuThemSuaXoaTheLoai.Font = new Font("Times New Roman", 10F);
            mnuThemSuaXoaTheLoai.ForeColor = Color.Black;
            mnuThemSuaXoaTheLoai.Name = "mnuThemSuaXoaTheLoai";
            mnuThemSuaXoaTheLoai.Size = new Size(310, 26);
            mnuThemSuaXoaTheLoai.Text = "➕✏️🗑️ Thêm/Sửa/Xóa Thể Loại";
            // 
            // mnuTimTheLoai
            // 
            mnuTimTheLoai.BackColor = Color.White;
            mnuTimTheLoai.Font = new Font("Times New Roman", 10F);
            mnuTimTheLoai.ForeColor = Color.Black;
            mnuTimTheLoai.Name = "mnuTimTheLoai";
            mnuTimTheLoai.Size = new Size(310, 26);
            mnuTimTheLoai.Text = "🔍 Tìm Kiếm Thể Loại";
            // 
            // mnuTacGia
            // 
            mnuTacGia.BackColor = Color.LightGray;
            mnuTacGia.DropDownItems.AddRange(new ToolStripItem[] { mnuXemDanhSachTacGia, mnuThemSuaXoaTacGia, mnuTimTacGia });
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
            mnuXemDanhSachTacGia.Size = new Size(302, 26);
            mnuXemDanhSachTacGia.Text = "📄 Xem Danh Sách Tác Giả";
            mnuXemDanhSachTacGia.Click += mnuXemDanhSachTacGia_Click_1;
            // 
            // mnuThemSuaXoaTacGia
            // 
            mnuThemSuaXoaTacGia.BackColor = Color.White;
            mnuThemSuaXoaTacGia.Font = new Font("Times New Roman", 10F);
            mnuThemSuaXoaTacGia.ForeColor = Color.Black;
            mnuThemSuaXoaTacGia.Name = "mnuThemSuaXoaTacGia";
            mnuThemSuaXoaTacGia.Size = new Size(302, 26);
            mnuThemSuaXoaTacGia.Text = "➕✏️🗑️ Thêm/Sửa/Xóa Tác Giả";
            // 
            // mnuTimTacGia
            // 
            mnuTimTacGia.BackColor = Color.White;
            mnuTimTacGia.Font = new Font("Times New Roman", 10F);
            mnuTimTacGia.ForeColor = Color.Black;
            mnuTimTacGia.Name = "mnuTimTacGia";
            mnuTimTacGia.Size = new Size(302, 26);
            mnuTimTacGia.Text = "🔍 Tìm Kiếm/Lọc Tác Giả";
            // 
            // mnuDocGia
            // 
            mnuDocGia.BackColor = Color.LightGray;
            mnuDocGia.DropDownItems.AddRange(new ToolStripItem[] { mnuThemSuaXoaDocGia, mnuTimKiemDocGia, mnuHienThiDanhSachDocGia });
            mnuDocGia.ForeColor = Color.Black;
            mnuDocGia.Name = "mnuDocGia";
            mnuDocGia.Size = new Size(199, 43);
            mnuDocGia.Text = "👤 Quản Lý Độc Giả";
            mnuDocGia.Click += mnuDocGia_Click;
            // 
            // mnuThemSuaXoaDocGia
            // 
            mnuThemSuaXoaDocGia.BackColor = Color.White;
            mnuThemSuaXoaDocGia.Font = new Font("Times New Roman", 10F);
            mnuThemSuaXoaDocGia.ForeColor = Color.Black;
            mnuThemSuaXoaDocGia.Name = "mnuThemSuaXoaDocGia";
            mnuThemSuaXoaDocGia.Size = new Size(308, 26);
            mnuThemSuaXoaDocGia.Text = "➕✏️🗑️ Thêm/Sửa/Xóa Độc Giả";
            // 
            // mnuTimKiemDocGia
            // 
            mnuTimKiemDocGia.BackColor = Color.White;
            mnuTimKiemDocGia.Font = new Font("Times New Roman", 10F);
            mnuTimKiemDocGia.ForeColor = Color.Black;
            mnuTimKiemDocGia.Name = "mnuTimKiemDocGia";
            mnuTimKiemDocGia.Size = new Size(308, 26);
            mnuTimKiemDocGia.Text = "🔍 Tìm Kiếm Độc Giả";
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
            mnuBaoCao.DropDownItems.AddRange(new ToolStripItem[] { mnuSachDangMuon, mnuSachTreHanNhieuNhat, mnuSoLuongSachMuon });
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
            // mnuSoLuongSachMuon
            // 
            mnuSoLuongSachMuon.BackColor = Color.White;
            mnuSoLuongSachMuon.Font = new Font("Times New Roman", 10F);
            mnuSoLuongSachMuon.ForeColor = Color.Black;
            mnuSoLuongSachMuon.Name = "mnuSoLuongSachMuon";
            mnuSoLuongSachMuon.Size = new Size(284, 26);
            mnuSoLuongSachMuon.Text = "📈 Số Lượng Sách Mượn";
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
            mnuLapPhieuMuon.DropDownItems.AddRange(new ToolStripItem[] { mnuChonDocGia, mnuChonSachMuon, mnuNgayMuonTra });
            mnuLapPhieuMuon.Font = new Font("Times New Roman", 10F);
            mnuLapPhieuMuon.ForeColor = Color.Black;
            mnuLapPhieuMuon.Name = "mnuLapPhieuMuon";
            mnuLapPhieuMuon.Size = new Size(351, 26);
            mnuLapPhieuMuon.Text = "📤 Lập Phiếu Mượn Sách";
            // 
            // mnuChonDocGia
            // 
            mnuChonDocGia.BackColor = Color.White;
            mnuChonDocGia.Font = new Font("Times New Roman", 10F);
            mnuChonDocGia.ForeColor = Color.Black;
            mnuChonDocGia.Name = "mnuChonDocGia";
            mnuChonDocGia.Size = new Size(229, 26);
            mnuChonDocGia.Text = "👤 Chọn Độc Giả";
            // 
            // mnuChonSachMuon
            // 
            mnuChonSachMuon.BackColor = Color.White;
            mnuChonSachMuon.Font = new Font("Times New Roman", 10F);
            mnuChonSachMuon.ForeColor = Color.Black;
            mnuChonSachMuon.Name = "mnuChonSachMuon";
            mnuChonSachMuon.Size = new Size(229, 26);
            mnuChonSachMuon.Text = "📚 Chọn Sách Mượn";
            // 
            // mnuNgayMuonTra
            // 
            mnuNgayMuonTra.BackColor = Color.White;
            mnuNgayMuonTra.Font = new Font("Times New Roman", 10F);
            mnuNgayMuonTra.ForeColor = Color.Black;
            mnuNgayMuonTra.Name = "mnuNgayMuonTra";
            mnuNgayMuonTra.Size = new Size(229, 26);
            mnuNgayMuonTra.Text = "📅 Ngày Mượn/Trả";
            // 
            // mnuLapPhieuTra
            // 
            mnuLapPhieuTra.BackColor = Color.White;
            mnuLapPhieuTra.DropDownItems.AddRange(new ToolStripItem[] { mnuChonDocGiaSachDangMuon, mnuXacNhanTra, mnuGhiNhanPhat });
            mnuLapPhieuTra.Font = new Font("Times New Roman", 10F);
            mnuLapPhieuTra.ForeColor = Color.Black;
            mnuLapPhieuTra.Name = "mnuLapPhieuTra";
            mnuLapPhieuTra.Size = new Size(351, 26);
            mnuLapPhieuTra.Text = "📥 Lập Phiếu Trả Sách";
            // 
            // mnuChonDocGiaSachDangMuon
            // 
            mnuChonDocGiaSachDangMuon.BackColor = Color.White;
            mnuChonDocGiaSachDangMuon.Font = new Font("Times New Roman", 10F);
            mnuChonDocGiaSachDangMuon.ForeColor = Color.Black;
            mnuChonDocGiaSachDangMuon.Name = "mnuChonDocGiaSachDangMuon";
            mnuChonDocGiaSachDangMuon.Size = new Size(346, 26);
            mnuChonDocGiaSachDangMuon.Text = "👤📚 Chọn Độc Giả/Sách Đang Mượn";
            // 
            // mnuXacNhanTra
            // 
            mnuXacNhanTra.BackColor = Color.White;
            mnuXacNhanTra.Font = new Font("Times New Roman", 10F);
            mnuXacNhanTra.ForeColor = Color.Black;
            mnuXacNhanTra.Name = "mnuXacNhanTra";
            mnuXacNhanTra.Size = new Size(346, 26);
            mnuXacNhanTra.Text = "✔️ Xác Nhận Trả";
            // 
            // mnuGhiNhanPhat
            // 
            mnuGhiNhanPhat.BackColor = Color.White;
            mnuGhiNhanPhat.Font = new Font("Times New Roman", 10F);
            mnuGhiNhanPhat.ForeColor = Color.Black;
            mnuGhiNhanPhat.Name = "mnuGhiNhanPhat";
            mnuGhiNhanPhat.Size = new Size(346, 26);
            mnuGhiNhanPhat.Text = "⚠️ Ghi Nhận Phạt";
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
        private ToolStripSeparator separator4;
        private ToolStripMenuItem mnuDocGia;
        private ToolStripMenuItem mnuThemSuaXoaDocGia;
        private ToolStripMenuItem mnuTimKiemDocGia;
        private ToolStripMenuItem mnuHienThiDanhSachDocGia;
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
        private ToolStripMenuItem mnuBaoCao;
        private ToolStripMenuItem mnuSachDangMuon;
        private ToolStripMenuItem mnuSachTreHanNhieuNhat;
        private ToolStripMenuItem mnuSoLuongSachMuon;
        private Panel headerPanel;
        private Label lblTitle;
        private Panel menuContainer;
    }
}
