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
    public partial class FNhanVien : Form
    {
        List<NhanVien> allNv;
        int currentIndex;

        List<string> listGt = new List<string> { "Nam", "Nữ" };

        public FNhanVien()
        {
            InitializeComponent();
        }

        private void FNhanVien_Load(object sender, EventArgs e)
        {
            LoadTheme();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            allNv = NhanVien.GetAll();
            dataGridView1.DataSource = allNv;
            dataGridView1.Columns["TenNv"].DataPropertyName = "TenNv";
            dataGridView1.Columns["GioiTinh"].DataPropertyName = "GioiTinh";
            dataGridView1.Columns["Sdt"].DataPropertyName = "Sdt";

            comboBox1.DataSource = listGt;
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

            var nhanVien = allNv[currentIndex];

            if( nhanVien != null)
            {
                textBox2.Text = nhanVien.TenNv;
                comboBox1.Text = nhanVien.GioiTinh;
                textBox3.Text = nhanVien.Sdt;  
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var nhanVien = new NhanVien
            {
                TenNv = textBox2.Text,
                GioiTinh = comboBox1.Text,
                Sdt = textBox3.Text,
            };

            NhanVien.Insert(nhanVien);

            dataGridView1.DataSource = null;
            allNv = NhanVien.GetAll();
            dataGridView1.DataSource = allNv;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var nhanVien = allNv[currentIndex];
            nhanVien.TenNv = textBox2.Text;
            nhanVien.GioiTinh = comboBox1.Text;
            nhanVien.Sdt = textBox3.Text;

            nhanVien.Update();

            dataGridView1.DataSource = null;
            allNv = NhanVien.GetAll();
            dataGridView1.DataSource = allNv;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cf = MessageBox.Show("Bạn có chắc muốn xóa không?", "Confirm", MessageBoxButtons.YesNo);
            if (cf == DialogResult.Yes)
            {
                var nhanVien = allNv[currentIndex];

                nhanVien.Delete();

                dataGridView1.DataSource = null;
                allNv = NhanVien.GetAll();
                dataGridView1.DataSource = allNv;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            allNv = NhanVien.Search(textBox1.Text.Trim());
            dataGridView1.DataSource = allNv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            allNv = NhanVien.Search(textBox1.Text.Trim());
            dataGridView1.DataSource = allNv;
        }
    }
}
