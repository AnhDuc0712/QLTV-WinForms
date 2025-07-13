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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitle = new KryptonLabel();
            lblReceiptCount = new KryptonLabel();
            lblUserId = new KryptonLabel();
            txtUserId = new SiticoneTextBox();
            btnLoad = new SiticoneButton();
            dgvBooks = new DataGridView();
            lblNgayTra = new KryptonLabel();
            dtpNgayTra = new DateTimePicker();
            btnXacNhan = new SiticoneButton();
            lblFineTotal = new KryptonLabel();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(590, 43);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(195, 46);
            lblTitle.StateCommon.ShortText.Color1 = Color.FromArgb(26, 26, 26);
            lblTitle.StateCommon.ShortText.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.StateCommon.ShortText.TextH = PaletteRelativeAlign.Center;
            lblTitle.TabIndex = 0;
            lblTitle.Values.Text = "📤 TRẢ SÁCH";
            // 
            // lblReceiptCount
            // 
            lblReceiptCount.Location = new Point(817, 95);
            lblReceiptCount.Name = "lblReceiptCount";
            lblReceiptCount.Size = new Size(307, 46);
            lblReceiptCount.StateCommon.ShortText.Color1 = Color.FromArgb(255, 215, 0);
            lblReceiptCount.StateCommon.ShortText.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblReceiptCount.TabIndex = 1;
            lblReceiptCount.Values.Text = "Số phiếu chưa trả: 0";
            // 
            // lblUserId
            // 
            lblUserId.LabelStyle = LabelStyle.BoldPanel;
            lblUserId.Location = new Point(81, 101);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(146, 36);
            lblUserId.StateCommon.ShortText.Color1 = Color.FromArgb(26, 26, 26);
            lblUserId.StateCommon.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblUserId.TabIndex = 2;
            lblUserId.Values.Text = "Mã độc giả:";
            // 
            // txtUserId
            // 
            txtUserId.BorderRadius = 10;
            txtUserId.DefaultText = "";
            txtUserId.FillColor = Color.FromArgb(232, 236, 239);
            txtUserId.Font = new Font("Segoe UI", 14F);
            txtUserId.ForeColor = Color.FromArgb(26, 26, 26);
            txtUserId.Location = new Point(233, 107);
            txtUserId.Margin = new Padding(3, 4, 3, 4);
            txtUserId.Name = "txtUserId";
            txtUserId.PasswordChar = '\0';
            txtUserId.PlaceholderText = "Nhập mã độc giả";
            txtUserId.SelectedText = "";
            txtUserId.Size = new Size(208, 30);
            txtUserId.TabIndex = 3;
            // 
            // btnLoad
            // 
            btnLoad.BorderRadius = 10;
            btnLoad.FillColor = Color.FromArgb(42, 46, 69);
            btnLoad.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnLoad.ForeColor = Color.FromArgb(255, 215, 0);
            btnLoad.HoverState.FillColor = Color.FromArgb(60, 64, 87);
            btnLoad.Location = new Point(1156, 107);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(98, 40);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "🔍 Tải sách";
            btnLoad.Click += btnLoad_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.BackgroundColor = Color.FromArgb(232, 236, 239);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(42, 46, 69);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 215, 0);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBooks.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(247, 249, 251);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(60, 64, 87);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 215, 0);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBooks.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBooks.Location = new Point(50, 172);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(1232, 357);
            dgvBooks.TabIndex = 5;
       
            // 
            // lblNgayTra
            // 
            lblNgayTra.Location = new Point(571, 535);
            lblNgayTra.Name = "lblNgayTra";
            lblNgayTra.Size = new Size(74, 24);
            lblNgayTra.StateCommon.ShortText.Color1 = Color.FromArgb(26, 26, 26);
            lblNgayTra.TabIndex = 6;
            lblNgayTra.Values.Text = "Ngày trả:";
            // 
            // dtpNgayTra
            // 
            dtpNgayTra.CalendarFont = new Font("Segoe UI", 10F);
            dtpNgayTra.CalendarMonthBackground = Color.FromArgb(232, 236, 239);
            dtpNgayTra.Location = new Point(651, 535);
            dtpNgayTra.Name = "dtpNgayTra";
            dtpNgayTra.Size = new Size(300, 27);
            dtpNgayTra.TabIndex = 7;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BorderRadius = 15;
            btnXacNhan.FillColor = Color.FromArgb(42, 46, 69);
            btnXacNhan.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnXacNhan.ForeColor = Color.FromArgb(255, 215, 0);
            btnXacNhan.HoverState.FillColor = Color.FromArgb(60, 64, 87);
            btnXacNhan.Location = new Point(50, 552);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(332, 40);
            btnXacNhan.TabIndex = 8;
            btnXacNhan.Text = "✔ Xác nhận trả sách";
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // lblFineTotal
            // 
            lblFineTotal.Location = new Point(1030, 552);
            lblFineTotal.Name = "lblFineTotal";
            lblFineTotal.Size = new Size(178, 24);
            lblFineTotal.StateCommon.ShortText.Color1 = Color.FromArgb(255, 215, 0);
            lblFineTotal.TabIndex = 9;
            lblFineTotal.Values.Text = "💰 Tổng tiền phạt: 0 VNĐ";
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 50;
            // 
            // fReturnBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 251);
            ClientSize = new Size(1371, 608);
            Controls.Add(lblFineTotal);
            Controls.Add(btnXacNhan);
            Controls.Add(dtpNgayTra);
            Controls.Add(lblNgayTra);
            Controls.Add(dgvBooks);
            Controls.Add(btnLoad);
            Controls.Add(txtUserId);
            Controls.Add(lblUserId);
            Controls.Add(lblReceiptCount);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "fReturnBook";
            Text = "Trả sách";
            Load += fReturnBook_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
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