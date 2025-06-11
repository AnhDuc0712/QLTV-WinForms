namespace Ngducanh_Quanlysach
{
    partial class fEditBook
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
            btnClose = new Button();
            btnAdd = new Button();
            txtStockQuantity = new TextBox();
            lblStockQuantity = new Label();
            cbPublisher = new ComboBox();
            lblPublisher = new Label();
            cbCategories = new ComboBox();
            lblCategories = new Label();
            txtTitle = new TextBox();
            lblBookTitle = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnClose.Location = new Point(527, 46);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 19;
            btnClose.Text = "Đóng ❌";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(433, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Sửa 🔧";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txtStockQuantity.Location = new Point(396, 46);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(125, 30);
            txtStockQuantity.TabIndex = 17;
            // 
            // lblStockQuantity
            // 
            lblStockQuantity.AutoSize = true;
            lblStockQuantity.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblStockQuantity.Location = new Point(298, 49);
            lblStockQuantity.Name = "lblStockQuantity";
            lblStockQuantity.Size = new Size(92, 23);
            lblStockQuantity.TabIndex = 16;
            lblStockQuantity.Text = "Số Lượng";
            // 
            // cbPublisher
            // 
            cbPublisher.FormattingEnabled = true;
            cbPublisher.Location = new Point(141, 48);
            cbPublisher.Name = "cbPublisher";
            cbPublisher.Size = new Size(151, 28);
            cbPublisher.TabIndex = 15;
            // 
            // lblPublisher
            // 
            lblPublisher.AutoSize = true;
            lblPublisher.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblPublisher.Location = new Point(8, 49);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(127, 23);
            lblPublisher.TabIndex = 14;
            lblPublisher.Text = "Nhà Xuất Bản";
            // 
            // cbCategories
            // 
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(276, 7);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(151, 28);
            cbCategories.TabIndex = 13;
            // 
            // lblCategories
            // 
            lblCategories.AutoSize = true;
            lblCategories.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblCategories.Location = new Point(222, 9);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(48, 23);
            lblCategories.TabIndex = 12;
            lblCategories.Text = "Loại";
            lblCategories.Click += lblCategories_Click;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txtTitle.Location = new Point(91, 5);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 30);
            txtTitle.TabIndex = 11;
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblBookTitle.Location = new Point(8, 8);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(87, 23);
            lblBookTitle.TabIndex = 10;
            lblBookTitle.Text = "Tên Sách";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSave.Location = new Point(527, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 20;
            btnSave.Text = "Lưu 💾";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // fEditBook
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
            Name = "fEditBook";
            Text = "Sửa 🔧";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnAdd;
        private TextBox txtStockQuantity;
        private Label lblStockQuantity;
        private ComboBox cbPublisher;
        private Label lblPublisher;
        private ComboBox cbCategories;
        private Label lblCategories;
        private TextBox txtTitle;
        private Label lblBookTitle;
        private Button btnSave;
    }
}