using Siticone.Desktop.UI.WinForms;
using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QLTV;
using QLTV.Models;
using System.Drawing.Text;

namespace Ngducanh
{
    public partial class fEditCategory : Form
    {
        private readonly int? _categoryId;

        public fEditCategory(int? categoryId = null)
        {
            InitializeComponent();
            _categoryId = categoryId;

            if (_categoryId.HasValue)
            {
                LoadCategory(_categoryId.Value);
            }

            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (_, __) => DialogResult = DialogResult.Cancel;
        }

        private void LoadCategory(int id)
        {
            using var ctx = new LibraryContext();
            var cat = ctx.Categories.Find(id);
            if (cat != null)
            {
                txtName.Text = cat.Name;
            }
            else
            {
                MessageBox.Show("Thể loại không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập tên thể loại.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        

            using var ctx = new LibraryContext();
            try
            {
                if (_categoryId.HasValue)
                {
                    var cat = ctx.Categories.Find(_categoryId.Value);
                    if (cat != null)
                    {
                        cat.Name = name;
                    }
                    else
                    {
                        MessageBox.Show("Thể loại không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    var cat = new Category { Name = name };
                    ctx.Categories.Add(cat);
                }

                ctx.SaveChanges();
                DialogResult = DialogResult.OK;
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fEditCategory_Load(object sender, EventArgs e)
        {
            // Thêm thời gian hiện tại (04:15 PM +07, Saturday, June 21, 2025) vào tiêu đề
            lblTitle.Values.ExtraText = $" - {DateTime.Now:hh:mm tt zzz, dddd, MMMM dd, yyyy}";
            if (_categoryId.HasValue)
            {
                this.Text = "Sửa thể loại";
            }
            else
            {
                this.Text = "Thêm thể loại";
            }
        }
    }
}