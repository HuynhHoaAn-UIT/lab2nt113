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
    public partial class Bai05 : Form
    {
        List<Phim> danhSachPhim = new List<Phim>();
        List<Phong> danhSachPhong = new List<Phong>();
        string inputFile = "input5.txt";
        string outputFile = "output5.txt";

        public Bai05()
        {
            InitializeComponent();
            this.Load += Bai05_Load;
            cboPhong.SelectedIndexChanged += cboPhong_SelectedIndexChanged_1;
        }

        private void Bai05_Load(object sender, EventArgs e)
        {
            KhoiTaoPhim();
            KhoiTaoPhong();
        }

        private void KhoiTaoPhim()
        {
            danhSachPhim.Clear();
            danhSachPhim.Add(new Phim("Đào, phở và piano", 45000));
            danhSachPhim.Add(new Phim("Mai", 100000));
            danhSachPhim.Add(new Phim("Gặp lại chị bầu", 70000));
            danhSachPhim.Add(new Phim("Tarot", 90000));

            cboPhim.Items.Clear();
            foreach (var p in danhSachPhim)
                cboPhim.Items.Add(p.TenPhim);
            cboPhim.SelectedIndex = 0;
        }

        private void KhoiTaoPhong()
        {
            danhSachPhong.Clear();
            danhSachPhong.Add(new Phong("P1", "Phòng 1"));
            danhSachPhong.Add(new Phong("P2", "Phòng 2"));
            danhSachPhong.Add(new Phong("P3", "Phòng 3"));

            cboPhong.Items.Clear();
            foreach (var p in danhSachPhong)
                cboPhong.Items.Add(p.TenPhong);
            cboPhong.SelectedIndex = 0;
        }

        private void cboPhong_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboPhong.SelectedIndex == -1) return;
            var phong = danhSachPhong[cboPhong.SelectedIndex];
            clbGhe.Items.Clear();
            foreach (var ghe in phong.GheTrong)
                clbGhe.Items.Add(ghe, false);
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (cboPhim.SelectedIndex == -1 || cboPhong.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phim và phòng!");
                return;
            }

            if (clbGhe.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!");
                return;
            }

            var phim = danhSachPhim[cboPhim.SelectedIndex];
            var phong = danhSachPhong[cboPhong.SelectedIndex];
            List<string> gheChon = clbGhe.CheckedItems.Cast<string>().ToList();

            foreach (var g in gheChon)
            {
                if (phong.GheDaDat.Contains(g))
                {
                    MessageBox.Show($"Ghế {g} đã được đặt trước!");
                    return;
                }
            }

            int soVe = gheChon.Count;
            double heSo = rdoThuong.Checked ? 1 : rdoVip.Checked ? 2 : 0.75;
            double tongTien = phim.GiaVe * soVe * heSo;

            phim.SoVeBan += soVe;
            phim.SoVeTon = Math.Max(0, 50 - phim.SoVeBan);
            phong.DoanhThu += tongTien;
            phong.GheDaDat.AddRange(gheChon);
            phong.GheTrong = phong.GheTrong.Except(gheChon).ToList();

            rtbKetQua.AppendText($"Phòng: {phong.TenPhong} | Phim: {phim.TenPhim} | Ghế: {string.Join(", ", gheChon)} | Loại: {(rdoVip.Checked ? "VIP" : rdoThuong.Checked ? "Thường" : "Vớt")} | Tổng tiền: {tongTien}\n");

            cboPhong_SelectedIndexChanged_1(null, null);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            rtbKetQua.AppendText("\n--- Thống kê phim ---\n");
            foreach (var p in danhSachPhim.OrderByDescending(x => x.DoanhThu))
                rtbKetQua.AppendText($"{p.TenPhim} | Doanh thu: {p.DoanhThu} | Vé bán: {p.SoVeBan} | Còn: {p.SoVeTon}\n");

            rtbKetQua.AppendText("\n--- Thống kê phòng ---\n");
            foreach (var p in danhSachPhong)
                rtbKetQua.AppendText($"{p.TenPhong} | Ghế đã đặt: {string.Join(", ", p.GheDaDat)} | Doanh thu: {p.DoanhThu}\n");
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(outputFile))
            {
                sw.WriteLine("=== Thống kê phim ===");
                foreach (var p in danhSachPhim.OrderByDescending(p => p.DoanhThu))
                {
                    sw.WriteLine($"{p.TenPhim} | Giá vé: {p.GiaVe} | Đã bán: {p.SoVeBan} | Còn: {p.SoVeTon} | Doanh thu: {p.DoanhThu}");
                }

                sw.WriteLine("\n=== Thống kê phòng ===");
                foreach (var p in danhSachPhong)
                {
                    sw.WriteLine($"{p.TenPhong} | Ghế đã đặt: {string.Join(", ", p.GheDaDat)} | Doanh thu: {p.DoanhThu}");
                }
            }
            MessageBox.Show("Đã ghi kết quả ra file output5.txt!");
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists(inputFile))
            {
                MessageBox.Show("Không tìm thấy file input5.txt! Dùng dữ liệu mặc định.");
                KhoiTaoPhim();
                return;
            }

            danhSachPhim.Clear();
            string[] lines = File.ReadAllLines(inputFile);
            for (int i = 0; i < lines.Length; i += 2)
            {
                if (i + 1 < lines.Length)
                {
                    danhSachPhim.Add(new Phim(lines[i], double.Parse(lines[i + 1])));
                }
            }
            HienThiPhim();
            MessageBox.Show("Đọc file thành công!");
        }

        private void HienThiPhim()
        {
            cboPhim.Items.Clear();
            foreach (var p in danhSachPhim)
                cboPhim.Items.Add(p.TenPhim);
            if (cboPhim.Items.Count > 0)
                cboPhim.SelectedIndex = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Phim
    {
        public string TenPhim { get; set; }
        public double GiaVe { get; set; }
        public int SoVeBan { get; set; }
        public int SoVeTon { get; set; }
        public double DoanhThu => SoVeBan * GiaVe;
        public double TyLeBan => (SoVeBan + SoVeTon) == 0 ? 0 : (double)SoVeBan / (SoVeBan + SoVeTon);

        public Phim(string ten, double gia)
        {
            TenPhim = ten;
            GiaVe = gia;
            SoVeBan = 0;
            SoVeTon = 50;
        }
    }

    public class Phong
    {
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }
        public List<string> GheDaDat { get; set; } = new List<string>();
        public List<string> GheTrong { get; set; } = new List<string>();
        public double DoanhThu { get; set; }

        public Phong(string ma, string ten)
        {
            MaPhong = ma;
            TenPhong = ten;
            for (char hang = 'A'; hang <= 'C'; hang++)
                for (int i = 1; i <= 5; i++)
                    GheTrong.Add($"{hang}{i}");
        }
    }
}