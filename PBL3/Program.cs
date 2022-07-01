using System;
using System.Windows.Forms;

namespace PBL3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("vi-VN");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi-VN");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDangNhap());
        }
    }
}
