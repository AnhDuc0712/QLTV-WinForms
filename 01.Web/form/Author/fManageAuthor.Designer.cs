using Siticone.Desktop.UI.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ngducanh
{
    partial class fManageAuthor
    {
        private System.ComponentModel.IContainer components = null;
        private SiticoneShadowForm shadowForm;
        private SiticoneElipse siticoneElipse1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            shadowForm = new SiticoneShadowForm(components);
            siticoneElipse1 = new SiticoneElipse(components);
            lblTitle = new Label();
            txtSearch = new SiticoneTextBox();
            btnSearch = new SiticoneButton();
            dgvAuthors = new DataGridView();
            btnAdd = new SiticoneButton();
            btnEdit = new SiticoneButton();
            btnDelete = new SiticoneButton();
            btnClose = new SiticoneButton();
            lblTotalAuthors = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).BeginInit();
            SuspendLayout();
            // 
            // shadowForm
            // 
            shadowForm.TargetForm = this;
            // 
            // siticoneElipse1
            // 
            siticoneElipse1.TargetControl = this;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(247, 249, 251);
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(26, 26, 26);
            lblTitle.Location = new Point(191, 54);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1024, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📚 QUẢN LÝ TÁC GIẢ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.BorderRadius = 10;
            txtSearch.DefaultText = "";
            txtSearch.FillColor = Color.FromArgb(232, 236, 239);
            txtSearch.Font = new Font("Segoe UI", 12F);
            txtSearch.ForeColor = Color.FromArgb(26, 26, 26);
            txtSearch.Location = new Point(253, 118);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Nhập từ khóa tìm kiếm...";
            txtSearch.SelectedText = "";
            txtSearch.Size = new Size(300, 30);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BorderRadius = 10;
            btnSearch.FillColor = Color.FromArgb(42, 46, 69);
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSearch.ForeColor = Color.FromArgb(255, 215, 0);
            btnSearch.HoverState.FillColor = Color.FromArgb(60, 64, 87);
            btnSearch.Location = new Point(634, 118);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 30);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "🔍 Tìm";
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvAuthors
            // 
            dgvAuthors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAuthors.BackgroundColor = Color.FromArgb(232, 236, 239);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(42, 46, 69);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 215, 0);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAuthors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(247, 249, 251);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(60, 64, 87);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 215, 0);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAuthors.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAuthors.EnableHeadersVisualStyles = false;
            dgvAuthors.Font = new Font("Segoe UI", 10F);
            dgvAuthors.GridColor = Color.FromArgb(232, 236, 239);
            dgvAuthors.Location = new Point(191, 165);
            dgvAuthors.Name = "dgvAuthors";
            dgvAuthors.RowHeadersVisible = false;
            dgvAuthors.RowHeadersWidth = 51;
            dgvAuthors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuthors.Size = new Size(984, 400);
            dgvAuthors.TabIndex = 3;
            dgvAuthors.CellContentClick += dgvAuthors_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 10;
            btnAdd.FillColor = Color.FromArgb(42, 46, 69);
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.ForeColor = Color.FromArgb(255, 215, 0);
            btnAdd.HoverState.FillColor = Color.FromArgb(60, 64, 87);
            btnAdd.Location = new Point(191, 586);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 35);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "➕ Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BorderRadius = 10;
            btnEdit.FillColor = Color.FromArgb(42, 46, 69);
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEdit.ForeColor = Color.FromArgb(255, 215, 0);
            btnEdit.HoverState.FillColor = Color.FromArgb(60, 64, 87);
            btnEdit.Location = new Point(491, 586);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 35);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "✏ Sửa";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BorderRadius = 10;
            btnDelete.FillColor = Color.FromArgb(232, 236, 239);
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDelete.ForeColor = Color.FromArgb(26, 26, 26);
            btnDelete.HoverState.FillColor = Color.FromArgb(200, 204, 207);
            btnDelete.Location = new Point(837, 586);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "🗑 Xoá";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.BorderRadius = 10;
            btnClose.FillColor = Color.FromArgb(232, 236, 239);
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(26, 26, 26);
            btnClose.HoverState.FillColor = Color.FromArgb(200, 204, 207);
            btnClose.Location = new Point(1075, 586);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 35);
            btnClose.TabIndex = 7;
            btnClose.Text = "↩ Đóng";
            btnClose.Click += btnClose_Click;
            // 
            // lblTotalAuthors
            // 
            lblTotalAuthors.AutoSize = true;
            lblTotalAuthors.BackColor = Color.FromArgb(247, 249, 251);
            lblTotalAuthors.Font = new Font("Segoe UI", 12F);
            lblTotalAuthors.ForeColor = Color.FromArgb(26, 26, 26);
            lblTotalAuthors.Location = new Point(864, 120);
            lblTotalAuthors.Name = "lblTotalAuthors";
            lblTotalAuthors.Size = new Size(120, 28);
            lblTotalAuthors.TabIndex = 8;
            lblTotalAuthors.Text = "Tổng tác giả";
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 50;
            // 
            // fManageAuthor
            // 
            BackColor = Color.FromArgb(247, 249, 251);
            ClientSize = new Size(1343, 633);
            Controls.Add(lblTotalAuthors);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvAuthors);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "fManageAuthor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Tác giả";
            Load += fManageAuthor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #region Windows Form Designer generated code
        private Label lblTitle;
        private SiticoneTextBox txtSearch;
        private SiticoneButton btnSearch;
        private DataGridView dgvAuthors;
        private SiticoneButton btnAdd;
        private SiticoneButton btnEdit;
        private SiticoneButton btnDelete;
        private SiticoneButton btnClose;
        private Label lblTotalAuthors;
        private ToolTip toolTip1;
        #endregion
    }
}