using Siticone.Desktop.UI.WinForms;
using Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ngducanh
{
    partial class fManageCategory
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
            label1 = new KryptonLabel();
            lblCategoryCount = new KryptonLabel();
            txtSearch = new SiticoneTextBox();
            btnSearch = new SiticoneButton();
            dgv = new DataGridView();
            btnAdd = new SiticoneButton();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
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
            // label1
            // 
            label1.Location = new Point(400, 33);
            label1.Name = "label1";
            label1.Size = new Size(352, 51);
            label1.StateCommon.ShortText.Color1 = Color.White;
            label1.StateCommon.ShortText.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.StateCommon.ShortText.TextH = PaletteRelativeAlign.Near;
            label1.TabIndex = 4;
            label1.Values.Text = "Quản lý thể loại sách";
            // 
            // lblCategoryCount
            // 
            lblCategoryCount.Location = new Point(247, 510);
            lblCategoryCount.Name = "lblCategoryCount";
            lblCategoryCount.Size = new Size(117, 36);
            lblCategoryCount.StateCommon.ShortText.Color1 = Color.LightGreen;
            lblCategoryCount.StateCommon.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCategoryCount.TabIndex = 5;
            lblCategoryCount.Values.Text = "Số loại: 0";
            // 
            // txtSearch
            // 
            txtSearch.BorderRadius = 12;
            txtSearch.DefaultText = "";
            txtSearch.FillColor = Color.FromArgb(28, 31, 38);
            txtSearch.Font = new Font("Segoe UI", 12F);
            txtSearch.ForeColor = Color.WhiteSmoke;
            txtSearch.Location = new Point(321, 118);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Nhập tên, Mã thể loại...";
            txtSearch.SelectedText = "";
            txtSearch.Size = new Size(550, 30);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BorderRadius = 12;
            btnSearch.FillColor = Color.FromArgb(41, 121, 255);
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.HoverState.FillColor = Color.FromArgb(30, 100, 200);
            btnSearch.Location = new Point(934, 117);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 30);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "🔍 Tìm kiếm";
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.FromArgb(22, 27, 34);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 121, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(28, 31, 38);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 100, 200);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle2;
            dgv.Location = new Point(238, 170);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(832, 323);
            dgv.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 12;
            btnAdd.FillColor = Color.FromArgb(0, 150, 136);
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.HoverState.FillColor = Color.FromArgb(0, 120, 110);
            btnAdd.Location = new Point(934, 578);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 56);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "➕ Thêm mới";
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 50;
            // 
            // fManageCategory
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(13, 17, 23);
            ClientSize = new Size(1332, 646);
            Controls.Add(btnAdd);
            Controls.Add(dgv);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblCategoryCount);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fManageCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ THỂ LOẠI SÁCH";
            Load += fManageCategory_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #region Windows Form Designer generated code
        private KryptonLabel label1;
        private KryptonLabel lblCategoryCount;
        private SiticoneTextBox txtSearch;
        private SiticoneButton btnSearch;
        private DataGridView dgv;
        private SiticoneButton btnAdd;
        private ToolTip toolTip1;
        #endregion
    }
}