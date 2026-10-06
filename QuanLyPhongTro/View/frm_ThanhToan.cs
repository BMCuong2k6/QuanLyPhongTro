using QuanLyPhongTro.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyPhongTro.View 
{
    public partial class frm_ThanhToan : Form
    {
        public frm_ThanhToan()
        {
            InitializeComponent();
            LoadThanhToan();
        }
        public void LoadThanhToan()
        {
            dgvThanhtoan.DataSource = DAO_Thanhtoan_truong.GetData();

            // Đặt lại tên hiển thị các cột khớp với bảng ThanhToan trong SQL
            dgvThanhtoan.Columns[0].HeaderText = "Mã Thanh Toán";
            dgvThanhtoan.Columns[1].HeaderText = "Mã Hóa Đơn";
            dgvThanhtoan.Columns[2].HeaderText = "Ngày Thanh Toán";
            dgvThanhtoan.Columns[3].HeaderText = "Số Tiền";
            dgvThanhtoan.Columns[4].HeaderText = "Phương Thức";
            dgvThanhtoan.Columns[5].HeaderText = "Trạng Thái";

            // Chỉnh độ rộng các cột tùy ý
            dgvThanhtoan.Columns[0].Width = 120;
            dgvThanhtoan.Columns[1].Width = 100;
        }

        private void frm_ThanhToan_Load(object sender, EventArgs e)
        {
            // Để trống hoặc gọi LoadThanhToan(); ở đây cũng được
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Lấy dữ liệu từ các ô control trên form
                string maThanhToan = txtMtt.Text.Trim();
                string maHoaDon = txtHd.Text.Trim(); // Hoặc txtMaHD tùy thiết kế của bạn
                string ngayThanhToan = DateTime.Now.ToString("yyyy-MM-dd"); // Hoặc lấy từ DateTimePicker nếu có
                string soTien = txtSt.Text.Trim();
                string phuongThuc = cbPt.Text.Trim();
                string trangThai = cbTt.Text.Trim();

                // 2. Kiểm tra xem đã nhập đủ mã thanh toán chưa
                if (string.IsNullOrEmpty(maThanhToan))
                {
                    MessageBox.Show("Vui lòng nhập mã thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMtt.Focus();
                    return;
                }

                // 3. Gọi hàm insert trong lớp DAO_Thanhtoan_truong
                DAO_Thanhtoan_truong.insertThanhToan(maThanhToan, maHoaDon, ngayThanhToan, soTien, phuongThuc, trangThai);

                // 4. Thông báo và load lại lưới
                MessageBox.Show("Thêm thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadThanhToan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại, lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMtt.Text))
            {
                MessageBox.Show("Vui lòng chọn bản ghi thanh toán cần sửa từ bảng danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string ngayThanhToan = DateTime.Now.ToString("yyyy-MM-dd");

                DAO_Thanhtoan_truong.updateThanhToan(
                    txtMtt.Text.Trim(),
                    txtHd.Text.Trim(),
                    ngayThanhToan,
                    txtSt.Text.Trim(),
                    cbPt.Text.Trim(),
                    cbTt.Text.Trim()
                );

                MessageBox.Show("Cập nhật thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadThanhToan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại, lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMtt.Text))
            {
                MessageBox.Show("Vui lòng chọn bản ghi thanh toán cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa mã thanh toán " + txtMtt.Text + " này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    DAO_Thanhtoan_truong.deleteThanhToan(txtMtt.Text.Trim());
                    MessageBox.Show("Xóa thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadThanhToan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại, lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
