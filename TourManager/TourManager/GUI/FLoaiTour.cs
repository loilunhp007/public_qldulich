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
    public partial class FLoaiTour : Form
    {
        List<LoaiTour> allLoai;
        int currentIndex;

        public FLoaiTour()
        {
            InitializeComponent();
        }

        private void FLoaiTour_Load(object sender, EventArgs e)
        {
            LoadTheme();

            dgvLoaiTour.AutoGenerateColumns = false;
            dgvLoaiTour.DataSource = null;
            allLoai = LoaiTour.GetAll();
            dgvLoaiTour.DataSource = allLoai;
            dgvLoaiTour.Columns["TenLoai"].DataPropertyName = "TenLoai";
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

        private void dgvLoaiTour_SelectionChanged(object sender, EventArgs e)
        {
            currentIndex = dgvLoaiTour.CurrentCell.RowIndex;
            var loai = allLoai[currentIndex];
            if (loai != null)
            {
                textBox2.Text = loai.TenLoai;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var loai = new LoaiTour
            {
                TenLoai = textBox2.Text
            };

            LoaiTour.Insert(loai);

            dgvLoaiTour.DataSource = null;
            allLoai = LoaiTour.GetAll();                
            dgvLoaiTour.DataSource = allLoai;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var loai = allLoai[currentIndex];
            loai.TenLoai = textBox2.Text;

            loai.Update();           
            
            dgvLoaiTour.DataSource = null;
            allLoai = LoaiTour.GetAll();
            dgvLoaiTour.DataSource = allLoai;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cf = MessageBox.Show("Bạn có chắc muốn xóa không?", "Confirm", MessageBoxButtons.YesNo);
            if(cf == DialogResult.Yes)
            {
                var loai = allLoai[currentIndex];
                loai.Delete();    
                
                dgvLoaiTour.DataSource = null;
                allLoai = LoaiTour.GetAll();
                dgvLoaiTour.DataSource = allLoai;
            }   
        }
    }
}
