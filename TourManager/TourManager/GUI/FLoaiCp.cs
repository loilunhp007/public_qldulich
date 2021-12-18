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
    public partial class FLoaiCp : Form
    {
        List<LoaiCp> allLoai;
        int currentIndex;

        public FLoaiCp()
        {
            InitializeComponent();
        }

        private void FLoaiCp_Load(object sender, EventArgs e)
        {
            LoadTheme();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            allLoai = LoaiCp.GetAll();
            dataGridView1.DataSource = allLoai;
            dataGridView1.Columns["TenLoaiCp"].DataPropertyName = "TenLoaiCp";
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            currentIndex = dataGridView1.CurrentCell.RowIndex;
            var loai = allLoai[currentIndex];
            if (loai != null)
            {
                textBox1.Text = loai.TenLoaiCp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loai = new LoaiCp
            {
               TenLoaiCp = textBox1.Text
            };

            LoaiCp.Insert(loai);

            dataGridView1.DataSource = null;
            allLoai = LoaiCp.GetAll();                
            dataGridView1.DataSource = allLoai;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var loai = allLoai[currentIndex];
            loai.TenLoaiCp = textBox1.Text;

            //LoaiCp.Update(loai);

            loai.Update();

            dataGridView1.DataSource = null;
            allLoai = LoaiCp.GetAll();                
            dataGridView1.DataSource = allLoai;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cf = MessageBox.Show("Bạn có chắc muốn xóa không?", "Confirm", MessageBoxButtons.YesNo);
            if(cf == DialogResult.Yes)
            {
                var loai = allLoai[currentIndex];

                //LoaiCp.Delete(loai);

                loai.Delete();

                dataGridView1.DataSource = null;
                allLoai = LoaiCp.GetAll();                
                dataGridView1.DataSource = allLoai;
            }   
        }
    }
}
