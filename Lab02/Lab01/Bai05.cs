using System.IO;
using System.Windows.Forms;

namespace Lab01;

public partial class Bai05 : Form
{
    public Bai05()
    {
        InitializeComponent();
    }

    private void btnBrowse_Click(object sender, EventArgs e)
    {
        using var dialog = new FolderBrowserDialog
        {
            Description = "Chọn thư mục cần liệt kê file",
            UseDescriptionForTitle = true,
            ShowNewFolderButton = false
        };

        if (dialog.ShowDialog() != DialogResult.OK)
            return;

        try
        {
            txtFolderPath.Text = dialog.SelectedPath;
            lvFiles.Items.Clear();

            var directory = new DirectoryInfo(dialog.SelectedPath);
            foreach (FileInfo file in directory.GetFiles())
            {
                var item = new ListViewItem(file.Name);
                item.SubItems.Add(file.Length.ToString("N0"));
                item.SubItems.Add(file.CreationTime.ToString("dd/MM/yyyy HH:mm:ss"));
                item.SubItems.Add(file.Extension);
                lvFiles.Items.Add(item);
            }

            lblFileCount.Text = $"Số file: {lvFiles.Items.Count}";
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
        {
            MessageBox.Show($"Không thể đọc thư mục: {ex.Message}", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
