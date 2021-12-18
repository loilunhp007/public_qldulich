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
    public partial class FTkNv : Form
    {
        List<NhanVien> nvTK;

        public FTkNv()
        {
            InitializeComponent();
        }

        private void FTkNv_Load(object sender, EventArgs e)
        {
            LoadTheme();

            nvTK = NhanVien.ThongKe(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = nvTK;
            dataGridView1.Columns["TenNv"].DataPropertyName = "TenNv";
            dataGridView1.Columns["SoTour"].DataPropertyName = "SoTour";  

            comboBox1.DataSource = NhanVien.GetAll();
            comboBox1.DisplayMember = "TenNv";
            comboBox1.ValueMember = "MaNv";
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
            if(comboBox1.Text == "")
            {
                nvTK = NhanVien.ThongKe(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = nvTK;
            }
            else
            {
                nvTK = NhanVien.ThongKeById(int.Parse(comboBox1.SelectedValue.ToString()),
                                            dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = nvTK;
            }
        }
    }
}
