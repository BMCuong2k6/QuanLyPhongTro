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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_HopDong_Truong frm = new frm_HopDong_Truong();
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_HoaDontruong frm = new frm_HoaDontruong();
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_ThanhToan frm = new frm_ThanhToan();
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void btn_QLYTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_QLyTaiKhoan frm = new frm_QLyTaiKhoan();
            frm.ShowDialog();
            frm = null;
            this.Show();
        }
    }
}
