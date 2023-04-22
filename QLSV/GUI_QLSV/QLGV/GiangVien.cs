using BUS_QLSV;
using DTO_QLSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace GUI_QLSV
{
    public partial class Giảng_viên : Form
    {
        private static BUS_GV bUS_GV = new BUS_GV();

        public Giảng_viên()
        {
            InitializeComponent();
        }

        public void LoadDataGV()
        {
            dataGridView1.DataSource = bUS_GV.getTGV();
        }

        private void Giảng_viên_Load(object sender, EventArgs e)
        {
            lbMSSV.Text = TrangChu.ms;

            LoadDataGV();

            string[] hocVi = { "Tiến Sĩ", "Thạc Sĩ", "Nghiên Cứu Sinh", "Cử Nhân" };
            foreach (string v in hocVi)
            {
                cbbHocVi.Items.Add(v);
            }

            string[] chucVu = { "Lãnh Đạo Khoa", "Chuyên Viên Khoa", "Giảng Viên Cơ Hữu", "Giảng Viên Thỉnh Giảng" };
            foreach(string c in chucVu)
            {
                cbbChucVu.Items.Add(c);
            }    
        }

        public bool CheckChar(string kw)
        {
            foreach(char c in kw)
            {
                if(!char.IsLetter(c))
                { return false;  
                }
            }
            return true;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtTen.Text != "" && mtxtCCCD.Text != "" && txtEmail.Text != "" && mtxtMaGV.Text != "" &&
                txtQue.Text != "" && mtxtSDT.Text != "" && mtxtNgaySinh.Text != "" && cbbChucVu.Text != ""
                && cbbHocVi.Text != "")
            {
                if(CheckChar(txtQue.Text))
                {     
                    DTO_GV dTO_GV = new DTO_GV(mtxtMaGV.Text, txtTen.Text, mtxtCCCD.Text, 
                        rdbtNam.Checked ? "Nam" : "Nữ", mtxtNgaySinh.Text, cbbHocVi.Text, cbbChucVu.Text,
                        txtQue.Text, txtEmail.Text, mtxtSDT.Text);

                    if (bUS_GV.ThemGV(dTO_GV))
                    {
                        MessageBox.Show("THÊM THÀNH CÔNG");
                        LoadDataGV();
                    }
                    else { MessageBox.Show("THÊM KHÔNG THÀNH CÔNG"); }
                }
                else { MessageBox.Show("Nhập quê sai định dạng"); }
            }
            else { MessageBox.Show("XIN HÃY NHẬP ĐẦY ĐỦ THÔNG TIN"); }
 }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                if (txtTen.Text != "" && mtxtCCCD.Text != "" && txtEmail.Text != "" && mtxtMaGV.Text != "" &&
                txtQue.Text != "" && mtxtSDT.Text != "" && mtxtNgaySinh.Text != "" && cbbChucVu.Text != ""
                && cbbHocVi.Text != "")
                {

                    DTO_GV dTO_GV = new DTO_GV(mtxtMaGV.Text, txtTen.Text, mtxtCCCD.Text,
                        rdbtNam.Checked ? "Nam" : "Nữ", mtxtNgaySinh.Text, cbbHocVi.Text, cbbChucVu.Text,
                        txtQue.Text, txtEmail.Text, mtxtSDT.Text);
                    if (bUS_GV.SuaGV(dTO_GV))
                    {
                        MessageBox.Show("SỬA THÀNH CÔNG");
                        LoadDataGV();
                    }
                    else
                    {
                        MessageBox.Show("SỬA KHÔNG THÀNH CÔNG");
                    }
                }
                else
                {
                    MessageBox.Show("THÔNG TIN SAI HOẶC NHẬP THIẾU THÔNG TIN");
                }
            }
            else
            {
                MessageBox.Show("HÃY CHỌN PHIẾU ĐIỂM MUỐN SỬA");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {

                if (bUS_GV.XoaGV(mtxtMaGV.Text))
                {
                    MessageBox.Show("XÓA THÀNH CÔNG");
                    LoadDataGV();
                }
                else
                {
                    MessageBox.Show("XÓA KHÔNG THÀNH CÔNG");
                }
            }
            else
            {
                MessageBox.Show("HÃY CHỌN PHIẾU ĐIỂM MUỐN XÓA");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu trangChu = new TrangChu();
            trangChu.ShowDialog();
            this.Close();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bUS_GV.getTGVById(txtSearch.Text);
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu trangChu = new TrangChu();
            trangChu.ShowDialog();
            this.Close();
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

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lop lop = new Lop();
            lop.ShowDialog();
            this.Close();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thống_kê thongKe = new Thống_kê();
            thongKe.ShowDialog();
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            if (e.RowIndex >= 0)
            {
                index = e.RowIndex;
                mtxtMaGV.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txtTen.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                mtxtNgaySinh.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                mtxtCCCD.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                if (dataGridView1.Rows[index].Cells[4].Value.ToString() == "Nam")
                {
                    rdbtNam.Checked = true;
                }    
                else { rdbtNu.Checked = true; }
                cbbHocVi.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
                cbbChucVu.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
                txtQue.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[index].Cells[8].Value.ToString();
                mtxtSDT.Text = dataGridView1.Rows[index].Cells[9].Value.ToString();
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Tìm kiếm mã sinh sinh";
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

    }
}
