using QuanLyPhongTro.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyPhongTro.View
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void txt_TaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tk = txt_TaiKhoan.Text.Trim();
            string mk = txt_MatKhau.Text.Trim();
            // 1. Kiểm tra đầu vào rỗng
            if (string.IsNullOrEmpty(tk) || string.IsNullOrEmpty(mk))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Gọi hàm kiểm tra từ file riêng
                bool i = DAO_DangNhap_Cuong.KiemTraDangNhap(tk, mk);

                if (i)
                {
                    //MessageBox.Show("Đăng nhập thành công!","Thông báo",
                    //MessageBoxButtons.OK,
                    //MessageBoxIcon.Information);

                    this.Hide(); // Ẩn form đăng nhập
                    frm_UI_Chinh frmChinh = new frm_UI_Chinh();
                    frmChinh.ShowDialog(); // Hiển thị form chính
                    frmChinh = null; // Giải phóng bộ nhớ
                    this.Close(); // Đóng form đăng nhập

                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!",
                        "Lỗi đăng nhập",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkB_HienMK_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkB_HienMK.Checked)
            {
                txt_MatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_MatKhau.UseSystemPasswordChar = true;
            }
        }

        private void linkLbl_QuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_QuenMK frmQuenMK = new frm_QuenMK();
            frmQuenMK.ShowDialog();
        }

        private void linkLbl_DKTK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_DangKyTK frmDangKyTK = new frm_DangKyTK();
            frmDangKyTK.ShowDialog();
        }
    }
}
