namespace QuanLyPhongTro.View
{
    partial class frm_QuenMK
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
            txtb_email_qmk = new TextBox();
            label1 = new Label();
            lbl_MatKhau = new Label();
            btn_XacNhan = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtb_email_qmk
            // 
            txtb_email_qmk.Location = new Point(27, 86);
            txtb_email_qmk.Name = "txtb_email_qmk";
            txtb_email_qmk.Size = new Size(213, 23);
            txtb_email_qmk.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 39);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 1;
            label1.Text = "Nhập Email";
            label1.Click += label1_Click;
            // 
            // lbl_MatKhau
            // 
            lbl_MatKhau.AutoSize = true;
            lbl_MatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_MatKhau.ForeColor = Color.Red;
            lbl_MatKhau.Location = new Point(116, 169);
            lbl_MatKhau.Name = "lbl_MatKhau";
            lbl_MatKhau.Size = new Size(0, 21);
            lbl_MatKhau.TabIndex = 2;
            // 
            // btn_XacNhan
            // 
            btn_XacNhan.Location = new Point(92, 224);
            btn_XacNhan.Name = "btn_XacNhan";
            btn_XacNhan.Size = new Size(90, 34);
            btn_XacNhan.TabIndex = 3;
            btn_XacNhan.Text = "Xác Nhận";
            btn_XacNhan.UseVisualStyleBackColor = true;
            btn_XacNhan.Click += btn_XacNhan_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(246, 94);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 4;
            label2.Text = "(*)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(27, 169);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 5;
            label3.Text = "Mật Khẩu: ";
            // 
            // frm_QuenMK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 298);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_XacNhan);
            Controls.Add(lbl_MatKhau);
            Controls.Add(label1);
            Controls.Add(txtb_email_qmk);
            MaximizeBox = false;
            Name = "frm_QuenMK";
            Text = "frm_QuenMK";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtb_email_qmk;
        private Label label1;
        private Label lbl_MatKhau;
        private Button btn_XacNhan;
        private Label label2;
        private Label label3;
    }
}