namespace Lab01
{
    partial class Bai06
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
            lvMonAn = new ListView();
            picMon = new PictureBox();
            lblTenMon = new Label();
            lblNguoiDongGop = new Label();
            btnNgauNhien = new Button();
            NtnNapLai = new Button();
            ((System.ComponentModel.ISupportInitialize)picMon).BeginInit();
            SuspendLayout();
            // 
            // lvMonAn
            // 
            lvMonAn.Location = new Point(12, 12);
            lvMonAn.Name = "lvMonAn";
            lvMonAn.Size = new Size(230, 426);
            lvMonAn.TabIndex = 0;
            lvMonAn.UseCompatibleStateImageBehavior = false;
            // 
            // picMon
            // 
            picMon.Location = new Point(429, 131);
            picMon.Name = "picMon";
            picMon.Size = new Size(334, 267);
            picMon.TabIndex = 1;
            picMon.TabStop = false;
            // 
            // lblTenMon
            // 
            lblTenMon.AutoSize = true;
            lblTenMon.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenMon.Location = new Point(429, 12);
            lblTenMon.Name = "lblTenMon";
            lblTenMon.Size = new Size(76, 31);
            lblTenMon.TabIndex = 2;
            lblTenMon.Text = "label1";
            // 
            // lblNguoiDongGop
            // 
            lblNguoiDongGop.AutoSize = true;
            lblNguoiDongGop.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNguoiDongGop.Location = new Point(429, 81);
            lblNguoiDongGop.Name = "lblNguoiDongGop";
            lblNguoiDongGop.Size = new Size(76, 31);
            lblNguoiDongGop.TabIndex = 3;
            lblNguoiDongGop.Text = "label1";
            // 
            // btnNgauNhien
            // 
            btnNgauNhien.BackColor = SystemColors.Info;
            btnNgauNhien.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNgauNhien.ForeColor = SystemColors.InactiveCaptionText;
            btnNgauNhien.Location = new Point(277, 22);
            btnNgauNhien.Name = "btnNgauNhien";
            btnNgauNhien.Size = new Size(111, 198);
            btnNgauNhien.TabIndex = 4;
            btnNgauNhien.Text = "Ngẫu Nhiên";
            btnNgauNhien.UseVisualStyleBackColor = false;
            btnNgauNhien.Click += btnNgauNhien_Click;
            // 
            // NtnNapLai
            // 
            NtnNapLai.BackColor = SystemColors.Info;
            NtnNapLai.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NtnNapLai.ForeColor = SystemColors.InactiveCaptionText;
            NtnNapLai.Location = new Point(277, 267);
            NtnNapLai.Name = "NtnNapLai";
            NtnNapLai.Size = new Size(111, 101);
            NtnNapLai.TabIndex = 5;
            NtnNapLai.Text = "Nạp Lại";
            NtnNapLai.UseVisualStyleBackColor = false;
            NtnNapLai.Click += NtnNapLai_Click;
            // 
            // Bai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(NtnNapLai);
            Controls.Add(btnNgauNhien);
            Controls.Add(lblNguoiDongGop);
            Controls.Add(lblTenMon);
            Controls.Add(picMon);
            Controls.Add(lvMonAn);
            Name = "Bai06";
            Text = "Bai06";
            ((System.ComponentModel.ISupportInitialize)picMon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvMonAn;
        private PictureBox picMon;
        private Label lblTenMon;
        private Label lblNguoiDongGop;
        private Button btnNgauNhien;
        private Button NtnNapLai;
    }
}