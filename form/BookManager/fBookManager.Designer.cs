namespace Ngducanh_Quanlysach
{
    partial class fBookManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnFind = new Button();
            dataGridView1 = new DataGridView();
            BookID = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            CategoryID = new DataGridViewTextBoxColumn();
            PublisherID = new DataGridViewTextBoxColumn();
            StockQuantity = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewTextBoxColumn();
            lblPublisher = new Label();
            lblFindTitle = new Label();
            btnAdd = new Button();
            cBPublisher = new ComboBox();
            lblMenu = new Label();
            btnClose = new Button();
            txtBookTitle = new TextBox();
            checkBox1 = new CheckBox();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnFind
            // 
            btnFind.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnFind.Location = new Point(829, 88);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 2;
            btnFind.Text = "Tìm 🔍";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BookID, Title, CategoryID, PublisherID, StockQuantity, Edit, Delete });
            dataGridView1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            dataGridView1.Location = new Point(-6, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(941, 247);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BookID
            // 
            BookID.HeaderText = "BookID";
            BookID.MinimumWidth = 6;
            BookID.Name = "BookID";
            BookID.Width = 125;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.Width = 125;
            // 
            // CategoryID
            // 
            CategoryID.HeaderText = "CategoryID";
            CategoryID.MinimumWidth = 6;
            CategoryID.Name = "CategoryID";
            CategoryID.Width = 125;
            // 
            // PublisherID
            // 
            PublisherID.HeaderText = "PublisherID";
            PublisherID.MinimumWidth = 6;
            PublisherID.Name = "PublisherID";
            PublisherID.Width = 125;
            // 
            // StockQuantity
            // 
            StockQuantity.HeaderText = "StockQuantity";
            StockQuantity.MinimumWidth = 10;
            StockQuantity.Name = "StockQuantity";
            StockQuantity.Width = 140;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Width = 125;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 125;
            // 
            // lblPublisher
            // 
            lblPublisher.AutoSize = true;
            lblPublisher.BackColor = Color.White;
            lblPublisher.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPublisher.Location = new Point(12, 55);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(161, 25);
            lblPublisher.TabIndex = 6;
            lblPublisher.Text = " Nhà Xuất Bản";
            lblPublisher.Click += lblPublisher_Click;
            // 
            // lblFindTitle
            // 
            lblFindTitle.AutoSize = true;
            lblFindTitle.BackColor = Color.White;
            lblFindTitle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFindTitle.Location = new Point(484, 54);
            lblFindTitle.Name = "lblFindTitle";
            lblFindTitle.Size = new Size(105, 25);
            lblFindTitle.TabIndex = 7;
            lblFindTitle.Text = "Tên Sách";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGray;
            btnAdd.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(714, 90);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Thêm ➕";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cBPublisher
            // 
            cBPublisher.BackColor = Color.White;
            cBPublisher.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            cBPublisher.FormattingEnabled = true;
            cBPublisher.Location = new Point(179, 54);
            cBPublisher.Name = "cBPublisher";
            cBPublisher.Size = new Size(218, 31);
            cBPublisher.TabIndex = 14;
            cBPublisher.SelectedIndexChanged += cBPublisher_SelectedIndexChanged;
            // 
            // lblMenu
            // 
            lblMenu.BackColor = Color.White;
            lblMenu.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMenu.ForeColor = Color.Navy;
            lblMenu.Location = new Point(303, 7);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(348, 40);
            lblMenu.TabIndex = 0;
            lblMenu.Text = " 📚 Quản Lý Sách  📚";
            lblMenu.TextAlign = ContentAlignment.MiddleCenter;
            lblMenu.Click += lblMenu_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightGray;
            btnClose.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnClose.Location = new Point(829, 53);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 16;
            btnClose.Text = "Đóng ❌";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtBookTitle
            // 
            txtBookTitle.BackColor = Color.White;
            txtBookTitle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBookTitle.Location = new Point(595, 50);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(228, 34);
            txtBookTitle.TabIndex = 17;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(563, 90);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(145, 29);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Trạng Thái";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightGray;
            btnEdit.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnEdit.Location = new Point(419, 90);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(109, 29);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Sửa🔧";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // fBookManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 371);
            Controls.Add(btnEdit);
            Controls.Add(checkBox1);
            Controls.Add(txtBookTitle);
            Controls.Add(btnClose);
            Controls.Add(lblMenu);
            Controls.Add(cBPublisher);
            Controls.Add(btnAdd);
            Controls.Add(lblFindTitle);
            Controls.Add(lblPublisher);
            Controls.Add(dataGridView1);
            Controls.Add(btnFind);
            Name = "fBookManager";
            Text = "Quản Lý Sách";
            WindowState = FormWindowState.Minimized;
            Load += fBookManager_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnFind;
        private DataGridView dataGridView1;
        private Label lblPublisher;
        private Label lblFindTitle;
        private Button btnFInd;
        private Button btnAdd;
        private ComboBox cBPublisher;
        private Label lblMenu;
        private Button btnClose;
        private DataGridViewTextBoxColumn BookID;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn CategoryID;
        private DataGridViewTextBoxColumn PublisherID;
        private DataGridViewTextBoxColumn StockQuantity;
        private DataGridViewButtonColumn Edit;
        private DataGridViewTextBoxColumn Delete;
        private TextBox txtBookTitle;
        private CheckBox checkBox1;
        private Button btnEdit;
    }
}
