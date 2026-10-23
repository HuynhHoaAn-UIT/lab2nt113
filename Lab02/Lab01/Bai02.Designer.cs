namespace Lab01
{
    partial class Bai02
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
            btnReadFile = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnExit = new Button();
            txtFileName = new TextBox();
            txtSize = new TextBox();
            txtURL = new TextBox();
            txtLines = new TextBox();
            txtWords = new TextBox();
            txtChars = new TextBox();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btnReadFile
            // 
            btnReadFile.BackColor = SystemColors.Info;
            btnReadFile.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReadFile.Location = new Point(21, 22);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(240, 41);
            btnReadFile.TabIndex = 0;
            btnReadFile.Text = "Read from file";
            btnReadFile.UseVisualStyleBackColor = false;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(21, 81);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 1;
            label1.Text = "File Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(21, 123);
            label2.Name = "label2";
            label2.Size = new Size(47, 28);
            label2.TabIndex = 2;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(21, 171);
            label3.Name = "label3";
            label3.Size = new Size(47, 28);
            label3.TabIndex = 3;
            label3.Text = "URL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(21, 215);
            label4.Name = "label4";
            label4.Size = new Size(105, 28);
            label4.TabIndex = 4;
            label4.Text = "Line Count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(21, 268);
            label5.Name = "label5";
            label5.Size = new Size(127, 28);
            label5.TabIndex = 5;
            label5.Text = "Words Count";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(21, 319);
            label6.Name = "label6";
            label6.Size = new Size(136, 23);
            label6.TabIndex = 6;
            label6.Text = "Character Count";
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.Info;
            btnExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(21, 379);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(240, 41);
            btnExit.TabIndex = 7;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(160, 82);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(195, 27);
            txtFileName.TabIndex = 8;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(160, 127);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(195, 27);
            txtSize.TabIndex = 9;
            // 
            // txtURL
            // 
            txtURL.Location = new Point(160, 175);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(195, 27);
            txtURL.TabIndex = 10;
            // 
            // txtLines
            // 
            txtLines.Location = new Point(160, 219);
            txtLines.Name = "txtLines";
            txtLines.Size = new Size(195, 27);
            txtLines.TabIndex = 11;
            // 
            // txtWords
            // 
            txtWords.Location = new Point(160, 272);
            txtWords.Name = "txtWords";
            txtWords.Size = new Size(195, 27);
            txtWords.TabIndex = 12;
            // 
            // txtChars
            // 
            txtChars.Location = new Point(160, 319);
            txtChars.Name = "txtChars";
            txtChars.Size = new Size(195, 27);
            txtChars.TabIndex = 13;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.InfoText;
            richTextBox1.ForeColor = SystemColors.HotTrack;
            richTextBox1.Location = new Point(376, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(412, 416);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "";
            // 
            // Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.anh_mo_ta;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(txtChars);
            Controls.Add(txtWords);
            Controls.Add(txtLines);
            Controls.Add(txtURL);
            Controls.Add(txtSize);
            Controls.Add(txtFileName);
            Controls.Add(btnExit);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnReadFile);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Bai02";
            Text = "Bai02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReadFile;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnExit;
        private TextBox txtFileName;
        private TextBox txtSize;
        private TextBox txtURL;
        private TextBox txtLines;
        private TextBox txtWords;
        private TextBox txtChars;
        private RichTextBox richTextBox1;
    }
}