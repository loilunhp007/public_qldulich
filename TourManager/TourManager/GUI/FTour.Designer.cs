
namespace TourManager.GUI
{
    partial class FTour
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTour = new System.Windows.Forms.DataGridView();
            this.TenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DacDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txTenTour = new System.Windows.Forms.TextBox();
            this.txDacDiem = new System.Windows.Forms.TextBox();
            this.txTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.cbLoaiTour = new System.Windows.Forms.ComboBox();
            this.btnFLoaiTour = new System.Windows.Forms.Button();
            this.btnFCtTour = new System.Windows.Forms.Button();
            this.btnFBangGia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loại Tour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên Tour";
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(788, 228);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(60, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(695, 228);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(60, 23);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(591, 228);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 23);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(591, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Đặc Điểm";
            // 
            // dgvTour
            // 
            this.dgvTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenTour,
            this.TenLoaiTour,
            this.DacDiem});
            this.dgvTour.Location = new System.Drawing.Point(12, 74);
            this.dgvTour.Name = "dgvTour";
            this.dgvTour.RowTemplate.Height = 25;
            this.dgvTour.Size = new System.Drawing.Size(530, 342);
            this.dgvTour.TabIndex = 9;
            this.dgvTour.SelectionChanged += new System.EventHandler(this.dgvTour_SelectionChanged);
            // 
            // TenTour
            // 
            this.TenTour.HeaderText = "Tên Tour";
            this.TenTour.Name = "TenTour";
            // 
            // TenLoaiTour
            // 
            this.TenLoaiTour.HeaderText = "Loại Tour";
            this.TenLoaiTour.Name = "TenLoaiTour";
            // 
            // DacDiem
            // 
            this.DacDiem.HeaderText = "Đặc Điểm";
            this.DacDiem.Name = "DacDiem";
            // 
            // txTenTour
            // 
            this.txTenTour.Location = new System.Drawing.Point(668, 74);
            this.txTenTour.Name = "txTenTour";
            this.txTenTour.Size = new System.Drawing.Size(180, 23);
            this.txTenTour.TabIndex = 18;
            // 
            // txDacDiem
            // 
            this.txDacDiem.Location = new System.Drawing.Point(668, 176);
            this.txDacDiem.Name = "txDacDiem";
            this.txDacDiem.Size = new System.Drawing.Size(180, 23);
            this.txDacDiem.TabIndex = 19;
            // 
            // txTim
            // 
            this.txTim.Location = new System.Drawing.Point(77, 26);
            this.txTim.Name = "txTim";
            this.txTim.Size = new System.Drawing.Size(180, 23);
            this.txTim.TabIndex = 21;
            this.txTim.TextChanged += new System.EventHandler(this.txTim_TextChanged);
            // 
            // btnTim
            // 
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Location = new System.Drawing.Point(12, 26);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(50, 23);
            this.btnTim.TabIndex = 22;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cbLoaiTour
            // 
            this.cbLoaiTour.FormattingEnabled = true;
            this.cbLoaiTour.Location = new System.Drawing.Point(668, 125);
            this.cbLoaiTour.Name = "cbLoaiTour";
            this.cbLoaiTour.Size = new System.Drawing.Size(180, 23);
            this.cbLoaiTour.TabIndex = 25;
            // 
            // btnFLoaiTour
            // 
            this.btnFLoaiTour.FlatAppearance.BorderSize = 0;
            this.btnFLoaiTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFLoaiTour.Image = global::TourManager.Properties.Resources.plus_16;
            this.btnFLoaiTour.Location = new System.Drawing.Point(868, 125);
            this.btnFLoaiTour.Name = "btnFLoaiTour";
            this.btnFLoaiTour.Size = new System.Drawing.Size(23, 23);
            this.btnFLoaiTour.TabIndex = 35;
            this.btnFLoaiTour.UseVisualStyleBackColor = true;
            this.btnFLoaiTour.Click += new System.EventHandler(this.btnFLoaiTour_Click);
            // 
            // btnFCtTour
            // 
            this.btnFCtTour.FlatAppearance.BorderSize = 0;
            this.btnFCtTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFCtTour.Location = new System.Drawing.Point(12, 449);
            this.btnFCtTour.Name = "btnFCtTour";
            this.btnFCtTour.Size = new System.Drawing.Size(245, 23);
            this.btnFCtTour.TabIndex = 36;
            this.btnFCtTour.Text = "Chi Tiết Địa Điểm";
            this.btnFCtTour.UseVisualStyleBackColor = true;
            this.btnFCtTour.Click += new System.EventHandler(this.btnFCtTour_Click);
            // 
            // btnFBangGia
            // 
            this.btnFBangGia.FlatAppearance.BorderSize = 0;
            this.btnFBangGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFBangGia.Location = new System.Drawing.Point(297, 449);
            this.btnFBangGia.Name = "btnFBangGia";
            this.btnFBangGia.Size = new System.Drawing.Size(245, 23);
            this.btnFBangGia.TabIndex = 37;
            this.btnFBangGia.Text = "Bảng Giá";
            this.btnFBangGia.UseVisualStyleBackColor = true;
            this.btnFBangGia.Click += new System.EventHandler(this.btnFBangGia_Click);
            // 
            // FTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.btnFBangGia);
            this.Controls.Add(this.btnFCtTour);
            this.Controls.Add(this.btnFLoaiTour);
            this.Controls.Add(this.cbLoaiTour);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txTim);
            this.Controls.Add(this.txDacDiem);
            this.Controls.Add(this.txTenTour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvTour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FTour";
            this.Text = "TOURS";
            this.Load += new System.EventHandler(this.FTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvTour;
        private System.Windows.Forms.TextBox txTenTour;
        private System.Windows.Forms.TextBox txDacDiem;
        private System.Windows.Forms.TextBox txTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cbLoaiTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn DacDiem;
        private System.Windows.Forms.Button btnFLoaiTour;
        private System.Windows.Forms.Button btnFCtTour;
        private System.Windows.Forms.Button btnFBangGia;
    }
}