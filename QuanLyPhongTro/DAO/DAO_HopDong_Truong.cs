using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QuanLyPhongTro.DAO
{
    internal class DAO_HopDong_Truong
    {
        private static SqlConnection conn = Connection.open();

        // 1. Lấy dữ liệu lên DataGridView
        public static DataTable GetData()
        {
            string query = "SELECT MaHD, MaPhong, MaKhach, NgayBatDau, NgayKetThuc, TienCoc, TrangThai FROM HopDong";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // 2. Thêm hợp đồng
        public static void insertHopDong(string maHD, string maPhong, string maKhach, string ngayBatDau, string ngayKetThuc, string tienCoc, string trangThai)
        {
            string sql = @"INSERT INTO HopDong (MaHD, MaPhong, MaKhach, NgayBatDau, NgayKetThuc, TienCoc, TrangThai) 
                           VALUES (@MaHD, @MaPhong, @MaKhach, @NgayBatDau, @NgayKetThuc, @TienCoc, @TrangThai)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaHD", maHD);
            cmd.Parameters.AddWithValue("@MaPhong", maPhong);
            cmd.Parameters.AddWithValue("@MaKhach", maKhach);

            // Bắt null cho ngày bắt đầu
            if (string.IsNullOrEmpty(ngayBatDau))
                cmd.Parameters.AddWithValue("@NgayBatDau", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);

            // Bắt null cho ngày kết thúc (tránh lỗi convert date sang SQL)
            if (string.IsNullOrEmpty(ngayKetThuc))
                cmd.Parameters.AddWithValue("@NgayKetThuc", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);

            cmd.Parameters.AddWithValue("@TienCoc", tienCoc);
            cmd.Parameters.AddWithValue("@TrangThai", trangThai);

            cmd.ExecuteNonQuery();
        }

        // 3. Sửa hợp đồng (trả về kiểu int để kiểm tra kq > 0)
        public static int updateHopDong(string maHD, string maPhong, string maKhach, string ngayBatDau, string ngayKetThuc, string tienCoc, string trangThai)
        {
            string sql = @"UPDATE HopDong 
                           SET MaPhong = @MaPhong, MaKhach = @MaKhach, NgayBatDau = @NgayBatDau, 
                               NgayKetThuc = @NgayKetThuc, TienCoc = @TienCoc, TrangThai = @TrangThai 
                           WHERE MaHD = @MaHD";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaHD", maHD);
            cmd.Parameters.AddWithValue("@MaPhong", maPhong);
            cmd.Parameters.AddWithValue("@MaKhach", maKhach);

            if (string.IsNullOrEmpty(ngayBatDau))
                cmd.Parameters.AddWithValue("@NgayBatDau", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);

            if (string.IsNullOrEmpty(ngayKetThuc))
                cmd.Parameters.AddWithValue("@NgayKetThuc", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);

            cmd.Parameters.AddWithValue("@TienCoc", tienCoc);
            cmd.Parameters.AddWithValue("@TrangThai", trangThai);

            int kq = cmd.ExecuteNonQuery();
            return kq;
        }

        // 4. Xóa hợp đồng
        public static void deleteHopDong(string maHD)
        {
            string sql = "DELETE FROM HopDong WHERE MaHD = @MaHD";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaHD", maHD);
            cmd.ExecuteNonQuery();
        }
    }
}
