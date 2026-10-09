namespace QuanLyPhongTro
{
    partial class frm_HoaDontruong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_MaHD = new Label();
            lbl_MaHopDong = new Label();
            lbl_Thang = new Label();
            lbl_Nam = new Label();
            lbl_Tp = new Label();
            lbl_Td = new Label();
            lbl_Tn = new Label();
            lbl_Tdv = new Label();
            lbl_Tt = new Label();
            txtMaHoaDon = new TextBox();
            txtThang = new TextBox();
            txtNam = new TextBox();
            txtTienPhong = new TextBox();
            txtTienDien = new TextBox();
            txtTienNuoc = new TextBox();
            txtTienDichVu = new TextBox();
            cbMaHD = new ComboBox();
            cbTrangThai = new ComboBox();
            dgvHoaDon = new DataGridView();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnThem = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // lbl_MaHD
            // 
            lbl_MaHD.AutoSize = true;
            lbl_MaHD.BackColor = Color.Transparent;
            lbl_MaHD.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_MaHD.Location = new Point(12, 47);
            lbl_MaHD.Name = "lbl_MaHD";
            lbl_MaHD.Size = new Size(96, 20);
            lbl_MaHD.TabIndex = 0;
            lbl_MaHD.Text = "Mã Hóa Đơn";
            // 
            // lbl_MaHopDong
            // 
            lbl_MaHopDong.AutoSize = true;
            lbl_MaHopDong.BackColor = Color.Transparent;
            lbl_MaHopDong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_MaHopDong.Location = new Point(12, 81);
            lbl_MaHopDong.Name = "lbl_MaHopDong";
            lbl_MaHopDong.Size = new Size(106, 20);
            lbl_MaHopDong.TabIndex = 1;
            lbl_MaHopDong.Text = "Mã Hợp Đồng";
            // 
            // lbl_Thang
            // 
            lbl_Thang.AutoSize = true;
            lbl_Thang.BackColor = Color.Transparent;
            lbl_Thang.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_Thang.Location = new Point(12, 114);
            lbl_Thang.Name = "lbl_Thang";
            lbl_Thang.Size = new Size(53, 20);
            lbl_Thang.TabIndex = 2;
            lbl_Thang.Text = "Tháng";
            // 
            // lbl_Nam
            // 
            lbl_Nam.AutoSize = true;
            lbl_Nam.BackColor = Color.Transparent;
            lbl_Nam.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_Nam.Location = new Point(12, 147);
            lbl_Nam.Name = "lbl_Nam";
            lbl_Nam.Size = new Size(43, 20);
            lbl_Nam.TabIndex = 3;
            lbl_Nam.Text = "Năm";
            // 
            // lbl_Tp
            // 
            lbl_Tp.AutoSize = true;
            lbl_Tp.BackColor = Color.Transparent;
            lbl_Tp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_Tp.Location = new Point(356, 43);
            lbl_Tp.Name = "lbl_Tp";
            lbl_Tp.Size = new Size(88, 20);
            lbl_Tp.TabIndex = 4;
            lbl_Tp.Text = "Tiền Phòng";
            // 
            // lbl_Td
            // 
            lbl_Td.AutoSize = true;
            lbl_Td.BackColor = Color.Transparent;
            lbl_Td.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_Td.Location = new Point(356, 81);
            lbl_Td.Name = "lbl_Td";
            lbl_Td.Size = new Size(75, 20);
            lbl_Td.TabIndex = 5;
            lbl_Td.Text = "Tiền Điện";
            // 
            // lbl_Tn
            // 
            lbl_Tn.AutoSize = true;
            lbl_Tn.BackColor = Color.Transparent;
            lbl_Tn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_Tn.Location = new Point(356, 118);
            lbl_Tn.Name = "lbl_Tn";
            lbl_Tn.Size = new Size(81, 20);
            lbl_Tn.TabIndex = 6;
            lbl_Tn.Text = "Tiền Nước";
            // 
            // lbl_Tdv
            // 
            lbl_Tdv.AutoSize = true;
            lbl_Tdv.BackColor = Color.Transparent;
            lbl_Tdv.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_Tdv.Location = new Point(356, 155);
            lbl_Tdv.Name = "lbl_Tdv";
            lbl_Tdv.Size = new Size(97, 20);
            lbl_Tdv.TabIndex = 7;
            lbl_Tdv.Text = "Tiền Dịch Vụ";
            // 
            // lbl_Tt
            // 
            lbl_Tt.AutoSize = true;
            lbl_Tt.BackColor = Color.Transparent;
            lbl_Tt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_Tt.Location = new Point(12, 185);
            lbl_Tt.Name = "lbl_Tt";
            lbl_Tt.Size = new Size(83, 20);
            lbl_Tt.TabIndex = 8;
            lbl_Tt.Text = "Trạng Thái";
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(124, 43);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(181, 27);
            txtMaHoaDon.TabIndex = 9;
            txtMaHoaDon.TextChanged += txtMaHoaDon_TextChanged;
            // 
            // txtThang
            // 
            txtThang.Location = new Point(124, 107);
            txtThang.Name = "txtThang";
            txtThang.Size = new Size(181, 27);
            txtThang.TabIndex = 10;
            // 
            // txtNam
            // 
            txtNam.Location = new Point(124, 144);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(181, 27);
            txtNam.TabIndex = 11;
            // 
            // txtTienPhong
            // 
            txtTienPhong.Location = new Point(459, 40);
            txtTienPhong.Name = "txtTienPhong";
            txtTienPhong.Size = new Size(125, 27);
            txtTienPhong.TabIndex = 12;
            // 
            // txtTienDien
            // 
            txtTienDien.Location = new Point(459, 74);
            txtTienDien.Name = "txtTienDien";
            txtTienDien.Size = new Size(125, 27);
            txtTienDien.TabIndex = 13;
            // 
            // txtTienNuoc
            // 
            txtTienNuoc.Location = new Point(459, 111);
            txtTienNuoc.Name = "txtTienNuoc";
            txtTienNuoc.Size = new Size(125, 27);
            txtTienNuoc.TabIndex = 14;
            // 
            // txtTienDichVu
            // 
            txtTienDichVu.Location = new Point(459, 147);
            txtTienDichVu.Name = "txtTienDichVu";
            txtTienDichVu.Size = new Size(125, 27);
            txtTienDichVu.TabIndex = 15;
            // 
            // cbMaHD
            // 
            cbMaHD.FormattingEnabled = true;
            cbMaHD.Location = new Point(124, 73);
            cbMaHD.Name = "cbMaHD";
            cbMaHD.Size = new Size(181, 28);
            cbMaHD.TabIndex = 16;
            // 
            // cbTrangThai
            // 
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Items.AddRange(new object[] { "Đã thanh toán", "Chưa thanh toán", "Thanh toán một phần" });
            cbTrangThai.Location = new Point(124, 177);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(151, 28);
            cbTrangThai.TabIndex = 17;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.BackgroundColor = Color.White;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Location = new Point(12, 259);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.Size = new Size(1343, 212);
            dgvHoaDon.TabIndex = 18;
            dgvHoaDon.CellContentClick += dgvHoaDon_CellContentClick;
            dgvHoaDon.MouseClick += dgvHoaDon_MouseClick;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.Image = Properties.Resources.build_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(202, 521);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 19;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.Image = Properties.Resources.delete_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(345, 521);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 20;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThoat.ForeColor = Color.Red;
            btnThoat.Image = Properties.Resources.tab_close_right_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(490, 521);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(119, 29);
            btnThoat.TabIndex = 21;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.Image = Properties.Resources.add_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(62, 521);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 22;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(640, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 46);
            label1.TabIndex = 23;
            label1.Text = "HÓA ĐƠN";
            // 
            // frm_HoaDontruong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Nâu_Be_Hình_Vẽ_Những_Chú_Mèo_Dễ_Thương_Hình_Nền_Máy_Tính_Đơn_Giản;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1367, 567);
            Controls.Add(label1);
            Controls.Add(btnThem);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(dgvHoaDon);
            Controls.Add(cbTrangThai);
            Controls.Add(cbMaHD);
            Controls.Add(txtTienDichVu);
            Controls.Add(txtTienNuoc);
            Controls.Add(txtTienDien);
            Controls.Add(txtTienPhong);
            Controls.Add(txtNam);
            Controls.Add(txtThang);
            Controls.Add(txtMaHoaDon);
            Controls.Add(lbl_Tt);
            Controls.Add(lbl_Tdv);
            Controls.Add(lbl_Tn);
            Controls.Add(lbl_Td);
            Controls.Add(lbl_Tp);
            Controls.Add(lbl_Nam);
            Controls.Add(lbl_Thang);
            Controls.Add(lbl_MaHopDong);
            Controls.Add(lbl_MaHD);
            Name = "frm_HoaDontruong";
            Text = "frm_HoaDontruong";
            Load += frm_HoaDontruong_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_MaHD;
        private Label lbl_MaHopDong;
        private Label lbl_Thang;
        private Label lbl_Nam;
        private Label lbl_Tp;
        private Label lbl_Td;
        private Label lbl_Tn;
        private Label lbl_Tdv;
        private Label lbl_Tt;
        private TextBox txtMaHoaDon;
        private TextBox txtThang;
        private TextBox txtNam;
        private TextBox txtTienPhong;
        private TextBox txtTienDien;
        private TextBox txtTienNuoc;
        private TextBox txtTienDichVu;
        private ComboBox cbMaHD;
        private ComboBox cbTrangThai;
        private DataGridView dgvHoaDon;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnThem;
        private Label label1;
    }
}