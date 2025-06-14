namespace Ngducanh
{
    partial class fNewAuthor
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblName = new Label();
            this.txtName = new TextBox();
            this.btnSave = new Button();
            this.btnCancel = new Button();

            SuspendLayout();

            // ===== Label =====
            this.lblName.AutoSize = true;
            this.lblName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblName.Location = new Point(30, 35);
            this.lblName.Text = "Tên tác giả:";

            // ===== TextBox =====
            this.txtName.Font = new Font("Segoe UI", 10F);
            this.txtName.Location = new Point(130, 32);
            this.txtName.Size = new Size(300, 30);
            this.txtName.PlaceholderText = "Nhập tên tác giả...";

            // ===== Button Save =====
            this.btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSave.Text = "💾 Lưu";
            this.btnSave.BackColor = Color.MediumSeaGreen;
            this.btnSave.ForeColor = Color.White;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.Location = new Point(130, 90);
            this.btnSave.Size = new Size(100, 36);
            this.btnSave.Click += new EventHandler(this.btnSave_Click);

            // ===== Button Cancel =====
            this.btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCancel.Text = "✖ Huỷ";
            this.btnCancel.BackColor = Color.Gainsboro;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.Location = new Point(240, 90);
            this.btnCancel.Size = new Size(100, 36);
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // ===== Form =====
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(460, 160);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Name = "fNewAuthor";
            this.Text = "Thêm tác giả";
            this.Load += new EventHandler(this.fNewAuthor_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
