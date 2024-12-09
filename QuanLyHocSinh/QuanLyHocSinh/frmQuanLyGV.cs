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
    public partial class frmQuanLyGV : Form
    {
        ToGVBLL toGVBLL = new ToGVBLL();
        GiaoVienBLL giaoVienBLL = new GiaoVienBLL();
        
        private bool fGV = false, fToGV = false;
        DataTable dtGV;
        DataTable dtToGV;
        public frmQuanLyGV()
        {
            InitializeComponent();     
            dtGV = giaoVienBLL.GetData();
            dtToGV = toGVBLL.GetData();
            // cbToGV
            this.cbTruongTo.DataSource = dtGV;
            this.cbTruongTo.DisplayMember = "HOTEN";
            this.cbTruongTo.ValueMember = "MAGV";
            this.cbTruongTo.SelectedIndex = -1;

            // cbToGV
            this.cbToGV.DataSource = dtToGV;
            this.cbToGV.DisplayMember = "TENTOGV";
            this.cbToGV.ValueMember = "MATOGV";
            this.cbToGV.SelectedIndex = -1;

            // dgvDanhSachToGV
            this.dgvDanhSachToGV.DataSource = dtToGV;
            this.dgvDanhSachToGV.Columns["MaToGv"].HeaderText = "Mã tổ";
            this.dgvDanhSachToGV.Columns["TenToGv"].HeaderText = "Tên tổ";
            this.dgvDanhSachToGV.Columns["TruongToGV"].HeaderText = "Trưởng tổ";
            

            // dgvDanhSach
            this.dgvDanhSach.DataSource = dtGV;
            this.dgvDanhSach.Columns["MAGV"].HeaderText = "Mã GV";
            this.dgvDanhSach.Columns["HOTEN"].HeaderText = "Họ tên";
            this.dgvDanhSach.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
            this.dgvDanhSach.Columns["QUEQUAN"].HeaderText = "Quê quán";
            this.dgvDanhSach.Columns["SODT"].HeaderText = "Số ĐT";
            this.dgvDanhSach.Columns["GIOITINH"].HeaderText = "Giới tính";
            this.dgvDanhSach.Columns["MONGD"].HeaderText = "Môn GD";
            this.dgvDanhSach.Columns["MATOGV"].HeaderText = "Mã tổ";
            this.dgvDanhSach.Columns["USERNAME"].HeaderText = "Tên ĐN";
            

            this.cbGioiTinh.SelectedIndex = -1; 
        }
        public void InsertGV()
        {
            GiaoVien gv = new GiaoVien(); 
            gv.MaGV = this.txtMaSo.Text.ToUpper();
            gv.TenGV = this.txtHoTen.Text;
            gv.QueQuan = this.txtQueQuan.Text;
            gv.SoDT = this.txtSoDT.Text;
            gv.MaToGV = this.cbToGV.SelectedValue?.ToString();
            gv.NgaySinh = this.dtpNgaySinh.Value.ToShortDateString();
            gv.GioiTinh = this.cbGioiTinh.SelectedItem?.ToString();           
            gv.Email = this.txtEmail.Text;
            gv.MonGD = this.txtMonGD.Text;

            gv.Taikhoan = gv.MaGV;
            gv.Matkhau = gv.MaGV.ToLower();
            
            string resultGV = giaoVienBLL.Insert(gv); // Insert GiaoVien
            MessageBox.Show(resultGV, "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.txtMaSo.Text = string.Empty;
            this.txtHoTen.Text = string.Empty;
            this.txtQueQuan.Text = string.Empty;
            this.txtSoDT.Text = string.Empty;
            this.cbToGV.SelectedIndex = -1;
            this.cbGioiTinh.SelectedIndex = -1;
            this.txtEmail.Text = string.Empty;
            this.txtMonGD.Text = string.Empty;        
        }

        public void InsertToGV()
        {           
            ToGV toGV = new ToGV();
            toGV.MaToGV = this.txtMaToGV.Text.ToUpper();
            toGV.TenToGV = this.txtTenTo.Text;
            toGV.TruongToGV = this.cbTruongTo.SelectedValue?.ToString();

            string resultToGV = toGVBLL.Insert(toGV); // Insert ToGV
            MessageBox.Show(resultToGV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            this.txtMaToGV.Text = string.Empty;
            this.txtTenTo.Text = string.Empty;
            this.cbTruongTo.SelectedIndex = -1;
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if(this.fGV)
            {
                this.InsertGV();
                this.fGV = false;
            }    
            if(this.fToGV)
            {
                this.InsertToGV();
                this.fToGV = false;
            }               
        }

        public void Update_GV()
        {
            GiaoVien gv = new GiaoVien();
            gv.MaGV = this.txtMaSo.Text;
            gv.TenGV = this.txtHoTen.Text;
            gv.QueQuan = this.txtQueQuan.Text;
            gv.SoDT = this.txtSoDT.Text;
            gv.MaToGV = this.cbToGV.SelectedValue?.ToString();
            gv.NgaySinh = this.dtpNgaySinh.Value.ToShortDateString();
            gv.GioiTinh = this.cbGioiTinh.SelectedItem?.ToString();
            gv.Email = this.txtEmail.Text;
            gv.MonGD = this.txtMonGD.Text;
            gv.Taikhoan = gv.MaGV;

            string resultUpadte = giaoVienBLL.Update(gv);
            MessageBox.Show(resultUpadte, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);            
        }
        public void Update_ToGV()
        {
            ToGV toGV = new ToGV();
            toGV.MaToGV = this.txtMaToGV.Text;
            toGV.TenToGV = this.txtTenTo.Text;
            toGV.TruongToGV = this.cbTruongTo.SelectedValue?.ToString();

            string resultUpadte = toGVBLL.Update(toGV);
            MessageBox.Show(resultUpadte, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);            
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            //if(this.dgvDanhSachToGV.SelectedRows.Count > 0)            
            //    this.Update_ToGV();
            if (this.dgvDanhSach.SelectedRows.Count > 0)
                this.Update_GV();
        }      

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            giaoVienBLL.Destroy();
            this.dgvDanhSach = new DataGridView();
            this.dgvDanhSach.DataSource = dtGV;

            this.dgvDanhSachToGV = new DataGridView();
            this.dgvDanhSachToGV.DataSource = dtToGV;
            toGVBLL.Destroy();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                giaoVienBLL.Save();
                toGVBLL.Save();
            }
        }

        private void txtMaToGV_TextChanged(object sender, EventArgs e)
        {
            if (this.txtMaToGV.Text != string.Empty)
                fToGV = true;
            else
                fToGV = false;
        }

        private void txtMaSo_TextChanged(object sender, EventArgs e)
        {
            if(this.txtMaSo.Text != string.Empty)
                fGV = true;
            else
                fGV = false;
        }

        private void dgvDanhSachToGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDanhSachToGV.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvDanhSachToGV.SelectedRows[0];
                this.txtMaToGV.Text = row.Cells["MATOGV"].Value.ToString();
                this.txtTenTo.Text = row.Cells["TENTOGV"].Value.ToString();

                DataRow[] findrow = dtGV.Select($"MAGV = '{row.Cells["TRUONGTOGV"].Value.ToString()}'");
                if (findrow.Length > 0)
                    this.cbTruongTo.SelectedValue = findrow[0]["MAGV"];
            }
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (this.dgvDanhSach.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvDanhSach.SelectedRows[0];
                this.txtMaSo.Text = row.Cells["MAGV"].Value.ToString();
                
                this.txtHoTen.Text = row.Cells["HOTEN"].Value.ToString();
                this.txtQueQuan.Text = row.Cells["QUEQUAN"].Value.ToString();
                this.txtSoDT.Text = row.Cells["SODT"].Value.ToString();
                this.txtEmail.Text = row.Cells["EMAIL"].Value.ToString();
                this.txtMonGD.Text = row.Cells["MONGD"].Value.ToString();
                this.dtpNgaySinh.Text = row.Cells["NGAYSINH"].Value.ToString();
                if (row.Cells["GIOITINH"].Value.ToString() == "Nam")
                    cbGioiTinh.SelectedIndex = 0;
                else
                    cbGioiTinh.SelectedIndex = 1;

                DataRow[] findrow = dtToGV.Select($"MATOGV = '{row.Cells["MATOGV"].Value.ToString()}'");
                if (findrow.Length >0)
                    this.cbToGV.SelectedValue = findrow[0]["MATOGV"];
              
            }            
        }
    }
}
