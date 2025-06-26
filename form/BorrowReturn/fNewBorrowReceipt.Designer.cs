using Siticone.Desktop.UI.WinForms;
using Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLTV.form.BorrowReturn
{
    partial class fNewBorrowReceipt
    {
        private System.ComponentModel.IContainer components = null;
        private SiticoneShadowForm shadowForm;
        private SiticoneElipse siticoneElipse1;

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
            shadowForm = new SiticoneShadowForm(components);
            siticoneElipse1 = new SiticoneElipse(components);
            lblTitle = new KryptonLabel();
            lblReceiptCount = new KryptonLabel();
            lblDocGia = new KryptonLabel();
            cbDocGia = new SiticoneComboBox();
            lblTimDocGia = new KryptonLabel();
            txtTimDocGia = new KryptonTextBox();
            btnTimDocGia = new SiticoneButton();
            lblSach = new KryptonLabel();
            lstSach = new ListBox();
            lblTimSach = new KryptonLabel();
            txtTimSach = new KryptonTextBox();
            btnTimSach = new SiticoneButton();
            lblNgayMuon = new KryptonLabel();
            dtpNgayMuon = new DateTimePicker();
            lblHanTra = new KryptonLabel();
            dtpHanTra = new DateTimePicker();
            btnTaoPhieuMuon = new SiticoneButton();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // shadowForm
            // 
            shadowForm.TargetForm = this;
            // 
            // siticoneElipse1
            // 
            siticoneElipse1.TargetControl = this;
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(221, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(409, 46);
            lblTitle.StateCommon.ShortText.Color1 = Color.White;
            lblTitle.StateCommon.ShortText.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.StateCommon.ShortText.TextH = PaletteRelativeAlign.Center;
            lblTitle.StateCommon.ShortText.TextV = PaletteRelativeAlign.Center;
            lblTitle.TabIndex = 0;
            lblTitle.Values.Text = "📝 TẠO PHIẾU MƯỢN SÁCH";
            // 
            // lblReceiptCount
            // 
            lblReceiptCount.Location = new Point(569, 288);
            lblReceiptCount.Name = "lblReceiptCount";
            lblReceiptCount.Size = new Size(140, 36);
            lblReceiptCount.StateCommon.ShortText.Color1 = Color.LightGreen;
            lblReceiptCount.StateCommon.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblReceiptCount.TabIndex = 1;
            lblReceiptCount.Values.Text = "Số phiếu: 0";
            // 
            // lblDocGia
            // 
            lblDocGia.Location = new Point(93, 72);
            lblDocGia.Name = "lblDocGia";
            lblDocGia.Size = new Size(92, 32);
            lblDocGia.StateCommon.ShortText.Color1 = Color.White;
            lblDocGia.StateCommon.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDocGia.TabIndex = 2;
            lblDocGia.Values.Text = "Độc giả:";
            // 
            // cbDocGia
            // 
            cbDocGia.BackColor = Color.Transparent;
            cbDocGia.BorderRadius = 10;
            cbDocGia.DrawMode = DrawMode.OwnerDrawFixed;
            cbDocGia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDocGia.FillColor = Color.FromArgb(28, 31, 38);
            cbDocGia.FocusedColor = Color.FromArgb(94, 148, 255);
            cbDocGia.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbDocGia.Font = new Font("Segoe UI", 10F);
            cbDocGia.ForeColor = Color.WhiteSmoke;
            cbDocGia.FormattingEnabled = true;
            cbDocGia.ItemHeight = 30;
            cbDocGia.Location = new Point(191, 72);
            cbDocGia.Name = "cbDocGia";
            cbDocGia.Size = new Size(250, 36);
            cbDocGia.TabIndex = 3;
            // 
            // lblTimDocGia
            // 
            lblTimDocGia.Location = new Point(444, 76);
            lblTimDocGia.Name = "lblTimDocGia";
            lblTimDocGia.Size = new Size(136, 32);
            lblTimDocGia.StateCommon.ShortText.Color1 = Color.White;
            lblTimDocGia.StateCommon.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTimDocGia.TabIndex = 4;
            lblTimDocGia.Values.Text = "Mã Độc Giả :";
            // 
            // txtTimDocGia
            // 
            txtTimDocGia.Location = new Point(586, 76);
            txtTimDocGia.Name = "txtTimDocGia";
            txtTimDocGia.Size = new Size(100, 33);
            txtTimDocGia.StateCommon.Back.Color1 = Color.FromArgb(28, 31, 38);
            txtTimDocGia.StateCommon.Border.Color1 = Color.FromArgb(94, 148, 255);
            txtTimDocGia.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtTimDocGia.StateCommon.Border.Rounding = 10F;
            txtTimDocGia.StateCommon.Content.Color1 = Color.WhiteSmoke;
            txtTimDocGia.TabIndex = 5;
            // 
            // btnTimDocGia
            // 
            btnTimDocGia.BorderRadius = 10;
            btnTimDocGia.FillColor = Color.FromArgb(41, 121, 255);
            btnTimDocGia.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTimDocGia.ForeColor = Color.White;
            btnTimDocGia.HoverState.FillColor = Color.FromArgb(30, 100, 200);
            btnTimDocGia.Location = new Point(698, 74);
            btnTimDocGia.Name = "btnTimDocGia";
            btnTimDocGia.Size = new Size(40, 30);
            btnTimDocGia.TabIndex = 6;
            btnTimDocGia.Text = "🔍";
            btnTimDocGia.Click += btnTimDocGia_Click;
            // 
            // lblSach
            // 
            lblSach.Location = new Point(12, 139);
            lblSach.Name = "lblSach";
            lblSach.Size = new Size(117, 32);
            lblSach.StateCommon.ShortText.Color1 = Color.White;
            lblSach.StateCommon.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSach.TabIndex = 7;
            lblSach.Values.Text = "Chọn sách:";
            // 
            // lstSach
            // 
            lstSach.BackColor = Color.FromArgb(22, 27, 34);
            lstSach.ForeColor = Color.WhiteSmoke;
            lstSach.FormattingEnabled = true;
            lstSach.Location = new Point(130, 139);
            lstSach.Name = "lstSach";
            lstSach.SelectionMode = SelectionMode.MultiExtended;
            lstSach.Size = new Size(400, 104);
            lstSach.TabIndex = 8;
            // 
            // lblTimSach
            // 
            lblTimSach.Location = new Point(536, 139);
            lblTimSach.Name = "lblTimSach";
            lblTimSach.Size = new Size(106, 32);
            lblTimSach.StateCommon.ShortText.Color1 = Color.White;
            lblTimSach.StateCommon.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTimSach.TabIndex = 9;
            lblTimSach.Values.Text = "Mã Sách :";
            // 
            // txtTimSach
            // 
            txtTimSach.Location = new Point(641, 138);
            txtTimSach.Name = "txtTimSach";
            txtTimSach.Size = new Size(100, 33);
            txtTimSach.StateCommon.Back.Color1 = Color.FromArgb(28, 31, 38);
            txtTimSach.StateCommon.Border.Color1 = Color.FromArgb(94, 148, 255);
            txtTimSach.StateCommon.Border.Rounding = 10F;
            txtTimSach.StateCommon.Content.Color1 = Color.WhiteSmoke;
            txtTimSach.TabIndex = 10;
            // 
            // btnTimSach
            // 
            btnTimSach.BorderRadius = 10;
            btnTimSach.FillColor = Color.FromArgb(41, 121, 255);
            btnTimSach.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTimSach.ForeColor = Color.White;
            btnTimSach.HoverState.FillColor = Color.FromArgb(30, 100, 200);
            btnTimSach.Location = new Point(747, 139);
            btnTimSach.Name = "btnTimSach";
            btnTimSach.Size = new Size(40, 30);
            btnTimSach.TabIndex = 11;
            btnTimSach.Text = "🔍";
            btnTimSach.Click += btnTimSach_Click;
            // 
            // lblNgayMuon
            // 
            lblNgayMuon.Location = new Point(34, 259);
            lblNgayMuon.Name = "lblNgayMuon";
            lblNgayMuon.Size = new Size(134, 32);
            lblNgayMuon.StateCommon.ShortText.Color1 = Color.White;
            lblNgayMuon.StateCommon.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNgayMuon.TabIndex = 12;
            lblNgayMuon.Values.Text = "Ngày mượn:";
            // 
            // dtpNgayMuon
            // 
            dtpNgayMuon.CalendarFont = new Font("Segoe UI", 10F);
            dtpNgayMuon.CalendarMonthBackground = Color.FromArgb(28, 31, 38);
            dtpNgayMuon.Location = new Point(34, 297);
            dtpNgayMuon.Name = "dtpNgayMuon";
            dtpNgayMuon.Size = new Size(200, 27);
            dtpNgayMuon.TabIndex = 13;
            // 
            // lblHanTra
            // 
            lblHanTra.Location = new Point(350, 259);
            lblHanTra.Name = "lblHanTra";
            lblHanTra.Size = new Size(91, 32);
            lblHanTra.StateCommon.ShortText.Color1 = Color.White;
            lblHanTra.StateCommon.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHanTra.TabIndex = 14;
            lblHanTra.Values.Text = "Hạn trả:";
            // 
            // dtpHanTra
            // 
            dtpHanTra.CalendarFont = new Font("Segoe UI", 10F);
            dtpHanTra.Location = new Point(330, 297);
            dtpHanTra.Name = "dtpHanTra";
            dtpHanTra.Size = new Size(200, 27);
            dtpHanTra.TabIndex = 15;
            // 
            // btnTaoPhieuMuon
            // 
            btnTaoPhieuMuon.BorderRadius = 15;
            btnTaoPhieuMuon.FillColor = Color.FromArgb(0, 150, 136);
            btnTaoPhieuMuon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTaoPhieuMuon.ForeColor = Color.White;
            btnTaoPhieuMuon.HoverState.FillColor = Color.FromArgb(0, 120, 110);
            btnTaoPhieuMuon.Location = new Point(569, 219);
            btnTaoPhieuMuon.Name = "btnTaoPhieuMuon";
            btnTaoPhieuMuon.Size = new Size(200, 40);
            btnTaoPhieuMuon.TabIndex = 16;
            btnTaoPhieuMuon.Text = "📥 TẠO PHIẾU MƯỢN";
            btnTaoPhieuMuon.Click += btnTaoPhieuMuon_Click;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 50;
            // 
            // fNewBorrowReceipt
            // 
            BackColor = Color.FromArgb(13, 17, 23);
            ClientSize = new Size(1024, 768);
            Controls.Add(btnTaoPhieuMuon);
            Controls.Add(dtpHanTra);
            Controls.Add(lblHanTra);
            Controls.Add(dtpNgayMuon);
            Controls.Add(lblNgayMuon);
            Controls.Add(btnTimSach);
            Controls.Add(txtTimSach);
            Controls.Add(lblTimSach);
            Controls.Add(lstSach);
            Controls.Add(lblSach);
            Controls.Add(btnTimDocGia);
            Controls.Add(txtTimDocGia);
            Controls.Add(lblTimDocGia);
            Controls.Add(cbDocGia);
            Controls.Add(lblDocGia);
            Controls.Add(lblReceiptCount);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "fNewBorrowReceipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tạo phiếu mượn sách";
            Load += fNewBorrowReceipt_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #region Windows Form Designer generated code
        private KryptonLabel lblTitle;
        private KryptonLabel lblReceiptCount;
        private KryptonLabel lblDocGia;
        private SiticoneComboBox cbDocGia;
        private KryptonLabel lblTimDocGia;
        private KryptonTextBox txtTimDocGia;
        private SiticoneButton btnTimDocGia;
        private KryptonLabel lblSach;
        private ListBox lstSach;
        private KryptonLabel lblTimSach;
        private KryptonTextBox txtTimSach;
        private SiticoneButton btnTimSach;
        private KryptonLabel lblNgayMuon;
        private DateTimePicker dtpNgayMuon;
        private KryptonLabel lblHanTra;
        private DateTimePicker dtpHanTra;
        private SiticoneButton btnTaoPhieuMuon;
        private ToolTip toolTip1;
        #endregion
    }
}