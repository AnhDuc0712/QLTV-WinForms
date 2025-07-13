using Siticone.Desktop.UI.WinForms;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QLTV;
using QLTV.Models;

namespace Ngducanh_Quanlysach
{
    public partial class fBookManager : Form
    {
        public fBookManager()
        {
            InitializeComponent();

            txtAddStockQuantity.KeyPress += NumericComboBox_KeyPress;
            txtEditStockQuantity.KeyPress += NumericComboBox_KeyPress;

            toolTip1.SetToolTip(txtEditBookID, "Nhập hoặc chọn mã sách");
            toolTip1.SetToolTip(txtEditStockQuantity, "Nhập hoặc chọn số lượng");
            toolTip1.SetToolTip(cBEditPublisherID, "Chọn nhà xuất bản");
            toolTip1.SetToolTip(cBEditCategories, "Chọn loại sách");
            //toolTip1.SetToolTip(txtAddBookID, "Nhập hoặc chọn mã sách");
            toolTip1.SetToolTip(txtAddStockQuantity, "Nhập hoặc chọn số lượng");
            toolTip1.SetToolTip(cBAddPublisherID, "Chọn nhà xuất bản");
            toolTip1.SetToolTip(cBAddCategories, "Chọn loại sách");
        }

        private void fBookManager_Load(object sender, EventArgs e)
        {
            InitializeComboBoxes();
            RefreshDataGridView();
            UpdateBookCount();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void InitializeComboBoxes()
        {
            using (var db = new LibraryContext())
            {
                var categories = db.Categories.ToList();
                cBEditCategories.DropDownStyle = ComboBoxStyle.DropDown;
                cBEditCategories.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cBEditCategories.AutoCompleteSource = AutoCompleteSource.ListItems;
                cBEditCategories.DataSource = categories;
                cBEditCategories.DisplayMember = "Name";
                cBEditCategories.ValueMember = "CategoryId";

                cBAddCategories.DropDownStyle = ComboBoxStyle.DropDown;
                cBAddCategories.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cBAddCategories.AutoCompleteSource = AutoCompleteSource.ListItems;
                cBAddCategories.DataSource = categories;
                cBAddCategories.DisplayMember = "Name";
                cBAddCategories.ValueMember = "CategoryId";

                var publishers = db.Publishers.ToList();
                if (!publishers.Any())
                {
                    MessageBox.Show("Không có dữ liệu Nhà xuất bản trong database. Vui lòng thêm dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                cBEditPublisherID.DropDownStyle = ComboBoxStyle.DropDown;
                cBEditPublisherID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cBEditPublisherID.AutoCompleteSource = AutoCompleteSource.ListItems;
                cBEditPublisherID.DataSource = publishers;
                cBEditPublisherID.DisplayMember = "Name";
                cBEditPublisherID.ValueMember = "PublisherId";

                cBAddPublisherID.DropDownStyle = ComboBoxStyle.DropDown;
                cBAddPublisherID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cBAddPublisherID.AutoCompleteSource = AutoCompleteSource.ListItems;
                cBAddPublisherID.DataSource = publishers;
                cBAddPublisherID.DisplayMember = "Name";
                cBAddPublisherID.ValueMember = "PublisherId";
            }
        }


        // ----- HÀM QUAN TRỌNG: HIỆN ẢNH ĐẠI DIỆN TRONG DATAGRIDVIEW -----
        private void RefreshDataGridView()
        {
            using (var db = new LibraryContext())
            {
                var booksList = db.Books
                    .Select(c => new
                    {
                        c.BookId,
                        c.Title,
                        c.CategoryId,
                        c.PublisherId,
                        c.StockQuantity,
                        c.ImageUrl
                    })
                    .ToList();

                dataGridView1.DataSource = booksList;

                // Thêm cột ảnh vào DataGridView nếu chưa có
                const string colImageName = "Ảnh";
                if (dataGridView1.Columns[colImageName] == null)
                {
                    DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                    imgCol.Name = colImageName;
                    imgCol.HeaderText = "Ảnh";
                    imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    imgCol.Width = 80;
                    dataGridView1.Columns.Insert(0, imgCol);
                }

                // Gán ảnh cho từng dòng
                for (int i = 0; i < booksList.Count; i++)
                {
                    var row = dataGridView1.Rows[i];
                    string imagePath = booksList[i].ImageUrl;
                    if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                    {
                        row.Cells[colImageName].Value = Image.FromFile(imagePath);
                    }
                    else
                    {
                        row.Cells[colImageName].Value = null; // hoặc ảnh mặc định
                    }
                }
                dataGridView1.Columns[colImageName].ReadOnly = true;
                UpdateBookCount();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = true;
            txtAddBookTitle.Text = "";
            txtAddStockQuantity.Text = "";
            cBAddCategories.SelectedIndex = -1;
            cBAddPublisherID.SelectedIndex = -1;
            //cBAddBookID.Text = "";
            //cBAddBookID.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new LibraryContext())
            {
                try
                {
                    if (!int.TryParse(txtEditBookID.Text, out int bookId) || bookId <= 0)
                    {
                        toolTip1.Show("Vui lòng nhập mã sách hợp lệ!", txtEditBookID, 0, 0, 2000);
                        return;
                    }
                    if (cBEditPublisherID.SelectedValue == null || !int.TryParse(cBEditPublisherID.SelectedValue.ToString(), out int publisherId) || publisherId <= 0)
                    {
                        toolTip1.Show("Vui lòng chọn nhà xuất bản hợp lệ!", cBEditPublisherID, 0, 0, 2000);
                        return;
                    }
                    if (cBEditCategories.SelectedValue == null || !int.TryParse(cBEditCategories.SelectedValue.ToString(), out int categoryId) || categoryId <= 0)
                    {
                        toolTip1.Show("Vui lòng chọn loại sách hợp lệ!", cBEditCategories, 0, 0, 2000);
                        return;
                    }
                    if (!int.TryParse(txtEditStockQuantity.Text, out int stockQuantity) || stockQuantity < 0)
                    {
                        toolTip1.Show("Vui lòng nhập số lượng hợp lệ!", txtEditStockQuantity, 0, 0, 2000);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(txtEditTitle.Text))
                    {
                        toolTip1.Show("Vui lòng nhập tên sách!", txtEditTitle, 0, 0, 2000);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(pictureBoxEdit.ImageLocation) || !File.Exists(pictureBoxEdit.ImageLocation))
                    {
                        toolTip1.Show("Vui lòng chọn hình ảnh hợp lệ!", pictureBoxEdit, 0, 0, 2000);
                        return;
                    }

                    var book = db.Books.Find(bookId);
                    if (book == null)
                    {
                        toolTip1.Show("Sách không tồn tại!", txtEditBookID, 0, 0, 2000);
                        return;
                    }

                    book.PublisherId = publisherId;
                    book.CategoryId = categoryId;
                    book.StockQuantity = stockQuantity;
                    book.Title = txtEditTitle.Text;
                    book.ImageUrl = pictureBoxEdit.ImageLocation;

                    db.Books.Update(book);
                    db.SaveChanges();

                    toolTip1.Show("Lưu thành công!", btnSave, 0, 0, 1000);
                    panelEdit.Visible = false;
                    RefreshDataGridView();
                }
                catch (DbUpdateException ex)
                {
                    toolTip1.Show($"Lỗi lưu: {ex.InnerException?.Message ?? ex.Message}", btnSave, 0, 0, 2000);
                }
                catch (Exception ex)
                {
                    toolTip1.Show($"Lỗi: {ex.Message}", btnSave, 0, 0, 2000);
                }
            }
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAddBookTitle.Text))
                {
                    toolTip1.Show("Vui lòng nhập tên sách!", txtAddBookTitle, 0, 0, 2000);
                    return;
                }
                if (cBAddPublisherID.SelectedValue == null || !int.TryParse(cBAddPublisherID.SelectedValue.ToString(), out int publisherId) || publisherId <= 0)
                {
                    toolTip1.Show("Vui lòng chọn nhà xuất bản hợp lệ!", cBAddPublisherID, 0, 0, 2000);
                    return;
                }
                if (cBAddCategories.SelectedValue == null || !int.TryParse(cBAddCategories.SelectedValue.ToString(), out int categoryId) || categoryId <= 0)
                {
                    toolTip1.Show("Vui lòng chọn loại sách hợp lệ!", cBAddCategories, 0, 0, 2000);
                    return;
                }
                if (!int.TryParse(txtAddStockQuantity.Text, out int stockQty) || stockQty < 0)
                {
                    toolTip1.Show("Vui lòng nhập số lượng hợp lệ!", txtAddStockQuantity, 0, 0, 2000);
                    return;
                }
                if (string.IsNullOrWhiteSpace(pictureBoxAdd.ImageLocation) || !File.Exists(pictureBoxAdd.ImageLocation))
                {
                    toolTip1.Show("Vui lòng chọn hình ảnh hợp lệ!", pictureBoxAdd, 0, 0, 2000);
                    return;
                }

                using (var db = new LibraryContext())
                {
                    var newBook = new Book
                    {
                        Title = txtAddBookTitle.Text,
                        PublisherId = publisherId,
                        CategoryId = categoryId,
                        StockQuantity = stockQty,
                        ImageUrl = pictureBoxAdd.ImageLocation
                    };

                    db.Books.Add(newBook);
                    db.SaveChanges();

                    toolTip1.Show("Thêm sách thành công!", btnAddSave, 0, 0, 1000);
                    panelAdd.Visible = false;
                    RefreshDataGridView();
                }
            }
            catch (DbUpdateException ex)
            {
                toolTip1.Show($"Lỗi lưu: {ex.InnerException?.Message ?? ex.Message}", btnAddSave, 0, 0, 2000);
            }
            catch (Exception ex)
            {
                toolTip1.Show($"Lỗi: {ex.Message}", btnAddSave, 0, 0, 2000);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookTitle.Text))
            {
                toolTip1.Show("Vui lòng nhập tên sách để tìm!", txtBookTitle, 0, 0, 1000);
                return;
            }

            using (var db = new LibraryContext())
            {
                var books = db.Books.ToList()
                    .Where(c => c.Title.Contains(txtBookTitle.Text, StringComparison.OrdinalIgnoreCase))
                    .Select(c => new
                    {
                        c.BookId,
                        c.Title,
                        c.CategoryId,
                        c.PublisherId,
                        c.StockQuantity,
                        c.ImageUrl
                    }).ToList();

                dataGridView1.DataSource = books;

                // Thêm cột ảnh (nếu cần)
                const string colImageName = "Ảnh";
                if (dataGridView1.Columns[colImageName] == null)
                {
                    DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                    imgCol.Name = colImageName;
                    imgCol.HeaderText = "Ảnh";
                    imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    imgCol.Width = 80;
                    dataGridView1.Columns.Insert(0, imgCol);
                }

                // Gán ảnh cho từng dòng
                for (int i = 0; i < books.Count; i++)
                {
                    var row = dataGridView1.Rows[i];
                    string imagePath = books[i].ImageUrl;
                    if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                        row.Cells[colImageName].Value = Image.FromFile(imagePath);
                    else
                        row.Cells[colImageName].Value = null;
                }

                dataGridView1.Columns[colImageName].ReadOnly = true;

                if (!books.Any())
                    toolTip1.Show("Không tìm thấy sách!", txtBookTitle, 0, 0, 1000);
                UpdateBookCount();
            }
        }

