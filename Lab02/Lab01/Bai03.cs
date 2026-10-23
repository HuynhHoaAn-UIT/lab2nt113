using System.Globalization;
using System.IO;

namespace Lab01;

public partial class Bai03 : Form
{
    private readonly string inputFile = Path.Combine(AppContext.BaseDirectory, "input.txt");
    private readonly string outputFile = Path.Combine(AppContext.BaseDirectory, "output.txt");

    public Bai03()
    {
        InitializeComponent();
    }

    private void btnReadfile_Click(object sender, EventArgs e)
    {
        try
        {
            if (!File.Exists(inputFile))
            {
                MessageBox.Show($"Không tìm thấy file: {inputFile}", "Lỗi");
                return;
            }

            richInput.Lines = File.ReadAllLines(inputFile);
            richOutput.Clear();
        }
        catch (IOException ex)
        {
            MessageBox.Show($"Không thể đọc file: {ex.Message}", "Lỗi");
        }
    }

    private void btnWriteFile_Click(object sender, EventArgs e)
    {
        try
        {
            if (!File.Exists(inputFile))
            {
                MessageBox.Show($"Không tìm thấy file: {inputFile}", "Lỗi");
                return;
            }

            string[] expressions = File.ReadAllLines(inputFile);
            var results = new List<string>();
            for (int i = 0; i < expressions.Length; i++)
            {
                string expression = expressions[i].Trim();
                if (expression.Length == 0)
                    continue;

                double result;
                try
                {
                    result = new ExpressionParser(expression).Parse();
                }
                catch (FormatException ex)
                {
                    throw new FormatException($"Dòng {i + 1}: {ex.Message}");
                }

                results.Add($"{expression} = {result.ToString(CultureInfo.InvariantCulture)}");
            }

            File.WriteAllLines(outputFile, results);
            richInput.Lines = expressions;
            richOutput.Lines = results.ToArray();
            MessageBox.Show("Đã tính các biểu thức và ghi kết quả vào output.txt.", "Thông báo");
        }
        catch (Exception ex) when (ex is IOException or FormatException)
        {
            MessageBox.Show($"Không thể xử lý file: {ex.Message}", "Lỗi");
        }
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private sealed class ExpressionParser(string text)
    {
        private int position;

        public double Parse()
        {
            double value = ParseExpression();
            SkipWhitespace();
            if (position != text.Length)
                throw new FormatException($"Ký tự không hợp lệ tại vị trí {position + 1}.");
            return value;
        }

        private double ParseExpression()
        {
            double value = ParseTerm();
            while (true)
            {
                SkipWhitespace();
                if (Consume('+')) value += ParseTerm();
                else if (Consume('-')) value -= ParseTerm();
                else return value;
            }
        }

        private double ParseTerm()
        {
            double value = ParseFactor();
            while (true)
            {
                SkipWhitespace();
                if (Consume('*')) value *= ParseFactor();
                else if (Consume('/'))
                {
                    double divisor = ParseFactor();
                    if (divisor == 0)
                        throw new FormatException("Không thể chia cho 0.");
                    value /= divisor;
                }
                else return value;
            }
        }

        private double ParseFactor()
        {
            SkipWhitespace();
            if (Consume('+')) return ParseFactor();
            if (Consume('-')) return -ParseFactor();
            if (Consume('('))
            {
                double value = ParseExpression();
                SkipWhitespace();
                if (!Consume(')'))
                    throw new FormatException("Thiếu dấu ngoặc đóng.");
                return value;
            }

            int start = position;
            while (position < text.Length && (char.IsDigit(text[position]) || text[position] == '.'))
                position++;

            if (start == position || !double.TryParse(
                    text[start..position], NumberStyles.Float, CultureInfo.InvariantCulture, out double number))
                throw new FormatException($"Thiếu số hợp lệ tại vị trí {start + 1}.");
            return number;
        }

        private bool Consume(char expected)
        {
            if (position >= text.Length || text[position] != expected)
                return false;
            position++;
            return true;
        }

        private void SkipWhitespace()
        {
            while (position < text.Length && char.IsWhiteSpace(text[position]))
                position++;
        }
    }
}
