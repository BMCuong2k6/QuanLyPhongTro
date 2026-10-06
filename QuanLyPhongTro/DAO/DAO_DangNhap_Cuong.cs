using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QuanLyPhongTro.DAO
{
    internal class DAO_DangNhap_Cuong
    {
        public static SqlConnection conn = Connection.open();
        public static SqlDataAdapter dap = null;
        public static SqlDataAdapter cmd = null;

        public static DataTable GetData()
        {
            DataTable tableHD = new DataTable();
            dap = new SqlDataAdapter("select * from taikhoan", conn);
            int aa = dap.Fill(tableHD);
            return tableHD;
        }
        public static bool KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            SqlCommand cmd = new SqlCommand();
            string query = "SELECT COUNT(*) " +
                "FROM TaiKhoan " +
                "WHERE TenTaiKhoan = @taiKhoan AND MatKhau = @matKhau";
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@taiKhoan", taiKhoan);
            cmd.Parameters.AddWithValue("@matKhau", matKhau);
            try
            {
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.ToString());
                throw;
            }
        }
        public static bool kiemtraemail(string email)
        {
            SqlCommand cmd = new SqlCommand();
            string query = "SELECT COUNT(*) " +
                "FROM TaiKhoan " +
                "WHERE Email = @email";
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@email", email);
            try
            {
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.ToString());
                throw;
            }
        }
        public static string laymatkhau(string email)
        {
            SqlCommand cmd = new SqlCommand();
            string query = "SELECT MatKhau " +
                "FROM TaiKhoan " +
                "WHERE Email = @email";
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@email", email);
            try
            {
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return result.ToString();
                }
                else
                {
                    return null; // Hoặc xử lý theo cách bạn muốn nếu không tìm thấy email
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.ToString());
                throw;
            }
        }
    }
}
