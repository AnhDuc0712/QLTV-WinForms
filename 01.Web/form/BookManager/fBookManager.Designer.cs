using Siticone.Desktop.UI.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ngducanh_Quanlysach
{
    partial class fBookManager
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
            btnFind = new SiticoneButton();
            dataGridView1 = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn(); // Thêm cột Xóa
            btnAdd = new SiticoneButton();
            lblMenu = new Label();
            lblBookCount = new Krypton.Toolkit.KryptonLabel();
            btnClose = new SiticoneButton();
            txtBookTitle = new SiticoneTextBox();
            panelEdit = new SiticonePanel();
            label2 = new Label();
            pictureBoxEdit = new PictureBox();
            cBEditBookID = new SiticoneComboBox();
            cBEditStockQuantity = new SiticoneComboBox();
            cBEditPublisherID = new SiticoneComboBox();
            cBEditCategories = new SiticoneComboBox();
            btnEditClose = new SiticoneButton();
            btnSave = new SiticoneButton();
            txtEditTitle = new SiticoneTextBox();
            panelAdd = new SiticonePanel();
            label1 = new Label();
            pictureBoxAdd = new PictureBox();
            cBAddBookID = new SiticoneComboBox();
            cBAddStockQuantity = new SiticoneComboBox();
            cBAddCategories = new SiticoneComboBox();
            cBAddPublisherID = new SiticoneComboBox();
            btnAddClose = new SiticoneButton();
            btnAddSave = new SiticoneButton();
            txtAddBookTitle = new SiticoneTextBox();
            toolTip1 = new ToolTip(components);
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEdit).BeginInit();
            panelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // btnFind
            // 
            btnFind.BorderRadius = 10;
            btnFind.FillColor = Color.FromArgb(41, 121, 255);
            btnFind.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFind.ForeColor = Color.White;
            btnFind.HoverState.FillColor = Color.FromArgb(30, 100, 200);
            btnFind.Location = new Point(485, 126);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 2;
            btnFind.Text = "Tìm 🔍";
            btnFind.Click += btnFind_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(22, 27, 34);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Font = new Font("Segoe UI", 10F);
            dataGridView1.GridColor = Color.FromArgb(28, 31, 38);
            dataGridView1.Location = new Point(266, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 300);
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
            // 
            // Delete
            // 
            Delete.HeaderText = "Xóa"; // Thêm cột Xóa
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Text = "Xóa";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 10;
            btnAdd.FillColor = Color.FromArgb(41, 121, 255);
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.HoverState.FillColor = Color.FromArgb(30, 100, 200);
            btnAdd.Location = new Point(600, 90);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Thêm ➕";
            btnAdd.Click += btnAdd_Click;
            // 
            // lblMenu
            // 
            lblMenu.BackColor = Color.FromArgb(22, 27, 34);
            lblMenu.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMenu.ForeColor = Color.White;
            lblMenu.Location = new Point(300, 10);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(300, 40);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "📚 Quản Lý Sách 📚";
            lblMenu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBookCount
            // 
            lblBookCount.StateCommon.ShortText.Color1 = Color.LightGreen;
            lblBookCount.StateCommon.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBookCount.Location = new Point(600, 20);
            lblBookCount.Name = "lblBookCount";
            lblBookCount.Size = new Size(200, 30);
            lblBookCount.TabIndex = 1;
            lblBookCount.Values.Text = "Số sách: 0";
            // 
            // btnClose
            // 
            btnClose.BorderRadius = 10;
            btnClose.FillColor = Color.FromArgb(192, 0, 0);
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.HoverState.FillColor = Color.FromArgb(160, 0, 0);
            btnClose.Location = new Point(715, 90);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(109, 29);
            btnClose.TabIndex = 16;
            btnClose.Text = "Đóng ❌";
            btnClose.Click += btnClose_Click;
            // 
            // txtBookTitle
            // 
            txtBookTitle.BorderRadius = 10;
            txtBookTitle.DefaultText = "";
            txtBookTitle.FillColor = Color.FromArgb(28, 31, 38);
            txtBookTitle.Font = new Font("Segoe UI", 12F);
            txtBookTitle.ForeColor = Color.WhiteSmoke;
            txtBookTitle.Location = new Point(296, 89);
            txtBookTitle.Margin = new Padding(3, 4, 3, 4);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.PasswordChar = '\0';
            txtBookTitle.PlaceholderText = "Nhập tên sách";
            txtBookTitle.SelectedText = "";
            txtBookTitle.Size = new Size(200, 30);
            txtBookTitle.TabIndex = 17;
            // 
            // panelEdit
            // 
            panelEdit.BorderRadius = 20;
            panelEdit.Controls.Add(label2);
            panelEdit.Controls.Add(pictureBoxEdit);
            panelEdit.Controls.Add(cBEditBookID);
            panelEdit.Controls.Add(cBEditStockQuantity);
            panelEdit.Controls.Add(cBEditPublisherID);
            panelEdit.Controls.Add(cBEditCategories);
            panelEdit.Controls.Add(btnEditClose);
            panelEdit.Controls.Add(btnSave);
            panelEdit.Controls.Add(txtEditTitle);
            panelEdit.FillColor = Color.FromArgb(22, 27, 34);
            panelEdit.Location = new Point(12, 11);
            panelEdit.Name = "panelEdit";
            panelEdit.Size = new Size(250, 449);
            panelEdit.TabIndex = 21;
            panelEdit.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(107, 285);
            label2.Name = "label2";
            label2.Size = new Size(50, 28);
            label2.TabIndex = 45;
            label2.Text = "Ảnh";
            // 
            // pictureBoxEdit
            // 
            pictureBoxEdit.BackColor = Color.White;
            pictureBoxEdit.Location = new Point(10, 316);
            pictureBoxEdit.Name = "pictureBoxEdit";
            pictureBoxEdit.Size = new Size(237, 75);
            pictureBoxEdit.TabIndex = 33;
            pictureBoxEdit.TabStop = false;
            pictureBoxEdit.Click += pictureBoxEdit_Click;
            // 
            // cBEditBookID
            // 
            cBEditBookID.BackColor = Color.Transparent;
            cBEditBookID.BorderRadius = 10;
            cBEditBookID.DrawMode = DrawMode.OwnerDrawFixed;
            cBEditBookID.DropDownStyle = ComboBoxStyle.DropDownList;
            cBEditBookID.FillColor = Color.FromArgb(28, 31, 38);
            cBEditBookID.FocusedColor = Color.FromArgb(94, 148, 255);
            cBEditBookID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cBEditBookID.Font = new Font("Segoe UI", 10F);
            cBEditBookID.ForeColor = Color.WhiteSmoke;
            cBEditBookID.FormattingEnabled = true;
            cBEditBookID.ItemHeight = 30;
            cBEditBookID.Location = new Point(20, 246);
            cBEditBookID.Name = "cBEditBookID";
            cBEditBookID.Size = new Size(210, 36);
            cBEditBookID.TabIndex = 32;
            // 
            // cBEditStockQuantity
            // 
            cBEditStockQuantity.BackColor = Color.Transparent;
            cBEditStockQuantity.BorderRadius = 10;
            cBEditStockQuantity.DrawMode = DrawMode.OwnerDrawFixed;
            cBEditStockQuantity.DropDownStyle = ComboBoxStyle.DropDownList;
            cBEditStockQuantity.FillColor = Color.FromArgb(28, 31, 38);
            cBEditStockQuantity.FocusedColor = Color.FromArgb(94, 148, 255);
            cBEditStockQuantity.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cBEditStockQuantity.Font = new Font("Segoe UI", 10F);
            cBEditStockQuantity.ForeColor = Color.WhiteSmoke;
            cBEditStockQuantity.FormattingEnabled = true;
            cBEditStockQuantity.ItemHeight = 30;
            cBEditStockQuantity.Location = new Point(20, 194);
            cBEditStockQuantity.Name = "cBEditStockQuantity";
            cBEditStockQuantity.Size = new Size(210, 36);
            cBEditStockQuantity.TabIndex = 31;
            // 
            // cBEditPublisherID
            // 
            cBEditPublisherID.BackColor = Color.Transparent;
            cBEditPublisherID.BorderRadius = 10;
            cBEditPublisherID.DrawMode = DrawMode.OwnerDrawFixed;
            cBEditPublisherID.DropDownStyle = ComboBoxStyle.DropDownList;
            cBEditPublisherID.FillColor = Color.FromArgb(28, 31, 38);
            cBEditPublisherID.FocusedColor = Color.FromArgb(94, 148, 255);
            cBEditPublisherID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cBEditPublisherID.Font = new Font("Segoe UI", 10F);
            cBEditPublisherID.ForeColor = Color.WhiteSmoke;
            cBEditPublisherID.FormattingEnabled = true;
            cBEditPublisherID.ItemHeight = 30;
            cBEditPublisherID.Location = new Point(20, 82);
            cBEditPublisherID.Name = "cBEditPublisherID";
            cBEditPublisherID.Size = new Size(210, 36);
            cBEditPublisherID.TabIndex = 30;
            // 
            // cBEditCategories
            // 
            cBEditCategories.BackColor = Color.Transparent;
            cBEditCategories.BorderRadius = 10;
            cBEditCategories.DrawMode = DrawMode.OwnerDrawFixed;
            cBEditCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cBEditCategories.FillColor = Color.FromArgb(28, 31, 38);
            cBEditCategories.FocusedColor = Color.FromArgb(94, 148, 255);
            cBEditCategories.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cBEditCategories.Font = new Font("Segoe UI", 10F);
            cBEditCategories.ForeColor = Color.WhiteSmoke;
            cBEditCategories.FormattingEnabled = true;
            cBEditCategories.ItemHeight = 30;
            cBEditCategories.Location = new Point(20, 139);
            cBEditCategories.Name = "cBEditCategories";
            cBEditCategories.Size = new Size(210, 36);
            cBEditCategories.TabIndex = 25;
            // 
            // btnEditClose
            // 
            btnEditClose.BorderRadius = 10;
            btnEditClose.FillColor = Color.FromArgb(192, 0, 0);
            btnEditClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditClose.ForeColor = Color.White;
            btnEditClose.HoverState.FillColor = Color.FromArgb(160, 0, 0);
            btnEditClose.Location = new Point(150, 397);
            btnEditClose.Name = "btnEditClose";
            btnEditClose.Size = new Size(90, 29);
            btnEditClose.TabIndex = 24;
            btnEditClose.Text = "Đóng ❌";
            btnEditClose.Click += btnEditClose_Click;
            // 
            // btnSave
            // 
            btnSave.BorderRadius = 10;
            btnSave.FillColor = Color.FromArgb(41, 121, 255);
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.HoverState.FillColor = Color.FromArgb(30, 100, 200);
            btnSave.Location = new Point(20, 397);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 29);
            btnSave.TabIndex = 23;
            btnSave.Text = "Lưu 💾";
            btnSave.Click += btnSave_Click;
            // 
            // txtEditTitle
            // 
            txtEditTitle.BorderRadius = 10;
            txtEditTitle.DefaultText = "";
            txtEditTitle.FillColor = Color.FromArgb(28, 31, 38);
            txtEditTitle.Font = new Font("Segoe UI", 12F);
            txtEditTitle.ForeColor = Color.WhiteSmoke;
            txtEditTitle.Location = new Point(20, 36);
            txtEditTitle.Margin = new Padding(3, 4, 3, 4);
            txtEditTitle.Name = "txtEditTitle";
            txtEditTitle.PasswordChar = '\0';
            txtEditTitle.PlaceholderText = "Nhập tên sách";
            txtEditTitle.SelectedText = "";
            txtEditTitle.Size = new Size(210, 30);
            txtEditTitle.TabIndex = 12;
            // 
            // panelAdd
            // 
            panelAdd.BorderRadius = 20;
            panelAdd.Controls.Add(label1);
            panelAdd.Controls.Add(pictureBoxAdd);
            panelAdd.Controls.Add(cBAddBookID);
            panelAdd.Controls.Add(cBAddStockQuantity);
            panelAdd.Controls.Add(cBAddCategories);
            panelAdd.Controls.Add(cBAddPublisherID);
            panelAdd.Controls.Add(btnAddClose);
            panelAdd.Controls.Add(btnAddSave);
            panelAdd.Controls.Add(txtAddBookTitle);
            panelAdd.FillColor = Color.FromArgb(22, 27, 34);
            panelAdd.Location = new Point(12, 466);
            panelAdd.Name = "panelAdd";
            panelAdd.Size = new Size(1054, 132);
            panelAdd.TabIndex = 22;
            panelAdd.Visible = false;
            panelAdd.Paint += panelAdd_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(904, 103);
            label1.Name = "label1";
            label1.Size = new Size(50, 28);
            label1.TabIndex = 44;
            label1.Text = "Ảnh";
            // 
            // pictureBoxAdd
            // 
            pictureBoxAdd.BackColor = Color.White;
            pictureBoxAdd.Location = new Point(795, 7);
            pictureBoxAdd.Name = "pictureBoxAdd";
            pictureBoxAdd.Size = new Size(256, 93);
            pictureBoxAdd.TabIndex = 43;
            pictureBoxAdd.TabStop = false;
            pictureBoxAdd.Click += pictureBoxAdd_Click;
            // 
            // cBAddBookID
            // 
            cBAddBookID.BackColor = Color.Transparent;
            cBAddBookID.BorderRadius = 10;
            cBAddBookID.DrawMode = DrawMode.OwnerDrawFixed;
            cBAddBookID.DropDownStyle = ComboBoxStyle.DropDownList;
            cBAddBookID.FillColor = Color.FromArgb(28, 31, 38);
            cBAddBookID.FocusedColor = Color.FromArgb(94, 148, 255);
            cBAddBookID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cBAddBookID.Font = new Font("Segoe UI", 10F);
            cBAddBookID.ForeColor = Color.WhiteSmoke;
            cBAddBookID.FormattingEnabled = true;
            cBAddBookID.ItemHeight = 30;
            cBAddBookID.Location = new Point(576, 7);
            cBAddBookID.Name = "cBAddBookID";
            cBAddBookID.Size = new Size(200, 36);
            cBAddBookID.TabIndex = 42;
            // 
            // cBAddStockQuantity
            // 
            cBAddStockQuantity.BackColor = Color.Transparent;
            cBAddStockQuantity.BorderRadius = 10;
            cBAddStockQuantity.DrawMode = DrawMode.OwnerDrawFixed;
            cBAddStockQuantity.DropDownStyle = ComboBoxStyle.DropDownList;
            cBAddStockQuantity.FillColor = Color.FromArgb(28, 31, 38);
            cBAddStockQuantity.FocusedColor = Color.FromArgb(94, 148, 255);
            cBAddStockQuantity.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cBAddStockQuantity.Font = new Font("Segoe UI", 10F);
            cBAddStockQuantity.ForeColor = Color.WhiteSmoke;
            cBAddStockQuantity.FormattingEnabled = true;
            cBAddStockQuantity.ItemHeight = 30;
            cBAddStockQuantity.Location = new Point(576, 49);
            cBAddStockQuantity.Name = "cBAddStockQuantity";
            cBAddStockQuantity.Size = new Size(200, 36);
            cBAddStockQuantity.TabIndex = 41;
            // 
            // cBAddCategories
            // 
            cBAddCategories.BackColor = Color.Transparent;
            cBAddCategories.BorderRadius = 10;
            cBAddCategories.DrawMode = DrawMode.OwnerDrawFixed;
            cBAddCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cBAddCategories.FillColor = Color.FromArgb(28, 31, 38);
            cBAddCategories.FocusedColor = Color.FromArgb(94, 148, 255);
            cBAddCategories.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cBAddCategories.Font = new Font("Segoe UI", 10F);
            cBAddCategories.ForeColor = Color.WhiteSmoke;
            cBAddCategories.FormattingEnabled = true;
            cBAddCategories.ItemHeight = 30;
            cBAddCategories.Location = new Point(388, 49);
            cBAddCategories.Name = "cBAddCategories";
            cBAddCategories.Size = new Size(179, 36);
            cBAddCategories.TabIndex = 40;
            cBAddCategories.SelectedIndexChanged += cBAddCategories_SelectedIndexChanged;
            // 
            // cBAddPublisherID
            // 
            cBAddPublisherID.BackColor = Color.Transparent;
            cBAddPublisherID.BorderRadius = 10;
            cBAddPublisherID.DrawMode = DrawMode.OwnerDrawFixed;
            cBAddPublisherID.DropDownStyle = ComboBoxStyle.DropDownList;
            cBAddPublisherID.FillColor = Color.FromArgb(28, 31, 38);
            cBAddPublisherID.FocusedColor = Color.FromArgb(94, 148, 255);
            cBAddPublisherID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cBAddPublisherID.Font = new Font("Segoe UI", 10F);
            cBAddPublisherID.ForeColor = Color.WhiteSmoke;
            cBAddPublisherID.FormattingEnabled = true;
            cBAddPublisherID.ItemHeight = 30;
            cBAddPublisherID.Location = new Point(388, 7);
            cBAddPublisherID.Name = "cBAddPublisherID";
            cBAddPublisherID.Size = new Size(179, 36);
            cBAddPublisherID.TabIndex = 39;
            // 
            // btnAddClose
            // 
            btnAddClose.BorderRadius = 10;
            btnAddClose.FillColor = Color.FromArgb(192, 0, 0);
            btnAddClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddClose.ForeColor = Color.White;
            btnAddClose.HoverState.FillColor = Color.FromArgb(160, 0, 0);
            btnAddClose.Location = new Point(10, 14);
            btnAddClose.Name = "btnAddClose";
            btnAddClose.Size = new Size(90, 29);
            btnAddClose.TabIndex = 26;
            btnAddClose.Text = "Đóng ❌";
            btnAddClose.Click += btnAddClose_Click;
            // 
            // btnAddSave
            // 
            btnAddSave.BorderRadius = 10;
            btnAddSave.FillColor = Color.FromArgb(41, 121, 255);
            btnAddSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddSave.ForeColor = Color.White;
            btnAddSave.HoverState.FillColor = Color.FromArgb(30, 100, 200);
            btnAddSave.Location = new Point(10, 71);
            btnAddSave.Name = "btnAddSave";
            btnAddSave.Size = new Size(90, 29);
            btnAddSave.TabIndex = 33;
            btnAddSave.Text = "Lưu 💾";
            btnAddSave.Click += btnAddSave_Click;
            // 
            // txtAddBookTitle
            // 
            txtAddBookTitle.BorderRadius = 10;
            txtAddBookTitle.DefaultText = "";
            txtAddBookTitle.FillColor = Color.FromArgb(28, 31, 38);
            txtAddBookTitle.Font = new Font("Segoe UI", 12F);
            txtAddBookTitle.ForeColor = Color.WhiteSmoke;
            txtAddBookTitle.Location = new Point(150, 27);
            txtAddBookTitle.Margin = new Padding(3, 4, 3, 4);
            txtAddBookTitle.Name = "txtAddBookTitle";
            txtAddBookTitle.PasswordChar = '\0';
            txtAddBookTitle.PlaceholderText = "Nhập tên sách";
            txtAddBookTitle.SelectedText = "";
            txtAddBookTitle.Size = new Size(232, 42);
            txtAddBookTitle.TabIndex = 27;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 50;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(916, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // fBookManager
            // 
            BackColor = Color.FromArgb(13, 17, 23);
            ClientSize = new Size(1196, 771);
            Controls.Add(pictureBox1);
            Controls.Add(panelAdd);
            Controls.Add(panelEdit);
            Controls.Add(txtBookTitle);
            Controls.Add(btnClose);
            Controls.Add(lblBookCount);
            Controls.Add(lblMenu);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(btnFind);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "fBookManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Sách";
            Load += fBookManager_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelEdit.ResumeLayout(false);
            panelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEdit).EndInit();
            panelAdd.ResumeLayout(false);
            panelAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #region Windows Form Designer generated code
        private SiticoneButton btnFind;
        private DataGridView dataGridView1;
        private SiticoneButton btnAdd;
        private Label lblMenu;
        private Krypton.Toolkit.KryptonLabel lblBookCount;
        private SiticoneButton btnClose;
        private SiticoneTextBox txtBookTitle;
        private SiticonePanel panelEdit;
        private Label label2;
        private PictureBox pictureBoxEdit;
        private SiticoneComboBox cBEditBookID;
        private SiticoneComboBox cBEditStockQuantity;
        private SiticoneComboBox cBEditPublisherID;
        private SiticoneComboBox cBEditCategories;
        private SiticoneButton btnEditClose;
        private SiticoneButton btnSave;
        private SiticoneTextBox txtEditTitle;
        private SiticonePanel panelAdd;
        private Label label1;
        private PictureBox pictureBoxAdd;
        private SiticoneComboBox cBAddBookID;
        private SiticoneComboBox cBAddStockQuantity;
        private SiticoneComboBox cBAddCategories;
        private SiticoneComboBox cBAddPublisherID;
        private SiticoneButton btnAddClose;
        private SiticoneButton btnAddSave;
        private SiticoneTextBox txtAddBookTitle;
        private ToolTip toolTip1;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete; // Thêm cột Xóa
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private PictureBox pictureBox1;
        #endregion
    }
}