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
    public partial class frm_Phong_Quan : Form
    {

        public frm_Phong_Quan()
        {
            InitializeComponent();
        }
        private void LoadDanhSachPhong()
        {
            dgvPhong.DataSource = DAO_Phong_Quan.GetAllPhong();
        }
        private void frm_Phong_Quan_Load(object sender, EventArgs e)
        {
            // ComboBox loại phòng
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Phòng đơn");
            comboBox2.Items.Add("Phòng đôi");


            // ComboBox trạng thái
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Trống");
            comboBox1.Items.Add("Đang thuê");
            comboBox1.Items.Add("Đang sửa");
            // ComboBox lọc trạng thái
            comboBox3.Items.Clear();

            comboBox3.Items.Add("Tất cả");
            comboBox3.Items.Add("Trống");
            comboBox3.Items.Add("Đang thuê");
            comboBox3.Items.Add("Đang sửa");

            comboBox3.SelectedIndex = 0;
            comboBox4.Items.Clear();

            comboBox4.Items.Add("Trống");
            comboBox4.Items.Add("Đang thuê");
            comboBox4.Items.Add("Đang sửa");

            comboBox4.SelectedIndex = -1;


            // Không chọn sẵn
            comboBox2.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;

            // Load danh sách phòng
            LoadDanhSachPhong();
        }

        DAO_Phong_Quan dao = new DAO_Phong_Quan();

        private void btnThemPhong(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu
                if (string.IsNullOrWhiteSpace(txtTenPhong.Text) ||
                    string.IsNullOrWhiteSpace(txtGiaPhong.Text) ||
                    string.IsNullOrWhiteSpace(comboBox2.Text) ||
                    string.IsNullOrWhiteSpace(comboBox1.Text))
                {
                    MessageBox.Show(
                        "Vui lòng điền đầy đủ thông tin phòng!",
                        "Cảnh báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Lấy dữ liệu
                string tenPhong = txtTenPhong.Text.Trim();
                string loaiPhong = comboBox2.Text.Trim();
                string trangThai = comboBox1.Text.Trim();

                // Kiểm tra giá
                if (!decimal.TryParse(
                        txtGiaPhong.Text.Trim(),
                        out decimal giaPhong))
                {
                    MessageBox.Show(
                        "Giá phòng phải là số!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    txtGiaPhong.Focus();
                    return;
                }

                // Thêm phòng
                bool kq = dao.ThemPhong(
                    tenPhong,
                    loaiPhong,
                    giaPhong,
                    trangThai);

                if (kq)
                {
                    MessageBox.Show(
                        "Thêm phòng thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadDanhSachPhong();
                    LamMoi();
                }
                else
                {
                    MessageBox.Show(
                        "Thêm phòng thất bại!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }



        private void LamMoi()
        {
            txtMaPhong.Clear();
            txtTenPhong.Clear();
            txtGiaPhong.Clear();

            comboBox2.SelectedIndex = -1; // Loại phòng
            comboBox1.SelectedIndex = -1; // Trạng thái

            txtMaPhong.Focus();
        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadDanhSachPhong();
        }


        private void dgvPhong_CellClick(
    object sender,
    DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvPhong.Rows[e.RowIndex];

            txtMaPhong.Text =
                row.Cells["MaPhong"].Value?.ToString() ?? "";

            txtTenPhong.Text =
                row.Cells["TenPhong"].Value?.ToString() ?? "";

            txtGiaPhong.Text =
                row.Cells["GiaPhong"].Value?.ToString() ?? "";

            // ĐÚNG: cột trong SQL là LoaiPhong
            comboBox2.Text =
                row.Cells["LoaiPhong"].Value?.ToString() ?? "";

            comboBox1.Text =
                row.Cells["TrangThai"].Value?.ToString() ?? "";
        }

        private void dgvPhong_CellContentClick(
    object sender,
    DataGridViewCellEventArgs e)
        {
            dgvPhong_CellClick(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đã chọn phòng
                if (string.IsNullOrWhiteSpace(txtMaPhong.Text))
                {
                    MessageBox.Show(
                        "Vui lòng chọn phòng cần sửa!",
                        "Cảnh báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Kiểm tra dữ liệu
                if (string.IsNullOrWhiteSpace(txtTenPhong.Text) ||
                    string.IsNullOrWhiteSpace(comboBox2.Text) ||
                    string.IsNullOrWhiteSpace(txtGiaPhong.Text) ||
                    string.IsNullOrWhiteSpace(comboBox1.Text))
                {
                    MessageBox.Show(
                        "Vui lòng nhập đầy đủ thông tin!",
                        "Cảnh báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Kiểm tra mã phòng
                if (!int.TryParse(
                        txtMaPhong.Text.Trim(),
                        out int maPhong))
                {
                    MessageBox.Show(
                        "Mã phòng không hợp lệ!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                string tenPhong = txtTenPhong.Text.Trim();
                string loaiPhong = comboBox2.Text.Trim();
                string trangThai = comboBox1.Text.Trim();

                // Kiểm tra giá
                if (!decimal.TryParse(
                        txtGiaPhong.Text.Trim(),
                        out decimal giaPhong))
                {
                    MessageBox.Show(
                        "Giá phòng phải là số!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    txtGiaPhong.Focus();
                    return;
                }

                // Xác nhận
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn sửa phòng này không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                bool kq = dao.UpdatePhong(
    maPhong,
    tenPhong,
    loaiPhong,
    giaPhong,
    trangThai);


                if (kq)
                {
                    MessageBox.Show(
                        "Sửa phòng thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadDanhSachPhong();
                    LamMoi();
                }
                else
                {
                    MessageBox.Show(
                        "Sửa phòng thất bại!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đã chọn phòng chưa
                if (string.IsNullOrWhiteSpace(txtMaPhong.Text))
                {
                    MessageBox.Show(
                        "Vui lòng chọn phòng cần xóa!",
                        "Cảnh báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Lấy mã phòng từ TextBox
                int maPhong;

                if (!int.TryParse(txtMaPhong.Text.Trim(), out maPhong))
                {
                    MessageBox.Show(
                        "Mã phòng không hợp lệ!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                // Kiểm tra phòng đang thuê
                if (dao.IsPhongDangThue(maPhong))
                {
                    MessageBox.Show(
                        "Phòng đang được thuê, không thể xóa!",
                        "Cảnh báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Xác nhận xóa
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa phòng này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    return;
                }

                // Thực hiện xóa
                bool kq = dao.DeletePhong(maPhong);

                if (kq)
                {
                    MessageBox.Show(
                        "Xóa phòng thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Load lại DataGridView
                    LoadDanhSachPhong();

                    // Xóa dữ liệu trên Form
                    LamMoi();
                }
                else
                {
                    MessageBox.Show(
                        "Xóa phòng thất bại!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string maPhongText = textBox1.Text.Trim();

                if (string.IsNullOrWhiteSpace(maPhongText))
                {
                    MessageBox.Show(
                        "Vui lòng nhập mã phòng cần tìm!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    textBox1.Focus();
                    return;
                }

                if (!int.TryParse(maPhongText, out int maPhong))
                {
                    MessageBox.Show(
                        "Mã phòng phải là số!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    textBox1.Focus();
                    return;
                }

                DataTable dt = dao.GetPhongByMaPhong(maPhong);

                if (dt.Rows.Count > 0)
                {
                    dgvPhong.DataSource = dt;
                }
                else
                {
                    dgvPhong.DataSource = null;

                    MessageBox.Show(
                        "Không tìm thấy phòng có mã " + maPhong,
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tìm kiếm: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }






        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Chưa có lựa chọn
                if (comboBox3.SelectedIndex == -1)
                    return;

                string trangThai = comboBox3.SelectedItem.ToString();

                // Chọn Tất cả
                if (trangThai == "Tất cả")
                {
                    LoadDanhSachPhong();
                    return;
                }

                // Lấy danh sách phòng theo trạng thái
                DataTable dt = dao.GetPhongByTrangThai(trangThai);

                // Hiển thị lên DataGridView
                dgvPhong.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi lọc phòng: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBox1.Text.Trim(), out int maPhong))
                {
                    MessageBox.Show("Mã phòng phải là số!");
                    return;
                }

                if (comboBox4.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn trạng thái mới!");
                    return;
                }

                string trangThaiMoi = comboBox4.Text.Trim();

                bool kq = dao.UpdateTrangThaiPhong(
                    maPhong,
                    trangThaiMoi);

                if (kq)
                {
                    MessageBox.Show(
                        "Cập nhật trạng thái thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadDanhSachPhong();
                }
                else
                {
                    MessageBox.Show(
                        "Không tìm thấy phòng có mã " + maPhong,
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi cập nhật: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }



    }
}



           