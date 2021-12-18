
namespace TourManager.GUI
{
    partial class FThongKe
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
            this.tlpTK = new System.Windows.Forms.TableLayoutPanel();
            this.pTkCp = new System.Windows.Forms.Panel();
            this.txSCp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pTkNv = new System.Windows.Forms.Panel();
            this.txCNv = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pTkDoan = new System.Windows.Forms.Panel();
            this.txCDoan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pTkTour = new System.Windows.Forms.Panel();
            this.txCTour = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pTK = new System.Windows.Forms.Panel();
            this.tlpTK.SuspendLayout();
            this.pTkCp.SuspendLayout();
            this.pTkNv.SuspendLayout();
            this.pTkDoan.SuspendLayout();
            this.pTkTour.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpTK
            // 
            this.tlpTK.ColumnCount = 4;
            this.tlpTK.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTK.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTK.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTK.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTK.Controls.Add(this.pTkCp, 3, 0);
            this.tlpTK.Controls.Add(this.pTkNv, 2, 0);
            this.tlpTK.Controls.Add(this.pTkDoan, 1, 0);
            this.tlpTK.Controls.Add(this.pTkTour, 0, 0);
            this.tlpTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpTK.Location = new System.Drawing.Point(0, 0);
            this.tlpTK.Name = "tlpTK";
            this.tlpTK.RowCount = 1;
            this.tlpTK.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTK.Size = new System.Drawing.Size(984, 100);
            this.tlpTK.TabIndex = 0;
            // 
            // pTkCp
            // 
            this.pTkCp.BackColor = System.Drawing.Color.Teal;
            this.pTkCp.Controls.Add(this.txSCp);
            this.pTkCp.Controls.Add(this.label8);
            this.pTkCp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTkCp.Location = new System.Drawing.Point(743, 5);
            this.pTkCp.Margin = new System.Windows.Forms.Padding(5);
            this.pTkCp.Name = "pTkCp";
            this.pTkCp.Size = new System.Drawing.Size(236, 90);
            this.pTkCp.TabIndex = 3;
            // 
            // txSCp
            // 
            this.txSCp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txSCp.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txSCp.ForeColor = System.Drawing.Color.White;
            this.txSCp.Location = new System.Drawing.Point(3, 48);
            this.txSCp.Name = "txSCp";
            this.txSCp.Size = new System.Drawing.Size(230, 28);
            this.txSCp.TabIndex = 1;
            this.txSCp.Text = "1000";
            this.txSCp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "DOANH SỐ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pTkNv
            // 
            this.pTkNv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pTkNv.Controls.Add(this.txCNv);
            this.pTkNv.Controls.Add(this.label6);
            this.pTkNv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTkNv.Location = new System.Drawing.Point(497, 5);
            this.pTkNv.Margin = new System.Windows.Forms.Padding(5);
            this.pTkNv.Name = "pTkNv";
            this.pTkNv.Size = new System.Drawing.Size(236, 90);
            this.pTkNv.TabIndex = 2;
            // 
            // txCNv
            // 
            this.txCNv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txCNv.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txCNv.ForeColor = System.Drawing.Color.White;
            this.txCNv.Location = new System.Drawing.Point(3, 48);
            this.txCNv.Name = "txCNv";
            this.txCNv.Size = new System.Drawing.Size(230, 28);
            this.txCNv.TabIndex = 1;
            this.txCNv.Text = "1000";
            this.txCNv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "NHÂN VIÊN";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pTkDoan
            // 
            this.pTkDoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pTkDoan.Controls.Add(this.txCDoan);
            this.pTkDoan.Controls.Add(this.label4);
            this.pTkDoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTkDoan.Location = new System.Drawing.Point(251, 5);
            this.pTkDoan.Margin = new System.Windows.Forms.Padding(5);
            this.pTkDoan.Name = "pTkDoan";
            this.pTkDoan.Size = new System.Drawing.Size(236, 90);
            this.pTkDoan.TabIndex = 1;
            // 
            // txCDoan
            // 
            this.txCDoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txCDoan.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txCDoan.ForeColor = System.Drawing.Color.White;
            this.txCDoan.Location = new System.Drawing.Point(3, 48);
            this.txCDoan.Name = "txCDoan";
            this.txCDoan.Size = new System.Drawing.Size(230, 28);
            this.txCDoan.TabIndex = 1;
            this.txCDoan.Text = "1000";
            this.txCDoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "ĐOÀN";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pTkTour
            // 
            this.pTkTour.BackColor = System.Drawing.Color.YellowGreen;
            this.pTkTour.Controls.Add(this.txCTour);
            this.pTkTour.Controls.Add(this.label1);
            this.pTkTour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTkTour.Location = new System.Drawing.Point(5, 5);
            this.pTkTour.Margin = new System.Windows.Forms.Padding(5);
            this.pTkTour.Name = "pTkTour";
            this.pTkTour.Size = new System.Drawing.Size(236, 90);
            this.pTkTour.TabIndex = 0;
            // 
            // txCTour
            // 
            this.txCTour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txCTour.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txCTour.ForeColor = System.Drawing.Color.White;
            this.txCTour.Location = new System.Drawing.Point(3, 48);
            this.txCTour.Name = "txCTour";
            this.txCTour.Size = new System.Drawing.Size(230, 28);
            this.txCTour.TabIndex = 1;
            this.txCTour.Text = "1000";
            this.txCTour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOURS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pTK
            // 
            this.pTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTK.Location = new System.Drawing.Point(0, 100);
            this.pTK.Name = "pTK";
            this.pTK.Size = new System.Drawing.Size(984, 411);
            this.pTK.TabIndex = 1;
            // 
            // FThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.pTK);
            this.Controls.Add(this.tlpTK);
            this.Name = "FThongKe";
            this.Text = "THỐNG KÊ";
            this.Load += new System.EventHandler(this.FThongKe_Load);
            this.tlpTK.ResumeLayout(false);
            this.pTkCp.ResumeLayout(false);
            this.pTkCp.PerformLayout();
            this.pTkNv.ResumeLayout(false);
            this.pTkNv.PerformLayout();
            this.pTkDoan.ResumeLayout(false);
            this.pTkDoan.PerformLayout();
            this.pTkTour.ResumeLayout(false);
            this.pTkTour.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTK;
        private System.Windows.Forms.Panel pTkTour;
        private System.Windows.Forms.Label txCTour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pTkCp;
        private System.Windows.Forms.Label txSCp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pTkNv;
        private System.Windows.Forms.Label txCNv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pTkDoan;
        private System.Windows.Forms.Label txCDoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pTK;
    }
}