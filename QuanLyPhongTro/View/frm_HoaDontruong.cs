using QuanLyPhongTro.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    public partial class frm_HoaDontruong : Form
    {
        string maCu = "";
        public frm_HoaDontruong()
        {
            InitializeComponent();
            LoadHoadontruong();
        }
        public void LoadHoadontruong()
        {
            dgvHoaDon.DataSource = DAO_Hoadontruong.GetData();

            // Đặt lại tên hiển thị cột cho đẹp và dễ đọc
            dgvHoaDon.Columns[0].HeaderText = "Mã Hóa Đơn";
            dgvHoaDon.Columns[1].HeaderText = "Mã Hợp Đồng";
            dgvHoaDon.Columns[2].HeaderText = "Tháng";
            dgvHoaDon.Columns[3].HeaderText = "Năm";
            dgvHoaDon.Columns[4].HeaderText = "Tiền Phòng";
            dgvHoaDon.Columns[5].HeaderText = "Tiền Điện";
            dgvHoaDon.Columns[6].HeaderText = "Tiền Nước";
            dgvHoaDon.Columns[7].HeaderText = "Tiền Dịch Vụ";
            dgvHoaDon.Columns[8].HeaderText = "Tổng Tiền";
            dgvHoaDon.Columns[9].HeaderText = "Trạng Thái";

            // Chỉnh độ rộng các cột tùy ý (ví dụ)
            dgvHoaDon.Columns[0].Width = 100;
            dgvHoaDon.Columns[1].Width = 100;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHoaDon.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần sửa từ bảng danh sách!");
                return;
            }

            // Gọi hàm update từ DAO_HoaDon (không cần hàm insert nữa)
            DAO_Hoadontruong.updateHoadontruong(
    txtMaHoaDon.Text.Trim(), // 1. Mã mới
    maCu,                    // 2. Mã cũ (để WHERE)
    cbMaHD.Text.Trim(),      // 3. Mã hợp đồng
    txtThang.Text.Trim(),    // 4. Tháng
    txtNam.Text.Trim(),      // 5. Năm
    txtTienPhong.Text.Trim(),// 6. Tiền phòng
    txtTienDien.Text.Trim(), // 7. Tiền điện
    txtTienNuoc.Text.Trim(), // 8. Tiền nước
    txtTienDichVu.Text.Trim(),// 9. Tiền dịch vụ
    cbTrangThai.Text.Trim()  // 10. Trạng thái 
            );

            MessageBox.Show("Cập nhật hóa đơn thành công!");
            LoadHoadontruong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHoaDon.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa!");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn " + txtMaHoaDon.Text + " này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                DAO_Hoadontruong.deleteHoadontruong(txtMaHoaDon.Text);
                MessageBox.Show("Xóa hóa đơn thành công!");
                LoadHoadontruong();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frm_HoaDontruong_Load(object sender, EventArgs e)
        {
            // Để trống cũng được, vì mình đã gọi ở constructor rồi
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Lấy dữ liệu từ các ô TextBox / Control trên form của bạn
                string maHoaDon = txtMaHoaDon.Text.Trim();
                string maHD = cbMaHD.Text.Trim();
                string thang = txtThang.Text.Trim();
                string nam = txtNam.Text.Trim();
                string tienPhong = txtTienPhong.Text.Trim();
                string tienDien = txtTienDien.Text.Trim();
                string tienNuoc = txtTienNuoc.Text.Trim();
                string tienDichVu = txtTienDichVu.Text.Trim();
                string trangThai = cbTrangThai.Text.Trim();

                // 2. Kiểm tra xem đã nhập đủ mã hóa đơn chưa
                if (string.IsNullOrEmpty(maHoaDon))
                {
                    MessageBox.Show("Vui lòng nhập mã hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaHoaDon.Focus();
                    return;
                }

                // 3. Gọi hàm Insert đã viết sẵn trong lớp DAO
                DAO_Hoadontruong.insertHoadontruong(maHoaDon, maHD, thang, nam, tienPhong, tienDien, tienNuoc, tienDichVu, trangThai);

                // 4. Thông báo thành công và load lại dữ liệu lên DataGridView
                MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Gọi lại hàm load dữ liệu bảng hóa đơn lên dgvHoaDon mà lúc nãy chúng ta vừa làm
                dgvHoaDon.DataSource = DAO_Hoadontruong.GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại, lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];

                // Đổ dữ liệu từ các cột trên lưới lên các ô TextBox/ComboBox tương ứng ở trên
                txtMaHoaDon.Text = row.Cells[0].Value.ToString(); // Hoặc dùng tên cột: row.Cells["MaHoaDon"].Value.ToString()
                cbMaHD.Text = row.Cells[1].Value.ToString();
                txtThang.Text = row.Cells[2].Value.ToString();
                txtNam.Text = row.Cells[3].Value.ToString();
                txtTienPhong.Text = row.Cells[4].Value.ToString();
                txtTienDien.Text = row.Cells[5].Value.ToString();
                txtTienNuoc.Text = row.Cells[6].Value.ToString();
                txtTienDichVu.Text = row.Cells[7].Value.ToString();

                // Cột 8 là Tổng Tiền (nếu có ô hiển thị tổng tiền thì gán vào, không thì thôi)

                cbTrangThai.Text = row.Cells[9].Value.ToString();
            }
        }

        private void txtMaHoaDon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
