using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourManager.BUS;
using TourManager.Models;

namespace TourManager.GUI
{
    public partial class FTour : Form
    {
        List<Tour> allTours;
        int currentTourIndex = 0;

        public FTour()
        {            
            InitializeComponent();            
        }

        private void FTour_Load(object sender, EventArgs e)
        {

            allTours = Tour.GetAll();

            dgvTour.AutoGenerateColumns = false;
            dgvTour.DataSource = allTours;//Tour.GetAll();//TourBUS.GetAll();
            
            dgvTour.Columns["TenTour"].DataPropertyName = "TenTour";
            dgvTour.Columns["LoaiTour"].DataPropertyName = "TenLoaiTour";

            cbLoaiTour.DataSource = LoaiTourBUS.GetAll();
            cbLoaiTour.DisplayMember = "TenLoai";
            cbLoaiTour.ValueMember = "MaLoai";
        }  

        private void dgvTour_SelectionChanged(object sender, EventArgs e)
        {
            currentTourIndex = dgvTour.CurrentCell.RowIndex;

            // update current tour details
            var tour = allTours[currentTourIndex];
            if( tour != null)
            {
                txMaTour.Text = tour.MaTour.ToString();
                cbLoaiTour.SelectedValue = tour.MaLoai;
                txTenTour.Text = tour.TenTour;
                txDacDiem.Text = tour.DacDiem;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var tour = allTours[currentTourIndex]; //TourBUS.GetById(int.Parse(txMaTour.Text));
            tour.MaLoai = int.Parse(cbLoaiTour.SelectedValue.ToString());
            tour.TenTour = txTenTour.Text;
            tour.DacDiem = txDacDiem.Text;
            // try catch cho nay
            tour.UpdateToDB();

            //TourBUS.Update(tour);

            // refresh GUI
            dgvTour.DataSource = null;
            dgvTour.DataSource = allTours;//TourBUS.GetAll();
        }
    }
}
