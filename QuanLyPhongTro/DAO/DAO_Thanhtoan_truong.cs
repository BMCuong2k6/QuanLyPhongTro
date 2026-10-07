using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QuanLyPhongTro.DAO
{
    internal class DAO_Thanhtoan_truong
    {
        public static SqlConnection conn = Connection.open();

        // 1. Lấy danh sách toàn bộ bảng ThanhToan lên DataGridView
        public static DataTable GetData()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ThanhToan", conn);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu thanh toán: " + ex.Message);
            }
            return dt;
        }

        // 2. Thêm mới một bản ghi thanh toán
        public static void insertThanhToan(string maThanhToan, string maHoaDon, string ngayThanhToan, string soTien, string phuongThuc, string trangThai)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            string strsql = "INSERT INTO ThanhToan (MaThanhToan, MaHoaDon, NgayThanhToan, SoTien, PhuongThuc, TrangThai) " +
                            "VALUES (@maThanhToan, @maHoaDon, @ngayThanhToan, @soTien, @phuongThuc, @trangThai)";
            cmd.CommandText = strsql;
            cmd.Connection = conn;

            cmd.Parameters.AddWithValue("@maThanhToan", maThanhToan);
            cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
            cmd.Parameters.AddWithValue("@ngayThanhToan", ngayThanhToan);
            cmd.Parameters.AddWithValue("@soTien", soTien);
            cmd.Parameters.AddWithValue("@phuongThuc", phuongThuc);
            cmd.Parameters.AddWithValue("@trangThai", trangThai);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi thêm thanh toán: " + e.ToString());
                throw;
            }
        }

        // 3. Cập nhật thông tin thanh toán
        public static int updateThanhtoan (string maThanhToan, string maHoaDon, string ngayThanhToan, string soTien, string phuongThuc, string trangThai)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            string strsql = "UPDATE ThanhToan SET MaHoaDon=@maHoaDon, NgayThanhToan=@ngayThanhToan, SoTien=@soTien, PhuongThuc=@phuongThuc, TrangThai=@trangThai WHERE MaThanhToan=@maThanhToan";
            cmd.CommandText = strsql;
            cmd.Connection = conn;

            cmd.Parameters.AddWithValue("@maThanhToan", maThanhToan);
            cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
            cmd.Parameters.AddWithValue("@ngayThanhToan", ngayThanhToan);
            cmd.Parameters.AddWithValue("@soTien", soTien);
            cmd.Parameters.AddWithValue("@phuongThuc", phuongThuc);
            cmd.Parameters.AddWithValue("@trangThai", trangThai);

            try
            {
                int kq = cmd.ExecuteNonQuery();
                return kq;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message);
                throw;
            }
        }

        // 4. Xóa bản ghi thanh toán theo Mã thanh toán
        public static void deleteThanhToan(string maThanhToan)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            string strsql = "DELETE FROM ThanhToan WHERE MaThanhToan=@maThanhToan";
            cmd.CommandText = strsql;
            cmd.Connection = conn;

            cmd.Parameters.AddWithValue("@maThanhToan", maThanhToan);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi xóa thanh toán: " + e.ToString());
                throw;
            }
        }
    }
}
