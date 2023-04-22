namespace GUI_QLSV
{
    partial class Thống_kê
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
            this.components = new System.ComponentModel.Container();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.smiTrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.smiQLSV = new System.Windows.Forms.ToolStripMenuItem();
            this.smiQLGV = new System.Windows.Forms.ToolStripMenuItem();
            this.smiQLLop = new System.Windows.Forms.ToolStripMenuItem();
            this.smiQLDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.smiDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.diemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(764, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 29);
            this.label11.TabIndex = 68;
            this.label11.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1370, 64);
            this.label1.TabIndex = 67;
            this.label1.Text = "Thống kê";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiTrangChu,
            this.smiQLSV,
            this.smiQLGV,
            this.smiQLLop,
            this.smiQLDiem,
            this.smiDangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 28);
            this.menuStrip1.TabIndex = 66;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // smiTrangChu
            // 
            this.smiTrangChu.Name = "smiTrangChu";
            this.smiTrangChu.Size = new System.Drawing.Size(89, 24);
            this.smiTrangChu.Text = "Trang Chủ";
            this.smiTrangChu.Click += new System.EventHandler(this.smiTrangChu_Click);
            // 
            // smiQLSV
            // 
            this.smiQLSV.Name = "smiQLSV";
            this.smiQLSV.Size = new System.Drawing.Size(140, 24);
            this.smiQLSV.Text = "Quản Lý Sinh Viên";
            this.smiQLSV.Click += new System.EventHandler(this.quảnLýSinhViênToolStripMenuItem_Click);
            // 
            // smiQLGV
            // 
            this.smiQLGV.Name = "smiQLGV";
            this.smiQLGV.Size = new System.Drawing.Size(151, 24);
            this.smiQLGV.Text = "Quản Lý Giảng Viên";
            this.smiQLGV.Click += new System.EventHandler(this.quảnLýGiảngViênToolStripMenuItem_Click);
            // 
            // smiQLLop
            // 
            this.smiQLLop.Name = "smiQLLop";
            this.smiQLLop.Size = new System.Drawing.Size(104, 24);
            this.smiQLLop.Text = "Quản Lý Lớp";
            this.smiQLLop.Click += new System.EventHandler(this.quảnLýLớpToolStripMenuItem_Click);
            // 
            // smiQLDiem
            // 
            this.smiQLDiem.Name = "smiQLDiem";
            this.smiQLDiem.Size = new System.Drawing.Size(115, 24);
            this.smiQLDiem.Text = "Quản Lý Điểm";
            this.smiQLDiem.Click += new System.EventHandler(this.quảnLýĐiểmToolStripMenuItem_Click);
            // 
            // smiDangXuat
            // 
            this.smiDangXuat.Name = "smiDangXuat";
            this.smiDangXuat.Size = new System.Drawing.Size(91, 24);
            this.smiDangXuat.Text = "Đăng xuất";
            this.smiDangXuat.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox2.Location = new System.Drawing.Point(58, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1250, 561);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1212, 504);
            this.dataGridView1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 726);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1370, 23);
            this.label3.TabIndex = 76;
            this.label3.Text = "@2023 Hệ thống quản lý sinh viên - Thiết kế bởi H&N";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diemBindingSource
            // 
            this.diemBindingSource.DataMember = "Diem";
            // 
            // Thống_kê
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Thống_kê";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Thống_kê_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem smiQLDiem;
        private System.Windows.Forms.ToolStripMenuItem smiQLSV;
        private System.Windows.Forms.ToolStripMenuItem smiQLGV;
        private System.Windows.Forms.ToolStripMenuItem smiQLLop;
        private System.Windows.Forms.ToolStripMenuItem smiTrangChu;
        private System.Windows.Forms.ToolStripMenuItem smiDangXuat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.BindingSource diemBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}