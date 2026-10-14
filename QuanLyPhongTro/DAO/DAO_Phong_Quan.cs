using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace QuanLyPhongTro.DAO
{
    internal class DAO_Phong_Quan
    {
        // =========================
        // LẤY TẤT CẢ PHÒNG
        // =========================
        public static DataTable GetAllPhong()
        {
            string query = "SELECT * FROM Phong";

            using (SqlConnection conn = Connection.open())
            {
                conn.Open();

                using (SqlDataAdapter adapter =
                       new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        // =========================
        // THÊM PHÒNG
        // MaPhong là IDENTITY nên không truyền vào
        // =========================
        public bool ThemPhong(
            string tenPhong,
            string loaiPhong,
            decimal giaPhong,
            string trangThai)
        {
            string query = @"
                INSERT INTO Phong
                (
                    TenPhong,
                    LoaiPhong,
                    GiaPhong,
                    TrangThai
                )
                VALUES
                (
                    @TenPhong,
                    @LoaiPhong,
                    @GiaPhong,
                    @TrangThai
                )";

            using (SqlConnection conn = Connection.open())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TenPhong", tenPhong);
                cmd.Parameters.AddWithValue("@LoaiPhong", loaiPhong);
                cmd.Parameters.AddWithValue("@GiaPhong", giaPhong);
                cmd.Parameters.AddWithValue("@TrangThai", trangThai);

                conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // =========================
        // SỬA PHÒNG
        // =========================
        public bool UpdatePhong(
            int maPhong,
            string tenPhong,
            string loaiPhong,
            decimal giaPhong,
            string trangThai)
        {
            string query = @"
                UPDATE Phong
                SET
                    TenPhong = @TenPhong,
                    LoaiPhong = @LoaiPhong,
                    GiaPhong = @GiaPhong,
                    TrangThai = @TrangThai
                WHERE MaPhong = @MaPhong";

            using (SqlConnection conn = Connection.open())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                cmd.Parameters.AddWithValue("@TenPhong", tenPhong);
                cmd.Parameters.AddWithValue("@LoaiPhong", loaiPhong);
                cmd.Parameters.AddWithValue("@GiaPhong", giaPhong);
                cmd.Parameters.AddWithValue("@TrangThai", trangThai);

                conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // =========================
        // XÓA PHÒNG
        // =========================
        public bool DeletePhong(int maPhong)
        {
            string query =
                "DELETE FROM Phong WHERE MaPhong = @MaPhong";

            using (SqlConnection conn = Connection.open())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaPhong", maPhong);

                conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public DataTable GetPhongByMaPhong(int maPhong)
        {
            string query = @"
        SELECT MaPhong, TenPhong, LoaiPhong, GiaPhong, TrangThai
        FROM Phong
        WHERE MaPhong = @MaPhong";

            using (SqlConnection conn = Connection.open())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@MaPhong", SqlDbType.Int).Value = maPhong;

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }






        // =========================
        // KIỂM TRA PHÒNG ĐANG THUÊ
        // =========================
        public bool IsPhongDangThue(int maPhong)
        {
            string query = @"
                SELECT COUNT(*)
                FROM Phong
                WHERE MaPhong = @MaPhong
                AND TrangThai = N'Đang thuê'";

            using (SqlConnection conn = Connection.open())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaPhong", maPhong);

                conn.Open();

                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        // =========================
        // TÌM KIẾM PHÒNG
        // =========================
        public DataTable SearchPhong(string keyword)
        {
            string query = @"
                SELECT *
                FROM Phong
                WHERE
                    CAST(MaPhong AS NVARCHAR) LIKE @Keyword
                    OR TenPhong LIKE @Keyword
                    OR LoaiPhong LIKE @Keyword
                    OR TrangThai LIKE @Keyword";

            using (SqlConnection conn = Connection.open())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue(
                    "@Keyword",
                    "%" + keyword + "%");

                using (SqlDataAdapter adapter =
                       new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        // =========================
        // KIỂM TRA MÃ PHÒNG
        // =========================
        public bool CheckMaPhong(int maPhong)
        {
            string query = @"
                SELECT COUNT(*)
                FROM Phong
                WHERE MaPhong = @MaPhong";

            using (SqlConnection conn = Connection.open())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaPhong", maPhong);

                conn.Open();

                return Convert.ToInt32(
                    cmd.ExecuteScalar()) > 0;
            }
        }

        // =========================
        // LẤY PHÒNG THEO TRẠNG THÁI
        // =========================
        public DataTable GetPhongByTrangThai(
            string trangThai)
        {
            string query = @"
                SELECT *
                FROM Phong
                WHERE TrangThai = @TrangThai";

            using (SqlConnection conn = Connection.open())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue(
                    "@TrangThai",
                    trangThai);

                using (SqlDataAdapter adapter =
                       new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        // =========================
        // ĐẾM PHÒNG THEO TRẠNG THÁI
        // =========================
        public int CountPhongByTrangThai(
            string trangThai)
        {
            string query = @"
                SELECT COUNT(*)
                FROM Phong
                WHERE TrangThai = @TrangThai";

            using (SqlConnection conn = Connection.open())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue(
                    "@TrangThai",
                    trangThai);

                conn.Open();

                return Convert.ToInt32(
                    cmd.ExecuteScalar());
            }
        }

        // =========================
        // CẬP NHẬT TRẠNG THÁI
        // =========================

        public bool UpdateTrangThaiPhong(int maPhong, string trangThai)
        {
            string query = @"
        UPDATE Phong
        SET TrangThai = @TrangThai
        WHERE MaPhong = @MaPhong";

            using (SqlConnection conn = Connection.open())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@MaPhong", SqlDbType.Int).Value = maPhong;
                cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar, 50).Value = trangThai;

                conn.Open();

                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
        }




    }
}
