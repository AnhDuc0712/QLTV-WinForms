namespace Ngducanh
{
    partial class fManageCategory
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgv = new DataGridView();
            btnAdd = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(321, 118);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập tên, Mã thể loại...";
            txtSearch.Size = new Size(550, 30);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(934, 117);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 30);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersHeight = 29;
            dgv.Location = new Point(238, 170);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(832, 323);
            dgv.TabIndex = 2;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.Location = new Point(934, 578);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 56);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(520, 33);
            label1.Name = "label1";
            label1.Size = new Size(329, 46);
            label1.TabIndex = 4;
            label1.Text = "Quản lý thể loại sách";
            // 
            // fManageCategory
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1332, 646);
            Controls.Add(btnAdd);
            Controls.Add(dgv);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F);
            Name = "fManageCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ THỂ LOẠI SÁCH";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
