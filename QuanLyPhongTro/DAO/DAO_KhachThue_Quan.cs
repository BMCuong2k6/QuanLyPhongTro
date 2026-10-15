using Microsoft.Data.SqlClient;
using System.Data;

namespace QuanLyPhongTro.DAO
{
    internal class DAO_KhachThue_Quan
    {
        // HIỂN THỊ DANH SÁCH KHÁCH THUÊ
        public DataTable GetAllKhachThue()
        {
            using (SqlConnection conn = Connection.open())
            {
                string sql = @"SELECT MaNguoiThue, HoTen, CCCD, SDT, QueQuan
                               FROM KhachThue";

                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // THÊM KHÁCH THUÊ
        public bool ThemKhachThue(
            string hoTen,
            string cccd,
            string queQuan,
            string sdt)
        {
            string sql = @"INSERT INTO KhachThue
                           (HoTen, CCCD, QueQuan, SDT)
                           VALUES (@HoTen, @CCCD, @QueQuan, @SDT)";

            using (SqlConnection conn = Connection.open())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100).Value = hoTen;
                cmd.Parameters.Add("@CCCD", SqlDbType.VarChar, 20).Value = cccd;
                cmd.Parameters.Add("@QueQuan", SqlDbType.NVarChar, 200).Value = queQuan;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar, 20).Value = sdt;

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // SỬA KHÁCH THUÊ
        public bool SuaKhachThue(
            int maNguoiThue,
            string hoTen,
            string cccd,
            string queQuan,
            string sdt)
        {
            string sql = @"UPDATE KhachThue
                           SET HoTen = @HoTen,
                               CCCD = @CCCD,
                               QueQuan = @QueQuan,
                               SDT = @SDT
                           WHERE MaNguoiThue = @MaNguoiThue";

            using (SqlConnection conn = Connection.open())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaNguoiThue", SqlDbType.Int).Value = maNguoiThue;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100).Value = hoTen;
                cmd.Parameters.Add("@CCCD", SqlDbType.VarChar, 20).Value = cccd;
                cmd.Parameters.Add("@QueQuan", SqlDbType.NVarChar, 200).Value = queQuan;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar, 20).Value = sdt;

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // XÓA KHÁCH THUÊ
        public bool XoaKhachThue(int maNguoiThue)
        {
            string sql = @"DELETE FROM KhachThue
                           WHERE MaNguoiThue = @MaNguoiThue";

            using (SqlConnection conn = Connection.open())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaNguoiThue", SqlDbType.Int).Value = maNguoiThue;

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // TÌM KHÁCH THUÊ THEO MÃ
        public DataTable TimTheoMaNguoiThue(int maNguoiThue)
        {
            string sql = @"SELECT MaNguoiThue, HoTen, CCCD, SDT, QueQuan
                           FROM KhachThue
                           WHERE MaNguoiThue = @MaNguoiThue";

            using (SqlConnection conn = Connection.open())
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