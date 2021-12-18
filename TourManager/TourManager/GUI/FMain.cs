using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourManager.GUI
{
    public partial class FMain : Form
    {
        private Button currentButton;
        //private Random random;
        //private int tempIndex;
        private Form activeForm;

        public FMain()
        {
            InitializeComponent();
            //random = new Random();
        }

        //private Color SelectThemeColor()
        //{
        //    int index = random.Next(ThemeColor.ColorList.Count);
        //    while (tempIndex == index)
        //    {
        //        index = random.Next(ThemeColor.ColorList.Count);
        //    }
        //    tempIndex = index;
        //    string color = ThemeColor.ColorList[index];
        //    return ColorTranslator.FromHtml(color);
        //}

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    
                    currentButton = (Button)btnSender;
                    //Color color = SelectThemeColor();
                    //currentButton.BackColor = color;
                    //panelTitleBar.BackColor = color;
                    //panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //ThemeColor.PrimaryColor = color;
                    //ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    currentButton.BackColor = Color.FromArgb(39, 43, 66);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));                    
                    panelTitleBar.BackColor = Color.FromArgb(39, 43, 66);                
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(24, 28, 54);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitle.Text = childForm.Text;
        }


        private void btnTours_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FTour(), sender);
        }

        private void btnDoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDoan(), sender);
        }        

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FNhanVien(), sender);
        }

        private void btnKhach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FKhach(), sender);
        }

        //private void btnChiPhi_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new FKhach(), sender);
        //}

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FThongKe(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lbTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(39, 43, 66);
            panelLogo.BackColor = Color.FromArgb(39, 43, 66);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }
    }
}
