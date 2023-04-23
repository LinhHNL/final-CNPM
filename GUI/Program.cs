using WinFormsApp2;
using WinFormsApp2.AdminPage;
using WinFormsApp2.KhachHangManager;
using WinFormsApp2.KhoPage;
using WinFormsApp2.NhanVienPage;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new AllMonAn());
        }
    }
}