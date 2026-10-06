using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QuanLyPhongTro.DAO
{
    internal class DAO_Hoadontruong
    {
        public static SqlConnection conn = Connection.open();
        public static SqlDataAdapter dap = null;
        public static SqlDataAdapter sqlcmd = null;

        public static DataTable GetData()
        {
            DataTable tableHD = new DataTable();
            dap = new SqlDataAdapter("select * from HoaDon", conn);
            int aa = dap.Fill(tableHD);
            return tableHD;
        }

        public static void sql_run(string strsql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strsql;
            cmd.Connection = conn;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("loi" + e.ToString());
                throw;
            }
        }

        public static void insertHoadontruong(string maHoaDon, string maHD, string thang, string nam, string tienPhong, string tienDien, string tienNuoc, string tienDichVu, string trangThai)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            // Bỏ TongTien ra khỏi câu lệnh insert vì SQL tự tính hoặc không cho sửa trực tiếp
            string strsql = "insert into HoaDon (MaHoaDon, MaHD, Thang, Nam, TienPhong, TienDien, TienNuoc, TienDichVu, TrangThai) values(@maHoaDon, @maHD, @thang, @nam, @tienPhong, @tienDien, @tienNuoc, @tienDichVu, @trangThai)";
            cmd.CommandText = strsql;
            cmd.Connection = conn;

            cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
            cmd.Parameters.AddWithValue("@maHD", maHD);
            cmd.Parameters.AddWithValue("@thang", thang);
            cmd.Parameters.AddWithValue("@nam", nam);
            cmd.Parameters.AddWithValue("@tienPhong", tienPhong);
            cmd.Parameters.AddWithValue("@tienDien", tienDien);
            cmd.Parameters.AddWithValue("@tienNuoc", tienNuoc);
            cmd.Parameters.AddWithValue("@tienDichVu", tienDichVu);
            cmd.Parameters.AddWithValue("@trangThai", trangThai);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.ToString());
                throw;
            }
        }

        static public void updateHoadontruong(string maHoaDon, string maHD, string thang, string nam, string tienPhong, string tienDien, string tienNuoc, string tienDichVu, string trangThai)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            // Bỏ TongTien ra khỏi câu lệnh update
            string strsql = "update HoaDon set MaHD=@maHD, Thang=@thang, Nam=@nam, TienPhong=@tienPhong, TienDien=@tienDien, TienNuoc=@tienNuoc, TienDichVu=@tienDichVu, TrangThai=@trangThai where MaHoaDon=@maHoaDon";
            cmd.CommandText = strsql;
            cmd.Connection = conn;

            cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
            cmd.Parameters.AddWithValue("@maHD", maHD);
            cmd.Parameters.AddWithValue("@thang", thang);
            cmd.Parameters.AddWithValue("@nam", nam);
            cmd.Parameters.AddWithValue("@tienPhong", tienPhong);
            cmd.Parameters.AddWithValue("@tienDien", tienDien);
            cmd.Parameters.AddWithValue("@tienNuoc", tienNuoc);
            cmd.Parameters.AddWithValue("@tienDichVu", tienDichVu);
            cmd.Parameters.AddWithValue("@trangThai", trangThai);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.ToString());
                throw;
            }
        }

        static public void deleteHoadontruong(string maHoaDon)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            string strsql = "delete from HoaDon where MaHoaDon=@maHoaDon";
            cmd.CommandText = strsql;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Loi: " + e.ToString());
                throw;
            }
        }
    }
}
