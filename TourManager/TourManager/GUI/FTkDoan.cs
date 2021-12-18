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
    public partial class FTkDoan : Form
    {
        List<Doan> doanTK;

        public FTkDoan()
        {
            InitializeComponent();
        }

        private void FTkDoan_Load(object sender, EventArgs e)
        {
            LoadTheme();

            doanTK = Doan.ThongKe(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = doanTK;
            dataGridView1.Columns["TenTour"].DataPropertyName = "LayTenTour";
            dataGridView1.Columns["TenDoan"].DataPropertyName = "TenDoan";   
            dataGridView1.Columns["NgayBd"].DataPropertyName = "NgayBd";  
            dataGridView1.Columns["NgayBd"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["NgayKt"].DataPropertyName = "NgayKt";  
            dataGridView1.Columns["NgayKt"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["SoKhach"].DataPropertyName = "SoKhach";   
            dataGridView1.Columns["SoNv"].DataPropertyName = "SoNv";  
            dataGridView1.Columns["DoanhSo"].DataPropertyName = "DoanhSo";
            dataGridView1.Columns["DoanhSo"].DefaultCellStyle.Format = "C0";


            label4.Text = "Tổng Khách: " + doanTK.Sum(d => d.SoKhach).ToString();
            label5.Text = "Tổng Doanh Số: " + string.Format("{0:C0}", doanTK.Sum(d => d.DoanhSo));

            comboBox1.DataSource = Tour.GetAll();
            comboBox1.DisplayMember = "TenTour";
            comboBox1.ValueMember = "MaTour";

            comboBox2.DataSource = Doan.GetAll();
            comboBox2.DisplayMember = "TenDoan";
            comboBox2.ValueMember = "MaDoan";
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
            if(comboBox1.Text == "" && comboBox2.Text == "")
            {
                doanTK = Doan.ThongKe(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = doanTK;

                label4.Text = "Tổng Khách: " + doanTK.Sum(d => d.SoKhach).ToString();
                label5.Text = "Tổng Doanh Số: " + string.Format("{0:C0}", doanTK.Sum(d => d.DoanhSo));

            }
            
            else if(comboBox1.Text != "" && comboBox2.Text == "")
            {
                doanTK = Doan.ThongKeByTourId(int.Parse(comboBox1.SelectedValue.ToString()), 
                                                dateTimePicker1.Value.Date, 
                                                dateTimePicker2.Value.Date);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = doanTK;

                label4.Text = "Tổng Khách: " + doanTK.Sum(d => d.SoKhach).ToString();
                label5.Text = "Tổng Doanh Số: " + string.Format("{0:C0}", doanTK.Sum(d => d.DoanhSo));
            }    

            else if(comboBox1.Text == "" && comboBox2.Text != "")
            {
                doanTK = Doan.ThongKeByDoanId(int.Parse(comboBox2.SelectedValue.ToString()), 
                                                dateTimePicker1.Value.Date, 
                                                dateTimePicker2.Value.Date);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = doanTK;

                label4.Text = "Tổng Khách: " + doanTK.Sum(d => d.SoKhach).ToString();
                label5.Text = "Tổng Doanh Số: " + string.Format("{0:C0}", doanTK.Sum(d => d.DoanhSo));
            } 

            else if(comboBox1.Text != "" && comboBox2.Text != "")
            {
                doanTK = Doan.ThongKeBy2Id(int.Parse(comboBox1.SelectedValue.ToString()), 
                                            int.Parse(comboBox2.SelectedValue.ToString()), 
                                            dateTimePicker1.Value.Date, 
                                            dateTimePicker2.Value.Date);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = doanTK;

                label4.Text = "Tổng Khách: " + doanTK.Sum(d => d.SoKhach).ToString();
                label5.Text = "Tổng Doanh Số: " + string.Format("{0:C0}", doanTK.Sum(d => d.DoanhSo));
            }   
        }
    }
}
