namespace Lab01;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) => new Bai01().ShowDialog(this);
    private void button2_Click(object sender, EventArgs e) => new Bai02().ShowDialog(this);
    private void button3_Click(object sender, EventArgs e) => new Bai03().ShowDialog(this);
    private void button4_Click(object sender, EventArgs e) => new Bai04().ShowDialog(this);
    private void button5_Click(object sender, EventArgs e) => new Bai05().ShowDialog(this);
}
