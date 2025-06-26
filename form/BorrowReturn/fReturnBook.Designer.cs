using Siticone.Desktop.UI.WinForms;
using Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLTV.form.BorrowReturn
{
    partial class fReturnBook
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new KryptonLabel();
            this.lblReceiptCount = new KryptonLabel();
            this.lblUserId = new KryptonLabel();
            this.txtUserId = new SiticoneTextBox();
            this.btnLoad = new SiticoneButton();
            this.dgvBooks = new DataGridView();
            this.lblNgayTra = new KryptonLabel();
            this.dtpNgayTra = new DateTimePicker();
            this.btnXacNhan = new SiticoneButton();
            this.lblFineTotal = new KryptonLabel();
            this.toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.StateCommon.ShortText.Color1 = Color.White;
            this.lblTitle.StateCommon.ShortText.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.Location = new Point(200, 20); // Điều chỉnh vị trí để fit với lblReceiptCount
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(200, 40); // Giảm kích thước để nhường chỗ
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Values.Text = "📤 TRẢ SÁCH";
            this.lblTitle.StateCommon.ShortText.TextH = PaletteRelativeAlign.Center;
            // 
            // lblReceiptCount
            // 
            this.lblReceiptCount.StateCommon.ShortText.Color1 = Color.LightGreen; // Màu nổi bật
            this.lblReceiptCount.StateCommon.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblReceiptCount.Location = new Point(400, 25); // Đặt cạnh lblTitle
            this.lblReceiptCount.Name = "lblReceiptCount";
            this.lblReceiptCount.Size = new Size(200, 30); // Kích thước đủ để hiển thị số
            this.lblReceiptCount.TabIndex = 1;
            this.lblReceiptCount.Values.Text = "Số phiếu chưa trả: 0";
            // 
            // lblUserId
            // 
            this.lblUserId.StateCommon.ShortText.Color1 = Color.White;
            this.lblUserId.Location = new Point(50, 80);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new Size(130, 30);
            this.lblUserId.TabIndex = 2;
            this.lblUserId.Values.Text = "Mã độc giả:";
            // 
            // txtUserId
            // 
            this.txtUserId.BorderRadius = 10;
            this.txtUserId.FillColor = Color.FromArgb(28, 31, 38);
            this.txtUserId.Font = new Font("Segoe UI", 12F);
            this.txtUserId.ForeColor = Color.WhiteSmoke;
            this.txtUserId.Location = new Point(180, 80);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.PlaceholderText = "Nhập mã độc giả";
            this.txtUserId.Size = new Size(200, 30);
            this.txtUserId.TabIndex = 3;
            // 
            // btnLoad
            // 
            this.btnLoad.BorderRadius = 10;
            this.btnLoad.FillColor = Color.FromArgb(41, 121, 255);
            this.btnLoad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnLoad.ForeColor = Color.White;
            this.btnLoad.HoverState.FillColor = Color.FromArgb(30, 100, 200);
            this.btnLoad.Location = new Point(400, 80);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new Size(100, 30);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "🔍 Tải sách";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgvBooks
            // 
            this.dgvBooks.Location = new Point(50, 130);
            this.dgvBooks.Size = new Size(700, 200);
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.BackgroundColor = Color.FromArgb(22, 27, 34);
            this.dgvBooks.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 121, 255);
            this.dgvBooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvBooks.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.dgvBooks.DefaultCellStyle.BackColor = Color.FromArgb(28, 31, 38);
            this.dgvBooks.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
            this.dgvBooks.DefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 100, 200);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersVisible = false;
            this.dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.TabIndex = 5;
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.StateCommon.ShortText.Color1 = Color.White;
            this.lblNgayTra.Location = new Point(50, 350);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new Size(100, 30);
            this.lblNgayTra.TabIndex = 6;
            this.lblNgayTra.Values.Text = "Ngày trả:";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.CalendarFont = new Font("Segoe UI", 10F);
            this.dtpNgayTra.Location = new Point(150, 350);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new Size(200, 30);
            this.dtpNgayTra.TabIndex = 7;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BorderRadius = 15;
            this.btnXacNhan.FillColor = Color.MediumSeaGreen;
            this.btnXacNhan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnXacNhan.ForeColor = Color.White;
            this.btnXacNhan.Location = new Point(400, 350);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new Size(200, 40);
            this.btnXacNhan.TabIndex = 8;
            this.btnXacNhan.Text = "✔ Xác nhận trả sách";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // lblFineTotal
            // 
            this.lblFineTotal.StateCommon.ShortText.Color1 = Color.Orange; // Màu nổi bật cho tiền phạt
            this.lblFineTotal.Location = new Point(50, 400);
            this.lblFineTotal.Name = "lblFineTotal";
            this.lblFineTotal.Size = new Size(300, 30);
            this.lblFineTotal.TabIndex = 9;
            this.lblFineTotal.Values.Text = "💰 Tổng tiền phạt: 0 VNĐ";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 50;
            // 
            // fReturnBook
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(13, 17, 23);
            this.ClientSize = new Size(800, 460);
            this.Controls.Add(this.lblFineTotal);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.dtpNgayTra);
            this.Controls.Add(this.lblNgayTra);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblReceiptCount);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "fReturnBook";
            this.Text = "Trả sách";
            this.Load += new System.EventHandler(this.fReturnBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #region Windows Form Designer generated code
        private KryptonLabel lblTitle;
        private KryptonLabel lblReceiptCount;
        private KryptonLabel lblUserId;
        private SiticoneTextBox txtUserId;
        private SiticoneButton btnLoad;
        private DataGridView dgvBooks;
        private KryptonLabel lblNgayTra;
        private DateTimePicker dtpNgayTra;
        private SiticoneButton btnXacNhan;
        private KryptonLabel lblFineTotal;
        private ToolTip toolTip1;
        #endregion
    }
}