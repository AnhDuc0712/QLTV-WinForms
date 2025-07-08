using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLTV.form.Reader
{
    partial class fManageReader
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblName = new Label();
            txtName = new TextBox();
            btFind = new Button();
            btNew = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold); // Chuyển font sang Segoe UI
            lblName.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            lblName.Location = new Point(-3, 25);
            lblName.Name = "lblName";
            lblName.Size = new Size(132, 24);
            lblName.TabIndex = 8;
            lblName.Text = "Tên độc giả:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(232, 236, 239); // #E8ECEF (Xám bạc)
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            txtName.Location = new Point(135, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(210, 32);
            txtName.TabIndex = 7;
            // 
            // btFind
            // 
            btFind.BackColor = Color.FromArgb(42, 46, 69); // #2A2E45 (Xanh đen sâu thẳm)
            btFind.FlatStyle = FlatStyle.Flat;
            btFind.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btFind.ForeColor = Color.FromArgb(255, 215, 0); // #FFD700 (Vàng ánh kim)
            btFind.Location = new Point(365, 21);
            btFind.Name = "btFind";
            btFind.Size = new Size(103, 41);
            btFind.TabIndex = 6;
            btFind.Text = "Tìm 🔍";
            btFind.UseVisualStyleBackColor = false;
            btFind.Click += btFind_Click;
            btFind.MouseEnter += (s, e) => btFind.BackColor = Color.FromArgb(60, 64, 87); // Tối hơn #2A2E45 khi hover
            btFind.MouseLeave += (s, e) => btFind.BackColor = Color.FromArgb(42, 46, 69); // Trở lại #2A2E45
            // 
            // btNew
            // 
            btNew.BackColor = Color.FromArgb(42, 46, 69); // #2A2E45 (Xanh đen sâu thẳm)
            btNew.FlatStyle = FlatStyle.Flat;
            btNew.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btNew.ForeColor = Color.FromArgb(255, 215, 0); // #FFD700 (Vàng ánh kim)
            btNew.Location = new Point(498, 21);
            btNew.Name = "btNew";
            btNew.Size = new Size(114, 41);
            btNew.TabIndex = 5;
            btNew.Text = "Thêm mới ➕";
            btNew.UseVisualStyleBackColor = false;
            btNew.Click += btNew_Click;
            btNew.MouseEnter += (s, e) => btNew.BackColor = Color.FromArgb(60, 64, 87); // Tối hơn #2A2E45 khi hover
            btNew.MouseLeave += (s, e) => btNew.BackColor = Color.FromArgb(42, 46, 69); // Trở lại #2A2E45
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(232, 236, 239); // #E8ECEF (Xám bạc)
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(42, 46, 69); // #2A2E45 (Xanh đen sâu thẳm)
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 215, 0); // #FFD700 (Vàng ánh kim)
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 38;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(247, 249, 251); // #F7F9FB (Trắng xám nhạt)
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(60, 64, 87); // Tối hơn #2A2E45 khi chọn
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 215, 0); // #FFD700 (Vàng ánh kim)
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(35, 70);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 32;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(900, 430);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold); // Chuyển font sang Segoe UI
            label1.ForeColor = Color.FromArgb(255, 215, 0); // #FFD700 (Vàng ánh kim)
            label1.Location = new Point(12, 507);
            label1.Name = "label1";
            label1.Size = new Size(0, 24);
            label1.TabIndex = 9;
            // 
            // fManageReader
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 251); // #F7F9FB (Trắng xám nhạt)
            ClientSize = new Size(980, 540);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btNew);
            Controls.Add(btFind);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Font = new Font("Segoe UI", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "fManageReader";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý độc giả";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}