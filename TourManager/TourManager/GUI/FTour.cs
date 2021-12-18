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
    public partial class FTour : Form
    {

        List<Tour> allTour;
        int currentTourIndex;

        List<LoaiTour> allLoaiTour;      

        public FTour()
        {            
            InitializeComponent();            
        }

        private void FTour_Load(object sender, EventArgs e)
        {
            LoadTheme();

            allTour = Tour.GetAll();
            dgvTour.AutoGenerateColumns = false;
            dgvTour.DataSource = allTour;
            dgvTour.Columns["TenTour"].DataPropertyName = "TenTour";
            dgvTour.Columns["TenLoaiTour"].DataPropertyName = "TenLoaiTour";
            dgvTour.Columns["DacDiem"].DataPropertyName = "DacDiem";  
            allLoaiTour = LoaiTour.GetAll();
            cbLoaiTour.DataSource = allLoaiTour;
            cbLoaiTour.DisplayMember = "TenLoai";
            cbLoaiTour.ValueMember = "MaLoai";
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

        private void dgvTour_SelectionChanged(object sender, EventArgs e)
        {            
            currentTourIndex = dgvTour.CurrentCell.RowIndex;

            var tour = allTour[currentTourIndex];

            if( tour != null)
            {
                cbLoaiTour.SelectedValue = tour.MaLoai;
                txTenTour.Text = tour.TenTour;
                txDacDiem.Text = tour.DacDiem;   
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var tour = new Tour
            {
                MaLoai = int.Parse(cbLoaiTour.SelectedValue.ToString()),
                TenTour = txTenTour.Text,
                DacDiem = txDacDiem.Text
            };  
            
            Tour.Insert(tour);

            dgvTour.DataSource = null;
            allTour = Tour.GetAll();
            dgvTour.DataSource = allTour;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var tour = allTour[currentTourIndex];
            tour.MaLoai = int.Parse(cbLoaiTour.SelectedValue.ToString());
            tour.TenTour = txTenTour.Text;
            tour.DacDiem = txDacDiem.Text;

            tour.Update();           
            
            dgvTour.DataSource = null;
            allTour = Tour.GetAll();
            dgvTour.DataSource = allTour;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var cf = MessageBox.Show("Bạn có chắc muốn xóa không?", "Confirm", MessageBoxButtons.YesNo);
            if(cf == DialogResult.Yes)
            {
                var tour = allTour[currentTourIndex];
                tour.Delete();                    
                dgvTour.DataSource = null;
                allTour = Tour.GetAll();
                dgvTour.DataSource = allTour;
            }            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvTour.DataSource = null;
            allTour = Tour.Search(txTim.Text.Trim());
            dgvTour.DataSource = allTour;
        }

        private void txTim_TextChanged(object sender, EventArgs e)
        {
            dgvTour.DataSource = null;
            allTour = Tour.Search(txTim.Text.Trim());
            dgvTour.DataSource = allTour;
        }

        private void btnFLoaiTour_Click(object sender, EventArgs e)
        {
            FLoaiTour f = new FLoaiTour();
            f.ShowDialog();
        }

        private void btnFCtTour_Click(object sender, EventArgs e)
        {
            FCtTour f = new FCtTour(allTour[currentTourIndex]);
            f.ShowDialog();
        }

        private void btnFBangGia_Click(object sender, EventArgs e)
        {
            FBangGia f = new FBangGia(allTour[currentTourIndex]);
            f.ShowDialog();
        }
    }
}
