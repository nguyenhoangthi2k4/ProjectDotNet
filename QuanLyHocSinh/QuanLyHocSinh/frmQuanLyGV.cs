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
            this.cbToGV.DataSource = dtToGV;
            this.cbToGV.DisplayMember = "TENTOGV";
            this.cbToGV.ValueMember = "MATOGV";
            this.cbToGV.SelectedIndex = -1;

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
            this.dgvDanhSach.Columns["USERNAME"].HeaderText = "Tài khoản";
            
            this.cbGioiTinh.SelectedIndex = -1; 
        }
        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDanhSach.SelectedRows.Count > 0)
            {
                this.txtMaSo.ReadOnly = true;
                this.txtMaSo.BackColor = Color.LightGray;

                DataGridViewRow row = this.dgvDanhSach.SelectedRows[0];
                this.txtMaSo.Text = row.Cells["MAGV"].Value.ToString();

                this.txtHoTen.Text = row.Cells["HOTEN"].Value.ToString();
                this.txtQueQuan.Text = row.Cells["QUEQUAN"].Value.ToString();
                this.mtxtSoDT.Text = row.Cells["SODT"].Value.ToString();
                this.txtEmail.Text = row.Cells["EMAIL"].Value.ToString();
                this.txtMonGD.Text = row.Cells["MONGD"].Value.ToString();
                this.dtpNgaySinh.Text = row.Cells["NGAYSINH"].Value.ToString();
                if (row.Cells["GIOITINH"].Value.ToString() == "Nam")
                    cbGioiTinh.SelectedIndex = 0;
                else
                    cbGioiTinh.SelectedIndex = 1;

                DataRow[] findrow = dtToGV.Select($"MATOGV = '{row.Cells["MATOGV"].Value.ToString()}'");
                if (findrow.Length > 0)
                    this.cbToGV.SelectedValue = findrow[0]["MATOGV"];

            }
        }
        public void InsertGV()
        {
            GiaoVien gv = new GiaoVien(); 
            gv.MaGV = this.txtMaSo.Text.ToUpper();
            gv.TenGV = this.txtHoTen.Text;
            gv.QueQuan = this.txtQueQuan.Text;
            gv.SoDT = this.mtxtSoDT.Text;
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
            this.mtxtSoDT.Text = string.Empty;
            this.cbToGV.SelectedIndex = -1;
            this.cbGioiTinh.SelectedIndex = -1;
            this.txtEmail.Text = string.Empty;
            this.txtMonGD.Text = string.Empty;        
        }

        public void Update_GV()
        {
            GiaoVien gv = new GiaoVien();
            gv.MaGV = this.txtMaSo.Text;
            gv.TenGV = this.txtHoTen.Text;
            gv.QueQuan = this.txtQueQuan.Text;
            gv.SoDT = this.mtxtSoDT.Text;
            gv.MaToGV = this.cbToGV.SelectedValue?.ToString();
            gv.NgaySinh = this.dtpNgaySinh.Value.ToShortDateString();
            gv.GioiTinh = this.cbGioiTinh.SelectedItem?.ToString();
            gv.Email = this.txtEmail.Text;
            gv.MonGD = this.txtMonGD.Text;
            gv.Taikhoan = gv.MaGV;

            string resultUpadte = giaoVienBLL.Update(gv);
            MessageBox.Show(resultUpadte, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);            
        }
       
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            this.InsertGV();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (this.dgvDanhSach.SelectedRows.Count > 0)
            {
                this.Update_GV();
            }  
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            giaoVienBLL.Cancel();

            this.dgvDanhSach.ClearSelection();
            this.txtMaSo.ReadOnly = false;
            this.txtMaSo.BackColor = Color.White;

            this.txtMaSo.Focus();
            this.txtMaSo.Text = string.Empty;
            this.txtHoTen.Text = string.Empty;
            this.txtQueQuan.Text = string.Empty;
            this.mtxtSoDT.Text = string.Empty;
            this.cbToGV.SelectedIndex = -1;
            this.cbGioiTinh.SelectedIndex = -1;
            this.txtEmail.Text = string.Empty;
            this.txtMonGD.Text = string.Empty;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                giaoVienBLL.Save();
                this.dgvDanhSach.ClearSelection();
                this.txtMaSo.ReadOnly = false;
                this.txtMaSo.BackColor = Color.White;

                this.txtMaSo.Text = string.Empty;
                this.txtHoTen.Text = string.Empty;
                this.txtQueQuan.Text = string.Empty;
                this.mtxtSoDT.Text = string.Empty;
                this.cbToGV.SelectedIndex = -1;
                this.cbGioiTinh.SelectedIndex = -1;
                this.txtEmail.Text = string.Empty;
                this.txtMonGD.Text = string.Empty;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(this.txtTimKiem.Text != "")
            {
                DataRow[] findrow = dtGV.Select($"HOTEN = '{this.txtTimKiem.Text}'");
                if (findrow.Length > 0)
                {
                    this.dgvDanhSach.ClearSelection();
                    this.dgvDanhSach.Rows[dtGV.Rows.IndexOf(findrow[0])].Selected = true;
                    this.dgvDanhSach_CellContentClick(null, null);
                    this.txtTimKiem.Clear();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtTimKiem.Clear();
                }
            }
        }

        private void frmQuanLyGV_Click(object sender, EventArgs e)
        {
            this.dgvDanhSach.ClearSelection();
            this.txtMaSo.ReadOnly = false;
            this.txtMaSo.BackColor = Color.White;
        }
    }
}
