using System;
using System.Drawing;
using System.Windows.Forms;
using QLTV;
using QLTV.Models;
using System.Xml.Linq;

namespace Ngducanh_Quanlysach
{
    partial class fLateBook
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

        private void InitializeComponent()
        {
            btnFind = new Button();
            dataGridView1 = new DataGridView();
            lblFindTitle = new Label();
            lblMenu = new Label();
            btnClose = new Button();
            txtFind = new TextBox();
            lblTotalLateBooks = new Label();
            lblTotalUser = new Label();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            // btnFind
            btnFind.BackColor = Color.FromArgb(42, 46, 69); // #2A2E45 (Xanh đen sâu thẳm)
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnFind.ForeColor = Color.FromArgb(255, 215, 0); // #FFD700 (Vàng ánh kim)
            btnFind.Location = new Point(530, 115);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 34);
            btnFind.TabIndex = 2;
            btnFind.Text = "Tìm 🔍";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            btnFind.MouseEnter += (s, e) => btnFind.BackColor = Color.FromArgb(60, 64, 87); // Tối hơn #2A2E45 khi hover
            btnFind.MouseLeave += (s, e) => btnFind.BackColor = Color.FromArgb(42, 46, 69); // Trở lại #2A2E45 khi không hover

            // dataGridView1
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(232, 236, 239); // #E8ECEF (Xám bạc)
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(42, 46, 69); // #2A2E45 (Xanh đen sâu thẳm)
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 215, 0); // #FFD700 (Vàng ánh kim)
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(247, 249, 251); // #F7F9FB (Trắng xám nhạt)
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(60, 64, 87); // Tối hơn #2A2E45 khi chọn
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 215, 0); // #FFD700 (Vàng ánh kim)
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            dataGridView1.GridColor = Color.FromArgb(232, 236, 239); // #E8ECEF (Xám bạc)
            dataGridView1.Location = new Point(48, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(900, 230);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            // lblFindTitle
            lblFindTitle.AutoSize = true;
            lblFindTitle.BackColor = Color.FromArgb(247, 249, 251); // #F7F9FB (Trắng xám nhạt)
            lblFindTitle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblFindTitle.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            lblFindTitle.Location = new Point(48, 118);
            lblFindTitle.Name = "lblFindTitle";
            lblFindTitle.Size = new Size(113, 25);
            lblFindTitle.TabIndex = 7;
            lblFindTitle.Text = "Tìm kiếm:";

            // lblMenu
            lblMenu.BackColor = Color.FromArgb(247, 249, 251); // #F7F9FB (Trắng xám nhạt)
            lblMenu.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMenu.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            lblMenu.Location = new Point(330, 10);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(400, 40);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "🕒 Sách trễ hạn 🕒";
            lblMenu.TextAlign = ContentAlignment.MiddleCenter;

            // btnClose
            btnClose.BackColor = Color.FromArgb(232, 236, 239); // #E8ECEF (Xám bạc)
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            btnClose.Location = new Point(729, 114);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 34);
            btnClose.TabIndex = 16;
            btnClose.Text = "Đóng ❌";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.MouseEnter += (s, e) => btnClose.BackColor = Color.FromArgb(200, 204, 207); // Tối hơn #E8ECEF khi hover
            btnClose.MouseLeave += (s, e) => btnClose.BackColor = Color.FromArgb(232, 236, 239); // Trở lại #E8ECEF khi không hover
            btnClose.Click += btnClose_Click;

            // txtFind
            txtFind.BackColor = Color.FromArgb(232, 236, 239); // #E8ECEF (Xám bạc)
            txtFind.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            txtFind.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            txtFind.Location = new Point(180, 115);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(330, 34);
            txtFind.TabIndex = 17;

            // lblTotalLateBooks
            lblTotalLateBooks.AutoSize = true;
            lblTotalLateBooks.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalLateBooks.ForeColor = Color.FromArgb(255, 215, 0); // #FFD700 (Vàng ánh kim)
            lblTotalLateBooks.Location = new Point(48, 60);
            lblTotalLateBooks.Name = "lblTotalLateBooks";
            lblTotalLateBooks.Size = new Size(232, 28);
            lblTotalLateBooks.TabIndex = 18;
            lblTotalLateBooks.Text = "Tổng số sách trễ hạn: 0";

            // lblTotalUser
            lblTotalLateBooks.AutoSize = true;
            lblTotalUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalUser.ForeColor = Color.FromArgb(255, 215, 0); // #FFD700 (Vàng ánh kim)
            lblTotalUser.Location = new Point(320, 60);
            lblTotalUser.Name = "lblTotalUser";
            lblTotalUser.Size = new Size(159, 28);
            lblTotalUser.TabIndex = 19;
            lblTotalUser.Text = "Tổng độc giả: 0";

            // fLateBook
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 251); // #F7F9FB (Trắng xám nhạt)
            ClientSize = new Size(1000, 420);
            Controls.Add(lblTotalUser);
            Controls.Add(lblTotalLateBooks);
            Controls.Add(txtFind);
            Controls.Add(btnClose);
            Controls.Add(lblMenu);
            Controls.Add(lblFindTitle);
            Controls.Add(dataGridView1);
            Controls.Add(btnFind);
            MaximizeBox = false;
            Name = "fLateBook";
            Text = "Quản Lý Sách Trễ Hạn";
            Load += fLateBook_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #region Windows Form Designer generated code
        private Button btnFind;
        private DataGridView dataGridView1;
        private Label lblFindTitle;
        private Label lblMenu;
        private Button btnClose;
        private TextBox txtFind;
        private Label lblTotalLateBooks;
        private Label lblTotalUser;
        #endregion
    }
}