namespace Lab01;

partial class Bai04
{
    private System.ComponentModel.IContainer? components = null;
    private TextBox txtMSSV = null!;
    private TextBox txtHoTen = null!;
    private TextBox txtDienThoai = null!;
    private TextBox txtDiemToan = null!;
    private TextBox txtDiemVan = null!;
    private ListBox listStudents = null!;
    private RichTextBox richResult = null!;
    private Button btnAdd = null!;
    private Button btnWriteFile = null!;
    private Button btnReadFile = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components is not null)
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        txtMSSV = new TextBox();
        txtHoTen = new TextBox();
        txtDienThoai = new TextBox();
        txtDiemToan = new TextBox();
        txtDiemVan = new TextBox();
        listStudents = new ListBox();
        richResult = new RichTextBox();
        btnAdd = new Button();
        btnWriteFile = new Button();
        btnReadFile = new Button();
        SuspendLayout();

        var inputGroup = new GroupBox
        {
            Location = new Point(16, 16),
            Size = new Size(430, 535),
            Text = "Nhập thông tin học viên"
        };
        string[] labels = { "MSSV", "Họ tên", "Điện thoại", "Điểm Toán", "Điểm Văn" };
        TextBox[] boxes = { txtMSSV, txtHoTen, txtDienThoai, txtDiemToan, txtDiemVan };
        for (int i = 0; i < labels.Length; i++)
        {
            int y = 34 + i * 42;
            inputGroup.Controls.Add(new Label
            {
                AutoSize = true,
                Location = new Point(16, y + 4),
                Text = labels[i]
            });
            boxes[i].Location = new Point(125, y);
            boxes[i].Size = new Size(280, 27);
            inputGroup.Controls.Add(boxes[i]);
        }

        btnAdd.Location = new Point(16, 252);
        btnAdd.Size = new Size(389, 36);
        btnAdd.Text = "THÊM HỌC VIÊN";
        btnAdd.Click += btnAdd_Click;
        inputGroup.Controls.Add(btnAdd);

        listStudents.Location = new Point(16, 302);
        listStudents.Size = new Size(389, 210);
        inputGroup.Controls.Add(listStudents);

        btnWriteFile.Location = new Point(470, 18);
        btnWriteFile.Size = new Size(495, 40);
        btnWriteFile.Text = "GHI MẢNG HỌC VIÊN VÀO input.txt";
        btnWriteFile.Click += btnWriteFile_Click;

        btnReadFile.Location = new Point(470, 68);
        btnReadFile.Size = new Size(495, 40);
        btnReadFile.Text = "ĐỌC FILE, TÍNH ĐTB VÀ GHI output.txt";
        btnReadFile.Click += btnReadFile_Click;

        richResult.Location = new Point(470, 126);
        richResult.Size = new Size(495, 425);
        richResult.ReadOnly = true;
        richResult.WordWrap = false;

        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(985, 570);
        Controls.Add(inputGroup);
        Controls.Add(btnWriteFile);
        Controls.Add(btnReadFile);
        Controls.Add(richResult);
        Name = "Bai04";
        Text = "Bài 04 - BinaryFormatter";
        ResumeLayout(false);
    }
}
