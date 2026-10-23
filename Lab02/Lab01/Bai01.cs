using System.IO;

namespace Lab01;

public partial class Bai01 : Form
{
    private readonly string inputFile = Path.Combine(AppContext.BaseDirectory, "input.txt");
    private readonly string outputFile = Path.Combine(AppContext.BaseDirectory, "output.txt");

    public Bai01()
    {
        InitializeComponent();
    }

    private void btnDoc_Click(object sender, EventArgs e)
    {
        try
        {
            if (!File.Exists(inputFile))
            {
                MessageBox.Show($"Không tìm thấy file: {inputFile}", "Lỗi");
                return;
            }

            using var reader = new StreamReader(inputFile);
            rtbKetQua.Text = reader.ReadToEnd();
        }
        catch (IOException ex)
        {
            MessageBox.Show($"Không thể đọc file: {ex.Message}", "Lỗi");
        }
    }

    private void btnGhi_Click(object sender, EventArgs e)
    {
        try
        {
            using var writer = new StreamWriter(outputFile, false);
            writer.Write(rtbKetQua.Text.ToUpperInvariant());
            MessageBox.Show("Đã ghi nội dung chữ hoa vào output.txt.", "Thông báo");
        }
        catch (IOException ex)
        {
            MessageBox.Show($"Không thể ghi file: {ex.Message}", "Lỗi");
        }
    }
}
