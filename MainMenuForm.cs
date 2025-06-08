using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Ngducanh
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

   
        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            
        }


        private void MainMenuForm_Paint(object sender, PaintEventArgs e)
        {
           
            using (LinearGradientBrush brush = new LinearGradientBrush(
                ClientRectangle, Color.White, Color.PaleGoldenrod, 90F))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }
        }

        
    }
}