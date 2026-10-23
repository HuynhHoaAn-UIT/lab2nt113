using System.IO;
using System.Windows.Forms;

namespace Lab01;

public partial class Bai02 : Form
{
    public Bai02()
    {
        InitializeComponent();
    }

    private void btnReadFile_Click(object sender, EventArgs e)
    {
        using var dialog = new OpenFileDialog
        {
            Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
            Title = "Chọn file cần đọc"
        };

        if (dialog.ShowDialog() != DialogResult.OK)
            return;

        try
        {
            string content;
            using (var reader = new StreamReader(dialog.FileName))
                content = reader.ReadToEnd();

            txtFileName.Text = dialog.SafeFileName;
            txtURL.Text = Path.GetFullPath(dialog.FileName);
            txtLines.Text = CountLines(content).ToString();
            txtWords.Text = content.Split(
                new[] { ' ', '\t', '\r', '\n' },
                StringSplitOptions.RemoveEmptyEntries).Length.ToString();
            txtChars.Text = content.Length.ToString();
            richTextBox1.Text = content;
        }
        catch (IOException ex)
        {
            MessageBox.Show($"Không thể đọc file: {ex.Message}", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private static int CountLines(string content)
    {
        if (content.Length == 0)
            return 0;

        int count = 0;
        using var reader = new StringReader(content);
        while (reader.ReadLine() is not null)
            count++;
        return count;
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();
    }
}
