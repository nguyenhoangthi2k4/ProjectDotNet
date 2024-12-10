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
    public partial class frmQuanLyHS : Form
    {
        HocSinhBLL hocSinhBLL = new HocSinhBLL();  
        LopHocBLL lopHocBLL = new LopHocBLL();
        DataTable dtHS = new DataTable();
        DataTable dtLH = new DataTable();
        public frmQuanLyHS()
        {
            InitializeComponent();

            // Load data
            dtHS = hocSinhBLL.GetData();
            this.dgvDanhSach.DataSource = dtHS;
            this.dgvDanhSach.Columns["MAHS"].HeaderText = "Mã học sinh";
            this.dgvDanhSach.Columns["HOTEN"].HeaderText = "Họ tên";
            this.dgvDanhSach.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
            this.dgvDanhSach.Columns["DIACHI"].HeaderText = "Địa chỉ";
            this.dgvDanhSach.Columns["SODT"].HeaderText = "Số điện thoại";
            this.dgvDanhSach.Columns["MAPH"].Visible = false;
            this.dgvDanhSach.Columns["GIOITINH"].HeaderText = "Giới tính";
            this.dgvDanhSach.Columns["MALOP"].HeaderText = "Mã lớp";
            this.dgvDanhSach.Columns["USERNAME"].HeaderText = "Tài khoản";

            // Set up combobox
            dtLH = lopHocBLL.GetData();
            dtLH.Columns.Add("MALOP_MANH", typeof(string), "TENLOP + ' - ' + MANH");
            this.cbMaLop.DataSource = dtLH;
            this.cbMaLop.DisplayMember = "MALOP_MANH"; // "TENLOP
            this.cbMaLop.ValueMember = "MALOP";
            this.cbMaLop.SelectedIndex = -1;

            this.cbGioiTinh.SelectedIndex = -1;
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.dgvDanhSach.SelectedRows.Count>0)
            {
                this.txtMaSo.ReadOnly = true;
                this.txtMaSo.BackColor = Color.LightGray;

                this.txtMaSo.Text = this.dgvDanhSach.SelectedRows[0].Cells["MAHS"].Value.ToString();
                this.txtHoTen.Text = this.dgvDanhSach.SelectedRows[0].Cells["HOTEN"].Value.ToString();
                this.dtpNgaySinh.Text = this.dgvDanhSach.SelectedRows[0].Cells["NGAYSINH"].Value.ToString();
                this.txtDiaChi.Text = this.dgvDanhSach.SelectedRows[0].Cells["DIACHI"].Value.ToString();
                this.mtxtSoDT.Text = this.dgvDanhSach.SelectedRows[0].Cells["SODT"].Value.ToString();
                this.cbMaLop.SelectedValue = this.dgvDanhSach.SelectedRows[0].Cells["MALOP"].Value.ToString();
                this.cbGioiTinh.SelectedItem = this.dgvDanhSach.SelectedRows[0].Cells["GIOITINH"].Value.ToString();
            }    
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh();
            hs.MaHS = this.txtMaSo.Text.ToUpper();
            hs.HoTen = this.txtHoTen.Text;
            hs.DiaChi = this.txtDiaChi.Text;
            hs.SoDT = this.mtxtSoDT.Text;
            hs.NgaySinh = this.dtpNgaySinh.Value.ToShortDateString();
            hs.MaLop = this.cbMaLop.SelectedValue?.ToString();
            hs.GioiTinh = this.cbGioiTinh.SelectedItem?.ToString();
            hs.Taikhoan = this.txtMaSo.Text.ToUpper();
            hs.MaPH = null;
            hs.Matkhau = this.txtMaSo.Text.ToLower();

            string result = hocSinhBLL.Insert(hs);
            MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.txtMaSo.Focus();
            this.txtMaSo.Text = string.Empty;
            this.txtHoTen.Text = string.Empty;
            this.txtDiaChi.Text = string.Empty;
            this.mtxtSoDT.Text = string.Empty;
            this.cbMaLop.SelectedIndex = -1;
            this.cbGioiTinh.SelectedIndex = -1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(this.dgvDanhSach.SelectedRows.Count >0)
            {
                HocSinh hs = new HocSinh();
                hs.MaHS = this.txtMaSo.Text.ToUpper();
                hs.HoTen = this.txtHoTen.Text;
                hs.DiaChi = this.txtDiaChi.Text;
                hs.SoDT = this.mtxtSoDT.Text;
                hs.NgaySinh = this.dtpNgaySinh.Value.ToShortDateString();
                hs.MaLop = this.cbMaLop.SelectedValue?.ToString();
                hs.GioiTinh = this.cbGioiTinh.SelectedItem?.ToString();
                hs.Taikhoan = this.txtMaSo.Text.ToUpper();               
                hs.Matkhau = this.txtMaSo.Text.ToLower();

                string result = hocSinhBLL.Update(hs);
                MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            hocSinhBLL.Destroy();

            this.txtMaSo.Focus();
            this.txtMaSo.ReadOnly = false;
            this.txtMaSo.BackColor = Color.White;
            this.dgvDanhSach.ClearSelection();

            this.txtMaSo.Text = string.Empty;
            this.txtHoTen.Text = string.Empty;
            this.txtDiaChi.Text = string.Empty;
            this.mtxtSoDT.Text = string.Empty;
            this.cbMaLop.SelectedIndex = -1;
            this.cbGioiTinh.SelectedIndex = -1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.txtMaSo.Focus();
                this.txtMaSo.ReadOnly = false;
                this.txtMaSo.BackColor = Color.White;
                this.dgvDanhSach.ClearSelection();

                hocSinhBLL.Save();

                this.txtMaSo.Text = string.Empty;
                this.txtHoTen.Text = string.Empty;
                this.txtDiaChi.Text = string.Empty;
                this.mtxtSoDT.Text = string.Empty;
                this.cbMaLop.SelectedIndex = -1;
                this.cbGioiTinh.SelectedIndex = -1;
            }                
        }

        private void frmQuanLyHS_Click(object sender, EventArgs e)
        {
            this.txtMaSo.ReadOnly = false;
            this.txtMaSo.BackColor = Color.White;
            this.dgvDanhSach.ClearSelection();
        }
    }
}
