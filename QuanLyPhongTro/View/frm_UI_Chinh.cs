using QuanLyPhongTro;
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
                formHienTai.Dispose();// Giải phóng tài nguyên của Form cũ
            }

            formHienTai = formCon;// Cập nhật Form đang hiển thị

            // Chỉ hiển thị trong pnlContent
            formCon.TopLevel = false;// Đặt TopLevel = false để Form con không phải là Form cấp cao nhất
            formCon.FormBorderStyle = FormBorderStyle.None;// Loại bỏ viền của Form con
            formCon.Dock = DockStyle.Fill;// Đặt DockStyle.Fill để Form con chiếm toàn bộ pnlContent

            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(formCon);

            formCon.Show();
        }
        private void doimaubutton(Button btn)
        {
            Color MauMacDinh = Color.DarkBlue;
            Color MauKhiChon = Color.Blue;
            Button[] DSNut = { btnTrangChu, btnPhong, btnHoaDon,
                btnThanhToan, btn_QLYTaiKhoan, btnHopDong,
                btnKhachThue };
            // Đưa tất cả nút về màu mặc định
            foreach (Button nut in DSNut)// Duyệt qua tất cả các nút trong mảng DSNut
            {
                nut.BackColor = MauMacDinh;
                nut.ForeColor = Color.White;
                nut.FlatStyle = FlatStyle.Flat;
                nut.FlatAppearance.BorderSize = 0;
            }

            // Đổi màu nút đang được chọn
            btn.BackColor = MauKhiChon;
            btn.ForeColor = Color.White;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            doimaubutton(btnTrangChu);
            MoFormCon(new frm_TongQuan());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            doimaubutton(btnHopDong);
            MoFormCon(new frm_HopDong_Truong());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            doimaubutton(btnHoaDon);
            MoFormCon(new frm_HoaDontruong());
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            doimaubutton(btnThanhToan);
            MoFormCon(new frm_ThanhToan());
        }

        private void btn_QLYTaiKhoan_Click(object sender, EventArgs e)
        {
            doimaubutton(btn_QLYTaiKhoan);
            MoFormCon(new frm_QLyTaiKhoan());
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            doimaubutton(btnPhong);
            MoFormCon(new frm_Phong_Quan());
        }

        private void frm_UI_Chinh_Load(object sender, EventArgs e)
        {
            doimaubutton(btnTrangChu);
            MoFormCon(new frm_TongQuan());
        }

        private void btnKhachThue_Click(object sender, EventArgs e)
        {
            doimaubutton(btnKhachThue);
            MoFormCon(new frm_KhachThue_Quan());
        }



        private void btnThongKe_Click(object sender, EventArgs e)
        {

        }

        private void panel_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_LoaiPhong_Click(object sender, EventArgs e)
        {
            //doimaubutton(btn_LoaiPhong);
        }
    }
}
