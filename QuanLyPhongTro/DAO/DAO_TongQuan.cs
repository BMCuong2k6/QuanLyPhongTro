using Microsoft.Data.SqlClient;
using System.Data;

namespace QuanLyPhongTro.DAO
{
    internal class DAO_TongQuan
    {
        public static SqlConnection conn = Connection.open();
        public static SqlDataAdapter dap = null;
        public static SqlDataAdapter cmd = null;
        // Lấy danh sách hóa đơn gần đây để hiển thị ở trang tổng quan
        public static DataTable LayHoaDonGanDay()
        {
            DataTable bangHoaDon = new DataTable();

            string cauLenh = @"
                SELECT TOP (8)
                    MaHoaDon,
                    MaHD,
                    Thang,
                    Nam,
                    TongTien,
                    TrangThai
                FROM HoaDon
                ORDER BY Nam DESC, Thang DESC, MaHoaDon DESC";

            // Connection.open() đã mở kết nối nên không gọi Open() lần nữa
            using (SqlConnection ketNoi = Connection.open())
            using (SqlDataAdapter boNapDuLieu = new SqlDataAdapter(cauLenh, ketNoi))
            {
                boNapDuLieu.Fill(bangHoaDon);
            }

            return bangHoaDon;
        }

        public static int DemSoPhongTrong()
        {
            string query = @"
        SELECT COUNT(*)
        FROM Phong
        WHERE LTRIM(RTRIM(TrangThai)) = N'Trống'";

            using (SqlConnection conn = Connection.open())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static int DemSoPhongDangThue()
        {
            string query = @"
        SELECT COUNT(*)
        FROM Phong
        WHERE LTRIM(RTRIM(TrangThai)) = N'Đang thuê'";

            using (SqlConnection conn = Connection.open())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static int DemTongSoPhong()
        {
            string query = "SELECT COUNT(maPhong) FROM Phong";

            using (SqlConnection conn = Connection.open())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static int DemSoKhachThue()
        {
            string query = "SELECT COUNT(maNguoiThue) FROM KhachThue";

            using (SqlConnection conn = Connection.open())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static decimal TinhTongDoanhThu()
        {
            string query = @"
        SELECT COALESCE(SUM(TongTien), 0)
        FROM HoaDon
        WHERE LTRIM(RTRIM(TrangThai)) = N'Đã thanh toán'";

            using (SqlConnection conn = Connection.open())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }

    }
}
