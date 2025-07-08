using System;
using System.Windows.Forms;
using System.Drawing;

namespace QLTV.form.Statistical
{
    partial class fBorrowedBooks : Form
    {
        private Label lblTitle;
        private Label lblTotal;
        private Button btClose;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn BookId;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn BorrowCount;
        private DataGridViewTextBoxColumn Readers;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBorrowedBooks));
            lblTitle = new Label();
            lblTotal = new Label();
            btClose = new Button();
            dataGridView1 = new DataGridView();
            BookId = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            BorrowCount = new DataGridViewTextBoxColumn();
            Readers = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(493, 37);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(482, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📚 Danh sách sách đang được mượn";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.ForeColor = Color.Red;
            lblTotal.Location = new Point(345, 466);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(218, 28);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Tổng số lượt mượn: 0";
            lblTotal.Click += lblTotal_Click;
            // 
            // btClose
            // 
            btClose.BackColor = Color.LightGray;
            btClose.FlatStyle = FlatStyle.Flat;
            btClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btClose.Location = new Point(1034, 466);
            btClose.Name = "btClose";
            btClose.Size = new Size(100, 35);
            btClose.TabIndex = 3;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BookId, Title, BorrowCount, Readers });
            dataGridView1.Location = new Point(354, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(950, 340);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BookId
            // 
            BookId.DataPropertyName = "BookId";
            BookId.HeaderText = "BookId";
            BookId.MinimumWidth = 6;
            BookId.Name = "BookId";
            BookId.ReadOnly = true;
            BookId.Width = 80;
            // 
            // Title
            // 
            Title.DataPropertyName = "Title";
            Title.HeaderText = "Title";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.Width = 320;
            // 
            // BorrowCount
            // 
            BorrowCount.DataPropertyName = "BorrowCount";
            BorrowCount.HeaderText = "Quantity";
            BorrowCount.MinimumWidth = 6;
            BorrowCount.Name = "BorrowCount";
            BorrowCount.ReadOnly = true;
            BorrowCount.Width = 90;
            // 
            // Readers
            // 
            Readers.DataPropertyName = "Readers";
            Readers.HeaderText = "Người mượn";
            Readers.MinimumWidth = 6;
            Readers.Name = "Readers";
            Readers.ReadOnly = true;
            Readers.Width = 300;
            // 
            // fBorrowedBooks
            // 
            BackColor = Color.White;
            ClientSize = new Size(1346, 600);
            Controls.Add(dataGridView1);
            Controls.Add(lblTitle);
            Controls.Add(lblTotal);
            Controls.Add(btClose);
            Font = new Font("Segoe UI", 10F);
            Name = "fBorrowedBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê sách đang được mượn";
            Load += fBorrowedBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
