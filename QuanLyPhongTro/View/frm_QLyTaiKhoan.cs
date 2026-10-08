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
    public partial class frm_QLyTaiKhoan : Form
    {
        public frm_QLyTaiKhoan()
        {
            InitializeComponent();
            LoadTaiKhoan();
        }
        public void LoadTaiKhoan()
        {
            // Lấy dữ liệu từ DAO và gán vào DataGridView
            dgv_QLTaiKhoan.DataSource = DAO_DangNhap_Cuong.GetData();
            // Đặt lại tên hiển thị cột cho đẹp và dễ đọc
            dgv_QLTaiKhoan.Columns[0].HeaderText = "Tên Tài Khoản";
            dgv_QLTaiKhoan.Columns[1].HeaderText = "Mật Khẩu";
            dgv_QLTaiKhoan.Columns[2].HeaderText = "Email";
            // Chỉnh độ rộng các cột tùy ý (ví dụ)
            dgv_QLTaiKhoan.Columns[0].Width = 150;
            dgv_QLTaiKhoan.Columns[1].Width = 150;
            dgv_QLTaiKhoan.Columns[2].Width = 200;
        }


        private void frm_QLyTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox
            string TenTK = txtb_TenTK.Text.Trim();
            string MatKhau = txtb_MatKhau.Text.Trim();
            string Email = txtb_Email.Text.Trim();
            // Kiểm tra xem các TextBox có trống hay không
            if (string.IsNullOrEmpty(TenTK) || string.IsNullOrEmpty(MatKhau) || string.IsNullOrEmpty(Email))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Gọi hàm thêm tài khoản từ DAO
            DAO_DangNhap_Cuong.insertTaiKhoan(TenTK, MatKhau, Email);
            MessageBox.Show("Thêm tài khoản thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Load lại dữ liệu để hiển thị tài khoản mới
            LoadTaiKhoan();

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox
            string TenTK = txtb_TenTK.Text.Trim();
            string MatKhau = txtb_MatKhau.Text.Trim();
            string Email = txtb_Email.Text.Trim();
            // Kiểm tra xem các TextBox có trống hay không
            if (string.IsNullOrEmpty(TenTK) || string.IsNullOrEmpty(MatKhau) || string.IsNullOrEmpty(Email))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Gọi hàm cập nhật tài khoản từ DAO
            DAO_DangNhap_Cuong.updateTaiKhoan(TenTK, MatKhau, Email);
            MessageBox.Show("Cập nhật tài khoản thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadTaiKhoan();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            // Lấy tên tài khoản từ TextBox
            string TenTK = txtb_TenTK.Text.Trim();
            // Kiểm tra xem TextBox có trống hay không
            if (string.IsNullOrEmpty(TenTK))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Gọi hàm xóa tài khoản từ DAO
            DAO_DangNhap_Cuong.deleteTaiKhoan(TenTK);
            MessageBox.Show("Xóa tài khoản thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadTaiKhoan();
        }
    }
}
