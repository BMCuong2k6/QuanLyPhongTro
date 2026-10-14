using QuanLyPhongTro.View;

namespace QuanLyPhongTro
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
            //Application.Run(new Form1());
            //Application.Run(new frm_HoaDontruong());
            //Application.Run(new View.ftm_UI_Chinh());
<<<<<<< HEAD
            Application.Run(new QuanLyPhongTro.View .frm_KhachThue_Quan());
=======
            //Application.Run(new frm_UI_Chinh());

            Application.Run(new View.frm_DangNhap());

            
>>>>>>> 9f6daf887ed593fce5aa5edd57081b0fcfe1e681
        }
    }
}