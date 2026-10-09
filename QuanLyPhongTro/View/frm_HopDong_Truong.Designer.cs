namespace QuanLyPhongTro.View
{
    partial class frm_HopDong_Truong
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
            dgvHopDong = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtMhd = new TextBox();
            txtMp = new TextBox();
            txtMk = new TextBox();
            txtTc = new TextBox();
            cbTt = new ComboBox();
            dtpNkt = new DateTimePicker();
            dtpNbd = new DateTimePicker();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnthoat = new Button();
            btnLammoi = new Button();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvHopDong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvHopDong
            // 
            dgvHopDong.BackgroundColor = Color.White;
            dgvHopDong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHopDong.Location = new Point(12, 136);
            dgvHopDong.Name = "dgvHopDong";
            dgvHopDong.RowHeadersWidth = 51;
            dgvHopDong.Size = new Size(813, 385);
            dgvHopDong.TabIndex = 0;
            dgvHopDong.CellContentClick += dgvHopDong_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(16, 30);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã Hợp Đồng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã Phòng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(257, 25);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 3;
            label3.Text = "Mã Khách";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(257, 79);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 4;
            label4.Text = "Tiền Cọc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(842, 47);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 5;
            label5.Text = "Trạng Thái";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(468, 79);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 6;
            label6.Text = "Ngày Kết Thúc";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(468, 23);
            label7.Name = "label7";
            label7.Size = new Size(106, 20);
            label7.TabIndex = 7;
            label7.Text = "Ngày Bắt Đầu";
            // 
            // txtMhd
            // 
            txtMhd.Location = new Point(126, 23);
            txtMhd.Name = "txtMhd";
            txtMhd.Size = new Size(125, 27);
            txtMhd.TabIndex = 8;
            // 
            // txtMp
            // 
            txtMp.Location = new Point(126, 79);
            txtMp.Name = "txtMp";
            txtMp.Size = new Size(125, 27);
            txtMp.TabIndex = 9;
            // 
            // txtMk
            // 
            txtMk.Location = new Point(337, 20);
            txtMk.Name = "txtMk";
            txtMk.Size = new Size(125, 27);
            txtMk.TabIndex = 10;
            // 
            // txtTc
            // 
            txtTc.Location = new Point(337, 79);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(125, 27);
            txtTc.TabIndex = 12;
            // 
            // cbTt
            // 
            cbTt.FormattingEnabled = true;
            cbTt.Items.AddRange(new object[] { "Đang Thuê", "Đã Kết THúc" });
            cbTt.Location = new Point(930, 39);
            cbTt.Name = "cbTt";
            cbTt.Size = new Size(151, 28);
            cbTt.TabIndex = 14;
            // 
            // dtpNkt
            // 
            dtpNkt.Location = new Point(586, 74);
            dtpNkt.Name = "dtpNkt";
            dtpNkt.Size = new Size(250, 27);
            dtpNkt.TabIndex = 15;
            // 
            // dtpNbd
            // 
            dtpNbd.Location = new Point(586, 21);
            dtpNbd.Name = "dtpNbd";
            dtpNbd.Size = new Size(250, 27);
            dtpNbd.TabIndex = 16;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.Image = Properties.Resources.add_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(12, 541);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 17;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += button1_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.Image = Properties.Resources.build_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(126, 541);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 18;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.Image = Properties.Resources.delete_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(241, 541);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 19;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnthoat
            // 
            btnthoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnthoat.Image = Properties.Resources.tab_close_right_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            btnthoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnthoat.Location = new Point(716, 541);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(109, 29);
            btnthoat.TabIndex = 20;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // btnLammoi
            // 
            btnLammoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLammoi.Image = Properties.Resources.reset_wrench_24dp_EA3323_FILL0_wght400_GRAD0_opsz24;
            btnLammoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLammoi.Location = new Point(350, 541);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(128, 29);
            btnLammoi.TabIndex = 21;
            btnLammoi.Text = "Làm Mới";
            btnLammoi.UseVisualStyleBackColor = true;
            btnLammoi.Click += btnLammoi_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(992, 79);
            label8.Name = "label8";
            label8.Size = new Size(241, 54);
            label8.TabIndex = 22;
            label8.Text = "HỢP ĐỒNG";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.This_Facebook_Account_Collects_Work_Memes__Here_Are_30_Of_The_Funniest;
            pictureBox1.Location = new Point(880, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(419, 477);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // frm_HopDong_Truong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.tải_xuống__1_;
            ClientSize = new Size(1323, 613);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(btnLammoi);
            Controls.Add(btnthoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dtpNbd);
            Controls.Add(dtpNkt);
            Controls.Add(cbTt);
            Controls.Add(txtTc);
            Controls.Add(txtMk);
            Controls.Add(txtMp);
            Controls.Add(txtMhd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvHopDong);
            Name = "frm_HopDong_Truong";
            Text = "frm_HopDong_Truong";
            ((System.ComponentModel.ISupportInitialize)dgvHopDong).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHopDong;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtMhd;
        private TextBox txtMp;
        private TextBox txtMk;
        private TextBox txtTc;
        private ComboBox cbTt;
        private DateTimePicker dtpNkt;
        private DateTimePicker dtpNbd;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnthoat;
        private Button btnLammoi;
        private Label label8;
        private PictureBox pictureBox1;
    }
}