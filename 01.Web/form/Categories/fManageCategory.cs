using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QLTV;            // namespace chứa LibraryContext
using QLTV.Models;     // namespace chứa entity Category, Book

namespace Ngducanh
{
    public partial class fManageCategory : Form
    {
        // ViewModel hiển thị lên grid
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

            // Nếu Designer chưa tạo cột, hãy thêm ở đây
            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã thể loại", Name = "colCode" });
                dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên thể loại", Name = "colName" });
                dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số lượng sách", Name = "colCount" });
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

            // Hook sự kiện
            btnSearch.Click += (s, e) => ApplyFilter();
            btnAdd.Click += (s, e) => OpenAddForm();
            dgv.CellClick += Dgv_CellClick;

            // Load dữ liệu từ database
            LoadDataFromDb();
        }

        private void LoadDataFromDb()
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
        }

        private void RefreshGrid(IEnumerable<CategoryVM> list)
        {
            dgv.Rows.Clear();
            int stt = 1;
            foreach (var c in list)
            {
                dgv.Rows.Add( c.CategoryId, c.Name, c.Count);
            }
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

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var id = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["colCode"].Value);
            var colName = dgv.Columns[e.ColumnIndex].Name;

            if (colName == "colEdit")
            {
                // Mở form sửa truyền vào id
                using var frm = new fEditCategory(id);
                if (frm.ShowDialog() == DialogResult.OK)
                    LoadDataFromDb();
            }
            else if (colName == "colDel")
            {
                if (MessageBox.Show($"Xóa thể loại #{id}?", "Xác nhận",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    == DialogResult.Yes)
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
            }
        }

        private void OpenAddForm()
        {
            using var frm = new fEditCategory();
            if (frm.ShowDialog() == DialogResult.OK)
                LoadDataFromDb();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
