using System;
using System.Drawing;
using System.Windows.Forms;
using QLTV;              // dùng được LibraryContext
using QLTV.Models;      // nếu có model
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

        #region Windows Form Designer generated code

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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            // btnFind
            btnFind.Font = new System.Drawing.Font("Times New Roman", 12F, FontStyle.Bold);
            btnFind.Location = new Point(530, 115);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 34);
            btnFind.TabIndex = 2;
            btnFind.Text = "Tìm 🔍";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;

            // dataGridView1
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Font = new System.Drawing.Font("Times New Roman", 12F, FontStyle.Bold);
            dataGridView1.GridColor = Color.Gainsboro;
            dataGridView1.Location = new Point(48, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(900, 230);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            // lblFindTitle
            lblFindTitle.AutoSize = true;
            lblFindTitle.BackColor = Color.White;
            lblFindTitle.Font = new System.Drawing.Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblFindTitle.Location = new Point(48, 118);
            lblFindTitle.Name = "lblFindTitle";
            lblFindTitle.Size = new Size(113, 25);
            lblFindTitle.TabIndex = 7;
            lblFindTitle.Text = "Tìm kiếm:";

            // lblMenu
            lblMenu.BackColor = Color.LightGray;
            lblMenu.Font = new System.Drawing.Font("Segoe UI", 18F, FontStyle.Bold);
            lblMenu.ForeColor = Color.Black;
            lblMenu.Location = new Point(330, 10);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(400, 40);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "🕒 Sách trễ hạn 🕒";
            lblMenu.TextAlign = ContentAlignment.MiddleCenter;

            // btnClose
            btnClose.BackColor = Color.LightGray;
            btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, FontStyle.Bold);
            btnClose.Location = new Point(729, 114);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 34);
            btnClose.TabIndex = 16;
            btnClose.Text = "Đóng ❌";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;

            // txtFind
            txtFind.BackColor = Color.White;
            txtFind.Font = new System.Drawing.Font("Times New Roman", 13.8F, FontStyle.Bold);
            txtFind.Location = new Point(180, 115);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(330, 34);
            txtFind.TabIndex = 17;

            // lblTotalLateBooks
            lblTotalLateBooks.AutoSize = true;
            lblTotalLateBooks.Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalLateBooks.Location = new Point(48, 60);
            lblTotalLateBooks.Name = "lblTotalLateBooks";
            lblTotalLateBooks.Size = new Size(232, 28);
            lblTotalLateBooks.TabIndex = 18;
            lblTotalLateBooks.Text = "Tổng số sách trễ hạn: 0";

            // lblTotalUser
            lblTotalUser.AutoSize = true;
            lblTotalUser.Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalUser.Location = new Point(320, 60);
            lblTotalUser.Name = "lblTotalUser";
            lblTotalUser.Size = new Size(159, 28);
            lblTotalUser.TabIndex = 19;
            lblTotalUser.Text = "Tổng độc giả: 0";

            // fLateBook
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
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

        #endregion

        private Button btnFind;
        private DataGridView dataGridView1;
        private Label lblFindTitle;
        private Label lblMenu;
        private Button btnClose;
        private TextBox txtFind;
        private Label lblTotalLateBooks;
        private Label lblTotalUser;
    }
}
