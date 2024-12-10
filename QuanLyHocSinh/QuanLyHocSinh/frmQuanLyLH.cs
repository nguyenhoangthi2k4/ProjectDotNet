using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmQuanLyLH : Form
    {
        NamHocBLL namHocBLL = new NamHocBLL();
        LopHocBLL lopHocBLL = new LopHocBLL();
        GiaoVienBLL giaoVienBLL = new GiaoVienBLL();
        
        public frmQuanLyLH()
        {
            InitializeComponent();
            
            // this.dgvLopHoc
            DataTable dtLop = lopHocBLL.GetData();
            this.dgvLopHoc.DataSource = dtLop;
            this.dgvLopHoc.Columns["MALOP"].HeaderText = "Mã Lớp";
            this.dgvLopHoc.Columns["TENLOP"].HeaderText = "Tên Lớp";
            this.dgvLopHoc.Columns["SISO"].HeaderText = "Sĩ Số";
            this.dgvLopHoc.Columns["GVCN"].HeaderText = "GVCN";
            this.dgvLopHoc.Columns["MANH"].HeaderText = "Mã Năm học";
            this.dgvLopHoc.Columns["HOTEN"].HeaderText = "Tên GVCN";
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

            this.cbMaNH.Focus();
            this.cbMaNH.SelectedIndex = -1;
            this.cbGVCN.SelectedIndex = -1;
        }
        private void dgvLopHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvLopHoc.SelectedRows.Count > 0)
            {
                this.txtMaLop.ReadOnly = true;
                this.txtMaLop.BackColor = Color.LightGray;

                DataGridViewRow row = this.dgvLopHoc.SelectedRows[0];
                this.txtMaLop.Text = row.Cells["MALOP"].Value.ToString();
                this.txtTenLop.Text = row.Cells["TENLOP"].Value.ToString();
                this.cbMaNH.SelectedValue = row.Cells["MANH"].Value.ToString();
                this.cbGVCN.SelectedValue = row.Cells["GVCN"].Value.ToString();
            }
        }
        private void InsertLopHoc()
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            InsertLopHoc(); 
        }

        private void UpdateLopHoc()
        {
            LopHoc lopHoc = new LopHoc();
            lopHoc.MaLop = this.txtMaLop.Text.ToUpper();
            lopHoc.TenLop = this.txtTenLop.Text;
            lopHoc.Gvcn = this.cbGVCN.SelectedValue?.ToString();            
            lopHoc.MaNH = this.cbMaNH.SelectedValue?.ToString();           

            string resultLopHoc = lopHocBLL.Update(lopHoc);
            MessageBox.Show(resultLopHoc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.txtMaLop.Text = string.Empty;
            this.txtTenLop.Text = string.Empty;
            this.cbMaNH.SelectedIndex = -1;
            this.cbGVCN.SelectedIndex = -1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (this.dgvLopHoc.SelectedRows.Count > 0)
                UpdateLopHoc();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                lopHocBLL.Save();
                this.dgvLopHoc.ClearSelection();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            lopHocBLL.Destroy();

            this.dgvLopHoc.ClearSelection();
            this.txtMaLop.ReadOnly = false;
            this.txtMaLop.BackColor = Color.White;

            this.txtMaLop.Focus();
            this.txtMaLop.Text = string.Empty;
            this.txtTenLop.Text = string.Empty;
            this.cbMaNH.SelectedIndex = -1;
            this.cbGVCN.SelectedIndex = -1;
        }

        private void frmQuanLyLH_Click(object sender, EventArgs e)
        {
            this.dgvLopHoc.ClearSelection();
            this.txtMaLop.ReadOnly = false;
            this.txtMaLop.BackColor = Color.White;
        }
    }
}
