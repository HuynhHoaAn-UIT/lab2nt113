using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab01
{
    public partial class Bai06 : Form
    {
        string dbPath;

        public Bai06()
        {
            InitializeComponent();
            this.Load += Bai06_Load;
            dbPath = $"Data Source={Path.Combine(Application.StartupPath, "monan.db")}";
        }

        private void Bai06_Load(object sender, EventArgs e)
        {
            TaoCSDL();
            LoadDanhSach();
        }
        private void TaoCSDL()
        {
            using (var conn = new SqliteConnection(dbPath))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
            CREATE TABLE IF NOT EXISTS MonAn(
                IDMA INTEGER PRIMARY KEY AUTOINCREMENT,
                TenMonAn TEXT,
                HinhAnh TEXT,
                IDNCC INTEGER
            );
            ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = @"
            CREATE TABLE IF NOT EXISTS NguoiDung(
                IDNCC INTEGER PRIMARY KEY AUTOINCREMENT,
                HoVaTen TEXT,
                QuyenHan TEXT
            );
            ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT COUNT(*) FROM NguoiDung;";
                    long countNguoiDung = (long)cmd.ExecuteScalar();
                    if (countNguoiDung == 0)
                    {
                        cmd.CommandText = "INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES ('Lê Bá Nam', 'Admin');";
                        cmd.ExecuteNonQuery();
                    }

                    cmd.CommandText = "SELECT COUNT(*) FROM MonAn;";
                    long countMonAn = (long)cmd.ExecuteScalar();
                    if (countMonAn == 0)
                    {
                        cmd.CommandText = "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES ('Phở bò', 'pho.jpg', 1);";
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES ('Bún chả', 'buncha.jpg', 1);";
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES ('Cơm tấm', '', 1);";
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
        private void LoadDanhSach()
        {
            lvMonAn.Items.Clear();

            using (var conn = new SqliteConnection(dbPath))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT IDMA, TenMonAn, HinhAnh FROM MonAn;";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string id = reader["IDMA"].ToString();
                            string ten = reader["TenMonAn"].ToString();
                            string hinh = reader["HinhAnh"].ToString();

                            ListViewItem item = new ListViewItem(id);
                            item.SubItems.Add(ten);
                            item.SubItems.Add(hinh);

                            lvMonAn.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void lvMonAn_DoubleClick(object sender, EventArgs e)
        {
            if (lvMonAn.SelectedItems.Count == 0) return;

            int id = (int)lvMonAn.SelectedItems[0].Tag;
            HienThiChiTiet(id);
        }
        private void HienThiChiTiet(int id)
        {
            using (var conn = new SqliteConnection(dbPath))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT MonAn.TenMonAn, MonAn.HinhAnh, NguoiDung.HoVaTen
                        FROM MonAn
                        JOIN NguoiDung ON MonAn.IDNCC = NguoiDung.IDNCC
                        WHERE MonAn.IDMA = $id;
                    ";
                    cmd.Parameters.AddWithValue("$id", id);

                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            lblTenMon.Text = rd.GetString(0);
                            lblNguoiDongGop.Text = "Người đóng góp: " + rd.GetString(2);

                            string path = rd.IsDBNull(1) ? "" : rd.GetString(1);
                            string fullPath = Path.Combine(Application.StartupPath, path);

                            if (!string.IsNullOrEmpty(path) && File.Exists(fullPath))
                                picMon.Image = Image.FromFile(fullPath);
                            else
                                picMon.Image = null;
                        }
                    }
                }
            }
        }
        private void btnNgauNhien_Click(object sender, EventArgs e)
        {
            using (var conn = new SqliteConnection(dbPath))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT IDMA FROM MonAn ORDER BY RANDOM() LIMIT 1;";
                    var id = cmd.ExecuteScalar();
                    if (id != null)
                        HienThiChiTiet(Convert.ToInt32(id));
                }
            }
        }

        private void NtnNapLai_Click(object sender, EventArgs e)
        {
            LoadDanhSach();
        }
    }
}


