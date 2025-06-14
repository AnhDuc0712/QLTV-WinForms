namespace QLTV.form.BorrowReturn
{
    partial class fReturnBook
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblUserId;
        private TextBox txtUserId;
        private Button btnLoad;
        private DataGridView dgvBooks;
        private Label lblNgayTra;
        private DateTimePicker dtpNgayTra;
        private Button btnXacNhan;
        private Label lblFineTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblUserId = new Label();
            this.txtUserId = new TextBox();
            this.btnLoad = new Button();
            this.dgvBooks = new DataGridView();
            this.lblNgayTra = new Label();
            this.dtpNgayTra = new DateTimePicker();
            this.btnXacNhan = new Button();
            this.lblFineTotal = new Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();

            // Title
            this.lblTitle.Text = "📤 TRẢ SÁCH";
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.Location = new Point(280, 20);
            this.lblTitle.Size = new Size(300, 40);
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // Mã độc giả
            this.lblUserId.Text = "Mã độc giả:";
            this.lblUserId.Location = new Point(50, 80);
            this.lblUserId.Size = new Size(130, 30);

            this.txtUserId.Location = new Point(180, 80);
            this.txtUserId.Size = new Size(200, 30);

            this.btnLoad.Text = "🔍 Tải sách";
            this.btnLoad.Location = new Point(400, 80);
            this.btnLoad.Size = new Size(100, 30);
            this.btnLoad.Click += new EventHandler(this.btnLoad_Click);

            // DataGridView
            this.dgvBooks.Location = new Point(50, 130);
            this.dgvBooks.Size = new Size(700, 200);
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Ngày trả
            this.lblNgayTra.Text = "Ngày trả:";
            this.lblNgayTra.Location = new Point(50, 350);
            this.lblNgayTra.Size = new Size(100, 30);

            this.dtpNgayTra.Location = new Point(150, 350);
            this.dtpNgayTra.Size = new Size(200, 30);

            // Xác nhận trả sách
            this.btnXacNhan.Text = "✔ Xác nhận trả sách";
            this.btnXacNhan.BackColor = Color.MediumSeaGreen;
            this.btnXacNhan.ForeColor = Color.White;
            this.btnXacNhan.FlatStyle = FlatStyle.Flat;
            this.btnXacNhan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnXacNhan.Location = new Point(400, 350);
            this.btnXacNhan.Size = new Size(200, 40);
            this.btnXacNhan.Click += new EventHandler(this.btnXacNhan_Click);

            // Form
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 460);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.lblNgayTra);
            this.Controls.Add(this.dtpNgayTra);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.lblFineTotal);
            this.Name = "fReturnBook";
            this.Text = "Trả sách";
            this.Load += new EventHandler(this.fReturnBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
