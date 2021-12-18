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
    public partial class FTkDs : Form
    {
        List<ChiPhi> dsTK;
        public FTkDs()
        {
            InitializeComponent();
        }

        private void FTkDs_Load(object sender, EventArgs e)
        {
            LoadTheme();

            dsTK = ChiPhi.GetAll();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dsTK;
            dataGridView1.Columns["TenDoan"].DataPropertyName = "LayTenDoan";   
            dataGridView1.Columns["TenLoaiCp"].DataPropertyName = "LayTenLoaiCp";   
            dataGridView1.Columns["GiaTien"].DataPropertyName = "GiaTien";
            dataGridView1.Columns["GiaTien"].DefaultCellStyle.Format = "C0";

            label3.Text = "Tổng: " + string.Format("{0:C0}", dsTK.Sum(d => d.GiaTien));

            comboBox1.DataSource = Doan.GetAll();
            comboBox1.DisplayMember = "TenDoan";
            comboBox1.ValueMember = "MaDoan";

            comboBox2.DataSource = LoaiCp.GetAll();
            comboBox2.DisplayMember = "TenLoaiCp";
            comboBox2.ValueMember = "MaLoaiCp";

            comboBox3.DataSource = Tour.GetAll();
            comboBox3.DisplayMember = "TenTour";
            comboBox3.ValueMember = "MaTour";
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = Color.FromArgb(39, 43, 66);
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(39, 43, 66);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "" && comboBox2.Text == "" && comboBox3.Text == "")
            {
                dsTK = ChiPhi.GetAll();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dsTK;

                label3.Text = "Tổng: " + string.Format("{0:C0}", dsTK.Sum(d => d.GiaTien));
            }

            else if(comboBox1.Text == "" && comboBox2.Text == "" && comboBox3.Text != "")
            {
                dsTK = ChiPhi.ThongKeByTour(int.Parse(comboBox3.SelectedValue.ToString()));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dsTK;

                label3.Text = "Tổng: " + string.Format("{0:C0}", dsTK.Sum(d => d.GiaTien));
            }
            
            else if(comboBox1.Text != "" && comboBox2.Text == "" && comboBox3.Text == "")
            {
                dsTK = ChiPhi.ThongKeByDoan(int.Parse(comboBox1.SelectedValue.ToString()));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dsTK;

                label3.Text = "Tổng: " + string.Format("{0:C0}", dsTK.Sum(d => d.GiaTien));
            }
            
            else if(comboBox1.Text == "" && comboBox2.Text != "" && comboBox3.Text == "")
            {
                dsTK = ChiPhi.ThongKeByLoaiCp(int.Parse(comboBox2.SelectedValue.ToString()));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dsTK;

                label3.Text = "Tổng: " + string.Format("{0:C0}", dsTK.Sum(d => d.GiaTien));
            }
            
            else if(comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text == "")
            {
                dsTK = ChiPhi.ThongKeByDoanLoai(int.Parse(comboBox1.SelectedValue.ToString()), int.Parse(comboBox2.SelectedValue.ToString()));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dsTK;

                label3.Text = "Tổng: " + string.Format("{0:C0}", dsTK.Sum(d => d.GiaTien));
            }

            else if(comboBox1.Text == "" && comboBox2.Text != "" && comboBox3.Text != "")
            {
                dsTK = ChiPhi.ThongKeByTourLoai(int.Parse(comboBox3.SelectedValue.ToString()), int.Parse(comboBox2.SelectedValue.ToString()));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dsTK;

                label3.Text = "Tổng: " + string.Format("{0:C0}", dsTK.Sum(d => d.GiaTien));
            }

            else if(comboBox1.Text != "" && comboBox2.Text == "" && comboBox3.Text != "")
            {
                dsTK = ChiPhi.ThongKeByTourDoan(int.Parse(comboBox3.SelectedValue.ToString()), int.Parse(comboBox1.SelectedValue.ToString()));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dsTK;

                label3.Text = "Tổng: " + string.Format("{0:C0}", dsTK.Sum(d => d.GiaTien));
            }

            else if(comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "")
            {
                dsTK = ChiPhi.ThongKeBy3Id(int.Parse(comboBox3.SelectedValue.ToString()), int.Parse(comboBox1.SelectedValue.ToString()), int.Parse(comboBox2.SelectedValue.ToString()));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dsTK;

                label3.Text = "Tổng: " + string.Format("{0:C0}", dsTK.Sum(d => d.GiaTien));
            }
        }
    }
}
