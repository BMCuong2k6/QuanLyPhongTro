
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace QuanLyPhongTro.DAO
{
    internal class DAO_KhachThue_Quan
    {
        private readonly string connectionString =
            @"Data Source=.;Initial Catalog=QuanLyPhongTro;Integrated Security=True;TrustServerCertificate=True";

        // HIỂN THỊ DANH SÁCH
        public DataTable GetAllKhachThue()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"SELECT MaNguoiThue, HoTen, CCCD, SDT, QueQuan
                               FROM NguoiThue";

                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // THÊM
        public bool ThemKhachThue(
            string hoTen, string cccd, string queQuan, string sdt)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO NguoiThue
                               (HoTen, CCCD, QueQuan, SDT)
                               VALUES (@HoTen, @CCCD, @QueQuan, @SDT)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100).Value = hoTen;
                    cmd.Parameters.Add("@CCCD", SqlDbType.VarChar, 20).Value = cccd;
                    cmd.Parameters.Add("@QueQuan", SqlDbType.NVarChar, 200).Value = queQuan;
                    cmd.Parameters.Add("@SDT", SqlDbType.VarChar, 20).Value = sdt;

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // SỬA
        public bool SuaKhachThue(
            int maNguoiThue, string hoTen, string cccd,
            string queQuan, string sdt)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE NguoiThue
                               SET HoTen = @HoTen,
                                   CCCD = @CCCD,
                                   QueQuan = @QueQuan,
                                   SDT = @SDT
                               WHERE MaNguoiThue = @MaNguoiThue";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaNguoiThue", SqlDbType.Int).Value = maNguoiThue;
                    cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100).Value = hoTen;
                    cmd.Parameters.Add("@CCCD", SqlDbType.VarChar, 20).Value = cccd;
                    cmd.Parameters.Add("@QueQuan", SqlDbType.NVarChar, 200).Value = queQuan;
                    cmd.Parameters.Add("@SDT", SqlDbType.VarChar, 20).Value = sdt;

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // XÓA
        public bool XoaKhachThue(int maNguoiThue)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"DELETE FROM NguoiThue
                               WHERE MaNguoiThue = @MaNguoiThue";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaNguoiThue", SqlDbType.Int).Value = maNguoiThue;

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // TÌM THEO MÃ
        public DataTable TimTheoMaNguoiThue(int maNguoiThue)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"SELECT MaNguoiThue, HoTen, CCCD, SDT, QueQuan
                               FROM NguoiThue
                               WHERE MaNguoiThue = @MaNguoiThue";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaNguoiThue", SqlDbType.Int).Value = maNguoiThue;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
