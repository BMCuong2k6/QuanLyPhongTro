
using QuanLyPhongTro.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyPhongTro.View
{
    public partial class frm_KhachThue_Quan : Form
    {
        private readonly DAO_KhachThue_Quan dao =
            new DAO_KhachThue_Quan();

        public frm_KhachThue_Quan()
        {
            InitializeComponent();
        }

        // TẢI DANH SÁCH
        private void LoadKhachThue()
        {
            try
            {
                dgvKhachThue.DataSource = dao.GetAllKhachThue();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void frm_KhachThue_Quan_Load(object sender, EventArgs e)
        {
            LoadKhachThue();
            dgvKhachThue.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvKhachThue.MultiSelect = false;
            dgvKhachThue.ReadOnly = true;
            dgvKhachThue.AllowUserToAddRows = false;
        }

        // LÀM TRỐNG Ô NHẬP
        private void LamTrong()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox2.Focus();
        }

        // THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                bool ketQua = dao.ThemKhachThue(
                    textBox2.Text.Trim(),
                    textBox5.Text.Trim(),
                    textBox3.Text.Trim(),
                    textBox4.Text.Trim());

                if (ketQua)
                {
                    MessageBox.Show("Thêm khách thuê thành công!");
                    LoadKhachThue();
                    LamTrong();
                }
                else
                {
                    MessageBox.Show("Thêm khách thuê thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm khách thuê: " + ex.Message);
            }
        }

        // SỬA

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã người thuê
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Vui lòng chọn người thuê cần sửa!");
                textBox1.Focus();
                return;
            }

            int maNguoiThue;
            if (!int.TryParse(textBox1.Text.Trim(), out maNguoiThue))
            {
                MessageBox.Show("Mã người thuê không hợp lệ!");
                textBox1.Focus();
                return;
            }

            // Kiểm tra thông tin
            if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                DAO_KhachThue_Quan dao = new DAO_KhachThue_Quan();

                bool ketQua = dao.SuaKhachThue(
                    maNguoiThue,
                    textBox2.Text.Trim(), // Họ tên
                    textBox5.Text.Trim(), // CCCD
                    textBox3.Text.Trim(), // Quê quán
                    textBox4.Text.Trim()  // Số điện thoại
                );

                if (ketQua)
                {
                    MessageBox.Show("Sửa thông tin khách thuê thành công!");
                    LoadKhachThue();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy người thuê cần sửa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa khách thuê: " + ex.Message);
            }
        }


        // XÓA

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Vui lòng chọn người thuê cần xóa!");
                textBox1.Focus();
                return;
            }

            int maNguoiThue;
            if (!int.TryParse(textBox1.Text.Trim(), out maNguoiThue))
            {
                MessageBox.Show("Mã người thuê không hợp lệ!");
                return;
            }

            DialogResult xacNhan = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa người thuê này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (xacNhan == DialogResult.Yes)
            {
                try
                {
                    DAO_KhachThue_Quan dao = new DAO_KhachThue_Quan();

                    bool ketQua = dao.XoaKhachThue(maNguoiThue);

                    if (ketQua)
                    {
                        MessageBox.Show("Xóa người thuê thành công!");

                        LoadKhachThue();

                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy người thuê cần xóa!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa người thuê: " + ex.Message);
                }
            }
        }

        // TÌM KIẾM THEO MÃ

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Vui lòng nhập mã người thuê cần tìm!");
                textBox6.Focus();
                return;
            }

            int maNguoiThue;
            if (!int.TryParse(textBox6.Text.Trim(), out maNguoiThue))
            {
                MessageBox.Show("Mã người thuê phải là số!");
                textBox6.Focus();
                return;
            }

            try
            {
                DAO_KhachThue_Quan dao = new DAO_KhachThue_Quan();

                DataTable dt = dao.TimTheoMaNguoiThue(maNguoiThue);

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvKhachThue.DataSource = dt;
                    MessageBox.Show("Tìm thấy người thuê!");
                }
                else
                {
                    dgvKhachThue.DataSource = null;
                    MessageBox.Show("Không tìm thấy người thuê có mã này!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }


        // LÀM MỚI

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // Xóa nội dung các ô nhập liệu
            textBox1.Clear(); // Mã người thuê
            textBox2.Clear(); // Họ tên
            textBox3.Clear(); // Quê quán
            textBox4.Clear(); // Số điện thoại
            textBox5.Clear(); // CCCD
            textBox6.Clear(); // Ô tìm kiếm

            // Tải lại danh sách người thuê
            LoadKhachThue();

            // Đưa con trỏ về ô mã người thuê
            textBox1.Focus();
        }


        // CHỌN DÒNG TRÊN BẢNG
        private void dataGridView1_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvKhachThue.Rows[e.RowIndex];

            textBox1.Text = row.Cells["MaNguoiThue"].Value?.ToString() ?? "";
            textBox2.Text = row.Cells["HoTen"].Value?.ToString() ?? "";
            textBox5.Text = row.Cells["CCCD"].Value?.ToString() ?? "";
            textBox4.Text = row.Cells["SDT"].Value?.ToString() ?? "";
            textBox3.Text = row.Cells["QueQuan"].Value?.ToString() ?? "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }
    }
}
