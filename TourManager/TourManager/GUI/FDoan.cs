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
    public partial class FDoan : Form
    {

        List<Doan> allDoan;
        int currentIndex;

        List<Tour> allTour;  

        public FDoan()
        {
            InitializeComponent();
        }

        private void FDoan_Load(object sender, EventArgs e)
        {
            LoadTheme();

            allDoan = Doan.GetAll();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = allDoan;
            dataGridView1.Columns["LayTenTour"].DataPropertyName = "LayTenTour";
            dataGridView1.Columns["TenDoan"].DataPropertyName = "TenDoan";            
            dataGridView1.Columns["NgayBd"].DataPropertyName = "NgayBd";  
            dataGridView1.Columns["NgayBd"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["NgayKt"].DataPropertyName = "NgayKt";  
            dataGridView1.Columns["NgayKt"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["NoiDung"].DataPropertyName = "NoiDung";  

            allTour = Tour.GetAll();
            comboBox1.DataSource = allTour;
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
                    //btn.BackColor = ThemeColor.PrimaryColor;
                    btn.BackColor = Color.FromArgb(39, 43, 66);
                    btn.ForeColor = Color.White;
                    //btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(39, 43, 66);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FPcDoan f = new FPcDoan(allDoan[currentIndex]);
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FCtKhach f = new FCtKhach(allDoan[currentIndex]);
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FCpDoan f = new FCpDoan(allDoan[currentIndex]);
            f.ShowDialog();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            currentIndex = dataGridView1.CurrentCell.RowIndex;

            var doan = allDoan[currentIndex];

            if( doan != null)
            {
                comboBox1.SelectedValue = doan.MaTour;
                textBox2.Text = doan.TenDoan;
                dateTimePicker1.Value = doan.NgayBd;
                dateTimePicker2.Value = doan.NgayKt;
                textBox3.Text = doan.NoiDung;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var doan = new Doan
                {
                    MaTour = int.Parse(comboBox1.SelectedValue.ToString()),
                    TenDoan = textBox2.Text,
                    NgayBd = dateTimePicker1.Value.Date,
                    NgayKt = dateTimePicker2.Value.Date,
                    NoiDung = textBox3.Text
                };  
            
                Doan.Insert(doan); 
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng thử lại", "Không thành công", MessageBoxButtons.OK);
            }            

            dataGridView1.DataSource = null;
            allDoan = Doan.GetAll();
            dataGridView1.DataSource = allDoan;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                var doan = allDoan[currentIndex];
                doan.MaTour = int.Parse(comboBox1.SelectedValue.ToString());
                doan.Tour = allTour.Find( e=> e.MaTour == int.Parse(comboBox1.SelectedValue.ToString()));
                doan.TenDoan = textBox2.Text;
                doan.NgayBd = dateTimePicker1.Value.Date;
                doan.NgayKt = dateTimePicker2.Value.Date;
                doan.NoiDung = textBox3.Text;
                doan.Update(); 
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng thử lại", "Không thành công", MessageBoxButtons.OK);
            }                         
            
            dataGridView1.DataSource = null;
            allDoan = Doan.GetAll();
            dataGridView1.DataSource = allDoan;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var cf = MessageBox.Show("Bạn có chắc muốn xóa không?", "Confirm", MessageBoxButtons.YesNo);
            if(cf == DialogResult.Yes)
            {
                var doan = allDoan[currentIndex];
                doan.Delete();                    
                dataGridView1.DataSource = null;
                allDoan = Doan.GetAll();
                dataGridView1.DataSource = allDoan;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            allDoan = Doan.Search(textBox1.Text.Trim());
            dataGridView1.DataSource = allDoan;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            allDoan = Doan.Search(textBox1.Text.Trim());
            dataGridView1.DataSource = allDoan;
        }
    }
}
