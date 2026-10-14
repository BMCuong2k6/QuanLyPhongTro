using QuanLyPhongTro;
using QuanLyPhongTro.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyPhongTro.View
{
    public partial class frm_TongQuan : Form
    {
        public frm_TongQuan()
        {
            InitializeComponent();
        }

        private void frm_TongQuan_Load(object sender, EventArgs e)
        {
            lblNgayHienTai.Text = "Ngày hiện tại: " + DateTime.Now.ToString("dd/MM/yyyy");
            LoadHoaDonGanDay();
            LoadThongKePhong();
        }
        private void LoadThongKePhong()
        {
            try
            {
                int soPhongTrong = DAO_TongQuan.DemSoPhongTrong();
                int soPhongDangThue = DAO_TongQuan.DemSoPhongDangThue();
                int tongSoPhong = DAO_TongQuan.DemTongSoPhong();
                decimal tongDoanhThu = DAO_TongQuan.TinhTongDoanhThu();
                lbl_PhongTrong.Text = soPhongTrong.ToString();
                lbl_PhongDangThue.Text = soPhongDangThue.ToString();
                lbl_TongPhong.Text = tongSoPhong.ToString();
                lbl_DoanhThu.Text = tongDoanhThu.ToString("N0") + " VND";
            }
            catch (Exception)
            {
                // Connection.open() tự thông báo khi không kết nối được; giữ form không bị đóng.
                lblTrangThaiDuLieu.Text = "Chưa tải được thống kê phòng.";
            }
        }

        // Tải danh sách hóa đơn gần đây lên DataGridView
        private void LoadHoaDonGanDay()
        {
            try
            {
                DataTable bangHoaDon = DAO_TongQuan.LayHoaDonGanDay();
                dgvHoaDonGanDay.DataSource = bangHoaDon;

                dgvHoaDonGanDay.Columns["MaHoaDon"].HeaderText = "Mã hóa đơn";
                dgvHoaDonGanDay.Columns["MaHD"].HeaderText = "Mã hợp đồng";
                dgvHoaDonGanDay.Columns["Thang"].HeaderText = "Tháng";
                dgvHoaDonGanDay.Columns["Nam"].HeaderText = "Năm";
                dgvHoaDonGanDay.Columns["TongTien"].HeaderText = "Tổng tiền";
                dgvHoaDonGanDay.Columns["TongTien"].DefaultCellStyle.Format = "N0";
                dgvHoaDonGanDay.Columns["TrangThai"].HeaderText = "Trạng thái";

                lblTrangThaiDuLieu.Text = "Đang hiển thị " + bangHoaDon.Rows.Count + " hóa đơn gần đây.";
            }
            catch (Exception)
            {
                // Connection.open() tự thông báo khi không kết nối được; giữ form không bị đóng.
                lblTrangThaiDuLieu.Text = "Chưa tải được danh sách hóa đơn.";
            }
        }

        // Mở form chức năng trong pnlContent của form chính
        private void MoFormChucNang(Form formCon)
        {
            
        }

        private void btnMoPhong_Click(object sender, EventArgs e)
        {
            MoFormChucNang(new frm_Phong_Quan());
        }

        private void btnMoKhachThue_Click(object sender, EventArgs e)
        {
            MoFormChucNang(new frm_KhachThue_Quan());
        }

        private void btnMoHopDong_Click(object sender, EventArgs e)
        {
            MoFormChucNang(new frm_HopDong_Truong());
        }

        private void btnMoHoaDon_Click(object sender, EventArgs e)
        {
            MoFormChucNang(new frm_HoaDontruong());
        }

        private void btnMoThanhToan_Click(object sender, EventArgs e)
        {
            MoFormChucNang(new frm_ThanhToan());
        }

        private void lblHoaDonGanDay_Click(object sender, EventArgs e)
        {

        }
    }
}
