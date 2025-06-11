namespace Ngducanh_Quanlysach
{
    partial class fNewBook
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
            lblBookTitle = new Label();
            txtTitle = new TextBox();
            lblCategories = new Label();
            cbCategories = new ComboBox();
            lblPublisher = new Label();
            cbPublisher = new ComboBox();
            lblStockQuantity = new Label();
            txtStockQuantity = new TextBox();
            btnAdd = new Button();
            btnClose = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblBookTitle.Location = new Point(12, 9);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(87, 23);
            lblBookTitle.TabIndex = 0;
            lblBookTitle.Text = "Tên Sách";
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txtTitle.Location = new Point(95, 6);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 30);
            txtTitle.TabIndex = 1;
            // 
            // lblCategories
            // 
            lblCategories.AutoSize = true;
            lblCategories.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblCategories.Location = new Point(226, 9);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(48, 23);
            lblCategories.TabIndex = 2;
            lblCategories.Text = "Loại";
            // 
            // cbCategories
            // 
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(280, 8);
            cbCategories.Margin = new Padding(3, 4, 3, 4);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(151, 28);
            cbCategories.TabIndex = 3;
            // 
            // lblPublisher
            // 
            lblPublisher.AutoSize = true;
            lblPublisher.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblPublisher.Location = new Point(12, 49);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(127, 23);
            lblPublisher.TabIndex = 4;
            lblPublisher.Text = "Nhà Xuất Bản";
            // 
            // cbPublisher
            // 
            cbPublisher.FormattingEnabled = true;
            cbPublisher.Location = new Point(145, 49);
            cbPublisher.Margin = new Padding(3, 4, 3, 4);
            cbPublisher.Name = "cbPublisher";
            cbPublisher.Size = new Size(151, 28);
            cbPublisher.TabIndex = 5;
            // 
            // lblStockQuantity
            // 
            lblStockQuantity.AutoSize = true;
            lblStockQuantity.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblStockQuantity.Location = new Point(302, 49);
            lblStockQuantity.Name = "lblStockQuantity";
            lblStockQuantity.Size = new Size(92, 23);
            lblStockQuantity.TabIndex = 6;
            lblStockQuantity.Text = "Số Lượng";
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txtStockQuantity.Location = new Point(400, 47);
            txtStockQuantity.Margin = new Padding(3, 4, 3, 4);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(125, 30);
            txtStockQuantity.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(437, 6);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm ➕";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnClose.Location = new Point(531, 47);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 9;
            btnClose.Text = "Đóng ❌";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSave.Location = new Point(537, 6);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 21;
            btnSave.Text = "Lưu 💾";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // fNewBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 78);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(txtStockQuantity);
            Controls.Add(lblStockQuantity);
            Controls.Add(cbPublisher);
            Controls.Add(lblPublisher);
            Controls.Add(cbCategories);
            Controls.Add(lblCategories);
            Controls.Add(txtTitle);
            Controls.Add(lblBookTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fNewBook";
            Text = "Thêm Sách ➕";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBookTitle;
        private TextBox txtTitle;
        private Label lblCategories;
        private ComboBox cbCategories;
        private Label lblPublisher;
        private ComboBox cbPublisher;
        private Label lblStockQuantity;
        private TextBox txtStockQuantity;
        private Button btnAdd;
        private Button btnClose;
        private Button btnSave;
    }
}