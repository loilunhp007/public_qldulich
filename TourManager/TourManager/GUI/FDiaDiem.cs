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
    public partial class FDiaDiem : Form
    {
        List<DiaDiem> allDd;
        int currentDdIndex;

        public FDiaDiem()
        {
            InitializeComponent();
        }

        private void FDiaDiem_Load(object sender, EventArgs e)
        {
            LoadTheme();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            allDd = DiaDiem.GetAll();
            dataGridView1.DataSource = allDd;
            dataGridView1.Columns["TenDd"].DataPropertyName = "TenDd";

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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            currentDdIndex = dataGridView1.CurrentCell.RowIndex;
            var diaDiem = allDd[currentDdIndex];
            if (diaDiem != null)
            {
                textBox2.Text = diaDiem.TenDd;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var diaDiem = new DiaDiem
                {
                    TenDd = textBox2.Text
                };

                DiaDiem.Insert(diaDiem);

                dataGridView1.DataSource = null;
                allDd = DiaDiem.GetAll();
                dataGridView1.DataSource = allDd;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var diaDiem = allDd[currentDdIndex];
            diaDiem.TenDd = textBox2.Text;

            diaDiem.Update();           
            
            dataGridView1.DataSource = null;
            allDd = DiaDiem.GetAll();
            dataGridView1.DataSource = allDd;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cf = MessageBox.Show("Bạn có chắc muốn xóa không?", "Confirm", MessageBoxButtons.YesNo);
            if(cf == DialogResult.Yes)
            {
                var diaDiem = allDd[currentDdIndex];
                diaDiem.Delete();    
                
                dataGridView1.DataSource = null;
                allDd = DiaDiem.GetAll();
                dataGridView1.DataSource = allDd;
            }
        }
    }
}
