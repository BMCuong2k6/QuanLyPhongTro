using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;


using Microsoft.Data.SqlClient;

namespace QuanLyPhongTro.DAO
{
    internal class Connection
    {
<<<<<<< HEAD
        private static string strconn =
            "Server=Admin-PC;" +
            "Database=QuanLyPhongTro;" +
            "Integrated Security=True;" +
            "TrustServerCertificate=True;";

=======
        //kết nối csdl

        //Trường

        //static string strconn = "server=LAPTOP-F6G2PCU0;" +
        // "database=QLPhongTro;" +
        //  "Integrated Security=True;" +
        // "trustservercertificate=true;";

        //Cường

        static string strconn = "server=DESKTOP-84UP1KC\\SQLEXPRESS;" +
            "database=QLPhongTro;" +
            "Integrated Security=True;" +
            "trustservercertificate=true;";

        // quân

        //static string strconn = "server=;" +
        //    "database=QLPhongTro;" +
        //    "Integrated Security=True;" +
        //    "trustservercertificate=true;";

        static SqlConnection conn = null;
>>>>>>> 9f6daf887ed593fce5aa5edd57081b0fcfe1e681
        public static SqlConnection open()
        {
            try
            {
                return new SqlConnection(strconn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                throw;
            }
        }
    }
}
