namespace QuanLyPhongTro.View
{
    partial class frm_QLyTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLyTaiKhoan));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtb_Email = new TextBox();
            txtb_MatKhau = new TextBox();
            txtb_TenTK = new TextBox();
            panel2 = new Panel();
            panel4 = new Panel();
            btn_Thoat = new Button();
            btn_Xoa = new Button();
            btn_Sua = new Button();
            btn_Them = new Button();
            panel3 = new Panel();
            dgv_QLTaiKhoan = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_QLTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtb_Email);
            panel1.Controls.Add(txtb_MatKhau);
            panel1.Controls.Add(txtb_TenTK);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 380);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.loginmanager_10029;
            pictureBox1.Location = new Point(326, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 157);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 124);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 95);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 66);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 3;
            label1.Text = "Tên Tài Khoản";
            // 
            // txtb_Email
            // 
            txtb_Email.Location = new Point(71, 121);
            txtb_Email.Name = "txtb_Email";
            txtb_Email.Size = new Size(178, 23);
            txtb_Email.TabIndex = 2;
            // 
            // txtb_MatKhau
            // 
            txtb_MatKhau.Location = new Point(135, 92);
            txtb_MatKhau.Name = "txtb_MatKhau";
            txtb_MatKhau.Size = new Size(114, 23);
            txtb_MatKhau.TabIndex = 1;
            // 
            // txtb_TenTK
            // 
            txtb_TenTK.Location = new Point(135, 63);
            txtb_TenTK.Name = "txtb_TenTK";
            txtb_TenTK.Size = new Size(114, 23);
            txtb_TenTK.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 211);
            panel2.Name = "panel2";
            panel2.Size = new Size(468, 169);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_Thoat);
            panel4.Controls.Add(btn_Xoa);
            panel4.Controls.Add(btn_Sua);
            panel4.Controls.Add(btn_Them);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 124);
            panel4.Name = "panel4";
            panel4.Size = new Size(468, 45);
            panel4.TabIndex = 1;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(381, 10);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(75, 23);
            btn_Thoat.TabIndex = 3;
            btn_Thoat.Text = "Thoat";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(174, 10);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(75, 23);
            btn_Xoa.TabIndex = 2;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(93, 10);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(75, 23);
            btn_Sua.TabIndex = 1;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(12, 10);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(75, 23);
            btn_Them.TabIndex = 0;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgv_QLTaiKhoan);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(468, 169);
            panel3.TabIndex = 0;
            // 
            // dgv_QLTaiKhoan
            // 
            dgv_QLTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_QLTaiKhoan.Dock = DockStyle.Fill;
            dgv_QLTaiKhoan.Location = new Point(0, 0);
            dgv_QLTaiKhoan.Name = "dgv_QLTaiKhoan";
            dgv_QLTaiKhoan.Size = new Size(468, 169);
            dgv_QLTaiKhoan.TabIndex = 0;
            // 
            // frm_QLyTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 380);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frm_QLyTaiKhoan";
            Text = "Quản Lý Tài Khoản";
            Load += frm_QLyTaiKhoan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_QLTaiKhoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Button btn_Xoa;
        private Button btn_Sua;
        private Button btn_Them;
        private Panel panel3;
        private Button btn_Thoat;
        private DataGridView dgv_QLTaiKhoan;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtb_Email;
        private TextBox txtb_MatKhau;
        private TextBox txtb_TenTK;
        private PictureBox pictureBox1;
    }
}