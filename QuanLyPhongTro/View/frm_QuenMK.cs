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
    public partial class frm_QuenMK : Form
    {
        public frm_QuenMK()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            string email = txtb_email_qmk.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string l = "select * from taikhoan where Email = '" + email + "'";
            bool i = DAO_DangNhap_Cuong.kiemtraemail(email);
            if (i)
            {
                string mk = DAO_DangNhap_Cuong.laymatkhau(email);
                lbl_MatKhau.Text = mk;
            }
            else
            {
                MessageBox.Show("Email không tồn tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
