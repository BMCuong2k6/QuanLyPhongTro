namespace QuanLyPhongTro.View
{
    partial class frm_ThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThanhToan));
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnthoat = new Button();
            dgvThanhtoan = new DataGridView();
            lbl_Mtt = new Label();
            lbl_mhd = new Label();
            lbl_Ntt = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtHd = new TextBox();
            txtNtt = new TextBox();
            txtMtt = new TextBox();
            txtSt = new TextBox();
            cbPt = new ComboBox();
            cbTt = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvThanhtoan).BeginInit();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(255, 255, 192);
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Image = Properties.Resources.add_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(12, 342);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 255, 192);
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Image = Properties.Resources.build_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(12, 377);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(255, 255, 192);
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(278, 342);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnthoat
            // 
            btnthoat.BackColor = Color.FromArgb(255, 255, 192);
            btnthoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnthoat.ForeColor = Color.Red;
            btnthoat.Image = Properties.Resources.tab_close_right_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            btnthoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnthoat.Location = new Point(278, 377);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(134, 29);
            btnthoat.TabIndex = 3;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = false;
            btnthoat.Click += btnthoat_Click;
            // 
            // dgvThanhtoan
            // 
            dgvThanhtoan.BackgroundColor = Color.White;
            dgvThanhtoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThanhtoan.Location = new Point(548, 12);
            dgvThanhtoan.Name = "dgvThanhtoan";
            dgvThanhtoan.RowHeadersWidth = 51;
            dgvThanhtoan.Size = new Size(693, 406);
            dgvThanhtoan.TabIndex = 4;
            dgvThanhtoan.CellContentClick += dgvThanhtoan_CellContentClick;
            dgvThanhtoan.MouseClick += dgvThanhtoan_MouseClick;
            // 
            // lbl_Mtt
            // 
            lbl_Mtt.AutoSize = true;
            lbl_Mtt.BackColor = Color.Transparent;
            lbl_Mtt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Mtt.Location = new Point(12, 99);
            lbl_Mtt.Name = "lbl_Mtt";
            lbl_Mtt.Size = new Size(117, 20);
            lbl_Mtt.TabIndex = 5;
            lbl_Mtt.Text = "Mã Thanh Toán";
            // 
            // lbl_mhd
            // 
            lbl_mhd.AutoSize = true;
            lbl_mhd.BackColor = Color.Transparent;
            lbl_mhd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_mhd.Location = new Point(12, 148);
            lbl_mhd.Name = "lbl_mhd";
            lbl_mhd.Size = new Size(96, 20);
            lbl_mhd.TabIndex = 6;
            lbl_mhd.Text = "Mã Hóa Đơn";
            // 
            // lbl_Ntt
            // 
            lbl_Ntt.AutoSize = true;
            lbl_Ntt.BackColor = Color.Transparent;
            lbl_Ntt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Ntt.Location = new Point(331, 194);
            lbl_Ntt.Name = "lbl_Ntt";
            lbl_Ntt.Size = new Size(132, 20);
            lbl_Ntt.TabIndex = 7;
            lbl_Ntt.Text = "Ngày Thanh Toán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(48, 194);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 8;
            label4.Text = "Số Tiền";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(287, 99);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 9;
            label5.Text = "Phương Thức";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(305, 148);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 10;
            label6.Text = "Trạng Thái";
            // 
            // txtHd
            // 
            txtHd.Location = new Point(129, 148);
            txtHd.Name = "txtHd";
            txtHd.Size = new Size(152, 27);
            txtHd.TabIndex = 11;
            // 
            // txtNtt
            // 
            txtNtt.Location = new Point(129, 194);
            txtNtt.Name = "txtNtt";
            txtNtt.Size = new Size(152, 27);
            txtNtt.TabIndex = 12;
            // 
            // txtMtt
            // 
            txtMtt.Location = new Point(129, 99);
            txtMtt.Name = "txtMtt";
            txtMtt.Size = new Size(152, 27);
            txtMtt.TabIndex = 13;
            // 
            // txtSt
            // 
            txtSt.Location = new Point(320, 217);
            txtSt.Name = "txtSt";
            txtSt.Size = new Size(152, 27);
            txtSt.TabIndex = 14;
            // 
            // cbPt
            // 
            cbPt.FormattingEnabled = true;
            cbPt.Items.AddRange(new object[] { "Chuyển Khoản", "Tiền Mặt" });
            cbPt.Location = new Point(389, 99);
            cbPt.Name = "cbPt";
            cbPt.Size = new Size(151, 28);
            cbPt.TabIndex = 15;
            // 
            // cbTt
            // 
            cbTt.FormattingEnabled = true;
            cbTt.Items.AddRange(new object[] { "Đã thanh toán", "Chưa thanh toán", "Thanh toán một phần" });
            cbTt.Location = new Point(391, 145);
            cbTt.Name = "cbTt";
            cbTt.Size = new Size(151, 28);
            cbTt.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(136, 22);
            label1.Name = "label1";
            label1.Size = new Size(238, 40);
            label1.TabIndex = 17;
            label1.Text = "THANH TOÁN";
            // 
            // frm_ThanhToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ok;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1253, 501);
            Controls.Add(label1);
            Controls.Add(cbTt);
            Controls.Add(cbPt);
            Controls.Add(txtSt);
            Controls.Add(txtMtt);
            Controls.Add(txtNtt);
            Controls.Add(txtHd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbl_Ntt);
            Controls.Add(lbl_mhd);
            Controls.Add(lbl_Mtt);
            Controls.Add(dgvThanhtoan);
            Controls.Add(btnthoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Name = "frm_ThanhToan";
            Text = "frm_ThanhToan";
            Load += frm_ThanhToan_Load;
            ((System.ComponentModel.ISupportInitialize)dgvThanhtoan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnthoat;
        private DataGridView dgvThanhtoan;
        private Label lbl_Mtt;
        private Label lbl_mhd;
        private Label lbl_Ntt;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtHd;
        private TextBox txtNtt;
        private TextBox txtMtt;
        private TextBox txtSt;
        private ComboBox cbPt;
        private ComboBox cbTt;
        private Label label1;
    }
}