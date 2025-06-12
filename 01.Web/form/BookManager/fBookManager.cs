namespace Ngducanh_Quanlysach
{
    public partial class fBookManager : Form
    {
        public fBookManager()
        {
            InitializeComponent();
        }

        private void txtEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFind_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fEditBook fEditBook = new fEditBook();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fNewBook f = new fNewBook();
            f.MdiParent = this.MdiParent;
            f.Show();

        }

        private void cBPublisher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            fEditBook f = new fEditBook();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fBookManager_Load(object sender, EventArgs e)
        {

        }

        private void lblPublisher_Click(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }


    }

}