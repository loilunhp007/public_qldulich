using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourManager.Models;

namespace TourManager.GUI
{
    public partial class FPcDoan : Form
    {
        List<PhanCong> allPcDoan;
        int currentIndex;

        public int MaDoan {get; set; }

        List<NhanVien> allNhanVien;

        List<string> allNhiemVu = new List<string> { "Lái xe", "Hướng dẫn viên", "Thông dịch viên", "Phục vụ" };        

        public FPcDoan(Doan doan)
        {
            InitializeComponent();
            MaDoan = doan.MaDoan;
            label1.Text = doan.TenDoan;
        }

        private void FPcDoan_Load(object sender, EventArgs e)
        {
            LoadTheme();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            allPcDoan = PhanCong.GetByDoanId(MaDoan);
            dataGridView1.DataSource = allPcDoan;
            dataGridView1.Columns["TenNv"].DataPropertyName = "TenNvPc";
            dataGridView1.Columns["NhiemVu"].DataPropertyName = "NhiemVu";

            allNhanVien = NhanVien.GetAll();
            comboBox1.DataSource = allNhanVien;
            comboBox1.DisplayMember = "TenNv";
            comboBox1.ValueMember = "MaNv";

            comboBox2.DataSource = allNhiemVu;
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    //btn.BackColor = ThemeColor.PrimaryColor;
                    btn.BackColor = Color.FromArgb(39, 43, 66);
                    btn.ForeColor = Color.White;
                    //btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(39, 43, 66);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            currentIndex = dataGridView1.CurrentCell.RowIndex;
            var phanCong = allPcDoan[currentIndex];
            if (phanCong != null)
            {
                comboBox1.SelectedValue = phanCong.MaNv;
                comboBox2.Text = phanCong.NhiemVu;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             try
            {
                var phanCong = new PhanCong
                {
                    MaDoan = MaDoan,
                    MaNv = int.Parse(comboBox1.SelectedValue.ToString()),
                    NhiemVu = comboBox2.Text,
                };

                PhanCong.Insert(phanCong);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng thử lại", "Không thành công", MessageBoxButtons.OK);
            }                   

            dataGridView1.DataSource = null;
            allPcDoan = PhanCong.GetByDoanId(MaDoan);
            dataGridView1.DataSource = allPcDoan;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var phanCong = allPcDoan[currentIndex];
                phanCong.MaDoan = MaDoan;
                phanCong.MaNv = int.Parse(comboBox1.SelectedValue.ToString());
                phanCong.NhanVien = allNhanVien.Find(e => e.MaNv == int.Parse(comboBox1.SelectedValue.ToString()));
                phanCong.NhiemVu = comboBox2.Text;
                phanCong.Update();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng thử lại", "Không thành công", MessageBoxButtons.OK);
            }               

            dataGridView1.DataSource = null;
            allPcDoan = PhanCong.GetByDoanId(MaDoan);
            dataGridView1.DataSource = allPcDoan;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cf = MessageBox.Show("Bạn có chắc muốn xóa không?", "Confirm", MessageBoxButtons.YesNo);
            if (cf == DialogResult.Yes)
            {
                var phanCong = allPcDoan[currentIndex];

                phanCong.Delete();

                dataGridView1.DataSource = null;
                allPcDoan = PhanCong.GetByDoanId(MaDoan);
                dataGridView1.DataSource = allPcDoan;
            }
        }
    }
}
