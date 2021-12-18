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
    public partial class FBangGia : Form
    {
        List<BangGia> allBangGia;
        int currentIndex;

        public int MaTour { get; set; }

        public FBangGia(Tour tour)
        {
            InitializeComponent();
            MaTour = tour.MaTour;
            label1.Text = tour.TenTour;
        }

        private void FBangGia_Load(object sender, EventArgs e)
        {
            LoadTheme();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            allBangGia = BangGia.GetByTourId(MaTour);
            dataGridView1.DataSource = allBangGia;
            dataGridView1.Columns["Gia"].DataPropertyName = "GiaTour";
            dataGridView1.Columns["Gia"].DefaultCellStyle.Format = "C0";
            dataGridView1.Columns["Tgbd"].DataPropertyName = "Tgbd";
            dataGridView1.Columns["Tgbd"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["Tgkt"].DataPropertyName = "Tgkt";
            dataGridView1.Columns["Tgkt"].DefaultCellStyle.Format = "dd/MM/yyyy";
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
            currentIndex = dataGridView1.CurrentCell.RowIndex;
            var bangGia = allBangGia[currentIndex];
            if (bangGia != null)
            {
                //textBox2.Text = bangGia.GiaTour.ToString();
                textBox2.Text = string.Format("{0:C0}", bangGia.GiaTour);
                dateTimePicker1.Value = bangGia.Tgbd;
                dateTimePicker2.Value = bangGia.Tgkt;
            }
        }

        //public bool checkTime(DateTime tg)
        //{
        //    if(dataGridView1.Rows.Count != 0)
        //    {
        //        tg = DateTime.Parse(dataGridView1.Rows[0].Cells["Tgkt"].Value.ToString());  
        //        if(DateTime.Compare(tg.Date, dateTimePicker1.Value.Date) >= 0) //Thời gian kết thúc của giá cũ lớn hơn thời gian bắt đầu giá mới 
        //        {
        //            return false;
        //        }    
        //    }

        //    if(DateTime.Compare(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date) >= 0 //Thời gian bắt đầu lớn hơn hoặc bằng thời gian kết thúc
        //    || DateTime.Compare(dateTimePicker1.Value.Date, DateTime.Now.Date) < 0 //Thời gian bắt đầu nhỏ hơn thời gian hiện tại
        //    || DateTime.Compare(dateTimePicker2.Value.Date, DateTime.Now.Date) < 0) //Thời gian kết thúc nhỏ hơn thời gian hiện tại
        //    {
        //        return false;
        //    }  
        //    return true;
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            //if (checkTime(dateTimePicker1.Value.Date))
            //{
            //    var bangGia = new BangGia
            //    {
            //        MaTour = MaTour,
            //        GiaTour = decimal.Parse(textBox2.Text),
            //        Tgbd = dateTimePicker1.Value.Date,
            //        Tgkt = dateTimePicker2.Value.Date
            //    };

            //    BangGia.Insert(bangGia);

            //    dataGridView1.DataSource = null;
            //    allBangGia = BangGia.GetByTourId(MaTour);
            //    dataGridView1.DataSource = allBangGia;
            //}
            //else
            //{
            //    MessageBox.Show("Thời gian đặt chưa đúng hoặc giá cũ vẫn đang được áp dụng", "Thông báo");
            //}

            try
            {
                var bangGia = new BangGia
                {
                    MaTour = MaTour,
                    GiaTour = decimal.Parse(textBox2.Text, NumberStyles.Currency),
                    Tgbd = dateTimePicker1.Value.Date,
                    Tgkt = dateTimePicker2.Value.Date
                };

                BangGia.Insert(bangGia);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng thử lại", "Không thành công", MessageBoxButtons.OK);
            }  

            dataGridView1.DataSource = null;
            allBangGia = BangGia.GetByTourId(MaTour);
            dataGridView1.DataSource = allBangGia;
        }

        private void button3_Click(object sender, EventArgs e)
        {  
            try
            {
                var bangGia = allBangGia[currentIndex];
                bangGia.GiaTour = decimal.Parse(textBox2.Text, NumberStyles.Currency);
                bangGia.Tgbd = dateTimePicker1.Value;
                bangGia.Tgkt = dateTimePicker2.Value;
                bangGia.Update(); 
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng thử lại", "Không thành công", MessageBoxButtons.OK);
            }   
                      
            
            dataGridView1.DataSource = null;
            allBangGia = BangGia.GetByTourId(MaTour);
            dataGridView1.DataSource = allBangGia;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cf = MessageBox.Show("Bạn có chắc muốn xóa không?", "Confirm", MessageBoxButtons.YesNo);
            if(cf == DialogResult.Yes)
            {
                var bangGia = allBangGia[currentIndex];
                bangGia.Delete();       
                
                dataGridView1.DataSource = null;
                allBangGia = BangGia.GetByTourId(MaTour);
                dataGridView1.DataSource = allBangGia;
            }  
        }
    }
}
