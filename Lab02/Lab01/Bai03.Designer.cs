namespace Lab01
{
    partial class Bai03
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
            btnReadfile = new Button();
            btnWriteFile = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            richInput = new RichTextBox();
            richOutput = new RichTextBox();
            SuspendLayout();
            // 
            // btnReadfile
            // 
            btnReadfile.BackColor = SystemColors.ActiveCaption;
            btnReadfile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReadfile.Location = new Point(26, 46);
            btnReadfile.Name = "btnReadfile";
            btnReadfile.Size = new Size(138, 83);
            btnReadfile.TabIndex = 0;
            btnReadfile.Text = "Read File";
            btnReadfile.UseVisualStyleBackColor = false;
            btnReadfile.Click += btnReadfile_Click;
            // 
            // btnWriteFile
            // 
            btnWriteFile.BackColor = SystemColors.ActiveCaption;
            btnWriteFile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWriteFile.Location = new Point(26, 172);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(138, 83);
            btnWriteFile.TabIndex = 1;
            btnWriteFile.Text = "Write File";
            btnWriteFile.UseVisualStyleBackColor = false;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.Info;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(26, 297);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(138, 83);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaption;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(515, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 31);
            label1.TabIndex = 3;
            label1.Text = "Input";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InactiveCaption;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(515, 249);
            label2.Name = "label2";
            label2.Size = new Size(83, 31);
            label2.TabIndex = 4;
            label2.Text = "output";
            // 
            // richInput
            // 
            richInput.BackColor = SystemColors.InfoText;
            richInput.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richInput.ForeColor = SystemColors.HotTrack;
            richInput.Location = new Point(227, 46);
            richInput.Name = "richInput";
            richInput.Size = new Size(570, 188);
            richInput.TabIndex = 5;
            richInput.Text = "";
            // 
            // richOutput
            // 
            richOutput.BackColor = SystemColors.InfoText;
            richOutput.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richOutput.ForeColor = SystemColors.HotTrack;
            richOutput.Location = new Point(227, 283);
            richOutput.Name = "richOutput";
            richOutput.Size = new Size(570, 155);
            richOutput.TabIndex = 6;
            richOutput.Text = "";
            // 
            // Bai03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.image_cache;
            ClientSize = new Size(800, 450);
            Controls.Add(richOutput);
            Controls.Add(richInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnWriteFile);
            Controls.Add(btnReadfile);
            Name = "Bai03";
            Text = "Bai03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReadfile;
        private Button btnWriteFile;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private RichTextBox richInput;
        private RichTextBox richOutput;
    }
}