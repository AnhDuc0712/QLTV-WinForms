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

            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Size = new Size(776, 40);
            lblTitle.Text = "QUẢN LÝ TÁC GIẢ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 60);
            txtSearch.Size = new Size(250, 27);
            txtSearch.PlaceholderText = "Nhập từ khóa tìm kiếm...";

            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(270, 59);
            btnSearch.Size = new Size(94, 29);
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;

            // 
            // dgvAuthors
            // 
            dgvAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthors.Location = new Point(12, 100);
            dgvAuthors.Name = "dgvAuthors";
            dgvAuthors.RowHeadersWidth = 51;
            dgvAuthors.Size = new Size(776, 280);
            dgvAuthors.TabIndex = 0;
            dgvAuthors.CellContentClick += dgvAuthors_CellContentClick;

            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 400);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;

            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(112, 400);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;

            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(212, 400);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;

            // 
            // btnClose
            // 
            btnClose.Location = new Point(312, 400);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;

            // 
            // fManageAuthor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(dgvAuthors);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnClose);
            Name = "fManageAuthor";
            Text = "Quản lý Tác giả";
            Load += fManageAuthor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
