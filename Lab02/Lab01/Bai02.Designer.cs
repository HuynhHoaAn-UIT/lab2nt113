namespace Lab01;

partial class Bai02
{
    private System.ComponentModel.IContainer? components = null;
    private Button btnReadFile = null!;
    private Button btnExit = null!;
    private Label label1 = null!;
    private Label label2 = null!;
    private Label label3 = null!;
    private Label label4 = null!;
    private Label label5 = null!;
    private TextBox txtFileName = null!;
    private TextBox txtURL = null!;
    private TextBox txtLines = null!;
    private TextBox txtWords = null!;
    private TextBox txtChars = null!;
    private RichTextBox richTextBox1 = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components is not null)
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        btnReadFile = new Button();
        btnExit = new Button();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        txtFileName = new TextBox();
        txtURL = new TextBox();
        txtLines = new TextBox();
        txtWords = new TextBox();
        txtChars = new TextBox();
        richTextBox1 = new RichTextBox();
        SuspendLayout();

        btnReadFile.Location = new Point(20, 20);
        btnReadFile.Size = new Size(300, 42);
        btnReadFile.Text = "ĐỌC FILE";
        btnReadFile.Click += btnReadFile_Click;

        string[] captions = { "Tên file", "Đường dẫn URL", "Số dòng", "Số từ", "Số ký tự" };
        TextBox[] boxes = { txtFileName, txtURL, txtLines, txtWords, txtChars };
        Label[] labels = { label1, label2, label3, label4, label5 };
        for (int i = 0; i < captions.Length; i++)
        {
            int y = 82 + i * 46;
            labels[i].AutoSize = true;
            labels[i].Location = new Point(20, y + 4);
            labels[i].Text = captions[i];
            boxes[i].Location = new Point(142, y);
            boxes[i].Size = new Size(280, 27);
            boxes[i].ReadOnly = true;
            Controls.Add(labels[i]);
            Controls.Add(boxes[i]);
        }

        richTextBox1.Location = new Point(445, 20);
        richTextBox1.Size = new Size(515, 485);
        richTextBox1.ReadOnly = true;
        richTextBox1.WordWrap = true;

        btnExit.Location = new Point(20, 335);
        btnExit.Size = new Size(300, 42);
        btnExit.Text = "THOÁT";
        btnExit.Click += btnExit_Click;

        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(980, 525);
        Controls.Add(btnReadFile);
        Controls.Add(btnExit);
        Controls.Add(richTextBox1);
        Name = "Bai02";
        Text = "Bài 02 - Đọc thông tin file .txt";
        ResumeLayout(false);
        PerformLayout();
    }
}
