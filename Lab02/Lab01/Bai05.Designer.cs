namespace Lab01
{
    partial class Bai05
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
            cboPhim = new ComboBox();
            cboPhong = new ComboBox();
            clbGhe = new CheckedListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            rdoThuong = new RadioButton();
            label5 = new Label();
            btnDocFile = new Button();
            btnGhiFile = new Button();
            btnTinhTien = new Button();
            btnThongKe = new Button();
            btnThoat = new Button();
            rtbKetQua = new RichTextBox();
            rdoVip = new RadioButton();
            rdoGiam = new RadioButton();
            SuspendLayout();
            // 
            // cboPhim
            // 
            cboPhim.FormattingEnabled = true;
            cboPhim.Location = new Point(91, 77);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(212, 28);
            cboPhim.TabIndex = 0;
            // 
            // cboPhong
            // 
            cboPhong.FormattingEnabled = true;
            cboPhong.Location = new Point(91, 148);
            cboPhong.Name = "cboPhong";
            cboPhong.Size = new Size(212, 28);
            cboPhong.TabIndex = 1;
            cboPhong.SelectedIndexChanged += cboPhong_SelectedIndexChanged_1;
            // 
            // clbGhe
            // 
            clbGhe.FormattingEnabled = true;
            clbGhe.Location = new Point(95, 219);
            clbGhe.Name = "clbGhe";
            clbGhe.Size = new Size(208, 114);
            clbGhe.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(106, 23);
            label1.Name = "label1";
            label1.Size = new Size(81, 31);
            label1.TabIndex = 3;
            label1.Text = "Đặt Vé";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(49, 23);
            label2.TabIndex = 4;
            label2.Text = "Phim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(12, 148);
            label3.Name = "label3";
            label3.Size = new Size(60, 23);
            label3.TabIndex = 5;
            label3.Text = "Phòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(12, 219);
            label4.Name = "label4";
            label4.Size = new Size(41, 23);
            label4.TabIndex = 6;
            label4.Text = "Ghế";
            // 
            // rdoThuong
            // 
            rdoThuong.AutoSize = true;
            rdoThuong.Location = new Point(95, 363);
            rdoThuong.Name = "rdoThuong";
            rdoThuong.Size = new Size(81, 24);
            rdoThuong.TabIndex = 7;
            rdoThuong.TabStop = true;
            rdoThuong.Text = "Thường";
            rdoThuong.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(12, 363);
            label5.Name = "label5";
            label5.Size = new Size(63, 23);
            label5.TabIndex = 8;
            label5.Text = "Loại vé";
            // 
            // btnDocFile
            // 
            btnDocFile.BackColor = SystemColors.Info;
            btnDocFile.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDocFile.ForeColor = Color.Coral;
            btnDocFile.Location = new Point(448, 18);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(122, 41);
            btnDocFile.TabIndex = 9;
            btnDocFile.Text = "Đọc File";
            btnDocFile.UseVisualStyleBackColor = false;
            btnDocFile.Click += btnDocFile_Click;
            // 
            // btnGhiFile
            // 
            btnGhiFile.BackColor = SystemColors.Info;
            btnGhiFile.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGhiFile.ForeColor = Color.Coral;
            btnGhiFile.Location = new Point(646, 18);
            btnGhiFile.Name = "btnGhiFile";
            btnGhiFile.Size = new Size(122, 41);
            btnGhiFile.TabIndex = 10;
            btnGhiFile.Text = "Ghi File";
            btnGhiFile.UseVisualStyleBackColor = false;
            btnGhiFile.Click += btnGhiFile_Click;
            // 
            // btnTinhTien
            // 
            btnTinhTien.BackColor = SystemColors.Info;
            btnTinhTien.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTinhTien.ForeColor = Color.Coral;
            btnTinhTien.Location = new Point(448, 333);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(122, 41);
            btnTinhTien.TabIndex = 11;
            btnTinhTien.Text = "Tính Tiền";
            btnTinhTien.UseVisualStyleBackColor = false;
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = SystemColors.Info;
            btnThongKe.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThongKe.ForeColor = Color.Coral;
            btnThongKe.Location = new Point(646, 333);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(122, 41);
            btnThongKe.TabIndex = 12;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.Info;
            btnThoat.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.Coral;
            btnThoat.Location = new Point(553, 397);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(122, 41);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // rtbKetQua
            // 
            rtbKetQua.BackColor = SystemColors.InfoText;
            rtbKetQua.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbKetQua.ForeColor = SystemColors.HotTrack;
            rtbKetQua.Location = new Point(372, 77);
            rtbKetQua.Name = "rtbKetQua";
            rtbKetQua.Size = new Size(416, 232);
            rtbKetQua.TabIndex = 14;
            rtbKetQua.Text = "";
            // 
            // rdoVip
            // 
            rdoVip.AutoSize = true;
            rdoVip.Location = new Point(95, 397);
            rdoVip.Name = "rdoVip";
            rdoVip.Size = new Size(52, 24);
            rdoVip.TabIndex = 15;
            rdoVip.TabStop = true;
            rdoVip.Text = "Vip";
            rdoVip.UseVisualStyleBackColor = true;
            // 
            // rdoGiam
            // 
            rdoGiam.AutoSize = true;
            rdoGiam.Location = new Point(196, 377);
            rdoGiam.Name = "rdoGiam";
            rdoGiam.Size = new Size(53, 24);
            rdoGiam.TabIndex = 16;
            rdoGiam.TabStop = true;
            rdoGiam.Text = "Vớt";
            rdoGiam.UseVisualStyleBackColor = true;
            // 
            // Bai05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_3d_rendered_movie_theatre_with_white_screen_image_3732826;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(rdoGiam);
            Controls.Add(rdoVip);
            Controls.Add(rtbKetQua);
            Controls.Add(btnThoat);
            Controls.Add(btnThongKe);
            Controls.Add(btnTinhTien);
            Controls.Add(btnGhiFile);
            Controls.Add(btnDocFile);
            Controls.Add(label5);
            Controls.Add(rdoThuong);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(clbGhe);
            Controls.Add(cboPhong);
            Controls.Add(cboPhim);
            Name = "Bai05";
            Text = "Bai05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboPhim;
        private ComboBox cboPhong;
        private CheckedListBox clbGhe;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton rdoThuong;
        private Label label5;
        private Button btnDocFile;
        private Button btnGhiFile;
        private Button btnTinhTien;
        private Button btnThongKe;
        private Button btnThoat;
        private RichTextBox rtbKetQua;
        private RadioButton rdoVip;
        private RadioButton rdoGiam;
    }
}