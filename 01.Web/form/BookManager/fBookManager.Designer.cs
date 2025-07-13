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
        private SiticoneTextBox txtEditStockQuantity;
        private SiticoneTextBox txtEditBookID;
        private SiticoneTextBox txtAddStockQuantity;


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
            Delete = new DataGridViewButtonColumn();
            btnAdd = new SiticoneButton();
            lblMenu = new Label();
            lblBookCount = new Krypton.Toolkit.KryptonLabel();
            btnClose = new SiticoneButton();
            txtBookTitle = new SiticoneTextBox();
            panelEdit = new SiticonePanel();
            cBEditPublisherID = new ComboBox();
            cBEditCategories = new ComboBox();
            label2 = new Label();
            pictureBoxEdit = new PictureBox();
            btnEditClose = new SiticoneButton();
            btnSave = new SiticoneButton();
            txtEditTitle = new SiticoneTextBox();
            txtEditBookID = new SiticoneTextBox();
            txtEditStockQuantity = new SiticoneTextBox();
            panelAdd = new SiticonePanel();
            cBAddCategories = new ComboBox();
            cBAddPublisherID = new ComboBox();
            label1 = new Label();
            pictureBoxAdd = new PictureBox();
            btnAddClose = new SiticoneButton();
            btnAddSave = new SiticoneButton();
            txtAddBookTitle = new SiticoneTextBox();
            txtAddStockQuantity = new SiticoneTextBox();
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
            btnFind.FillColor = Color.FromArgb(42, 46, 69);
            btnFind.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFind.ForeColor = Color.FromArgb(255, 215, 0);
            btnFind.HoverState.FillColor = Color.FromArgb(60, 64, 87);
            btnFind.Location = new Point(881, 166);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(146, 50);
            btnFind.TabIndex = 2;
            btnFind.Text = "Tìm 🔍";
            btnFind.Click += btnFind_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(232, 236, 239);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Font = new Font("Segoe UI", 10F);
            dataGridView1.GridColor = Color.FromArgb(232, 236, 239);
            dataGridView1.Location = new Point(391, 222);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(759, 385);
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
            Delete.HeaderText = "Xóa";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Text = "Xóa";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 10;
            btnAdd.FillColor = Color.FromArgb(42, 46, 69);
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.ForeColor = Color.FromArgb(255, 215, 0);
            btnAdd.HoverState.FillColor = Color.FromArgb(60, 64, 87);
            btnAdd.Location = new Point(397, 115);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(146, 50);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Thêm ➕";
            btnAdd.Click += btnAdd_Click;
            // 
            // lblMenu
            // 
            lblMenu.BackColor = Color.FromArgb(247, 249, 251);
            lblMenu.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenu.ForeColor = Color.FromArgb(26, 26, 26);
            lblMenu.Location = new Point(694, 12);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(470, 74);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "📚 Quản Lý Sách 📚";
            lblMenu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBookCount
            // 
            lblBookCount.Location = new Point(766, 109);
            lblBookCount.Name = "lblBookCount";
            lblBookCount.Size = new Size(160, 46);
            lblBookCount.StateCommon.ShortText.Color1 = Color.FromArgb(255, 215, 0);
            lblBookCount.StateCommon.ShortText.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblBookCount.TabIndex = 1;
            lblBookCount.Values.Text = "Số sách: 0";
            // 
            // btnClose
            // 
            btnClose.BorderRadius = 10;
            btnClose.FillColor = Color.FromArgb(232, 236, 239);
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(26, 26, 26);
            btnClose.HoverState.FillColor = Color.FromArgb(200, 204, 207);
            btnClose.Location = new Point(549, 115);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(154, 50);
            btnClose.TabIndex = 16;
            btnClose.Text = "Đóng ❌";
            btnClose.Click += btnClose_Click;
            // 
            // txtBookTitle
            // 
            txtBookTitle.BorderRadius = 10;
            txtBookTitle.DefaultText = "";
            txtBookTitle.FillColor = Color.FromArgb(232, 236, 239);
            txtBookTitle.Font = new Font("Segoe UI", 12F);
            txtBookTitle.ForeColor = Color.FromArgb(26, 26, 26);
            txtBookTitle.Location = new Point(391, 172);
            txtBookTitle.Margin = new Padding(3, 4, 3, 4);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.PasswordChar = '\0';
            txtBookTitle.PlaceholderText = "Nhập tên sách";
            txtBookTitle.SelectedText = "";
            txtBookTitle.Size = new Size(473, 43);
            txtBookTitle.TabIndex = 17;
            // 
            // panelEdit
            // 
            panelEdit.BorderRadius = 20;
            panelEdit.Controls.Add(cBEditPublisherID);
            panelEdit.Controls.Add(cBEditCategories);
            panelEdit.Controls.Add(label2);
            panelEdit.Controls.Add(pictureBoxEdit);
            panelEdit.Controls.Add(btnEditClose);
            panelEdit.Controls.Add(btnSave);
            panelEdit.Controls.Add(txtEditTitle);
            panelEdit.Controls.Add(txtEditBookID);
            panelEdit.Controls.Add(txtEditStockQuantity);
            panelEdit.FillColor = Color.FromArgb(247, 249, 251);
            panelEdit.Location = new Point(21, 12);
            panelEdit.Name = "panelEdit";
            panelEdit.Size = new Size(370, 594);
            panelEdit.TabIndex = 21;
            panelEdit.Visible = false;
            // 
            // cBEditPublisherID
            // 
            cBEditPublisherID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBEditPublisherID.FormattingEnabled = true;
            cBEditPublisherID.Location = new Point(20, 97);
            cBEditPublisherID.Name = "cBEditPublisherID";
            cBEditPublisherID.Size = new Size(268, 31);
            cBEditPublisherID.TabIndex = 47;
            // 
            // cBEditCategories
            // 
            cBEditCategories.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBEditCategories.FormattingEnabled = true;
            cBEditCategories.Location = new Point(20, 155);
            cBEditCategories.Name = "cBEditCategories";
            cBEditCategories.Size = new Size(268, 31);
            cBEditCategories.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(26, 26, 26);
            label2.Location = new Point(127, 552);
            label2.Name = "label2";
            label2.Size = new Size(50, 28);
            label2.TabIndex = 45;
            label2.Text = "Ảnh";
            // 
            // pictureBoxEdit
            // 
            pictureBoxEdit.BackColor = Color.FromArgb(232, 236, 239);
            pictureBoxEdit.Location = new Point(127, 306);
            pictureBoxEdit.Name = "pictureBoxEdit";
            pictureBoxEdit.Size = new Size(237, 227);
            pictureBoxEdit.TabIndex = 33;
            pictureBoxEdit.TabStop = false;
            pictureBoxEdit.Click += pictureBoxEdit_Click;
            // 
            // btnEditClose
            // 
            btnEditClose.BorderRadius = 10;
            btnEditClose.FillColor = Color.FromArgb(232, 236, 239);
            btnEditClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditClose.ForeColor = Color.FromArgb(26, 26, 26);
            btnEditClose.HoverState.FillColor = Color.FromArgb(200, 204, 207);
            btnEditClose.Location = new Point(3, 476);
            btnEditClose.Name = "btnEditClose";
            btnEditClose.Size = new Size(118, 57);
            btnEditClose.TabIndex = 24;
            btnEditClose.Text = "Đóng ❌";
            btnEditClose.Click += btnEditClose_Click;
            // 
            // btnSave
            // 
            btnSave.BorderRadius = 10;
            btnSave.FillColor = Color.FromArgb(42, 46, 69);
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.FromArgb(255, 215, 0);
            btnSave.HoverState.FillColor = Color.FromArgb(60, 64, 87);
            btnSave.Location = new Point(3, 316);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 57);
            btnSave.TabIndex = 23;
            btnSave.Text = "Lưu 💾";
            btnSave.Click += btnSave_Click;
            // 
            // txtEditTitle
            // 
            txtEditTitle.BorderRadius = 10;
            txtEditTitle.DefaultText = "";
            txtEditTitle.FillColor = Color.FromArgb(232, 236, 239);
            txtEditTitle.Font = new Font("Segoe UI", 12F);
            txtEditTitle.ForeColor = Color.FromArgb(26, 26, 26);
            txtEditTitle.Location = new Point(20, 31);
            txtEditTitle.Margin = new Padding(3, 4, 3, 4);
            txtEditTitle.Name = "txtEditTitle";
            txtEditTitle.PasswordChar = '\0';
            txtEditTitle.PlaceholderText = "Nhập tên sách";
            txtEditTitle.SelectedText = "";
            txtEditTitle.Size = new Size(268, 30);
            txtEditTitle.TabIndex = 12;
            // 
            // txtEditBookID
            // 
            txtEditBookID.BorderRadius = 10;
            txtEditBookID.DefaultText = "";
            txtEditBookID.FillColor = Color.FromArgb(232, 236, 239);
            txtEditBookID.Font = new Font("Segoe UI", 12F);
            txtEditBookID.ForeColor = Color.FromArgb(26, 26, 26);
            txtEditBookID.Location = new Point(20, 269);
            txtEditBookID.Margin = new Padding(3, 4, 3, 4);
            txtEditBookID.Name = "txtEditBookID";
            txtEditBookID.PasswordChar = '\0';
            txtEditBookID.PlaceholderText = "Mã sách";
            txtEditBookID.SelectedText = "";
            txtEditBookID.Size = new Size(268, 30);
            txtEditBookID.TabIndex = 0;
            // 
            // txtEditStockQuantity
            // 
            txtEditStockQuantity.BorderRadius = 10;
            txtEditStockQuantity.DefaultText = "";
            txtEditStockQuantity.FillColor = Color.FromArgb(232, 236, 239);
            txtEditStockQuantity.Font = new Font("Segoe UI", 12F);
            txtEditStockQuantity.ForeColor = Color.FromArgb(26, 26, 26);
            txtEditStockQuantity.Location = new Point(20, 209);
            txtEditStockQuantity.Margin = new Padding(3, 4, 3, 4);
            txtEditStockQuantity.Name = "txtEditStockQuantity";
            txtEditStockQuantity.PasswordChar = '\0';
            txtEditStockQuantity.PlaceholderText = "Nhập số lượng";
            txtEditStockQuantity.SelectedText = "";
            txtEditStockQuantity.Size = new Size(268, 30);
            txtEditStockQuantity.TabIndex = 1;
            // 
            // panelAdd
            // 
            panelAdd.BorderRadius = 20;
            panelAdd.Controls.Add(cBAddCategories);
            panelAdd.Controls.Add(cBAddPublisherID);
            panelAdd.Controls.Add(label1);
            panelAdd.Controls.Add(pictureBoxAdd);
            panelAdd.Controls.Add(btnAddClose);
            panelAdd.Controls.Add(btnAddSave);
            panelAdd.Controls.Add(txtAddBookTitle);
            panelAdd.Controls.Add(txtAddStockQuantity);
            panelAdd.FillColor = Color.FromArgb(247, 249, 251);
            panelAdd.Location = new Point(21, 612);
            panelAdd.Name = "panelAdd";
            panelAdd.Size = new Size(1174, 199);
            panelAdd.TabIndex = 22;
            panelAdd.Visible = false;
            panelAdd.Paint += panelAdd_Paint;
            // 
            // cBAddCategories
            // 
            cBAddCategories.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBAddCategories.FormattingEnabled = true;
            cBAddCategories.Location = new Point(283, 15);
            cBAddCategories.Name = "cBAddCategories";
            cBAddCategories.Size = new Size(268, 31);
            cBAddCategories.TabIndex = 46;
            // 
            // cBAddPublisherID
            // 
            cBAddPublisherID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBAddPublisherID.FormattingEnabled = true;
            cBAddPublisherID.Location = new Point(583, 15);
            cBAddPublisherID.Name = "cBAddPublisherID";
            cBAddPublisherID.Size = new Size(255, 31);
            cBAddPublisherID.TabIndex = 45;
            cBAddPublisherID.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(26, 26, 26);
            label1.Location = new Point(819, 98);
            label1.Name = "label1";
            label1.Size = new Size(50, 28);
            label1.TabIndex = 44;
            label1.Text = "Ảnh";
            // 
            // pictureBoxAdd
            // 
            pictureBoxAdd.BackColor = Color.FromArgb(232, 236, 239);
            pictureBoxAdd.Location = new Point(875, 10);
            pictureBoxAdd.Name = "pictureBoxAdd";
            pictureBoxAdd.Size = new Size(294, 186);
            pictureBoxAdd.TabIndex = 43;
            pictureBoxAdd.TabStop = false;
            pictureBoxAdd.Click += pictureBoxAdd_Click;
            // 
            // btnAddClose
            // 
            btnAddClose.BorderRadius = 10;
            btnAddClose.FillColor = Color.FromArgb(232, 236, 239);
            btnAddClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddClose.ForeColor = Color.FromArgb(26, 26, 26);
            btnAddClose.HoverState.FillColor = Color.FromArgb(200, 204, 207);
            btnAddClose.Location = new Point(52, 7);
            btnAddClose.Name = "btnAddClose";
            btnAddClose.Size = new Size(143, 57);
            btnAddClose.TabIndex = 26;
            btnAddClose.Text = "Đóng ❌";
            btnAddClose.Click += btnAddClose_Click;
            // 
            // btnAddSave
            // 
            btnAddSave.BorderRadius = 10;
            btnAddSave.FillColor = Color.FromArgb(42, 46, 69);
            btnAddSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddSave.ForeColor = Color.FromArgb(255, 215, 0);
            btnAddSave.HoverState.FillColor = Color.FromArgb(60, 64, 87);
            btnAddSave.Location = new Point(52, 69);
            btnAddSave.Name = "btnAddSave";
            btnAddSave.Size = new Size(141, 57);
            btnAddSave.TabIndex = 33;
            btnAddSave.Text = "Lưu 💾";
            btnAddSave.Click += btnAddSave_Click;
            // 
            // txtAddBookTitle
            // 
            txtAddBookTitle.BorderRadius = 10;
            txtAddBookTitle.DefaultText = "";
            txtAddBookTitle.FillColor = Color.FromArgb(232, 236, 239);
            txtAddBookTitle.Font = new Font("Segoe UI", 12F);
            txtAddBookTitle.ForeColor = Color.FromArgb(26, 26, 26);
            txtAddBookTitle.Location = new Point(283, 144);
            txtAddBookTitle.Margin = new Padding(3, 4, 3, 4);
            txtAddBookTitle.Name = "txtAddBookTitle";
            txtAddBookTitle.PasswordChar = '\0';
            txtAddBookTitle.PlaceholderText = "Nhập tên sách";
            txtAddBookTitle.SelectedText = "";
            txtAddBookTitle.Size = new Size(268, 42);
            txtAddBookTitle.TabIndex = 27;
            // 
            // txtAddStockQuantity
            // 
            txtAddStockQuantity.BorderRadius = 10;
            txtAddStockQuantity.DefaultText = "";
            txtAddStockQuantity.FillColor = Color.FromArgb(232, 236, 239);
            txtAddStockQuantity.Font = new Font("Segoe UI", 12F);
            txtAddStockQuantity.ForeColor = Color.FromArgb(26, 26, 26);
            txtAddStockQuantity.Location = new Point(583, 144);
            txtAddStockQuantity.Margin = new Padding(3, 4, 3, 4);
            txtAddStockQuantity.Name = "txtAddStockQuantity";
            txtAddStockQuantity.PasswordChar = '\0';
            txtAddStockQuantity.PlaceholderText = "Số lượng";
            txtAddStockQuantity.SelectedText = "";
            txtAddStockQuantity.Size = new Size(255, 40);
            txtAddStockQuantity.TabIndex = 0;
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
            pictureBox1.BackColor = Color.FromArgb(232, 236, 239);
            pictureBox1.Location = new Point(1140, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 171);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // fBookManager
            // 
            BackColor = Color.FromArgb(247, 249, 251);
            ClientSize = new Size(1381, 845);
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
            PerformLayout();
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
        private SiticoneButton btnEditClose;
        private SiticoneButton btnSave;
        private SiticoneTextBox txtEditTitle;
        private SiticonePanel panelAdd;
        private Label label1;
        private PictureBox pictureBoxAdd;
        private SiticoneButton btnAddClose;
        private SiticoneButton btnAddSave;
        private SiticoneTextBox txtAddBookTitle;
        private ToolTip toolTip1;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private PictureBox pictureBox1;
        #endregion



        private ComboBox cBAddPublisherID;
        private ComboBox cBAddCategories;
        private ComboBox cBEditPublisherID;
        private ComboBox cBEditCategories;
    }
}