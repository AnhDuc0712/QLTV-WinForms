namespace Ngducanh_Quanlysach
{
    partial class fBookManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnFind = new Button();
            dataGridView1 = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            lblFindTitle = new Label();
            btnAdd = new Button();
            lblMenu = new Label();
            btnClose = new Button();
            txtBookTitle = new TextBox();
            panelEdit = new Panel();
            cBEditBookID = new ComboBox();
            cBEditStockQuantity = new ComboBox();
            cBEditPublisherID = new ComboBox();
            lblEditBookID = new Label();
            lblEditTitle = new Label();
            cBEditCategories = new ComboBox();
            btnEditClose = new Button();
            btnSave = new Button();
            lblStockQuantity = new Label();
            lblEditCategories = new Label();
            lblEditPiblisher = new Label();
            txtTitle = new TextBox();
            lblBookTitle = new Label();
            panelAdd = new Panel();
            cBAddBookID = new ComboBox();
            cBAddStockQuantity = new ComboBox();
            cBAddCategories = new ComboBox();
            cBAddPublisherID = new ComboBox();
            lblAddBookID = new Label();
            lblAddTitle = new Label();
            btnAddClose = new Button();
            btnAddSave = new Button();
            label5 = new Label();
            lblAddCategories = new Label();
            lblAddPublisher = new Label();
            txtAddBookTitle = new TextBox();
            lblAddBookTitle = new Label();
            toolTip1 = new ToolTip(components);
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelEdit.SuspendLayout();
            panelAdd.SuspendLayout();
            SuspendLayout();
            // 
            // btnFind
            // 
            btnFind.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnFind.Location = new Point(376, 155);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 2;
            btnFind.Text = "Tìm 🔍";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            dataGridView1.GridColor = Color.Gainsboro;
            dataGridView1.Location = new Point(286, 211);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(793, 247);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Edit
            // 
            Edit.HeaderText = "Sửa";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Text = "Sửa";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 49;
            // 
            // Delete
            // 
            Delete.HeaderText = "Xóa";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Text = "Xóa";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 49;
            // 
            // lblFindTitle
            // 
            lblFindTitle.AutoSize = true;
            lblFindTitle.BackColor = Color.White;
            lblFindTitle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFindTitle.Location = new Point(286, 120);
            lblFindTitle.Name = "lblFindTitle";
            lblFindTitle.Size = new Size(105, 25);
            lblFindTitle.TabIndex = 7;
            lblFindTitle.Text = "Tên Sách";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGray;
            btnAdd.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(657, 94);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Thêm ➕";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblMenu
            // 
            lblMenu.BackColor = Color.LightGray;
            lblMenu.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMenu.ForeColor = Color.Black;
            lblMenu.Location = new Point(439, 9);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(348, 40);
            lblMenu.TabIndex = 0;
            lblMenu.Text = " 📚 Quản Lý Sách  📚";
            lblMenu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightGray;
            btnClose.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnClose.Location = new Point(657, 131);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(109, 29);
            btnClose.TabIndex = 16;
            btnClose.Text = "Đóng ❌";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtBookTitle
            // 
            txtBookTitle.BackColor = Color.White;
            txtBookTitle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBookTitle.Location = new Point(413, 117);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(228, 34);
            txtBookTitle.TabIndex = 17;
            // 
            // panelEdit
            // 
            panelEdit.Controls.Add(cBEditBookID);
            panelEdit.Controls.Add(cBEditStockQuantity);
            panelEdit.Controls.Add(cBEditPublisherID);
            panelEdit.Controls.Add(lblEditBookID);
            panelEdit.Controls.Add(lblEditTitle);
            panelEdit.Controls.Add(cBEditCategories);
            panelEdit.Controls.Add(btnEditClose);
            panelEdit.Controls.Add(btnSave);
            panelEdit.Controls.Add(lblStockQuantity);
            panelEdit.Controls.Add(lblEditCategories);
            panelEdit.Controls.Add(lblEditPiblisher);
            panelEdit.Controls.Add(txtTitle);
            panelEdit.Controls.Add(lblBookTitle);
            panelEdit.Location = new Point(4, 12);
            panelEdit.Name = "panelEdit";
            panelEdit.Size = new Size(282, 446);
            panelEdit.TabIndex = 21;
            panelEdit.Tag = "";
            panelEdit.Visible = false;
            // 
            // cBEditBookID
            // 
            cBEditBookID.FormattingEnabled = true;
            cBEditBookID.Location = new Point(16, 320);
            cBEditBookID.Name = "cBEditBookID";
            cBEditBookID.Size = new Size(232, 28);
            cBEditBookID.TabIndex = 32;
            // 
            // cBEditStockQuantity
            // 
            cBEditStockQuantity.FormattingEnabled = true;
            cBEditStockQuantity.Location = new Point(16, 263);
            cBEditStockQuantity.Name = "cBEditStockQuantity";
            cBEditStockQuantity.Size = new Size(232, 28);
            cBEditStockQuantity.TabIndex = 31;
            // 
            // cBEditPublisherID
            // 
            cBEditPublisherID.FormattingEnabled = true;
            cBEditPublisherID.Location = new Point(11, 145);
            cBEditPublisherID.Name = "cBEditPublisherID";
            cBEditPublisherID.Size = new Size(237, 28);
            cBEditPublisherID.TabIndex = 30;
            // 
            // lblEditBookID
            // 
            lblEditBookID.AutoSize = true;
            lblEditBookID.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblEditBookID.Location = new Point(11, 294);
            lblEditBookID.Name = "lblEditBookID";
            lblEditBookID.Size = new Size(83, 23);
            lblEditBookID.TabIndex = 28;
            lblEditBookID.Text = "Mã Sách";
            // 
            // lblEditTitle
            // 
            lblEditTitle.BackColor = Color.LightGray;
            lblEditTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblEditTitle.ForeColor = Color.Black;
            lblEditTitle.Location = new Point(3, 16);
            lblEditTitle.Name = "lblEditTitle";
            lblEditTitle.Size = new Size(276, 56);
            lblEditTitle.TabIndex = 26;
            lblEditTitle.Text = "🔧Sửa Sách🔧";
            lblEditTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cBEditCategories
            // 
            cBEditCategories.FormattingEnabled = true;
            cBEditCategories.Location = new Point(11, 204);
            cBEditCategories.Name = "cBEditCategories";
            cBEditCategories.Size = new Size(237, 28);
            cBEditCategories.TabIndex = 25;
            // 
            // btnEditClose
            // 
            btnEditClose.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnEditClose.Location = new Point(185, 411);
            btnEditClose.Name = "btnEditClose";
            btnEditClose.Size = new Size(94, 29);
            btnEditClose.TabIndex = 24;
            btnEditClose.Text = "Đóng ❌";
            btnEditClose.UseVisualStyleBackColor = true;
            btnEditClose.Click += btnEditClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSave.Location = new Point(0, 411);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 23;
            btnSave.Text = "Lưu 💾";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblStockQuantity
            // 
            lblStockQuantity.AutoSize = true;
            lblStockQuantity.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblStockQuantity.Location = new Point(11, 235);
            lblStockQuantity.Name = "lblStockQuantity";
            lblStockQuantity.Size = new Size(92, 23);
            lblStockQuantity.TabIndex = 19;
            lblStockQuantity.Text = "Số Lượng";
            // 
            // lblEditCategories
            // 
            lblEditCategories.AutoSize = true;
            lblEditCategories.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblEditCategories.Location = new Point(11, 178);
            lblEditCategories.Name = "lblEditCategories";
            lblEditCategories.Size = new Size(48, 23);
            lblEditCategories.TabIndex = 17;
            lblEditCategories.Text = "Loại";
            // 
            // lblEditPiblisher
            // 
            lblEditPiblisher.AutoSize = true;
            lblEditPiblisher.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblEditPiblisher.Location = new Point(11, 119);
            lblEditPiblisher.Name = "lblEditPiblisher";
            lblEditPiblisher.Size = new Size(127, 23);
            lblEditPiblisher.TabIndex = 15;
            lblEditPiblisher.Text = "Nhà Xuất Bản";
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txtTitle.Location = new Point(92, 81);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(187, 30);
            txtTitle.TabIndex = 12;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblBookTitle.Location = new Point(3, 82);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(87, 23);
            lblBookTitle.TabIndex = 11;
            lblBookTitle.Text = "Tên Sách";
            // 
            // panelAdd
            // 
            panelAdd.Controls.Add(cBAddBookID);
            panelAdd.Controls.Add(cBAddStockQuantity);
            panelAdd.Controls.Add(cBAddCategories);
            panelAdd.Controls.Add(cBAddPublisherID);
            panelAdd.Controls.Add(lblAddBookID);
            panelAdd.Controls.Add(lblAddTitle);
            panelAdd.Controls.Add(btnAddClose);
            panelAdd.Controls.Add(btnAddSave);
            panelAdd.Controls.Add(label5);
            panelAdd.Controls.Add(lblAddCategories);
            panelAdd.Controls.Add(lblAddPublisher);
            panelAdd.Controls.Add(txtAddBookTitle);
            panelAdd.Controls.Add(lblAddBookTitle);
            panelAdd.Location = new Point(4, 458);
            panelAdd.Name = "panelAdd";
            panelAdd.Size = new Size(1075, 189);
            panelAdd.TabIndex = 22;
            panelAdd.Visible = false;
            // 
            // cBAddBookID
            // 
            cBAddBookID.FormattingEnabled = true;
            cBAddBookID.Location = new Point(400, 131);
            cBAddBookID.Name = "cBAddBookID";
            cBAddBookID.Size = new Size(237, 28);
            cBAddBookID.TabIndex = 42;
            // 
            // cBAddStockQuantity
            // 
            cBAddStockQuantity.FormattingEnabled = true;
            cBAddStockQuantity.Location = new Point(835, 131);
            cBAddStockQuantity.Name = "cBAddStockQuantity";
            cBAddStockQuantity.Size = new Size(154, 28);
            cBAddStockQuantity.TabIndex = 41;
            // 
            // cBAddCategories
            // 
            cBAddCategories.FormattingEnabled = true;
            cBAddCategories.Location = new Point(191, 73);
            cBAddCategories.Name = "cBAddCategories";
            cBAddCategories.Size = new Size(237, 28);
            cBAddCategories.TabIndex = 40;
            // 
            // cBAddPublisherID
            // 
            cBAddPublisherID.FormattingEnabled = true;
            cBAddPublisherID.Location = new Point(546, 15);
            cBAddPublisherID.Name = "cBAddPublisherID";
            cBAddPublisherID.Size = new Size(237, 28);
            cBAddPublisherID.TabIndex = 39;
            // 
            // lblAddBookID
            // 
            lblAddBookID.AutoSize = true;
            lblAddBookID.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblAddBookID.Location = new Point(311, 136);
            lblAddBookID.Name = "lblAddBookID";
            lblAddBookID.Size = new Size(83, 23);
            lblAddBookID.TabIndex = 38;
            lblAddBookID.Text = "Mã Sách";
            // 
            // lblAddTitle
            // 
            lblAddTitle.BackColor = Color.LightGray;
            lblAddTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblAddTitle.ForeColor = Color.Black;
            lblAddTitle.Location = new Point(790, 47);
            lblAddTitle.Name = "lblAddTitle";
            lblAddTitle.Size = new Size(282, 62);
            lblAddTitle.TabIndex = 35;
            lblAddTitle.Text = "➕ Thêm Sách ➕";
            lblAddTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAddClose
            // 
            btnAddClose.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnAddClose.Location = new Point(13, 113);
            btnAddClose.Name = "btnAddClose";
            btnAddClose.Size = new Size(94, 29);
            btnAddClose.TabIndex = 26;
            btnAddClose.Text = "Đóng ❌";
            btnAddClose.UseVisualStyleBackColor = true;
            btnAddClose.Click += btnAddClose_Click;
            // 
            // btnAddSave
            // 
            btnAddSave.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnAddSave.Location = new Point(8, 148);
            btnAddSave.Name = "btnAddSave";
            btnAddSave.Size = new Size(94, 29);
            btnAddSave.TabIndex = 33;
            btnAddSave.Text = "Lưu 💾";
            btnAddSave.UseVisualStyleBackColor = true;
            btnAddSave.Click += btAddSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.Location = new Point(737, 131);
            label5.Name = "label5";
            label5.Size = new Size(92, 23);
            label5.TabIndex = 31;
            label5.Text = "Số Lượng";
            // 
            // lblAddCategories
            // 
            lblAddCategories.AutoSize = true;
            lblAddCategories.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblAddCategories.Location = new Point(137, 73);
            lblAddCategories.Name = "lblAddCategories";
            lblAddCategories.Size = new Size(48, 23);
            lblAddCategories.TabIndex = 30;
            lblAddCategories.Text = "Loại";
            // 
            // lblAddPublisher
            // 
            lblAddPublisher.AutoSize = true;
            lblAddPublisher.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblAddPublisher.Location = new Point(400, 20);
            lblAddPublisher.Name = "lblAddPublisher";
            lblAddPublisher.Size = new Size(127, 23);
            lblAddPublisher.TabIndex = 28;
            lblAddPublisher.Text = "Nhà Xuất Bản";
            // 
            // txtAddBookTitle
            // 
            txtAddBookTitle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txtAddBookTitle.Location = new Point(92, 13);
            txtAddBookTitle.Name = "txtAddBookTitle";
            txtAddBookTitle.Size = new Size(187, 30);
            txtAddBookTitle.TabIndex = 27;
            // 
            // lblAddBookTitle
            // 
            lblAddBookTitle.AutoSize = true;
            lblAddBookTitle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblAddBookTitle.Location = new Point(8, 13);
            lblAddBookTitle.Name = "lblAddBookTitle";
            lblAddBookTitle.Size = new Size(87, 23);
            lblAddBookTitle.TabIndex = 26;
            lblAddBookTitle.Text = "Tên Sách";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(794, 12);
            label1.Name = "label1";
            label1.Size = new Size(39, 28);
            label1.TabIndex = 23;
            label1.Text = "Do";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(794, 56);
            label2.Name = "label2";
            label2.Size = new Size(54, 28);
            label2.TabIndex = 24;
            label2.Text = "Tình";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(928, 95);
            label3.Name = "label3";
            label3.Size = new Size(53, 28);
            label3.TabIndex = 25;
            label3.Text = "Sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(795, 144);
            label4.Name = "label4";
            label4.Size = new Size(24, 28);
            label4.TabIndex = 26;
            label4.Text = "Ý";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(928, 12);
            label6.Name = "label6";
            label6.Size = new Size(39, 28);
            label6.TabIndex = 27;
            label6.Text = "Do";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(928, 56);
            label7.Name = "label7";
            label7.Size = new Size(24, 28);
            label7.TabIndex = 28;
            label7.Text = "Ý";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(795, 95);
            label8.Name = "label8";
            label8.Size = new Size(53, 28);
            label8.TabIndex = 29;
            label8.Text = "Sinh";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(928, 144);
            label9.Name = "label9";
            label9.Size = new Size(49, 28);
            label9.TabIndex = 30;
            label9.Text = "Chữ";
            // 
            // fBookManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1083, 647);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelAdd);
            Controls.Add(panelEdit);
            Controls.Add(txtBookTitle);
            Controls.Add(btnClose);
            Controls.Add(lblMenu);
            Controls.Add(btnAdd);
            Controls.Add(lblFindTitle);
            Controls.Add(dataGridView1);
            Controls.Add(btnFind);
            MaximizeBox = false;
            Name = "fBookManager";
            Text = "Quản Lý Sách";
            TransparencyKey = Color.Pink;
            Load += fBookManager_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelEdit.ResumeLayout(false);
            panelEdit.PerformLayout();
            panelAdd.ResumeLayout(false);
            panelAdd.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnFind;
        private DataGridView dataGridView1;
        private Label lblFindTitle;
        private Button btnAdd;
        private Label lblMenu;
        private Button btnClose;
        private TextBox txtBookTitle;
        private Panel panelEdit;
        private Label lblBookTitle;
        private TextBox txtTitle;
        private Label lblEditPiblisher;
        private Label lblEditCategories;
        private Label lblStockQuantity;
        private Button btnSave;
        private Button btnEditClose;
        private ComboBox cBEditCategories;
        private Panel panelAdd;
        private Button btnAddClose;
        private Button btnAddSave;
        private Label label5;
        private Label lblAddCategories;
        private Label lblAddPublisher;
        private TextBox txtAddBookTitle;
        private Label lblAddBookTitle;
        private Label lblEditTitle;
        private Label lblAddTitle;
        private Label lblEditBookID;
        private ToolTip toolTip1;
        private Label lblAddBookID;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private ComboBox cBEditBookID;
        private ComboBox cBEditStockQuantity;
        private ComboBox cBEditPublisherID;
        private ComboBox cBAddBookID;
        private ComboBox cBAddStockQuantity;
        private ComboBox cBAddCategories;
        private ComboBox cBAddPublisherID;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}