using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLTV.form.BorrowReturn
{
    partial class fNewBorrowReceipt
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblDocGia;
        private ComboBox cbDocGia;
        private Label lblTimDocGia;
        private TextBox txtTimDocGia;
        private Button btnTimDocGia;
        private Label lblSach;
        private ListBox lstSach;
        private Label lblTimSach;
        private TextBox txtTimSach;
        private Button btnTimSach;
        private Label lblNgayMuon;
        private DateTimePicker dtpNgayMuon;
        private Label lblHanTra;
        private DateTimePicker dtpHanTra;
        private Button btnTaoPhieuMuon;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblDocGia = new Label();
            this.cbDocGia = new ComboBox();
            this.lblTimDocGia = new Label();
            this.txtTimDocGia = new TextBox();
            this.btnTimDocGia = new Button();
            this.lblSach = new Label();
            this.lstSach = new ListBox();
            this.lblTimSach = new Label();
            this.txtTimSach = new TextBox();
            this.btnTimSach = new Button();
            this.lblNgayMuon = new Label();
            this.dtpNgayMuon = new DateTimePicker();
            this.lblHanTra = new Label();
            this.dtpHanTra = new DateTimePicker();
            this.btnTaoPhieuMuon = new Button();
            this.SuspendLayout();

            // === Tiêu đề ===
            this.lblTitle.Text = "📝 TẠO PHIẾU MƯỢN SÁCH";
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.Location = new Point(200, 20);
            this.lblTitle.Size = new Size(400, 40);
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // === Độc giả ===
            this.lblDocGia.Text = "Độc giả:";
            this.lblDocGia.Location = new Point(50, 80);
            this.lblDocGia.Size = new Size(100, 30);

            this.cbDocGia.Location = new Point(150, 80);
            this.cbDocGia.Size = new Size(250, 30);

            this.lblTimDocGia.Text = "Mã:";
            this.lblTimDocGia.Location = new Point(420, 80);
            this.lblTimDocGia.Size = new Size(30, 30);

            this.txtTimDocGia.Location = new Point(460, 80);
            this.txtTimDocGia.Size = new Size(80, 30);

            this.btnTimDocGia.Text = "🔍";
            this.btnTimDocGia.Location = new Point(550, 80);
            this.btnTimDocGia.Size = new Size(30, 30);
            this.btnTimDocGia.Click += new EventHandler(this.btnTimDocGia_Click);

            // === Chọn sách ===
            this.lblSach.Text = "Chọn sách:";
            this.lblSach.Location = new Point(50, 130);
            this.lblSach.Size = new Size(100, 30);

            this.lstSach.Location = new Point(150, 130);
            this.lstSach.Size = new Size(360, 100);
            this.lstSach.SelectionMode = SelectionMode.MultiExtended;

            this.lblTimSach.Text = "Mã:";
            this.lblTimSach.Location = new Point(520, 130);
            this.lblTimSach.Size = new Size(30, 30);

            this.txtTimSach.Location = new Point(550, 130);
            this.txtTimSach.Size = new Size(80, 30);

            this.btnTimSach.Text = "🔍";
            this.btnTimSach.Location = new Point(640, 130);
            this.btnTimSach.Size = new Size(30, 30);
            this.btnTimSach.Click += new EventHandler(this.btnTimSach_Click);

            // === Ngày mượn ===
            this.lblNgayMuon.Text = "Ngày mượn:";
            this.lblNgayMuon.Location = new Point(50, 250);
            this.lblNgayMuon.Size = new Size(100, 30);

            this.dtpNgayMuon.Location = new Point(150, 250);
            this.dtpNgayMuon.Size = new Size(200, 30);

            // === Hạn trả ===
            this.lblHanTra.Text = "Hạn trả:";
            this.lblHanTra.Location = new Point(400, 250);
            this.lblHanTra.Size = new Size(100, 30);

            this.dtpHanTra.Location = new Point(500, 250);
            this.dtpHanTra.Size = new Size(200, 30);

            // === Nút tạo phiếu ===
            this.btnTaoPhieuMuon.Text = "📥 TẠO PHIẾU MƯỢN";
            this.btnTaoPhieuMuon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnTaoPhieuMuon.BackColor = Color.MediumSeaGreen;
            this.btnTaoPhieuMuon.ForeColor = Color.White;
            this.btnTaoPhieuMuon.FlatStyle = FlatStyle.Flat;
            this.btnTaoPhieuMuon.Location = new Point(300, 320);
            this.btnTaoPhieuMuon.Size = new Size(200, 40);
            this.btnTaoPhieuMuon.Click += new EventHandler(this.btnTaoPhieuMuon_Click);

            // === Add controls to form ===
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDocGia);
            this.Controls.Add(this.cbDocGia);
            this.Controls.Add(this.lblTimDocGia);
            this.Controls.Add(this.txtTimDocGia);
            this.Controls.Add(this.btnTimDocGia);
            this.Controls.Add(this.lblSach);
            this.Controls.Add(this.lstSach);
            this.Controls.Add(this.lblTimSach);
            this.Controls.Add(this.txtTimSach);
            this.Controls.Add(this.btnTimSach);
            this.Controls.Add(this.lblNgayMuon);
            this.Controls.Add(this.dtpNgayMuon);
            this.Controls.Add(this.lblHanTra);
            this.Controls.Add(this.dtpHanTra);
            this.Controls.Add(this.btnTaoPhieuMuon);

            // === Form ===
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 400);
            this.Name = "fNewBorrowReceipt";
            this.Text = "Tạo phiếu mượn sách";
            this.Load += new EventHandler(this.fNewBorrowReceipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
