namespace QuanLyPhongTro.View
{
    partial class frm_UI_Chinh
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
            panel_menu = new Panel();
            btn_QLYTaiKhoan = new Button();
            btnThanhToan = new Button();
            btnHoaDon = new Button();
            btnHopDong = new Button();
            btnKhachThue = new Button();
            btnPhong = new Button();
            btnTrangChu = new Button();
            lbl_logo = new Label();
            panel2 = new Panel();
            lblNguoiDung = new Label();
            lblTieuDe = new Label();
            pnlContent = new Panel();
            panel_menu.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel_menu
            // 
            panel_menu.BackColor = Color.DarkBlue;
            panel_menu.Controls.Add(btn_QLYTaiKhoan);
            panel_menu.Controls.Add(btnThanhToan);
            panel_menu.Controls.Add(btnHoaDon);
            panel_menu.Controls.Add(btnHopDong);
            panel_menu.Controls.Add(btnKhachThue);
            panel_menu.Controls.Add(btnPhong);
            panel_menu.Controls.Add(btnTrangChu);
            panel_menu.Controls.Add(lbl_logo);
            panel_menu.Dock = DockStyle.Left;
            panel_menu.Location = new Point(0, 0);
            panel_menu.Name = "panel_menu";
            panel_menu.Size = new Size(217, 581);
            panel_menu.TabIndex = 0;
            panel_menu.Paint += panel_menu_Paint;
            // 
            // btn_QLYTaiKhoan
            // 
            btn_QLYTaiKhoan.FlatAppearance.BorderSize = 0;
            btn_QLYTaiKhoan.FlatStyle = FlatStyle.Flat;
            btn_QLYTaiKhoan.ForeColor = Color.White;
            btn_QLYTaiKhoan.Location = new Point(0, 346);
            btn_QLYTaiKhoan.Name = "btn_QLYTaiKhoan";
            btn_QLYTaiKhoan.Size = new Size(232, 45);
            btn_QLYTaiKhoan.TabIndex = 9;
            btn_QLYTaiKhoan.Text = "Quản Lý Tài Khoản";
            btn_QLYTaiKhoan.UseVisualStyleBackColor = true;
            btn_QLYTaiKhoan.Click += btn_QLYTaiKhoan_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.FlatAppearance.BorderSize = 0;
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(-10, 295);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(232, 45);
            btnThanhToan.TabIndex = 6;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.ForeColor = Color.White;
            btnHoaDon.Location = new Point(-10, 244);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(232, 45);
            btnHoaDon.TabIndex = 5;
            btnHoaDon.Text = "Hóa đơn";
            btnHoaDon.UseVisualStyleBackColor = true;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnHopDong
            // 
            btnHopDong.FlatAppearance.BorderSize = 0;
            btnHopDong.FlatStyle = FlatStyle.Flat;
            btnHopDong.ForeColor = Color.White;
            btnHopDong.Location = new Point(-10, 193);
            btnHopDong.Name = "btnHopDong";
            btnHopDong.Size = new Size(232, 45);
            btnHopDong.TabIndex = 4;
            btnHopDong.Text = "Hợp đồng";
            btnHopDong.UseVisualStyleBackColor = true;
            btnHopDong.Click += button4_Click;
            // 
            // btnKhachThue
            // 
            btnKhachThue.FlatAppearance.BorderSize = 0;
            btnKhachThue.FlatStyle = FlatStyle.Flat;
            btnKhachThue.ForeColor = Color.White;
            btnKhachThue.Location = new Point(-10, 142);
            btnKhachThue.Name = "btnKhachThue";
            btnKhachThue.Size = new Size(232, 45);
            btnKhachThue.TabIndex = 3;
            btnKhachThue.Text = "Khách thuê";
            btnKhachThue.UseVisualStyleBackColor = true;
            btnKhachThue.Click += btnKhachThue_Click;
            // 
            // btnPhong
            // 
            btnPhong.FlatAppearance.BorderSize = 0;
            btnPhong.FlatStyle = FlatStyle.Flat;
            btnPhong.ForeColor = Color.White;
            btnPhong.Location = new Point(-10, 91);
            btnPhong.Name = "btnPhong";
            btnPhong.Size = new Size(232, 45);
            btnPhong.TabIndex = 2;
            btnPhong.Text = "Phòng trọ";
            btnPhong.UseVisualStyleBackColor = true;
            btnPhong.Click += btnPhong_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = Color.Blue;
            btnTrangChu.FlatAppearance.BorderSize = 0;
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.ForeColor = Color.White;
            btnTrangChu.Location = new Point(-10, 40);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(230, 45);
            btnTrangChu.TabIndex = 1;
            btnTrangChu.Text = "⌂ Trang chủ";
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += button1_Click;
            // 
            // lbl_logo
            // 
            lbl_logo.AutoSize = true;
            lbl_logo.Dock = DockStyle.Top;
            lbl_logo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_logo.ForeColor = Color.White;
            lbl_logo.Location = new Point(0, 0);
            lbl_logo.Name = "lbl_logo";
            lbl_logo.Size = new Size(222, 28);
            lbl_logo.TabIndex = 0;
            lbl_logo.Text = "QUẢN LÝ PHÒNG TRỌ";
            lbl_logo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblNguoiDung);
            panel2.Controls.Add(lblTieuDe);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(217, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 85);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // lblNguoiDung
            // 
            lblNguoiDung.AutoSize = true;
            lblNguoiDung.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNguoiDung.Location = new Point(228, 58);
            lblNguoiDung.Name = "lblNguoiDung";
            lblNguoiDung.Size = new Size(0, 28);
            lblNguoiDung.TabIndex = 1;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.Location = new Point(6, 40);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(276, 37);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Tổng quan hệ thống";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = SystemColors.AppWorkspace;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(217, 85);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(776, 496);
            pnlContent.TabIndex = 2;
            // 
            // frm_UI_Chinh
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 581);
            Controls.Add(pnlContent);
            Controls.Add(panel2);
            Controls.Add(panel_menu);
            Font = new Font("Segoe UI", 10F);
            Name = "frm_UI_Chinh";
            Text = "Quản Lý Phòng Trọ";
            Load += frm_UI_Chinh_Load;
            panel_menu.ResumeLayout(false);
            panel_menu.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_menu;
        private Label lbl_logo;
        private Panel panel2;
        private Panel pnlContent;
        private Button btnThanhToan;
        private Button btnHoaDon;
        private Button btnHopDong;
        private Button btnKhachThue;
        private Button btnPhong;
        private Button btnTrangChu;
        private Label lblNguoiDung;
        private Label lblTieuDe;
        private Button btn_QLYTaiKhoan;
    }
}