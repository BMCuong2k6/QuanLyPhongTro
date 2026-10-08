namespace QuanLyPhongTro.View
{
    partial class frm_DangKyTK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangKyTK));
            txtb_TaiKhoan = new TextBox();
            txtb_MatKhau = new TextBox();
            txtb_email = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtb_XacNhanMK = new TextBox();
            label5 = new Label();
            btn_XacNhan = new Button();
            checkB_HienMK = new CheckBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // txtb_TaiKhoan
            // 
            txtb_TaiKhoan.Location = new Point(175, 77);
            txtb_TaiKhoan.Name = "txtb_TaiKhoan";
            txtb_TaiKhoan.Size = new Size(137, 23);
            txtb_TaiKhoan.TabIndex = 0;
            txtb_TaiKhoan.TextChanged += txtb_TaiKhoan_TextChanged;
            // 
            // txtb_MatKhau
            // 
            txtb_MatKhau.Location = new Point(175, 104);
            txtb_MatKhau.Name = "txtb_MatKhau";
            txtb_MatKhau.Size = new Size(137, 23);
            txtb_MatKhau.TabIndex = 1;
            txtb_MatKhau.UseSystemPasswordChar = true;
            // 
            // txtb_email
            // 
            txtb_email.Location = new Point(73, 200);
            txtb_email.Name = "txtb_email";
            txtb_email.Size = new Size(239, 23);
            txtb_email.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 198);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 3;
            label1.Text = "Email: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 4;
            label2.Text = "Tài Khoản: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 5;
            label3.Text = "Mật Khẩu: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 131);
            label4.Name = "label4";
            label4.Size = new Size(153, 21);
            label4.TabIndex = 6;
            label4.Text = "Xác Nhận Mật Khẩu: ";
            // 
            // txtb_XacNhanMK
            // 
            txtb_XacNhanMK.Location = new Point(175, 133);
            txtb_XacNhanMK.Name = "txtb_XacNhanMK";
            txtb_XacNhanMK.Size = new Size(137, 23);
            txtb_XacNhanMK.TabIndex = 7;
            txtb_XacNhanMK.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DodgerBlue;
            label5.Location = new Point(73, 9);
            label5.Name = "label5";
            label5.Size = new Size(186, 30);
            label5.TabIndex = 8;
            label5.Text = "Đăng Ký Tài Khoản";
            // 
            // btn_XacNhan
            // 
            btn_XacNhan.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_XacNhan.Location = new Point(101, 259);
            btn_XacNhan.Name = "btn_XacNhan";
            btn_XacNhan.Size = new Size(124, 34);
            btn_XacNhan.TabIndex = 9;
            btn_XacNhan.Text = "Xác Nhận";
            btn_XacNhan.UseVisualStyleBackColor = true;
            btn_XacNhan.Click += btn_XacNhan_Click;
            // 
            // checkB_HienMK
            // 
            checkB_HienMK.AutoSize = true;
            checkB_HienMK.Location = new Point(12, 166);
            checkB_HienMK.Name = "checkB_HienMK";
            checkB_HienMK.Size = new Size(104, 19);
            checkB_HienMK.TabIndex = 10;
            checkB_HienMK.Text = "Hiện Mật khẩu";
            checkB_HienMK.UseVisualStyleBackColor = true;
            checkB_HienMK.CheckedChanged += checkB_HienMK_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(318, 80);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 11;
            label6.Text = "(*)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(318, 107);
            label7.Name = "label7";
            label7.Size = new Size(20, 15);
            label7.TabIndex = 12;
            label7.Text = "(*)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(318, 136);
            label8.Name = "label8";
            label8.Size = new Size(20, 15);
            label8.TabIndex = 13;
            label8.Text = "(*)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(318, 204);
            label9.Name = "label9";
            label9.Size = new Size(20, 15);
            label9.TabIndex = 14;
            label9.Text = "(*)";
            // 
            // frm_DangKyTK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 317);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(checkB_HienMK);
            Controls.Add(btn_XacNhan);
            Controls.Add(label5);
            Controls.Add(txtb_XacNhanMK);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtb_email);
            Controls.Add(txtb_MatKhau);
            Controls.Add(txtb_TaiKhoan);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frm_DangKyTK";
            Text = "Đăng Ký Tài Khoản";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtb_TaiKhoan;
        private TextBox txtb_MatKhau;
        private TextBox txtb_email;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtb_XacNhanMK;
        private Label label5;
        private Button btn_XacNhan;
        private CheckBox checkB_HienMK;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}