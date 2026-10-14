namespace QuanLyPhongTro
{
    partial class frm_Phong_Quan
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnSua = new Button();
            btnLamMoi = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            txtGiaPhong = new TextBox();
            txtTenPhong = new TextBox();
            txtMaPhong = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnTim = new Button();
            comboBox3 = new ComboBox();
            lblLoc = new Label();
            textBox1 = new TextBox();
            lblTimKiem = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            dgvPhong = new DataGridView();
            label9 = new Label();
            groupBox4 = new GroupBox();
            btnCapNhat = new Button();
            comboBox4 = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.BackColor = SystemColors.HighlightText;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(402, 15);
            label1.Name = "label1";
            label1.Size = new Size(256, 62);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ PHÒNG";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(txtGiaPhong);
            groupBox1.Controls.Add(txtTenPhong);
            groupBox1.Controls.Add(txtMaPhong);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(5, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1030, 278);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(623, 179);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 14;
            btnSua.Text = "SỬA";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(818, 179);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(112, 34);
            btnLamMoi.TabIndex = 13;
            btnLamMoi.Text = "LÀM MỚI";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(623, 101);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 12;
            btnThem.Text = "THÊM";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThemPhong;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(818, 101);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "XOÁ";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(107, 225);
            label7.Name = "label7";
            label7.Size = new Size(129, 25);
            label7.TabIndex = 10;
            label7.Text = "TRẠNG THÁI:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(107, 188);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 9;
            label6.Text = "GIÁ PHÒNG:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(107, 149);
            label5.Name = "label5";
            label5.Size = new Size(130, 25);
            label5.TabIndex = 8;
            label5.Text = "LOẠI PHÒNG:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(105, 110);
            label4.Name = "label4";
            label4.Size = new Size(123, 25);
            label4.TabIndex = 7;
            label4.Text = "TÊN PHÒNG:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(105, 73);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 6;
            label3.Text = "MÃ PHÒNG:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(285, 149);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(239, 33);
            comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(285, 225);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(239, 33);
            comboBox1.TabIndex = 4;
            // 
            // txtGiaPhong
            // 
            txtGiaPhong.Location = new Point(285, 188);
            txtGiaPhong.Name = "txtGiaPhong";
            txtGiaPhong.Size = new Size(239, 31);
            txtGiaPhong.TabIndex = 3;
            // 
            // txtTenPhong
            // 
            txtTenPhong.Location = new Point(285, 110);
            txtTenPhong.Name = "txtTenPhong";
            txtTenPhong.Size = new Size(239, 31);
            txtTenPhong.TabIndex = 2;
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(285, 67);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(239, 31);
            txtMaPhong.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(412, 27);
            label2.Name = "label2";
            label2.Size = new Size(172, 25);
            label2.TabIndex = 0;
            label2.Text = "THÔNG TIN PHÒNG";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTim);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(lblLoc);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(lblTimKiem);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(5, 358);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1030, 150);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(623, 39);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(112, 34);
            btnTim.TabIndex = 19;
            btnTim.Text = "TÌM";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(285, 66);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(239, 33);
            comboBox3.TabIndex = 18;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // lblLoc
            // 
            lblLoc.AutoSize = true;
            lblLoc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoc.Location = new Point(157, 66);
            lblLoc.Name = "lblLoc";
            lblLoc.Size = new Size(51, 25);
            lblLoc.TabIndex = 17;
            lblLoc.Text = "LỌC:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(285, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 31);
            textBox1.TabIndex = 16;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimKiem.Location = new Point(107, 30);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(101, 25);
            lblTimKiem.TabIndex = 15;
            lblTimKiem.Text = "TÌM KIẾM:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(422, 0);
            label8.Name = "label8";
            label8.Size = new Size(148, 25);
            label8.TabIndex = 0;
            label8.Text = "TÌM KIẾM và LỌC";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvPhong);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(5, 514);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1030, 298);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            // 
            // dgvPhong
            // 
            dgvPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhong.Location = new Point(7, 45);
            dgvPhong.Name = "dgvPhong";
            dgvPhong.RowHeadersWidth = 62;
            dgvPhong.Size = new Size(1023, 247);
            dgvPhong.TabIndex = 1;
            dgvPhong.CellContentClick += dgvPhong_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(422, 16);
            label9.Name = "label9";
            label9.Size = new Size(181, 25);
            label9.TabIndex = 0;
            label9.Text = "DANH SÁCH PHÒNG";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnCapNhat);
            groupBox4.Controls.Add(comboBox4);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label10);
            groupBox4.Location = new Point(12, 805);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1023, 142);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(616, 72);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(112, 34);
            btnCapNhat.TabIndex = 3;
            btnCapNhat.Text = "CẬP NHẬT";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(278, 74);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(239, 33);
            comboBox4.TabIndex = 2;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(98, 77);
            label11.Name = "label11";
            label11.Size = new Size(171, 25);
            label11.TabIndex = 1;
            label11.Text = "TRẠNG THÁI MỚI:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(415, 10);
            label10.Name = "label10";
            label10.Size = new Size(203, 25);
            label10.TabIndex = 0;
            label10.Text = "CẬP NHẬT TRẠNG THÁI";
            // 
            // frm_Phong_Quan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 959);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frm_Phong_Quan";
            Text = "Form2";
            Load += frm_Phong_Quan_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox txtGiaPhong;
        private TextBox txtTenPhong;
        private TextBox txtMaPhong;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnSua;
        private Button btnLamMoi;
        private Button btnThem;
        private Button btnXoa;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Label lblTimKiem;
        private Label label8;
        private ComboBox comboBox3;
        private Label lblLoc;
        private Button btnTim;
        private GroupBox groupBox3;
        private Label label9;
        private DataGridView dgvPhong;
        private GroupBox groupBox4;
        private Label label11;
        private Label label10;
        private Button btnCapNhat;
        private ComboBox comboBox4;
    }
}