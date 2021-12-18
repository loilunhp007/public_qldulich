
namespace TourManager.GUI
{
    partial class FMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnKhach = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnDoan = new System.Windows.Forms.Button();
            this.btnTour = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.panelMenu.Controls.Add(this.btnThongKe);
            this.panelMenu.Controls.Add(this.btnKhach);
            this.panelMenu.Controls.Add(this.btnNhanVien);
            this.panelMenu.Controls.Add(this.btnDoan);
            this.panelMenu.Controls.Add(this.btnTour);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 611);
            this.panelMenu.TabIndex = 0;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = global::TourManager.Properties.Resources.icons8_cashbook_30;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 300);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(220, 60);
            this.btnThongKe.TabIndex = 7;
            this.btnThongKe.Text = "   THỐNG KÊ";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnKhach
            // 
            this.btnKhach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhach.FlatAppearance.BorderSize = 0;
            this.btnKhach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKhach.ForeColor = System.Drawing.Color.White;
            this.btnKhach.Image = ((System.Drawing.Image)(resources.GetObject("btnKhach.Image")));
            this.btnKhach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhach.Location = new System.Drawing.Point(0, 240);
            this.btnKhach.Name = "btnKhach";
            this.btnKhach.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnKhach.Size = new System.Drawing.Size(220, 60);
            this.btnKhach.TabIndex = 5;
            this.btnKhach.Text = "   KHÁCH";
            this.btnKhach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhach.UseVisualStyleBackColor = true;
            this.btnKhach.Click += new System.EventHandler(this.btnKhach_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Image = global::TourManager.Properties.Resources.icons8_tour_guide_skin_type_3_30;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 180);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(220, 60);
            this.btnNhanVien.TabIndex = 4;
            this.btnNhanVien.Text = "   NHÂN VIÊN";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnDoan
            // 
            this.btnDoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoan.FlatAppearance.BorderSize = 0;
            this.btnDoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDoan.ForeColor = System.Drawing.Color.White;
            this.btnDoan.Image = global::TourManager.Properties.Resources.icons8_group_30;
            this.btnDoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoan.Location = new System.Drawing.Point(0, 120);
            this.btnDoan.Name = "btnDoan";
            this.btnDoan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDoan.Size = new System.Drawing.Size(220, 60);
            this.btnDoan.TabIndex = 3;
            this.btnDoan.Text = "   ĐOÀN";
            this.btnDoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoan.UseVisualStyleBackColor = true;
            this.btnDoan.Click += new System.EventHandler(this.btnDoan_Click);
            // 
            // btnTour
            // 
            this.btnTour.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTour.FlatAppearance.BorderSize = 0;
            this.btnTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTour.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTour.ForeColor = System.Drawing.Color.White;
            this.btnTour.Image = global::TourManager.Properties.Resources.icons8_bus_301;
            this.btnTour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTour.Location = new System.Drawing.Point(0, 60);
            this.btnTour.Name = "btnTour";
            this.btnTour.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTour.Size = new System.Drawing.Size(220, 60);
            this.btnTour.TabIndex = 1;
            this.btnTour.Text = "   TOURS";
            this.btnTour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTour.UseVisualStyleBackColor = true;
            this.btnTour.Click += new System.EventHandler(this.btnTours_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 60);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lbTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(964, 60);
            this.panelTitleBar.TabIndex = 1;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.Image")));
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(51, 60);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Visible = false;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(441, 18);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(76, 30);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "HOME";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Controls.Add(this.pictureBox);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(220, 60);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(964, 551);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = global::TourManager.Properties.Resources.Trip_amico;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(964, 551);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktopPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnTour;
        private System.Windows.Forms.Button btnKhach;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnDoan;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnThongKe;
    }
}

