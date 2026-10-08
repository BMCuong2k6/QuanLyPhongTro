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
    public partial class frm_DangKyTK : Form
    {
        public frm_DangKyTK()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtb_TaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtb_TaiKhoan.Text;
            string matKhau = txtb_MatKhau.Text;
            string nhapLaiMatKhau = txtb_XacNhanMK.Text;
            string email = txtb_email.Text;
            // Kiểm tra mật khẩu và xác nhận mật khẩu có khớp nhau hay không
            if (matKhau != nhapLaiMatKhau)
            {
                MessageBox.Show("Mật khẩu không khớp. Vui lòng nhập lại.");
                return;
            }
            // Kiểm tra các trường có rỗng hay không
            if (txtb_TaiKhoan.Text == "" || txtb_MatKhau.Text == "" || txtb_XacNhanMK.Text == "" || txtb_email.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            // Kiểm tra xem tài khoản đã tồn tại hay chưa
            if (DAO_DangNhap_Cuong.kiemtraemail(email))
            {
                MessageBox.Show("Email đã tồn tại. Vui lòng sử dụng email khác.");
                return;
            }
            // Thêm tài khoản vào cơ sở dữ liệu
            DAO_DangNhap_Cuong.insertTaiKhoan(taiKhoan, matKhau, email);
            MessageBox.Show("Đăng ký tài khoản thành công. Quay lại trang đăng nhập.");
            this.Close();

        }

        private void checkB_HienMK_CheckedChanged(object sender, EventArgs e)
        {
            // Hiển thị hoặc ẩn mật khẩu khi checkbox được chọn hoặc bỏ chọn
            if (checkB_HienMK.Checked)
            {
                txtb_MatKhau.UseSystemPasswordChar = false;
                txtb_XacNhanMK.UseSystemPasswordChar = false;
            }
            else
            {
                txtb_MatKhau.UseSystemPasswordChar = true;
                txtb_XacNhanMK.UseSystemPasswordChar = true;
            }
        }
    }
}
