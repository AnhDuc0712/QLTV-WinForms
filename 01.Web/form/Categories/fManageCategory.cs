using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QLTV;
using QLTV.Models;

namespace Ngducanh
{
    public partial class fManageCategory : Form
    {
        private class CategoryVM
        {
            public int CategoryId { get; set; }
            public string Name { get; set; }
            public int Count { get; set; }
        }

        private List<CategoryVM> _data = new();

        public fManageCategory()
        {
            InitializeComponent();

            // Thêm cột cho DataGridView
            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã thể loại", Name = "colCode", ReadOnly = true });
                dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên thể loại", Name = "colName", ReadOnly = true });
                dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số lượng sách", Name = "colCount", ReadOnly = true });
                dgv.Columns.Add(new DataGridViewButtonColumn
                {
                    HeaderText = "Sửa",
                    Name = "colEdit",
                    Text = "Sửa",
                    UseColumnTextForButtonValue = true,
                    Width = 70
                });
                dgv.Columns.Add(new DataGridViewButtonColumn
                {
                    HeaderText = "Xóa",
                    Name = "colDel",
                    Text = "Xóa",
                    UseColumnTextForButtonValue = true,
                    Width = 70
                });
            }

            // Gán sự kiện
            btnSearch.Click += BtnSearch_Click;
            btnAdd.Click += BtnAdd_Click;
            dgv.CellClick += Dgv_CellClick;

            // Load dữ liệu
            LoadDataFromDb();
        }

        private void fManageCategory_Load(object sender, EventArgs e)
        {
            label1.Values.ExtraText = $" - {DateTime.Now:hh:mm tt zzz, dddd, MMMM dd, yyyy}"; // 04:23 PM +07, Saturday, June 21, 2025
            UpdateCategoryCount();
        }

        private void LoadDataFromDb()
        {
            try
            {
                using var ctx = new LibraryContext();
                var list = ctx.Categories
                              .Include(c => c.Books)
                              .Select(c => new CategoryVM
                              {
                                  CategoryId = c.CategoryId,
                                  Name = c.Name,
                                  Count = c.Books.Count
                              })
                              .ToList();
                _data = list;
                RefreshGrid(_data);
                UpdateCategoryCount(); // Cập nhật số lượng sau khi load
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshGrid(IEnumerable<CategoryVM> list)
        {
            dgv.Rows.Clear();
            foreach (var c in list)
            {
                int rowIndex = dgv.Rows.Add(c.CategoryId, c.Name, c.Count);
                dgv.Rows[rowIndex].Cells["colEdit"].Value = "Sửa";
                dgv.Rows[rowIndex].Cells["colDel"].Value = "Xóa";
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            var txt = txtSearch.Text.Trim().ToLower();
            var filtered = _data
                .Where(x =>
                    x.CategoryId.ToString().Contains(txt) ||
                    x.Name.ToLower().Contains(txt)
                );
            RefreshGrid(filtered);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            OpenAddForm();
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var id = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["colCode"].Value);
            var colName = dgv.Columns[e.ColumnIndex].Name;

            if (colName == "colEdit")
            {
                using var frm = new fEditCategory(id);
                if (frm.ShowDialog() == DialogResult.OK)
                    LoadDataFromDb();
            }
            else if (colName == "colDel")
            {
                if (MessageBox.Show($"Xóa thể loại #{id}?", "Xác nhận",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        using var ctx = new LibraryContext();
                        var cat = ctx.Categories.Find(id);
                        if (cat != null)
                        {
                            ctx.Categories.Remove(cat);
                            ctx.SaveChanges();
                        }
                        LoadDataFromDb();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void OpenAddForm()
        {
            using var frm = new fEditCategory();
            if (frm.ShowDialog() == DialogResult.OK)
                LoadDataFromDb();
        }

        private void UpdateCategoryCount()
        {
            try
            {
                using var ctx = new LibraryContext();
                int count = ctx.Categories.Count();
                lblCategoryCount.Values.Text = $"Số lượng: {count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tính số lượng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}