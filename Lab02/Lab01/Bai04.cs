using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Bai04 : Form
    {
        List<Student> students = new List<Student>();
        int currentIndex = 0;
        string inputFile = "input4.txt";
        string outputFile = "output4.txt";
        public Bai04()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtID.Text == "" || txtPhone.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
                if (txtPhone.Text.Length != 10 || !txtPhone.Text.StartsWith("0"))
                {
                    MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bằng 0!");
                    return;
                }
                if (txtID.Text.Length != 8)
                {
                    MessageBox.Show("MSSV phải có 8 chữ số!");
                    return;
                }
                float c1 = float.Parse(txtCourse1.Text);
                float c2 = float.Parse(txtCourse2.Text);
                float c3 = float.Parse(txtCourse3.Text);
                if (c1 < 0 || c1 > 10 || c2 < 0 || c2 > 10 || c3 < 0 || c3 > 10)
                {
                    MessageBox.Show("Điểm phải nằm trong khoảng 0 - 10!");
                    return;
                }
                Student s = new Student()
                {
                    Name = txtName.Text,
                    MSSV = txtID.Text,
                    Phone = txtPhone.Text,
                    Course1 = c1,
                    Course2 = c2,
                    Course3 = c3
                };
                s.CalculateAverage();
                students.Add(s);
                listBoxStudents.Items.Add($"{s.Name} - {s.MSSV} - TB: {s.Average:F2}");
                MessageBox.Show("Thêm sinh viên thành công!");
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message);
            }
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fs = new FileStream(inputFile, FileMode.Create))
                {
#pragma warning disable SYSLIB0011
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, students);
#pragma warning restore SYSLIB0011
                }
                MessageBox.Show("Ghi dữ liệu xuống file thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message);
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(inputFile))
                {
                    MessageBox.Show("Không tìm thấy file input4.txt!");
                    return;
                }

                using (FileStream fs = new FileStream(inputFile, FileMode.Open))
                {
#pragma warning disable SYSLIB0011
                    BinaryFormatter bf = new BinaryFormatter();
                    students = (List<Student>)bf.Deserialize(fs);
#pragma warning restore SYSLIB0011
                }

                using (StreamWriter sw = new StreamWriter(outputFile))
                {
                    foreach (var s in students)
                    {
                        s.CalculateAverage();
                        sw.WriteLine($"{s.Name} - {s.MSSV} - TB: {s.Average:F2}");
                    }
                }

                if (students.Count > 0)
                {
                    currentIndex = 0;
                    DisplayStudent(students[currentIndex]);
                }

                MessageBox.Show("Đọc và ghi file thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
            }
        }
        private void DisplayStudent(Student s)
        {
            txtNameR.Text = s.Name;
            txtIDR.Text = s.MSSV;
            txtPhoneR.Text = s.Phone;
            txtCourse1R.Text = s.Course1.ToString();
            txtCourse2R.Text = s.Course2.ToString();
            txtCourse3R.Text = s.Course3.ToString();
            txtAverageR.Text = s.Average.ToString("F2");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (students.Count == 0) return;
            currentIndex = (currentIndex - 1 + students.Count) % students.Count;
            DisplayStudent(students[currentIndex]);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (students.Count == 0) return;
            currentIndex = (currentIndex + 1) % students.Count;
            DisplayStudent(students[currentIndex]);
        }
        private void ClearInputs()
        {
            txtName.Clear();
            txtID.Clear();
            txtPhone.Clear();
            txtCourse1.Clear();
            txtCourse2.Clear();
            txtCourse3.Clear();
        }
        [Serializable]
        public class Student
        {
            public string Name { get; set; }
            public string MSSV { get; set; }
            public string Phone { get; set; }
            public float Course1 { get; set; }
            public float Course2 { get; set; }
            public float Course3 { get; set; }
            public float Average { get; set; }

            public void CalculateAverage()
            {
                Average = (Course1 + Course2 + Course3) / 3;
            }
        }
    }
}