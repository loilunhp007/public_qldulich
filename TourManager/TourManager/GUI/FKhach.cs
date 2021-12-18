using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourManager.Models;

namespace TourManager.GUI
{
    public partial class FKhach : Form
    {
        List<Khach> allKhach;
        int currentIndex;

        List<string> listGt = new List<string> { "Nam", "Nữ" };

        List<string> listQt()
        {
            List<string> CultureList = new List<string>();

            CultureInfo[] getCultureInfos = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            foreach (CultureInfo getCultureInfo in getCultureInfos)
            {
                RegionInfo getRegionInfo = new RegionInfo(getCultureInfo.LCID);
                if(!(CultureList.Contains(getRegionInfo.EnglishName)))
                {
                    CultureList.Add(getRegionInfo.EnglishName);
                }
            }

            CultureList.Sort();
            return CultureList;
        }

        public FKhach()
        {
            InitializeComponent();
        }

        private void FKhach_Load(object sender, EventArgs e)
        {
            LoadTheme();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            allKhach = Khach.GetAll();
            dataGridView1.DataSource = allKhach;

            dataGridView1.Columns["Ten"].DataPropertyName = "Ten";
            dataGridView1.Columns["Sdt"].DataPropertyName = "Sdt";
            dataGridView1.Columns["Cmnd"].DataPropertyName = "Cmnd";
            dataGridView1.Columns["GioiTinh"].DataPropertyName = "GioiTinh";            
            dataGridView1.Columns["DiaChi"].DataPropertyName = "DiaChi";
            dataGridView1.Columns["QuocTich"].DataPropertyName = "QuocTich";

            comboBox1.DataSource = listGt;
            comboBox2.DataSource = listQt();
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

            var khach = allKhach[currentIndex];

            if( khach != null)
            {
                textBox2.Text = khach.Ten;
                textBox3.Text = khach.Sdt;
                textBox4.Text = khach.Cmnd;
                comboBox1.Text = khach.GioiTinh;
                textBox5.Text = khach.DiaChi;
                //textBox6.Text = khach.QuocTich;
                comboBox2.Text = khach.QuocTich;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var khach = new Khach
            {
                Ten = textBox2.Text,
                Sdt = textBox3.Text,
                Cmnd = textBox4.Text,
                GioiTinh = comboBox1.Text,
                DiaChi = textBox5.Text,
                //QuocTich = textBox6.Text,
                QuocTich = comboBox2.Text,
            };

            Khach.Insert(khach);

            dataGridView1.DataSource = null;
            allKhach = Khach.GetAll();
            dataGridView1.DataSource = allKhach;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var khach = allKhach[currentIndex];
            khach.Ten = textBox2.Text;
            khach.Sdt = textBox3.Text;
            khach.Cmnd = textBox4.Text;
            khach.GioiTinh = comboBox1.Text;
            khach.DiaChi = textBox5.Text;
            //khach.QuocTich = textBox6.Text;
            khach.QuocTich = comboBox2.Text;

            khach.Update();

            dataGridView1.DataSource = null;
            allKhach = Khach.GetAll();
            dataGridView1.DataSource = allKhach;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cf = MessageBox.Show("Bạn có chắc muốn xóa không?", "Confirm", MessageBoxButtons.YesNo);
            if (cf == DialogResult.Yes)
            {
                var khach = allKhach[currentIndex];

                khach.Delete();

                dataGridView1.DataSource = null;
                allKhach = Khach.GetAll();
                dataGridView1.DataSource = allKhach;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            allKhach = Khach.Search(textBox1.Text.Trim());
            dataGridView1.DataSource = allKhach;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            allKhach = Khach.Search(textBox1.Text.Trim());
            dataGridView1.DataSource = allKhach;
        }
    }
}
