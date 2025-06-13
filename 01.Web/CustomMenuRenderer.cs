using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Ngducanh
{
    public class CustomMenuRenderer : ToolStripProfessionalRenderer
    {
        // Vẽ nền cho các mục menu
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            Rectangle rect = new Rectangle(Point.Empty, e.Item.Size);
            if (e.Item.Selected || e.Item.Pressed)
            {
                // Hiệu ứng hover: gradient hồng đậm
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    rect, Color.FromArgb(255, 45, 85), Color.FromArgb(200, 30, 60), 90F))
                {
                    e.Graphics.FillRectangle(brush, rect);
                }
            }
            else
            {
                // Nền mặc định cho dropdown: gradient tím than
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    rect, Color.FromArgb(18, 18, 18), Color.FromArgb(30, 30, 30), 90F))
                {
                    e.Graphics.FillRectangle(brush, rect);
                }
            }
        }

     
      

        // Vẽ chữ cho các mục menu
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            if (e.Item.Selected || e.Item.Pressed)
            {
                e.TextColor = Color.White;
            }
            else
            {
                e.TextColor = Color.FromArgb(208, 208, 208); // Màu xám sáng
            }
            base.OnRenderItemText(e);
        }

        // Vẽ viền cho MenuStrip
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(42, 42, 42), 1))
            {
                e.Graphics.DrawRectangle(pen, 1, 1, e.ToolStrip.Width - 3, e.ToolStrip.Height - 3);
            }
        }

        // Vẽ đường phân cách
        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(80, 80, 80)))
            {
                e.Graphics.DrawLine(pen, 5, e.Item.Height / 2, e.Item.Width - 5, e.Item.Height / 2);
            }
        }

        // Vẽ viền cho dropdown
        protected override void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected || e.Item.Pressed)
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    e.Item.Bounds, Color.FromArgb(255, 45, 85), Color.FromArgb(200, 30, 60), 90F))
                {
                    e.Graphics.FillRectangle(brush, e.Item.Bounds);
                }
                using (Pen pen = new Pen(Color.FromArgb(180, 180, 180)))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, e.Item.Width - 1, e.Item.Height - 1);
                }
            }
            else
            {
                base.OnRenderDropDownButtonBackground(e);
            }
        }
    }
}
