using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;



namespace Lab01
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            try
            {
                string FileInput = "input1.txt";
                if (!File.Exists(FileInput))
                {
                    MessageBox.Show("Không tìm thấy file input1.txt", "Lỗi!");
                    return;
                }
                using (StreamReader sr = new StreamReader(FileInput))
                {
                    string NoiDung = sr.ReadToEnd();
                    rtbKetQua.Text = NoiDung;
                }
                MessageBox.Show("Đọc File thành công !", "Thông Báo");
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
                }
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            string FileOutput = "output1.txt";
            string NoiDung = rtbKetQua.Text;
            try
            {
                using (StreamWriter sw = new StreamWriter(FileOutput)) {
                    sw.Write(NoiDung);
                }
                MessageBox.Show("Đã ghi nội dung xuống file output1.txt thành công!", "Thông báo");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message);
            }
        }
    }
    }
