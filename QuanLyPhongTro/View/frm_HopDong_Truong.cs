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
    public partial class frm_HopDong_Truong : Form
    {
        public frm_HopDong_Truong()
        {
            InitializeComponent();
            LoadHopDong();
            ResetForm();
        }
        public void LoadHopDong()
        {
            dgvHopDong.DataSource = DAO_HopDong_Truong.GetData();

            if (dgvHopDong.Columns.Count >= 7)
            {
                dgvHopDong.Columns[0].HeaderText = "Mã HĐ";
                dgvHopDong.Columns[1].HeaderText = "Mã Phòng";
                dgvHopDong.Columns[2].HeaderText = "Mã Khách";
                dgvHopDong.Columns[3].HeaderText = "Ngày Bắt Đầu";
                dgvHopDong.Columns[4].HeaderText = "Ngày Kết Thúc";
                dgvHopDong.Columns[5].HeaderText = "Tiền Cọc";
                dgvHopDong.Columns[6].HeaderText = "Trạng Thái";
            }
        }

        // 2. Hàm dọn sạch form (Làm mới)
        private void ResetForm()
        {
            txtMhd.Clear();
            txtMp.Clear();
            txtMk.Clear();
            txtTc.Clear();

            dtpNbd.Value = DateTime.Now;
            dtpNkt.Checked = false; // Bỏ chọn để hiểu là NULL
            cbTt.SelectedIndex = -1;

            txtMhd.ReadOnly = false; // Mở khóa mã hợp đồng để nhập mới
            txtMhd.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMhd.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập Mã Hợp Đồng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMhd.Focus();
                return;
            }

            try
            {
                string ngayBatDau = dtpNbd.Value.ToString("yyyy-MM-dd");
                string ngayKetThuc = dtpNkt.Checked ? dtpNkt.Value.ToString("yyyy-MM-dd") : "";

                DAO_HopDong_Truong.insertHopDong(
                    txtMhd.Text.Trim(),
                    txtMp.Text.Trim(),
                    txtMk.Text.Trim(),
                    ngayBatDau,
                    ngayKetThuc,
                    txtTc.Text.Trim(),
                    cbTt.Text.Trim()
                );

                MessageBox.Show("Thêm hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHopDong();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại, lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHopDong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHopDong.Rows[e.RowIndex];

                txtMhd.Text = row.Cells[0].Value?.ToString();
                txtMp.Text = row.Cells[1].Value?.ToString();
                txtMk.Text = row.Cells[2].Value?.ToString();

                // Đổ ngày bắt đầu
                if (row.Cells[3].Value != null && row.Cells[3].Value != DBNull.Value && !string.IsNullOrEmpty(row.Cells[3].Value.ToString()))
                {
                    dtpNbd.Value = Convert.ToDateTime(row.Cells[3].Value);
                }

                // Đổ ngày kết thúc (kiểm tra NULL)
                if (row.Cells[4].Value != null && row.Cells[4].Value != DBNull.Value && !string.IsNullOrEmpty(row.Cells[4].Value.ToString()))
                {
                    dtpNbd.Checked = true;
                    dtpNkt.Value = Convert.ToDateTime(row.Cells[4].Value);
                }
                else
                {
                    dtpNkt.Checked = false; // Hợp đồng chưa hết hạn -> Bỏ tích
                }

                txtTc.Text = row.Cells[5].Value?.ToString();
                cbTt.Text = row.Cells[6].Value?.ToString();

                txtMhd.ReadOnly = true; // Đang chọn xem/sửa thì khóa ô mã lại
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ResetForm();
            LoadHopDong();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMhd.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn hợp đồng cần sửa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string ngayBatDau = dtpNbd.Value.ToString("yyyy-MM-dd");
                string ngayKetThuc = dtpNkt.Checked ? dtpNkt.Value.ToString("yyyy-MM-dd") : "";

                int kq = DAO_HopDong_Truong.updateHopDong(
                    txtMhd.Text.Trim(),
                    txtMp.Text.Trim(),
                    txtMk.Text.Trim(),
                    ngayBatDau,
                    ngayKetThuc,
                    txtTc.Text.Trim(),
                    cbTt.Text.Trim()
                );

                if (kq > 0)
                {
                    MessageBox.Show("Cập nhật hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHopDong();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hợp đồng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại, lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMhd.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn hợp đồng cần xóa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa hợp đồng " + txtMhd.Text.Trim() + " không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    DAO_HopDong_Truong.deleteHopDong(txtMhd.Text.Trim());
                    MessageBox.Show("Xóa hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHopDong();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại, lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
