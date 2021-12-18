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
    public partial class FCtKhach : Form
    {
        List<CtDoan> allCtKhach;
        int currentIndex;

        public int MaDoan {get; set; }

        List<Khach> allKhach;

        public FCtKhach(Doan doan)
        {
            InitializeComponent();
            MaDoan = doan.MaDoan;
            label1.Text = doan.TenDoan;
        }

        private void FCtKhach_Load(object sender, EventArgs e)
        {
            LoadTheme();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            allCtKhach = CtDoan.GetByDoanId(MaDoan);
            dataGridView1.DataSource = allCtKhach;
            dataGridView1.Columns["TenKhach"].DataPropertyName = "TenKhach";
            dataGridView1.Columns["CmndKhach"].DataPropertyName = "CmndKhach";

            allKhach = Khach.GetAll();
            comboBox1.DataSource = allKhach;
            comboBox1.DisplayMember = "Ten";
            comboBox1.ValueMember = "MaKhach";
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
            var ctKhach = allCtKhach[currentIndex];
            if (ctKhach != null)
            {
                comboBox1.SelectedValue = ctKhach.MaKhach;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var ctKhach = new CtDoan
                {
                    MaDoan = MaDoan,
                    MaKhach = int.Parse(comboBox1.SelectedValue.ToString()),
                };

                CtDoan.Insert(ctKhach);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng thử lại", "Không thành công", MessageBoxButtons.OK);
            }              

            dataGridView1.DataSource = null;
            allCtKhach = CtDoan.GetByDoanId(MaDoan);
            dataGridView1.DataSource = allCtKhach;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var ctKhach = allCtKhach[currentIndex];
                ctKhach.MaDoan = MaDoan;
                ctKhach.MaKhach = int.Parse(comboBox1.SelectedValue.ToString());
                ctKhach.Khach = allKhach.Find( e=> e.MaKhach == int.Parse(comboBox1.SelectedValue.ToString()));
                ctKhach.Update();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng thử lại", "Không thành công", MessageBoxButtons.OK);
            }              

            dataGridView1.DataSource = null;
            allCtKhach = CtDoan.GetByDoanId(MaDoan);
            dataGridView1.DataSource = allCtKhach;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cf = MessageBox.Show("Bạn có chắc muốn xóa không?", "Confirm", MessageBoxButtons.YesNo);
            if (cf == DialogResult.Yes)
            {
                var ctKhach = allCtKhach[currentIndex];

                ctKhach.Delete();

                dataGridView1.DataSource = null;
                allCtKhach = CtDoan.GetByDoanId(MaDoan);
                dataGridView1.DataSource = allCtKhach;
            }
        }
    }
}
