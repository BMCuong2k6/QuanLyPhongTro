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
    }
}
