namespace Ngducanh
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Truyền username nếu muốn
                Application.Run(new MainMenuForm(loginForm.Username));
            }
            // Nếu đăng nhập thất bại hoặc bị đóng, không vào hệ thống
        }
    }
}
