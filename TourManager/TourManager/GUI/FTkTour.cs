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
    public partial class FTkTour : Form
    {
        List<Tour> tourTK;

        public FTkTour()
        {
            InitializeComponent();
        }

        private void FTkTour_Load(object sender, EventArgs e)
        {
            LoadTheme();

            tourTK = Tour.ThongKe();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = tourTK;
            dataGridView1.Columns["TenTour"].DataPropertyName = "TenTour";
            dataGridView1.Columns["SoDoan"].DataPropertyName = "SoDoan";   
            dataGridView1.Columns["SoKhach"].DataPropertyName = "SoKhach"; 
            dataGridView1.Columns["SoNv"].DataPropertyName = "SoNv"; 
            //dataGridView1.Columns["Gia"].DataPropertyName = "Gia";   
            //dataGridView1.Columns["Gia"].DefaultCellStyle.Format = "C0";
            dataGridView1.Columns["TongCp"].DataPropertyName = "TongCp";   
            dataGridView1.Columns["TongCp"].DefaultCellStyle.Format = "C0";

            label2.Text = "Tổng Khách: " + tourTK.Sum(t => t.SoKhach).ToString();
            label3.Text = "Tổng Doanh Số: " + string.Format("{0:C0}", tourTK.Sum(t => t.TongCp));

            comboBox1.DataSource = Tour.GetAll();
            comboBox1.DisplayMember = "TenTour";
            comboBox1.ValueMember = "MaTour";
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
                tourTK = Tour.ThongKe();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tourTK;

                label2.Text = "Tổng Khách: " + tourTK.Sum(t => t.SoKhach).ToString();
                label3.Text = "Tổng Doanh Số: " + string.Format("{0:C0}", tourTK.Sum(t => t.TongCp));
            }
            else
            {
                tourTK = Tour.ThongKeById(int.Parse(comboBox1.SelectedValue.ToString()));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tourTK;

                label2.Text = "Tổng Khách: " + tourTK.Sum(t => t.SoKhach).ToString();
                label3.Text = "Tổng Doanh Số: " + string.Format("{0:C0}", tourTK.Sum(t => t.TongCp));
            }
        }
    }
}
