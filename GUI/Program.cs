using GUI.Components;
using GUI.Kitchen;
using WinFormsApp2;
using WinFormsApp2.AdminPage;
using WinFormsApp2.KhachHangManager;
using WinFormsApp2.KhoPage;
using WinFormsApp2.NhanVienPage;
using WinFormsApp2.Statistic;
using WinFormsApp2.StaffAccount;
using GUI.KhachHangInfo;
using GUI.ThanhToan;

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
            Application.Run(new Payment());
        }
    }
}