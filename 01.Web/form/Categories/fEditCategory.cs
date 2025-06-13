using System;
using System.Windows.Forms;
using System.Xml.Linq;
using QLTV;

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
            if (_categoryId.HasValue)
            {
                var cat = ctx.Categories.Find(_categoryId.Value);
                if (cat != null)
                {
                    cat.Name = name;
                }
            }
            else
            {
                var cat = new QLTV.Models.Category { Name = name };
                ctx.Categories.Add(cat);
            }

            ctx.SaveChanges();
            DialogResult = DialogResult.OK;
        }
    }
}
