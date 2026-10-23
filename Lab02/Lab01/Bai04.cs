using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab01;

public partial class Bai04 : Form
{
    private readonly string inputFile = Path.Combine(AppContext.BaseDirectory, "input.txt");
    private readonly string outputFile = Path.Combine(AppContext.BaseDirectory, "output.txt");
    private readonly List<Student> students = new();

    public Bai04()
    {
        InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMSSV.Text) ||
            string.IsNullOrWhiteSpace(txtHoTen.Text) ||
            string.IsNullOrWhiteSpace(txtDienThoai.Text))
        {
            MessageBox.Show("Nhập MSSV, họ tên và điện thoại.", "Thiếu thông tin");
            return;
        }

        if (!TryReadScore(txtDiemToan.Text, out float diemToan) ||
            !TryReadScore(txtDiemVan.Text, out float diemVan) ||
            diemToan is < 0 or > 10 || diemVan is < 0 or > 10)
        {
            MessageBox.Show("Điểm Toán và Văn phải là số từ 0 đến 10.", "Dữ liệu không hợp lệ");
            return;
        }

        students.Add(new Student
        {
            MSSV = txtMSSV.Text.Trim(),
            HoTen = txtHoTen.Text.Trim(),
            DienThoai = txtDienThoai.Text.Trim(),
            DiemToan = diemToan,
            DiemVan = diemVan
        });

        listStudents.Items.Add($"{txtMSSV.Text.Trim()} - {txtHoTen.Text.Trim()}");
        txtMSSV.Clear();
        txtHoTen.Clear();
        txtDienThoai.Clear();
        txtDiemToan.Clear();
        txtDiemVan.Clear();
        txtMSSV.Focus();
    }

    private void btnWriteFile_Click(object sender, EventArgs e)
    {
        if (students.Count == 0)
        {
            MessageBox.Show("Hãy nhập ít nhất một học viên trước khi ghi file.", "Chưa có dữ liệu");
            return;
        }

        try
        {
            Student[] studentArray = students.ToArray();
            using var stream = new FileStream(inputFile, FileMode.Create, FileAccess.Write);
#pragma warning disable SYSLIB0011
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, studentArray);
#pragma warning restore SYSLIB0011
            MessageBox.Show("Đã ghi mảng học viên dạng nhị phân vào input.txt.", "Thông báo");
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException or System.Runtime.Serialization.SerializationException)
        {
            MessageBox.Show($"Không thể ghi input.txt: {ex.Message}", "Lỗi");
        }
    }

    private void btnReadFile_Click(object sender, EventArgs e)
    {
        if (!File.Exists(inputFile))
        {
            MessageBox.Show($"Không tìm thấy file: {inputFile}", "Lỗi");
            return;
        }

        try
        {
            Student[] studentArray;
            using (var stream = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
            {
#pragma warning disable SYSLIB0011
                var formatter = new BinaryFormatter();
                studentArray = (Student[])formatter.Deserialize(stream);
#pragma warning restore SYSLIB0011
            }

            string[] outputLines = studentArray.Select(student =>
            {
                student.CalculateAverage();
                return $"MSSV: {student.MSSV} | Họ tên: {student.HoTen} | Điện thoại: {student.DienThoai} | " +
                       $"Toán: {student.DiemToan:F1} | Văn: {student.DiemVan:F1} | ĐTB: {student.DTB:F2}";
            }).ToArray();

            File.WriteAllLines(outputFile, outputLines);
            richResult.Lines = outputLines;
            MessageBox.Show("Đã đọc mảng, tính điểm trung bình và ghi kết quả vào output.txt.", "Thông báo");
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException or System.Runtime.Serialization.SerializationException or InvalidCastException)
        {
            MessageBox.Show($"Không thể xử lý input.txt: {ex.Message}", "Lỗi");
        }
    }

    private static bool TryReadScore(string text, out float score) =>
        float.TryParse(text, NumberStyles.Float, CultureInfo.CurrentCulture, out score) ||
        float.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out score);

    [Serializable]
    public class Student
    {
        public string MSSV { get; set; } = "";
        public string HoTen { get; set; } = "";
        public string DienThoai { get; set; } = "";
        public float DiemToan { get; set; }
        public float DiemVan { get; set; }
        public float DTB { get; set; }

        public void CalculateAverage() => DTB = (DiemToan + DiemVan) / 2;
    }
}
