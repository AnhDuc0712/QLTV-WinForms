using System;
using System.Windows.Forms;

namespace Ngducanh
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Luôn mở LoginForm trước!
            Application.Run(new LoginForm());
        }
    }
}
