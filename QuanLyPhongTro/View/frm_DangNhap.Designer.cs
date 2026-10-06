namespace QuanLyPhongTro.View
{
    partial class frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangNhap));
            txt_TaiKhoan = new TextBox();
            txt_MatKhau = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            checkB_HienMK = new CheckBox();
            linkLbl_QuenMK = new LinkLabel();
            label3 = new Label();
            SuspendLayout();
            // 
            // txt_TaiKhoan
            // 
            txt_TaiKhoan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_TaiKhoan.Location = new Point(163, 83);
            txt_TaiKhoan.Name = "txt_TaiKhoan";
            txt_TaiKhoan.Size = new Size(123, 23);
            txt_TaiKhoan.TabIndex = 0;
            txt_TaiKhoan.TextChanged += txt_TaiKhoan_TextChanged;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_MatKhau.Location = new Point(163, 121);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(123, 23);
            txt_MatKhau.TabIndex = 1;
            txt_MatKhau.UseSystemPasswordChar = true;
            txt_MatKhau.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(81, 81);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 2;
            label1.Text = "Tài Khoản";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(81, 119);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 3;
            label2.Text = "Mật Khẩu";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(141, 232);
            button1.Name = "button1";
            button1.Size = new Size(90, 36);
            button1.TabIndex = 5;
            button1.Text = "Đăng Nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkB_HienMK
            // 
            checkB_HienMK.AutoSize = true;
            checkB_HienMK.Location = new Point(81, 150);
            checkB_HienMK.Name = "checkB_HienMK";
            checkB_HienMK.Size = new Size(105, 19);
            checkB_HienMK.TabIndex = 6;
            checkB_HienMK.Text = "Hiện Mật Khẩu";
            checkB_HienMK.UseVisualStyleBackColor = true;
            checkB_HienMK.CheckedChanged += checkB_HienMK_CheckedChanged_1;
            // 
            // linkLbl_QuenMK
            // 
            linkLbl_QuenMK.AutoSize = true;
            linkLbl_QuenMK.Location = new Point(250, 313);
            linkLbl_QuenMK.Name = "linkLbl_QuenMK";
            linkLbl_QuenMK.Size = new Size(95, 15);
            linkLbl_QuenMK.TabIndex = 7;
            linkLbl_QuenMK.TabStop = true;
            linkLbl_QuenMK.Text = "Quên Mật Khẩu?";
            linkLbl_QuenMK.LinkClicked += linkLbl_QuenMK_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(132, 9);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 8;
            label3.Text = "Đăng Nhập";
            // 
            // frm_DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 337);
            Controls.Add(label3);
            Controls.Add(linkLbl_QuenMK);
            Controls.Add(checkB_HienMK);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_MatKhau);
            Controls.Add(txt_TaiKhoan);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frm_DangNhap";
            Text = "Đăng Nhập";
            Load += frm_DangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void checkb_HienMK_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox txt_TaiKhoan;
        private TextBox txt_MatKhau;
        private Label label1;
        private Label label2;
        private Button button1;
        private CheckBox checkB_HienMK;
        private LinkLabel linkLbl_QuenMK;
        private Label label3;
    }
}