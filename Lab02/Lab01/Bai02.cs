using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (ofd.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                string filePath = ofd.FileName;
                string fileName = ofd.SafeFileName;
                string content;
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (StreamReader sr = new StreamReader(fs))
                {
                    content = sr.ReadToEnd();
                    txtFileName.Text = fileName;
                    txtURL.Text = fs.Name;
                    txtSize.Text = fs.Length + " bytes";
                }
                richTextBox1.Text = content;
                int lineCount = content.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
                int charCount = content.Length;
                int wordCount = content.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
                txtLines.Text = lineCount.ToString();
                txtWords.Text = wordCount.ToString();
                txtChars.Text = charCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
