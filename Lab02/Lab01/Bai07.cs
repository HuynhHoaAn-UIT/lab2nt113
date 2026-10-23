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
    public partial class Bai07 : Form
    {
        public Bai07()
        {
            InitializeComponent();
            this.Load += Bai07_Load;
            treeView1.BeforeExpand += treeView1_BeforeExpand;
            treeView1.NodeMouseDoubleClick += treeView1_NodeMouseDoubleClick;
        }

        private void Bai07_Load(object sender, EventArgs e)
        {
            LoadDrives();
        }
        private void LoadDrives()
        {
            treeView1.Nodes.Clear();
            foreach (var drive in DriveInfo.GetDrives())
            {
                TreeNode node = new TreeNode(drive.Name);
                node.Tag = drive.Name;
                node.Nodes.Add("..."); 
                treeView1.Nodes.Add(node);
            }
        }
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string path = e.Node.Tag.ToString();

            try
            {
                foreach (var dir in Directory.GetDirectories(path))
                {
                    TreeNode node = new TreeNode(Path.GetFileName(dir));
                    node.Tag = dir;
                    node.Nodes.Add("...");
                    e.Node.Nodes.Add(node);
                }
                foreach (var file in Directory.GetFiles(path))
                {
                    TreeNode node = new TreeNode(Path.GetFileName(file));
                    node.Tag = file;
                    e.Node.Nodes.Add(node);
                }
            }
            catch (UnauthorizedAccessException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc thư mục: " + ex.Message);
            }
        }
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string path = e.Node.Tag.ToString();
            if (Directory.Exists(path))
            {
                e.Node.Expand();
                return;
            }

            if (!File.Exists(path))
                return;

            string ext = Path.GetExtension(path).ToLower();

            if (ext == ".jpg" || ext == ".png" || ext == ".bmp" || ext == ".jpeg" || ext == ".gif")
            {
                try
                {
                    pictureBox1.Visible = true;
                    textBox1.Visible = false;

                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = null;
                    }

                    using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        pictureBox1.Image = Image.FromStream(fs);
                    }

                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể hiển thị ảnh: " + ex.Message);
                }
            }
            else if (ext == ".txt" || ext == ".log" || ext == ".csv")
            {
                pictureBox1.Visible = false;
                textBox1.Visible = true;
                try
                {
                    textBox1.Text = File.ReadAllText(path);
                }
                catch (Exception ex)
                {
                    textBox1.Text = "Không thể đọc file: " + ex.Message;
                }
            }
            else
            {
                pictureBox1.Visible = false;
                textBox1.Visible = true;
                textBox1.Text = "Không hỗ trợ định dạng này.";
            }
        }
    }
}

