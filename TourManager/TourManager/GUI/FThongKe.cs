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
    public partial class FThongKe : Form
    {
        public FThongKe()
        {
            InitializeComponent();
        }        

        private void FThongKe_Load(object sender, EventArgs e)
        {
            txCTour.Text = Tour.GetAll().Count.ToString();
            txCDoan.Text = Doan.GetAll().Count.ToString();
            txCNv.Text = NhanVien.GetAll().Count.ToString();
            txSCp.Text = string.Format("{0:C0}", ChiPhi.GetAll().Sum(cp => cp.GiaTien));

            FTkDoan f = new FTkDoan();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.pTK.Controls.Add(f);
            this.pTK.Tag = f;
            f.BringToFront();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FTkTour f = new FTkTour();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.pTK.Controls.Add(f);
            this.pTK.Tag = f;
            f.BringToFront();
            f.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FTkDoan f = new FTkDoan();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.pTK.Controls.Add(f);
            this.pTK.Tag = f;
            f.BringToFront();
            f.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FTkNv f = new FTkNv();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.pTK.Controls.Add(f);
            this.pTK.Tag = f;
            f.BringToFront();
            f.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            FTkDs f = new FTkDs();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.pTK.Controls.Add(f);
            this.pTK.Tag = f;
            f.BringToFront();
            f.Show();
        }
    }
}
