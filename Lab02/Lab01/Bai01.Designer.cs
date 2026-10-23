namespace Lab01
{
    partial class Bai01
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
            btnDoc = new Button();
            btnGhi = new Button();
            rtbKetQua = new RichTextBox();
            SuspendLayout();
            // 
            // btnDoc
            // 
            btnDoc.BackColor = SystemColors.ActiveCaption;
            btnDoc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDoc.Location = new Point(83, 98);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(158, 80);
            btnDoc.TabIndex = 0;
            btnDoc.Text = "Đọc File";
            btnDoc.UseVisualStyleBackColor = false;
            btnDoc.Click += btnDoc_Click;
            // 
            // btnGhi
            // 
            btnGhi.BackColor = SystemColors.ActiveCaption;
            btnGhi.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGhi.Location = new Point(83, 277);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(158, 80);
            btnGhi.TabIndex = 1;
            btnGhi.Text = "Ghi File";
            btnGhi.UseVisualStyleBackColor = false;
            btnGhi.Click += btnGhi_Click;
            // 
            // rtbKetQua
            // 
            rtbKetQua.Location = new Point(382, 54);
            rtbKetQua.Name = "rtbKetQua";
            rtbKetQua.Size = new Size(326, 330);
            rtbKetQua.TabIndex = 2;
            rtbKetQua.Text = "";
            // 
            // Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1459373176_612x612;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbKetQua);
            Controls.Add(btnGhi);
            Controls.Add(btnDoc);
            Name = "Bai01";
            Text = "Bai01";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDoc;
        private Button btnGhi;
        private RichTextBox rtbKetQua;
    }
}