namespace Lab01;

partial class Form1
{
    private System.ComponentModel.IContainer? components = null;
    private Button button1 = null!;
    private Button button2 = null!;
    private Button button3 = null!;
    private Button button4 = null!;
    private Button button5 = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components is not null)
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        button5 = new Button();
        SuspendLayout();

        Button[] buttons = { button1, button2, button3, button4, button5 };
        EventHandler[] handlers = { button1_Click, button2_Click, button3_Click, button4_Click, button5_Click };
        string[] captions = { "Bài 01 - Đọc/Ghi", "Bài 02 - Thống kê file", "Bài 03 - Tính biểu thức", "Bài 04 - BinaryFormatter", "Bài 05 - Duyệt thư mục" };
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].Location = new Point(35 + (i % 2) * 355, 55 + (i / 2) * 115);
            buttons[i].Size = new Size(320, 75);
            buttons[i].Text = captions[i];
            buttons[i].UseVisualStyleBackColor = true;
            buttons[i].Click += handlers[i];
            Controls.Add(buttons[i]);
        }

        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(760, 420);
        Name = "Form1";
        Text = "Lab 2 - File và I/O Stream trong C#";
        ResumeLayout(false);
    }
}
