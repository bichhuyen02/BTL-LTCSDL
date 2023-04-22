using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLSV;
using BUS_QLSV;

namespace GUI_QLSV
{
    public partial class TrangChu : Form
    {
        public static string ms = "";
        public static string cbb = "";
        public static string ten = "";

        private static BUS_SV bUS_SV = new BUS_SV();
        private static BUS_Diem bUS_Diem = new BUS_Diem();
        private static BUS_MonHoc bUS_MonHoc = new BUS_MonHoc();

        public TrangChu()
        {
            InitializeComponent();
        }


        public void LoadDataSV()
        {
            dataGridView1.DataSource=bUS_SV.getTSV();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            label4.Text = ms;
            label6.Text = ten;

            if(cbb == "Sinh Viên")
            {
                dataGridView1.DataSource = bUS_Diem.getTDiemByMSSV(ms);

                smiQLDiem.Visible = false;
                smiQLGV.Visible = false;
                smiQLLop.Visible = false;
                smiQLSV.Visible = false;
            }
            if(cbb == "Giảng Viên")
            {
                dataGridView1.DataSource = bUS_MonHoc.getTMHByMGV(ms);
                smiQLGV.Visible = false;
                smiQLLop.Visible = false;
                smiQLSV.Visible = false;
                smiThongKe.Visible = false;
            }
            else { 
                LoadDataSV();
            }
        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diem qLD = new Diem();
            qLD.ShowDialog();
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ms = "";
            Login login = new Login();
            login.ShowDialog();   
            this.Close();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SinhVien qlSV = new SinhVien();
            qlSV.ShowDialog();
            this.Close();
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lop qLL = new Lop();
            qLL.ShowDialog();
            this.Close();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thống_kê thong_Ke = new Thống_kê();
            thong_Ke.ShowDialog();
            this.Close();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" && cbb == "Sinh Viên")
            {
                txtSearch.Text = "Nhập mã môn học";
            }
            if (txtSearch.Text == "" && cbb == "Giảng Viên")
            {
                txtSearch.Text = "Nhập mã môn học";
            }
            if(txtSearch.Text == "" && cbb == "Quản trị")
            {
                txtSearch.Text = "Nhập mã sinh viên";
            }    
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void smiQLGV_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giảng_viên giang_Vien = new Giảng_viên();
            giang_Vien.ShowDialog();
            this.Close();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "" && cbb == "Sinh Viên")
            {
                dataGridView1.DataSource = bUS_Diem.getTDiemByIdMH(txtSearch.Text);
            }
            if (txtSearch.Text != "" && cbb == "Giảng Viên")
            {
                dataGridView1.DataSource = bUS_MonHoc.getTMHById(txtSearch.Text);
            }
            if (txtSearch.Text != "" && cbb == "Quản trị")
            {
                dataGridView1.DataSource = bUS_SV.getTSVByID(txtSearch.Text);
            }
        }
    }
}
