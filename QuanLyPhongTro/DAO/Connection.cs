using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyPhongTro.DAO
{
    internal class Connection
    {
        //kết nối csdl
        static string strconn = "server=DESKTOP-AER5QIC\\SQLEXPRESS;" +
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
