using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;


using Microsoft.Data.SqlClient;

namespace QuanLyPhongTro.DAO
{
    internal class Connection
    {
        //kết nối csdl

        //Trường

<<<<<<< HEAD
        //static string strconn = "server=LAPTOP-F6G2PCU0;" +
        // "database=QuanLyPhongTro;" +
        //  "Integrated Security=True;" +
        // "trustservercertificate=true;";
=======
        static string strconn = "server=LAPTOP-F6G2PCU0;" +
         "database=QLPhongTro;" +
          "Integrated Security=True;" +
         "trustservercertificate=true;";
>>>>>>> 8d47d034a55dcad593b974553de498bac54d6b46

        //Cường

        //static string strconn = "server=DESKTOP-84UP1KC\\SQLEXPRESS;" +
<<<<<<< HEAD
        //  "database=QuanLyPhongTro;" +
        //  "Integrated Security=True;" +
        // "trustservercertificate=true;";
=======
        //    "database=QLPhongTro;" +
        //    "Integrated Security=True;" +
        //    "trustservercertificate=true;";
>>>>>>> 8d47d034a55dcad593b974553de498bac54d6b46

        // quân

        static string strconn = "server=Admin-PC;" +
            "database=QLPhongTro;" +
            "Integrated Security=True;" +
            "trustservercertificate=true;";

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
