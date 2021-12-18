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
    public partial class FCtTour : Form
    {
        List<CtTour> allCtTour;
        int currentCtTourIndex;

        List<DiaDiem> allDiaDiem;

        public int MaTour { get; set; }

        public FCtTour(Tour tour)
        {
            InitializeComponent();
            MaTour = tour.MaTour;
            label3.Text = tour.TenTour;
        }

        private void FCtTour_Load(object sender, EventArgs e)
        {
            LoadTheme();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            allCtTour = CtTour.GetByTourId(MaTour);
            dataGridView1.DataSource = allCtTour;
            dataGridView1.Columns["TenDdCt"].DataPropertyName = "TenDdCt";
            dataGridView1.Columns["ThuTu"].DataPropertyName = "ThuTu";
        }        

        private void FCtTour_Activated(object sender, EventArgs e)
        {
            allDiaDiem = DiaDiem.GetAll();
            comboBox1.DataSource = allDiaDiem;
            comboBox1.DisplayMember = "TenDd";
            comboBox1.ValueMember = "MaDd";
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
            currentCtTourIndex = dataGridView1.CurrentCell.RowIndex;
            var ctTour = allCtTour[currentCtTourIndex];
            if (ctTour != null)
            {
                comboBox1.SelectedValue = ctTour.MaDd;
                textBox1.Text = ctTour.ThuTu.ToString();
            }
        }

        //private bool checkThuTu(string tt)
        //{
        //    foreach (DataGridViewRow row in dataGridView1.Rows)
        //    {
        //        if (row.Cells["ThuTu"].Value.ToString().Equals(tt))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               var ctTour = new CtTour
                {
                    MaTour = MaTour,
                    MaDd = int.Parse(comboBox1.SelectedValue.ToString()),
                    ThuTu = allCtTour.Count() + 1
                };

                CtTour.Insert(ctTour);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng thử lại", "Không thành công", MessageBoxButtons.OK);
            }              

            dataGridView1.DataSource = null;
            allCtTour = CtTour.GetByTourId(MaTour);
            dataGridView1.DataSource = allCtTour;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var ctTour = allCtTour[currentCtTourIndex];
                ctTour.MaTour = MaTour;
                ctTour.MaDd = int.Parse(comboBox1.SelectedValue.ToString());
                ctTour.DiaDiem = allDiaDiem.Find(e => e.MaDd == int.Parse(comboBox1.SelectedValue.ToString()));
                ctTour.ThuTu = int.Parse(textBox1.Text);
                ctTour.Update();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng thử lại", "Không thành công", MessageBoxButtons.OK);
            }                

            dataGridView1.DataSource = null;
            allCtTour = CtTour.GetByTourId(MaTour);
            dataGridView1.DataSource = allCtTour;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cf = MessageBox.Show("Bạn có chắc muốn xóa không?", "Confirm", MessageBoxButtons.YesNo);
            if (cf == DialogResult.Yes)
            {
                var ctTour = allCtTour[currentCtTourIndex];

                ctTour.Delete();

                dataGridView1.DataSource = null;
                allCtTour = CtTour.GetByTourId(MaTour);
                dataGridView1.DataSource = allCtTour;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FDiaDiem f = new FDiaDiem();
            f.ShowDialog();
        }
    }
}
