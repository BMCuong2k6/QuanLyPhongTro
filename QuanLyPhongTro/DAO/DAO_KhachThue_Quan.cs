
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace QuanLyPhongTro.DAO
{ 
    internal class DAO_KhachThue_Quan
    {
        public static SqlConnection conn = Connection.open();
        public static SqlDataAdapter dap = null;
        public static SqlDataAdapter sqlcmd = null;
       
        // HIỂN THỊ DANH SÁCH
        public DataTable GetAllKhachThue()
        {
            DataTable dt = new DataTable();
            dap = new SqlDataAdapter("SELECT MaNguoiThue, HoTen, CCCD, SDT, QueQuan FROM KhachThue", conn);
            dap.Fill(dt);
            return dt;
        }
        // THÊM
        public bool ThemKhachThue(
            string hoTen, string cccd, string queQuan, string sdt)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            string strsql = "INSERT INTO KhachThue (HoTen, CCCD, QueQuan, SDT) " +
                "VALUES (@hoTen, @cccd, @queQuan, @sdt)";
            cmd.CommandText = strsql;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@hoTen", hoTen);
            cmd.Parameters.AddWithValue("@cccd", cccd);
            cmd.Parameters.AddWithValue("@queQuan", queQuan);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            try
            {
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.ToString());
                throw;
            }

            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    string sql = @"INSERT INTO NguoiThue
            //                   (HoTen, CCCD, QueQuan, SDT)
            //                   VALUES (@HoTen, @CCCD, @QueQuan, @SDT)";

            //    using (SqlCommand cmd = new SqlCommand(sql, conn))
            //    {
            //        cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100).Value = hoTen;
            //        cmd.Parameters.Add("@CCCD", SqlDbType.VarChar, 20).Value = cccd;
            //        cmd.Parameters.Add("@QueQuan", SqlDbType.NVarChar, 200).Value = queQuan;
            //        cmd.Parameters.Add("@SDT", SqlDbType.VarChar, 20).Value = sdt;

            //        conn.Open();
            //        return cmd.ExecuteNonQuery() > 0;
            //    }
            //}
        }

        // SỬA
        public bool SuaKhachThue(
            int maNguoiThue, string hoTen, string cccd,
            string queQuan, string sdt)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            string strsql = "UPDATE KhachThue " +
                "SET HoTen = @hoTen, CCCD = @cccd, QueQuan = @queQuan, SDT = @sdt " +
                "WHERE MaNguoiThue = @maNguoiThue";
            cmd.CommandText = strsql;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@maNguoiThue", maNguoiThue);
            cmd.Parameters.AddWithValue("@hoTen", hoTen);
            cmd.Parameters.AddWithValue("@cccd", cccd);
            cmd.Parameters.AddWithValue("@queQuan", queQuan);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            try
            {
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.ToString());
                throw;
            }


            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    string sql = @"UPDATE NguoiThue
            //                   SET HoTen = @HoTen,
            //                       CCCD = @CCCD,
            //                       QueQuan = @QueQuan,
            //                       SDT = @SDT
            //                   WHERE MaNguoiThue = @MaNguoiThue";

            //    using (SqlCommand cmd = new SqlCommand(sql, conn))
            //    {
            //        cmd.Parameters.Add("@MaNguoiThue", SqlDbType.Int).Value = maNguoiThue;
            //        cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100).Value = hoTen;
            //        cmd.Parameters.Add("@CCCD", SqlDbType.VarChar, 20).Value = cccd;
            //        cmd.Parameters.Add("@QueQuan", SqlDbType.NVarChar, 200).Value = queQuan;
            //        cmd.Parameters.Add("@SDT", SqlDbType.VarChar, 20).Value = sdt;

            //        conn.Open();
            //        return cmd.ExecuteNonQuery() > 0;
            //    }
            //}
        }

        // XÓA
        public bool XoaKhachThue(int maNguoiThue)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            string strsql = "DELETE FROM KhachThue WHERE MaNguoiThue = @maNguoiThue";
            cmd.CommandText = strsql;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@maNguoiThue", maNguoiThue);
            try
            {
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.ToString());
                throw;
            }

            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    string sql = @"DELETE FROM NguoiThue
            //                   WHERE MaNguoiThue = @MaNguoiThue";

            //    using (SqlCommand cmd = new SqlCommand(sql, conn))
            //    {
            //        cmd.Parameters.Add("@MaNguoiThue", SqlDbType.Int).Value = maNguoiThue;

            //        conn.Open();
            //        return cmd.ExecuteNonQuery() > 0;
            //    }
            //}
        }

        // TÌM THEO MÃ
        public DataTable TimTheoMaNguoiThue(int maNguoiThue)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            string strsql = "SELECT MaNguoiThue, HoTen, CCCD, SDT, QueQuan " +
                "FROM KhachThue " +
                "WHERE MaNguoiThue = @maNguoiThue";
            cmd.CommandText = strsql;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@maNguoiThue", maNguoiThue);
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.ToString());
                throw;
            }

            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    string sql = @"SELECT MaNguoiThue, HoTen, CCCD, SDT, QueQuan
            //                   FROM NguoiThue
            //                   WHERE MaNguoiThue = @MaNguoiThue";

            //    using (SqlCommand cmd = new SqlCommand(sql, conn))
            //    {
            //        cmd.Parameters.Add("@MaNguoiThue", SqlDbType.Int).Value = maNguoiThue;

            //        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            //        {
            //            DataTable dt = new DataTable();
            //            da.Fill(dt);
            //            return dt;
            //        }
            //    }
            //}
        }
    }
}
