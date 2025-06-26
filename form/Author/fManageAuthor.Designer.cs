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
            lblTitle.BackColor = Color.FromArgb(22, 27, 34);
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 10);
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
            txtSearch.FillColor = Color.FromArgb(28, 31, 38);
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            txtSearch.ForeColor = Color.WhiteSmoke;
            txtSearch.Location = new Point(20, 70);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(300, 30);
            txtSearch.TabIndex = 1;
            txtSearch.PlaceholderText = "Nhập từ khóa tìm kiếm...";
            // 
            // btnSearch
            // 
            btnSearch.BorderRadius = 10;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSearch.Location = new Point(330, 70);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 30);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "🔍 Tìm";
            btnSearch.FillColor = Color.FromArgb(41, 121, 255);
            btnSearch.ForeColor = Color.White;
            btnSearch.HoverState.FillColor = Color.FromArgb(30, 100, 200);
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvAuthors
            // 
            dgvAuthors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAuthors.BackgroundColor = Color.FromArgb(22, 27, 34);
            dgvAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthors.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            dgvAuthors.ForeColor = Color.WhiteSmoke;
            dgvAuthors.GridColor = Color.FromArgb(28, 31, 38);
            dgvAuthors.Location = new Point(20, 120);
            dgvAuthors.Name = "dgvAuthors";
            dgvAuthors.RowHeadersVisible = false;
            dgvAuthors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuthors.Size = new Size(984, 400);
            dgvAuthors.TabIndex = 3;
            dgvAuthors.EnableHeadersVisualStyles = false;
            dgvAuthors.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 121, 255);
            dgvAuthors.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAuthors.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvAuthors.DefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 100, 200);
            dgvAuthors.CellContentClick += dgvAuthors_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 10;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(150, 540);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 35);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "➕ Thêm";
            btnAdd.FillColor = Color.FromArgb(41, 121, 255);
            btnAdd.ForeColor = Color.White;
            btnAdd.HoverState.FillColor = Color.FromArgb(30, 100, 200);
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BorderRadius = 10;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEdit.Location = new Point(270, 540);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 35);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "✏ Sửa";
            btnEdit.FillColor = Color.FromArgb(41, 121, 255);
            btnEdit.ForeColor = Color.White;
            btnEdit.HoverState.FillColor = Color.FromArgb(30, 100, 200);
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BorderRadius = 10;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDelete.Location = new Point(390, 540);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "🗑 Xoá";
            btnDelete.FillColor = Color.FromArgb(192, 0, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.HoverState.FillColor = Color.FromArgb(160, 0, 0);
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.BorderRadius = 10;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.Location = new Point(510, 540);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 35);
            btnClose.TabIndex = 7;
            btnClose.Text = "↩ Đóng";
            btnClose.FillColor = Color.FromArgb(192, 0, 0);
            btnClose.ForeColor = Color.White;
            btnClose.HoverState.FillColor = Color.FromArgb(160, 0, 0);
            btnClose.Click += btnClose_Click;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 50;
            // 
            // fManageAuthor
            // 
            BackColor = Color.FromArgb(13, 17, 23);
            ClientSize = new Size(1024, 768);
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
        private ToolTip toolTip1;
        #endregion
    }
}