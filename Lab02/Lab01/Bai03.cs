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
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void btnReadfile_Click(object sender, EventArgs e)
        {
            try
            {
                string inputPath = "input3.txt";

                if (!File.Exists(inputPath))
                {
                    MessageBox.Show("Không tìm thấy file input3.txt!");
                    return;
                }
                string[] lines = File.ReadAllLines(inputPath);
                richInput.Clear();
                richInput.Lines = lines;
                MessageBox.Show("Đọc file thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
            }
        }
        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            try
            {
                string inputPath = "input3.txt";
                string outputPath = "output3.txt";
                if (!File.Exists(inputPath))
                {
                    MessageBox.Show("Không tìm thấy file input3.txt!");
                    return;
                }
                string[] lines = File.ReadAllLines(inputPath);
                List<string> results = new List<string>();
                foreach (string line in lines)
                {
                    string expr = line.Trim();
                    if (expr == "") continue;

                    double result = EvaluateExpression(expr);
                    results.Add(expr + " = " + result);
                }
                File.WriteAllLines(outputPath, results);
                richOutput.Lines = results.ToArray();
                MessageBox.Show("Đã ghi kết quả xuống file output3.txt!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message);
            }
        }
        private double EvaluateExpression(string expr)
        {
            try
            {
                List<string> tokens = Tokenize(expr);
                Stack<double> values = new Stack<double>();
                Stack<char> ops = new Stack<char>();

                for (int i = 0; i < tokens.Count; i++)
                {
                    string token = tokens[i];

                    if (double.TryParse(token, out double num))
                    {
                        values.Push(num);
                    }
                    else if (token == "(")
                    {
                        ops.Push('(');
                    }
                    else if (token == ")")
                    {
                        while (ops.Peek() != '(')
                            values.Push(ApplyOp(ops.Pop(), values.Pop(), values.Pop()));
                        ops.Pop();
                    }
                    else
                    {
                        char op = token[0];
                        while (ops.Count > 0 && Precedence(ops.Peek()) >= Precedence(op))
                            values.Push(ApplyOp(ops.Pop(), values.Pop(), values.Pop()));
                        ops.Push(op);
                    }
                }
                while (ops.Count > 0)
                    values.Push(ApplyOp(ops.Pop(), values.Pop(), values.Pop()));
                return values.Pop();
            }
            catch
            {
                return double.NaN;
            }
        }
        private List<string> Tokenize(string expr)
        {
            List<string> tokens = new List<string>();
            string num = "";
            foreach (char c in expr)
            {
                if (char.IsDigit(c) || c == '.')
                    num += c;
                else if ("+-*/()".Contains(c))
                {
                    if (num != "")
                    {
                        tokens.Add(num);
                        num = "";
                    }
                    tokens.Add(c.ToString());
                }
                else if (c == ' ')
                {
                    if (num != "")
                    {
                        tokens.Add(num);
                        num = "";
                    }
                }
            }
            if (num != "")
                tokens.Add(num);

            return tokens;
        }
        private int Precedence(char op)
        {
            if (op == '+' || op == '-') return 1;
            if (op == '*' || op == '/') return 2;
            return 0;
        }
        private double ApplyOp(char op, double b, double a)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/': return b != 0 ? a / b : double.NaN;
                default: return 0;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

