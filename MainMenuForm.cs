using System.Windows.Forms;
using System.Drawing;

namespace Ngducanh
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm(string userName)
        {
            InitializeComponent();

            // Hiện tên đăng nhập ngoài phải MenuStrip
            var toolStripLabelUser = new ToolStripLabel
            {
                Name = "toolStripLabelUser",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 102, 204),
                Text = $"👤 {userName}",
                Alignment = ToolStripItemAlignment.Right
            };
            menuMain.Items.Add(toolStripLabelUser);

            // Gán sự kiện cho nút Thoát
            mnuThoat.Click += MnuThoat_Click;
        }

        private void MnuThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var loginForm = new LoginForm())
            {
                loginForm.ShowDialog();
            }
            this.Close();
        }

        private void MainMenuForm_Load(object sender, System.EventArgs e)
        {
            // Không cần code gì ở đây nữa
        }
    }
}