        private void btnEditClose_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
        }

        private void btnAddClose_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
        }

        private void NumericComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                try
                {
                    int bookId = (int)dataGridView1.Rows[e.RowIndex].Cells["BookId"].Value;
                    using (var db = new LibraryContext())
                    {
                        var book = db.Books.Find(bookId);
                        if (book == null) throw new Exception("Sách không tồn tại!");

                        txtEditBookID.Text = book.BookId.ToString();
                        txtEditTitle.Text = book.Title;
                        cBEditPublisherID.SelectedValue = book.PublisherId;
                        cBEditCategories.SelectedValue = book.CategoryId;
                        txtEditStockQuantity.Text = book.StockQuantity.ToString();
                        pictureBoxEdit.ImageLocation = book.ImageUrl;
                        panelEdit.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi mở form sửa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                int bookId = (int)dataGridView1.Rows[e.RowIndex].Cells["BookId"].Value;
                if (MessageBox.Show($"Xóa sách #{bookId}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        using (var db = new LibraryContext())
                        {
                            var book = db.Books.Find(bookId);
                            if (book != null)
                            {
                                db.Books.Remove(book);
                                db.SaveChanges();
                                RefreshDataGridView();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxAdd.ImageLocation = ofd.FileName;
            }
        }

        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxEdit.ImageLocation = ofd.FileName;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Để trống hoặc mở ảnh lớn nếu cần
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells["BookId"].Value != null)
            {
                try
                {
                    int bookId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BookId"].Value);
                    using (var db = new LibraryContext())
                    {
                        var book = db.Books.Find(bookId);
                        if (book != null && !string.IsNullOrWhiteSpace(book.ImageUrl) && File.Exists(book.ImageUrl))
                        {
                            pictureBox1.ImageLocation = book.ImageUrl;
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        else
                        {
                            pictureBox1.Image = null;
                        }
                    }
                }
                catch
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void panelAdd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cBAddCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateBookCount()
        {
            try
            {
                using var db = new LibraryContext();
                int count = db.Books.Count();
                lblBookCount.Values.Text = $"Số sách: {count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tính số lượng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
