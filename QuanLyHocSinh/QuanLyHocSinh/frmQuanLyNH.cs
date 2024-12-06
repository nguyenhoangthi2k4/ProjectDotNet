using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace QuanLyHocSinh
{
    public partial class frmQuanLyNH : Form
    {
        NamHocBLL namHocBLL = new NamHocBLL();
        LopHocBLL lopHocBLL = new LopHocBLL();
        GiaoVienBLL giaoVienBLL = new GiaoVienBLL();
        

        private bool flagNH = false; // Không thay đổi dữ liệu bảng NAMHOC
        private bool flagLH = false; // Không thay đổi dữ liệu bảng LOPHOC
        public frmQuanLyNH()
        {
            InitializeComponent();
            // this.cbHocKy
            string[] hk = new string[2] { "1", "2" };
            this.cbHocKy.Items.AddRange(hk);

            // Danh sách Năm học
            DataTable dtNH = namHocBLL.GetData();
            this.dgvDanhSachNH.DataSource = dtNH;
            this.dgvDanhSachNH.Columns["MaNH"].HeaderText = "Năm học";
            this.dgvDanhSachNH.Columns["MaHK"].HeaderText = "Học kỳ";            

            // this.dgvLopHoc
            DataTable dtLop = lopHocBLL.GetData();
            this.dgvLopHoc.DataSource = dtLop;
            this.dgvLopHoc.Columns["MALOP"].HeaderText = "Mã Lớp";
            this.dgvLopHoc.Columns["TENLOP"].HeaderText = "Tên Lớp";
            this.dgvLopHoc.Columns["SISO"].HeaderText = "Sĩ Số";
            this.dgvLopHoc.Columns["GVCN"].HeaderText = "GVCN";
            this.dgvLopHoc.Columns["MANH"].HeaderText = "Mã Năm học";
            this.dgvLopHoc.Columns["MAHK"].Visible = false;

            // this.cbGVCN
            DataTable dtGVCN = giaoVienBLL.GetData();
            this.cbGVCN.DataSource = dtGVCN;
            this.cbGVCN.DisplayMember = "HOTEN";
            this.cbGVCN.ValueMember = "MAGV";
            

            // this.cbMaNH
            this.cbMaNH.DataSource = namHocBLL.GetDataMaNH();
            this.cbMaNH.DisplayMember = "MaNH";
            this.cbMaNH.ValueMember = "MaNH";

            this.txtNamHoc.Focus();
            this.cbHocKy.SelectedIndex = -1;
            this.cbMaNH.SelectedIndex = -1;
            this.cbGVCN.SelectedIndex = -1;
        }

        private void dgvDanhSachNH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDanhSachNH.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvDanhSachNH.SelectedRows[0];
                this.txtNamHoc.Text = row.Cells[0].Value.ToString();
                if (row.Cells[1].Value.ToString() == "1")
                    this.cbHocKy.SelectedIndex = 0;
                else
                    this.cbHocKy.SelectedIndex = 1;
            }
        }
        private void dgvLopHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.dgvLopHoc.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvLopHoc.SelectedRows[0];
                this.txtMaLop.Text = row.Cells[0].Value.ToString();
                this.txtTenLop.Text = row.Cells[1].Value.ToString();
                this.cbMaNH.SelectedValue = row.Cells[4].Value.ToString();
                this.cbGVCN.SelectedValue = row.Cells[3].Value.ToString();
            }
        }

        public void InsertNH()
        {
            NamHoc namHoc = new NamHoc();
            namHoc.MaNH = this.txtNamHoc.Text.ToUpper();
            namHoc.MaHK = this.cbHocKy.SelectedItem?.ToString();

            string resultNH = namHocBLL.Insert(namHoc);
            MessageBox.Show(resultNH, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.txtNamHoc.Text = string.Empty;
            this.cbHocKy.SelectedIndex = -1;           
        }

        public void InsertLopHoc()
        {
            LopHoc lopHoc = new LopHoc();
            lopHoc.MaLop = this.txtMaLop.Text.ToUpper();
            lopHoc.TenLop = this.txtTenLop.Text;
            lopHoc.Gvcn = this.cbGVCN.SelectedValue?.ToString();
            lopHoc.SiSo = "0";
            lopHoc.MaNH = this.cbMaNH.SelectedValue?.ToString();
            lopHoc.MaHK = "1"; // Default
            
            string resultLopHoc = lopHocBLL.Insert(lopHoc);
            MessageBox.Show(resultLopHoc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.txtMaLop.Text = string.Empty;
            this.txtTenLop.Text = string.Empty;
            this.cbMaNH.SelectedIndex = -1;
            this.cbGVCN.SelectedIndex = -1; 
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if(flagNH==true)
            {
                this.InsertNH();
                flagNH = false;
            }    
            if(flagLH==true)
            {
                this.InsertLopHoc();
                flagLH = false;
            }               
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                namHocBLL.Save();
                lopHocBLL.Save();
            }
        }

        private void txtNamHoc_TextChanged(object sender, EventArgs e)
        {
            if (this.txtNamHoc.Text != string.Empty)
                flagNH = true;
            else
                flagNH = false;
        }

        private void txtMaLop_TextChanged(object sender, EventArgs e)
        {
            if (this.txtMaLop.Text != string.Empty)
                flagLH = true;
            else
                flagLH = false;
        }
    }
}
