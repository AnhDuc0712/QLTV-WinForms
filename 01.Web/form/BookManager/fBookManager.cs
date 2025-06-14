﻿using Microsoft.EntityFrameworkCore;
using QLTV.Models;
using QLTV;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Ngducanh_Quanlysach
{
    public partial class fBookManager : Form
    {
        private object gruopBox1;

        public fBookManager()
        {
            InitializeComponent();

            cBAddStockQuantity.KeyPress += NumericComboBox_KeyPress;
            cBEditBookID.KeyPress += NumericComboBox_KeyPress;
            cBEditStockQuantity.KeyPress += NumericComboBox_KeyPress;
        }

        private void fBookManager_Load(object sender, EventArgs e)
        {
            InitializeComboBoxes();
            RefreshDataGridView();
        }

        private void InitializeComboBoxes()
        {
            using (var db = new LibraryContext())
            {

                var categories = db.Categories.ToList();
                cBEditCategories.DataSource = categories;
                cBEditCategories.DisplayMember = "Name";
                cBEditCategories.ValueMember = "CategoryId";
                cBAddCategories.DataSource = categories;
                cBAddCategories.DisplayMember = "Name";
                cBAddCategories.ValueMember = "CategoryId";


                var publishers = db.Publishers.ToList();
                if (!publishers.Any())
                {
                    MessageBox.Show("Không có dữ liệu Nhà xuất bản trong database. Vui lòng thêm dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                cBEditPublisherID.DataSource = publishers;
                cBEditPublisherID.DisplayMember = "Name";
                cBEditPublisherID.ValueMember = "PublisherId";
                cBAddPublisherID.DataSource = publishers;
                cBAddPublisherID.DisplayMember = "Name";
                cBAddPublisherID.ValueMember = "PublisherId";
            }
        }

        private void RefreshDataGridView()
        {
            using (var db = new LibraryContext())
            {
                dataGridView1.DataSource = db.Books
                    .Select(c => new
                    {
                        c.BookId,
                        c.Title,
                        c.CategoryId,
                        c.PublisherId,
                        c.StockQuantity
                    }).ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = true;
            txtAddBookTitle.Text = cBAddStockQuantity.Text = "";
            cBAddCategories.SelectedIndex = -1;
            cBAddPublisherID.SelectedIndex = -1;
            cBAddBookID.Text = "";
            cBAddBookID.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new LibraryContext())
            {
                try
                {
                    if (!int.TryParse(cBEditBookID.Text, out int bookId) || bookId <= 0)
                        throw new Exception("Mã sách không hợp lệ!");
                    if (cBEditPublisherID.SelectedValue == null || !int.TryParse(cBEditPublisherID.SelectedValue.ToString(), out int publisherId) || publisherId <= 0)
                        throw new Exception("Vui lòng chọn nhà xuất bản hợp lệ!");
                    if (cBEditCategories.SelectedValue == null || !int.TryParse(cBEditCategories.SelectedValue.ToString(), out int categoryId) || categoryId <= 0)
                        throw new Exception("Vui lòng chọn loại sách hợp lệ!");
                    if (!int.TryParse(cBEditStockQuantity.Text, out int stockQuantity) || stockQuantity < 0)
                        throw new Exception("Số lượng không hợp lệ!");
                    if (string.IsNullOrWhiteSpace(txtTitle.Text))
                        throw new Exception("Vui lòng nhập tên sách!");

                    var book = db.Books.Find(bookId);
                    if (book == null)
                        throw new Exception("Sách không tồn tại!");

                    book.PublisherId = publisherId;
                    book.CategoryId = categoryId;
                    book.StockQuantity = stockQuantity;
                    book.Title = txtTitle.Text;

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

        private void btAddSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAddBookTitle.Text))
                    throw new Exception("Vui lòng nhập tên sách!");
                if (cBAddPublisherID.SelectedValue == null || !int.TryParse(cBAddPublisherID.SelectedValue.ToString(), out int publisherId) || publisherId <= 0)
                    throw new Exception("Vui lòng chọn nhà xuất bản hợp lệ!");
                if (cBAddCategories.SelectedValue == null || !int.TryParse(cBAddCategories.SelectedValue.ToString(), out int categoryId) || categoryId <= 0)
                    throw new Exception("Vui lòng chọn loại sách hợp lệ!");
                if (!int.TryParse(cBAddStockQuantity.Text, out int stockQty) || stockQty < 0)
                    throw new Exception("Số lượng không hợp lệ!");

                using (var db = new LibraryContext())
                {
                    var newBook = new Book
                    {
                        Title = txtAddBookTitle.Text,
                        PublisherId = publisherId,
                        CategoryId = categoryId,
                        StockQuantity = stockQty
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
                toolTip1.Show("Vui lòng nhập tên sách để tìm!", btnFind, 0, 0, 1000);
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
                        c.StockQuantity
                    }).ToList();

                dataGridView1.DataSource = books;
                if (!books.Any())
                    toolTip1.Show("Không tìm thấy sách!", btnFind, 0, 0, 1000);
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

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    int bookId = (int)dataGridView1.Rows[e.RowIndex].Cells["BookId"].Value;
                    using (var db = new LibraryContext())
                    {
                        var book = db.Books.Find(bookId);
                        if (book == null) throw new Exception("Sách không tồn tại!");

                        if (MessageBox.Show($"Bạn muốn xóa sách: {book.Title}?", "Xác nhận xóa",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                try
                {
                    int bookId = (int)dataGridView1.Rows[e.RowIndex].Cells["BookId"].Value;
                    using (var db = new LibraryContext())
                    {
                        var book = db.Books.Find(bookId);
                        if (book == null) throw new Exception("Sách không tồn tại!");

                        cBEditBookID.Text = book.BookId.ToString();
                        txtTitle.Text = book.Title;
                        cBEditPublisherID.SelectedValue = book.PublisherId;
                        cBEditCategories.SelectedValue = book.CategoryId;
                        cBEditStockQuantity.Text = book.StockQuantity.ToString();
                        panelEdit.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi mở form sửa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblMenu_Click(object sender, EventArgs e)
        {

        }
    }
}