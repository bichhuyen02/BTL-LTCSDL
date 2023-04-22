using BUS_QLSV;
using DTO_QLSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace GUI_QLSV
{
    public partial class Thống_kê : Form
    {
        private static BUS_SV bUS_SV = new BUS_SV();
        private static BUS_Diem bUS_Diem = new BUS_Diem();

        public Thống_kê()
        {
            InitializeComponent();
        }

        public void LoadDataSV()
        {
            dataGridView1.DataSource = bUS_SV.getTSV();
        }

        private void Thống_kê_Load(object sender, EventArgs e)
        {
            if (TrangChu.cbb == "Sinh Viên")
            {
                dataGridView1.DataSource = bUS_Diem.getTDiemByMSSV(TrangChu.ms);

                smiQLDiem.Visible = false;
                smiQLGV.Visible = false;
                smiQLLop.Visible = false;
                smiQLSV.Visible = false;
            }
            else { LoadDataSV(); }
        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diem diem = new Diem();
            diem.ShowDialog();
            this.Close();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SinhVien sinhVien = new SinhVien();
            sinhVien.ShowDialog();
            this.Close();
        }

        private void quảnLýGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giảng_viên giang_Vien = new Giảng_viên();
            giang_Vien.ShowDialog();
            this.Close();
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lop lop = new Lop();
            lop.ShowDialog();
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void smiTrangChu_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu trangChu = new TrangChu();
            trangChu.ShowDialog();
            this.Close();
        }

    }
}
