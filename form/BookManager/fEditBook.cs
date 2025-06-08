using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ngducanh_Quanlysach
{
    public partial class fEditBook : Form
    {
        public fEditBook()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã lưu sách thành công");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã sửa sách thành công ");
        }

        private void lblCategories_Click(object sender, EventArgs e)
        {

        }
    }
}
