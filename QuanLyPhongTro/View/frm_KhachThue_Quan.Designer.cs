namespace QuanLyPhongTro.View
{
    partial class frm_KhachThue_Quan
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
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            label7 = new Label();
            txtQueQuan = new Label();
            txtSDT = new Label();
            txtCCCD = new Label();
            txtTen = new Label();
            txtMaNguoiThue = new Label();
            groupBox2 = new GroupBox();
            btnTim = new Button();
            textBox6 = new TextBox();
            label8 = new Label();
            dgvKhachThue = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachThue).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(328, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(280, 28);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ KHÁCH THUÊ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtQueQuan);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtCCCD);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(txtMaNguoiThue);
            groupBox1.Location = new Point(10, 35);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(926, 261);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(267, 108);
            textBox5.Margin = new Padding(2, 2, 2, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(270, 27);
            textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(267, 141);
            textBox4.Margin = new Padding(2, 2, 2, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(270, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(267, 175);
            textBox3.Margin = new Padding(2, 2, 2, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(270, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(267, 76);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(270, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(267, 40);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 27);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(102, 214);
            btnThem.Margin = new Padding(2, 2, 2, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 27);
            btnThem.TabIndex = 2;
            btnThem.Text = "THÊM";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(267, 214);
            btnSua.Margin = new Padding(2, 2, 2, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 27);
            btnSua.TabIndex = 3;
            btnSua.Text = "SỬA";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(456, 214);
            btnXoa.Margin = new Padding(2, 2, 2, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 27);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "XOÁ";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(650, 214);
            btnLamMoi.Margin = new Padding(2, 2, 2, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(90, 27);
            btnLamMoi.TabIndex = 5;
            btnLamMoi.Text = "LÀM MỚI";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(331, 10);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(214, 23);
            label7.TabIndex = 5;
            label7.Text = "THÔNG TIN NGƯỜI THUÊ";
            // 
            // txtQueQuan
            // 
            txtQueQuan.AutoSize = true;
            txtQueQuan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQueQuan.Location = new Point(135, 177);
            txtQueQuan.Margin = new Padding(2, 0, 2, 0);
            txtQueQuan.Name = "txtQueQuan";
            txtQueQuan.Size = new Size(92, 20);
            txtQueQuan.TabIndex = 4;
            txtQueQuan.Text = "QUÊ QUÁN:";
            txtQueQuan.Click += label6_Click;
            // 
            // txtSDT
            // 
            txtSDT.AutoSize = true;
            txtSDT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSDT.Location = new Point(104, 141);
            txtSDT.Margin = new Padding(2, 0, 2, 0);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(123, 20);
            txtSDT.TabIndex = 3;
            txtSDT.Text = "SỐ ĐIỆN THOẠI:";
            // 
            // txtCCCD
            // 
            txtCCCD.AutoSize = true;
            txtCCCD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCCCD.Location = new Point(177, 113);
            txtCCCD.Margin = new Padding(2, 0, 2, 0);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(51, 20);
            txtCCCD.TabIndex = 2;
            txtCCCD.Text = "CCCD:";
            // 
            // txtTen
            // 
            txtTen.AutoSize = true;
            txtTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTen.Location = new Point(158, 76);
            txtTen.Margin = new Padding(2, 0, 2, 0);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(68, 20);
            txtTen.TabIndex = 1;
            txtTen.Text = "HỌ TÊN:";
            txtTen.Click += label3_Click;
            // 
            // txtMaNguoiThue
            // 
            txtMaNguoiThue.AutoSize = true;
            txtMaNguoiThue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaNguoiThue.Location = new Point(93, 44);
            txtMaNguoiThue.Margin = new Padding(2, 0, 2, 0);
            txtMaNguoiThue.Name = "txtMaNguoiThue";
            txtMaNguoiThue.Size = new Size(137, 20);
            txtMaNguoiThue.TabIndex = 0;
            txtMaNguoiThue.Text = "MÃ NGƯỜI THUÊ:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTim);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(10, 300);
            groupBox2.Margin = new Padding(2, 2, 2, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 2, 2, 2);
            groupBox2.Size = new Size(926, 68);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(650, 24);
            btnTim.Margin = new Padding(2, 2, 2, 2);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(90, 27);
            btnTim.TabIndex = 2;
            btnTim.Text = "TÌM";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(267, 25);
            textBox6.Margin = new Padding(2, 2, 2, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(270, 27);
            textBox6.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(47, 25);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(184, 20);
            label8.TabIndex = 0;
            label8.Text = "NHẬP MÃ NGƯỜI THUÊ:";
            // 
            // dgvKhachThue
            // 
            dgvKhachThue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachThue.Location = new Point(10, 372);
            dgvKhachThue.Margin = new Padding(2, 2, 2, 2);
            dgvKhachThue.Name = "dgvKhachThue";
            dgvKhachThue.RowHeadersWidth = 62;
            dgvKhachThue.Size = new Size(926, 238);
            dgvKhachThue.TabIndex = 3;
            dgvKhachThue.CellContentClick += dataGridView1_CellContentClick;
            // 
            // frm_KhachThue_Quan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 621);
            Controls.Add(dgvKhachThue);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frm_KhachThue_Quan";
            Text = "frm_KhachThue_Quan";
            Load += frm_KhachThue_Quan_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachThue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label txtQueQuan;
        private Label txtSDT;
        private Label txtCCCD;
        private Label txtTen;
        private Label txtMaNguoiThue;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Label label7;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Label label8;
        private Button btnTim;
        private TextBox textBox6;
        private DataGridView dgvKhachThue;
    }
}