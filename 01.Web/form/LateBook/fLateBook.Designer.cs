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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnFind = new Button();
            dataGridView1 = new DataGridView();
            lblFindTitle = new Label();
            lblMenu = new Label();
            btnClose = new Button();
            txtFind = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.FromArgb(42, 46, 69);
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnFind.ForeColor = Color.FromArgb(255, 215, 0);
            btnFind.Location = new Point(784, 93);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 34);
            btnFind.TabIndex = 2;
            btnFind.Text = "Tìm 🔍";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(232, 236, 239);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(42, 46, 69);
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 215, 0);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(247, 249, 251);
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(60, 64, 87);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 215, 0);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            dataGridView1.GridColor = Color.FromArgb(232, 236, 239);
            dataGridView1.Location = new Point(130, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(905, 363);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblFindTitle
            // 
            lblFindTitle.AutoSize = true;
            lblFindTitle.BackColor = Color.FromArgb(247, 249, 251);
            lblFindTitle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblFindTitle.ForeColor = Color.FromArgb(26, 26, 26);
            lblFindTitle.Location = new Point(91, 93);
            lblFindTitle.Name = "lblFindTitle";
            lblFindTitle.Size = new Size(113, 25);
            lblFindTitle.TabIndex = 7;
            lblFindTitle.Text = "Tìm kiếm:";
            // 
            // lblMenu
            // 
            lblMenu.BackColor = Color.FromArgb(247, 249, 251);
            lblMenu.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMenu.ForeColor = Color.FromArgb(26, 26, 26);
            lblMenu.Location = new Point(478, 9);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(400, 40);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "🕒 Sách trễ hạn 🕒";
            lblMenu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(232, 236, 239);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(26, 26, 26);
            btnClose.Location = new Point(941, 93);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 34);
            btnClose.TabIndex = 16;
            btnClose.Text = "Đóng ❌";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtFind
            // 
            txtFind.BackColor = Color.FromArgb(232, 236, 239);
            txtFind.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            txtFind.ForeColor = Color.FromArgb(26, 26, 26);
            txtFind.Location = new Point(210, 90);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(330, 34);
            txtFind.TabIndex = 17;
            // 
            // fLateBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 251);
            ClientSize = new Size(1112, 548);
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
        private Label lblTotalUser;
        #endregion
    }
}