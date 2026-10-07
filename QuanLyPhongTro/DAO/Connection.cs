using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyPhongTro.DAO
{
    internal class Connection
    {
        //kết nối csdl

        //Trường

        static string strconn = "server=LAPTOP-F6G2PCU0;" +
           "database=QLPhongTro;" +
           "Integrated Security=True;" +
          "trustservercertificate=true;";

        //Cường

        //static string strconn = "server=DESKTOP-AER5QIC\\SQLEXPRESS;" +
          //  "database=QLPhongTro;" +
          //  "Integrated Security=True;" +
           // "trustservercertificate=true;";

        // quân

        //static string strconn = "server=;" +
        //    "database=QLPhongTro;" +
        //    "Integrated Security=True;" +
        //    "trustservercertificate=true;";

        static SqlConnection conn = null;
        public static SqlConnection open()
        {
            try
            {
                conn = new SqlConnection(strconn);
                conn.Open();
                //MessageBox.Show("ket noi thanh cong");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.ToString(), "loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            return conn;
        }
        public static void close()
        {
            conn.Close();
        }
    }
}
