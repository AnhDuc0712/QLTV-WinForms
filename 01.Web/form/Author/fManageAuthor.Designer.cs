namespace Ngducanh
{
    partial class fManageAuthor
    {
        private System.Windows.Forms.DataGridView dgvAuthors;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTitle;

        private void InitializeComponent()
        {
            dgvAuthors = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblTitle = new Label();

            ((System.ComponentModel.ISupportInitialize)dgvAuthors).BeginInit();
            SuspendLayout();

            // ========== Title ==========
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.DarkSlateBlue;
            lblTitle.Location = new Point(0, 10);
            lblTitle.Size = new Size(800, 45);
            lblTitle.Text = "📚 QUẢN LÝ TÁC GIẢ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // ========== Search ==========
            txtSearch.Location = new Point(30, 65);
            txtSearch.Size = new Size(300, 30);
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.PlaceholderText = "Nhập từ khóa tìm kiếm...";

            btnSearch.Location = new Point(340, 64);
            btnSearch.Size = new Size(80, 32);
            btnSearch.Text = "🔍 Tìm";
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.BackColor = Color.LightSteelBlue;
            btnSearch.Click += btnSearch_Click;

            // ========== DataGridView ==========
            dgvAuthors.Location = new Point(30, 110);
            dgvAuthors.Size = new Size(740, 260);
            dgvAuthors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAuthors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuthors.EnableHeadersVisualStyles = false;
            dgvAuthors.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumSlateBlue;
            dgvAuthors.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAuthors.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvAuthors.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvAuthors.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgvAuthors.RowHeadersVisible = false;
            dgvAuthors.CellContentClick += dgvAuthors_CellContentClick;

            // ========== Buttons ==========
            int btnTop = 390;
            int btnWidth = 100;

            btnAdd.Text = "➕ Thêm";
            btnAdd.Location = new Point(150, btnTop);
            btnAdd.Size = new Size(btnWidth, 35);
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Click += btnAdd_Click;

            btnEdit.Text = "✏ Sửa";
            btnEdit.Location = new Point(270, btnTop);
            btnEdit.Size = new Size(btnWidth, 35);
            btnEdit.BackColor = Color.LightSkyBlue;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Click += btnEdit_Click;

            btnDelete.Text = "🗑 Xoá";
            btnDelete.Location = new Point(390, btnTop);
            btnDelete.Size = new Size(btnWidth, 35);
            btnDelete.BackColor = Color.Salmon;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Click += btnDelete_Click;

            btnClose.Text = "↩ Đóng";
            btnClose.Location = new Point(510, btnTop);
            btnClose.Size = new Size(btnWidth, 35);
            btnClose.BackColor = Color.Gainsboro;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Click += btnClose_Click;

            // ========== Form ==========
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            BackColor = Color.WhiteSmoke;
            Controls.Add(lblTitle);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(dgvAuthors);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "fManageAuthor";
            Text = "Quản lý Tác giả";
            Load += fManageAuthor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

    }
}
