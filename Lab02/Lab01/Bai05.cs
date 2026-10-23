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
            // Liệt kê file trong thư mục đã chọn và toàn bộ thư mục con.
            foreach (FileInfo file in directory.GetFiles("*", SearchOption.AllDirectories)
                         .OrderBy(file => file.FullName, StringComparer.OrdinalIgnoreCase))
            {
                // Hiện đường dẫn tương đối để phân biệt các file trùng tên ở thư mục con.
                var relativePath = Path.GetRelativePath(directory.FullName, file.FullName);
                var item = new ListViewItem(relativePath);
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
