using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyPhongTro.View
{
    public partial class frm_UI_Chinh : Form
    {
        public frm_UI_Chinh()
        {
            InitializeComponent();
        }

        // Biến để lưu Form đang hiển thị
        private Form formHienTai = null;
        // Phương thức để mở Form con trong pnlContent
        private void MoFormCon(Form formCon)
        {
            // Đóng Form đang hiển thị
            if (formHienTai != null)
            {
                formHienTai.Close();
                formHienTai.Dispose();
            }

            formHienTai = formCon;

            // Chỉ hiển thị trong pnlContent
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;

            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(formCon);

            formCon.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MoFormCon(new frm_HopDong_Truong());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            MoFormCon(new frm_HoaDontruong());
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            MoFormCon(new frm_ThanhToan());
        }

        private void btn_QLYTaiKhoan_Click(object sender, EventArgs e)
        {
            MoFormCon(new frm_QLyTaiKhoan());
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {

        }

        private void frm_UI_Chinh_Load(object sender, EventArgs e)
        {

        }
    }
}
