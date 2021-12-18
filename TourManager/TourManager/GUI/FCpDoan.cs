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
    public partial class FCpDoan : Form
    {
        List<ChiPhi> allCpDoan;
        int currentIndex;

        public int MaDoan {get; set; }

        List<LoaiCp> allLoai;

        public FCpDoan(Doan doan)
        {
            InitializeComponent();
            MaDoan = doan.MaDoan;
            label1.Text = doan.TenDoan;
        }

        private void FCpDoan_Load(object sender, EventArgs e)
        {
            LoadTheme();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            allCpDoan = ChiPhi.GetByDoanId(MaDoan);
            dataGridView1.DataSource = allCpDoan;
            dataGridView1.Columns["Gia"].DataPropertyName = "GiaTien";
            dataGridView1.Columns["Gia"].DefaultCellStyle.Format = "C0";
            dataGridView1.Columns["TenLoaiCp"].DataPropertyName = "LayTenLoaiCp";            
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

        private void FCpDoan_Activated(object sender, EventArgs e)
        {
            allLoai = LoaiCp.GetAll();
            comboBox1.DataSource = allLoai;
            comboBox1.DisplayMember = "TenLoaiCp";
            comboBox1.ValueMember = "MaLoaiCp";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FLoaiCp f = new FLoaiCp();
            f.ShowDialog();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            currentIndex = dataGridView1.CurrentCell.RowIndex;
            var chiPhi = allCpDoan[currentIndex];
            if (chiPhi != null)
            {
                textBox1.Text = string.Format("{0:C0}", chiPhi.GiaTien);
                comboBox1.SelectedValue = chiPhi.MaLoaiCp;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var chiPhi = new ChiPhi
                {
                    MaDoan = MaDoan,
                    GiaTien = decimal.Parse(textBox1.Text, NumberStyles.Currency),
                    MaLoaiCp = int.Parse(comboBox1.SelectedValue.ToString()),
                };

                ChiPhi.Insert(chiPhi);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng thử lại", "Không thành công", MessageBoxButtons.OK);
            }             

            dataGridView1.DataSource = null;
            allCpDoan = ChiPhi.GetByDoanId(MaDoan);
            dataGridView1.DataSource = allCpDoan;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var chiPhi = allCpDoan[currentIndex];
                chiPhi.GiaTien = decimal.Parse(textBox1.Text, NumberStyles.Currency);
                chiPhi.MaLoaiCp = int.Parse(comboBox1.SelectedValue.ToString());
                chiPhi.LoaiCp = allLoai.Find(e => e.MaLoaiCp == int.Parse(comboBox1.SelectedValue.ToString()));
                chiPhi.Update();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng thử lại", "Không thành công", MessageBoxButtons.OK);
            }          
                       
            
            dataGridView1.DataSource = null;
            allCpDoan = ChiPhi.GetByDoanId(MaDoan);
            dataGridView1.DataSource = allCpDoan;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cf = MessageBox.Show("Bạn có chắc muốn xóa không?", "Confirm", MessageBoxButtons.YesNo);
            if(cf == DialogResult.Yes)
            {
                var chiPhi = allCpDoan[currentIndex];
                chiPhi.Delete();       
                
                dataGridView1.DataSource = null;
                allCpDoan = ChiPhi.GetByDoanId(MaDoan);
                dataGridView1.DataSource = allCpDoan;
            }
        }
    }
}
