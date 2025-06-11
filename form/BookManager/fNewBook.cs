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
    public partial class fNewBook : Form
    {
        public fNewBook()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã thêm sách mới!");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã lưu sách mới thành công !");
        }
    }
}
