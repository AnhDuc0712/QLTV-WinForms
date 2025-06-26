using System;
using System.Windows.Forms;
using QLTV.Models;
using System.Linq;

namespace QLTV.form.Reader
{
    public partial class fManageReader : Form
    {
        public fManageReader()
        {
            InitializeComponent();
            this.Load += fManageReader_Load;
        }

        private void fManageReader_Load(object sender, EventArgs e)
        {
            LoadReaders();
        }

        private void LoadReaders(string keyword = "")
        {
            using (var db = new LibraryContext())
            {
                var list = db.Users
                    .Where(u => u.FullName.Contains(keyword))
                    .Select(u => new { u.UserId, u.FullName, u.Email, u.Phone, u.Address })
                    .ToList();
                dataGridView1.DataSource = list;
            }

            // Xóa cột Edit/Delete cũ (nếu có) để luôn đảm bảo ở cuối
            if (dataGridView1.Columns.Contains("Edit"))
                dataGridView1.Columns.Remove("Edit");
            if (dataGridView1.Columns.Contains("Delete"))
                dataGridView1.Columns.Remove("Delete");

            // Thêm cột Sửa ở cuối
            var btnEdit = new DataGridViewButtonColumn
            {
                Name = "Edit",
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                Width = 60
            };
            dataGridView1.Columns.Add(btnEdit);

            // Thêm cột Xóa ở cuối
            var btnDelete = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Width = 60
            };
            dataGridView1.Columns.Add(btnDelete);
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            LoadReaders(txtName.Text.Trim());
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            var f = new fNewReader();

            f.MdiParent = this.MdiParent;
            f.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int userId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["UserId"].Value);

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                var f = new fEditReader(userId);

                f.MdiParent = this.MdiParent;
                f.Show();

            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Bạn muốn xóa độc giả này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (var db = new LibraryContext())
                    {
                        var user = db.Users.Find(userId);
                        if (user != null)
                        {
                            db.Users.Remove(user);
                            db.SaveChanges();
                            LoadReaders();
                        }
                    }
                }
            }
        }

        private void fManageReader_Load_1(object sender, EventArgs e)
        {

        }
    }
}
