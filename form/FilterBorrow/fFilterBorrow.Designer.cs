namespace QLTV.form.Borrow
{
    partial class mnuLocDocGiaSachTrangThai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Controls
        private System.Windows.Forms.Label lblReader;
        private System.Windows.Forms.ComboBox cbReader;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.ComboBox cbBook;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Panel panelTop;

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
            panelTop = new Panel();
            lblReader = new Label();
            cbReader = new ComboBox();
            lblBook = new Label();
            cbBook = new ComboBox();
            lblStatus = new Label();
            cbStatus = new ComboBox();
            btnFilter = new Button();
            dgvResult = new DataGridView();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.WhiteSmoke;
            panelTop.Controls.Add(lblReader);
            panelTop.Controls.Add(cbReader);
            panelTop.Controls.Add(lblBook);
            panelTop.Controls.Add(cbBook);
            panelTop.Controls.Add(lblStatus);
            panelTop.Controls.Add(cbStatus);
            panelTop.Controls.Add(btnFilter);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(1000, 60);
            panelTop.TabIndex = 1;
            // 
            // lblReader
            // 
            lblReader.AutoSize = true;
            lblReader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblReader.Location = new Point(0, 20);
            lblReader.Name = "lblReader";
            lblReader.Size = new Size(84, 25);
            lblReader.TabIndex = 0;
            lblReader.Text = "Độc giả:";
            // 
            // cbReader
            // 
            cbReader.Font = new Font("Segoe UI", 11F);
            cbReader.Location = new Point(101, 17);
            cbReader.Name = "cbReader";
            cbReader.Size = new Size(226, 33);
            cbReader.TabIndex = 1;
            // 
            // lblBook
            // 
            lblBook.AutoSize = true;
            lblBook.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblBook.Location = new Point(330, 20);
            lblBook.Name = "lblBook";
            lblBook.Size = new Size(58, 25);
            lblBook.TabIndex = 2;
            lblBook.Text = "Sách:";
            // 
            // cbBook
            // 
            cbBook.Font = new Font("Segoe UI", 11F);
            cbBook.Location = new Point(394, 16);
            cbBook.Name = "cbBook";
            cbBook.Size = new Size(211, 33);
            cbBook.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStatus.Location = new Point(620, 20);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(107, 25);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Trạng thái:";
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Font = new Font("Segoe UI", 11F);
            cbStatus.Location = new Point(733, 17);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(140, 33);
            cbStatus.TabIndex = 5;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.MediumSlateBlue;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(893, 14);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(80, 34);
            btnFilter.TabIndex = 6;
            btnFilter.Text = "LỌC";
            btnFilter.UseVisualStyleBackColor = false;
            // 
            // dgvResult
            // 
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResult.BackgroundColor = Color.White;
            dgvResult.ColumnHeadersHeight = 29;
            dgvResult.Dock = DockStyle.Fill;
            dgvResult.Location = new Point(0, 60);
            dgvResult.Name = "dgvResult";
            dgvResult.ReadOnly = true;
            dgvResult.RowHeadersVisible = false;
            dgvResult.RowHeadersWidth = 51;
            dgvResult.Size = new Size(1000, 540);
            dgvResult.TabIndex = 0;
            dgvResult.CellContentClick += dgvResult_CellContentClick;
            // 
            // mnuLocDocGiaSachTrangThai
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1000, 600);
            Controls.Add(dgvResult);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 11F);
            Name = "mnuLocDocGiaSachTrangThai";
            Text = "Lọc Độc Giả/Sách/Trạng Thái";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
        }
        #endregion
    }
}
