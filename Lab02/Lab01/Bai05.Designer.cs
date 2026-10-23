namespace Lab01;

partial class Bai05
{
    private System.ComponentModel.IContainer? components = null;
    private Button btnBrowse = null!;
    private TextBox txtFolderPath = null!;
    private Label lblFileCount = null!;
    private ListView lvFiles = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components is not null)
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        btnBrowse = new Button();
        txtFolderPath = new TextBox();
        lblFileCount = new Label();
        lvFiles = new ListView();
        SuspendLayout();

        btnBrowse.Location = new Point(16, 16);
        btnBrowse.Size = new Size(190, 36);
        btnBrowse.Text = "CHỌN THƯ MỤC";
        btnBrowse.Click += btnBrowse_Click;

        txtFolderPath.Location = new Point(220, 20);
        txtFolderPath.Size = new Size(750, 27);
        txtFolderPath.ReadOnly = true;
        txtFolderPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

        lblFileCount.AutoSize = true;
        lblFileCount.Location = new Point(16, 66);
        lblFileCount.Text = "Số file: 0";

        lvFiles.Location = new Point(16, 95);
        lvFiles.Size = new Size(954, 500);
        lvFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lvFiles.View = View.Details;
        lvFiles.FullRowSelect = true;
        lvFiles.GridLines = true;
        lvFiles.Columns.Add("Tên file", 390);
        lvFiles.Columns.Add("Kích thước (byte)", 170);
        lvFiles.Columns.Add("Ngày tạo", 230);
        lvFiles.Columns.Add("Đuôi mở rộng", 140);

        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(990, 615);
        Controls.Add(btnBrowse);
        Controls.Add(txtFolderPath);
        Controls.Add(lblFileCount);
        Controls.Add(lvFiles);
        Name = "Bai05";
        Text = "Bài 05 - Duyệt thư mục";
        ResumeLayout(false);
        PerformLayout();
    }
}
