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
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        public frmQuanLyGV()
        {
            InitializeComponent();        
            
            // dgvDanhSachToGV
            this.dgvDanhSachToGV.DataSource = toGVBLL.GetData();
            this.dgvDanhSachToGV.Columns["MaToGv"].HeaderText = "Mã tổ";
            this.dgvDanhSachToGV.Columns["TenToGv"].HeaderText = "Tên tổ";
            this.dgvDanhSachToGV.Columns["TruongToGV"].HeaderText = "Trưởng tổ";

            // dgvDanhSach
            this.dgvDanhSach.DataSource = giaoVienBLL.GetData();
            this.dgvDanhSach.Columns["MAGV"].HeaderText = "Mã GV";
            this.dgvDanhSach.Columns["HOTEN"].HeaderText = "Họ tên";
            this.dgvDanhSach.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
            this.dgvDanhSach.Columns["DIACHI"].HeaderText = "Địa chỉ";
            this.dgvDanhSach.Columns["SODT"].HeaderText = "Số ĐT";
            this.dgvDanhSach.Columns["GIOITINH"].HeaderText = "Giới tính";
            this.dgvDanhSach.Columns["MONGD"].HeaderText = "Môn GD";
            this.dgvDanhSach.Columns["MATOGV"].HeaderText = "Mã tổ";
            this.dgvDanhSach.Columns["USERNAME"].HeaderText = "Tên đăng nhập";
            this.dgvDanhSach.Columns["PASSWORD"].HeaderText = "Mật khẩu";
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien();
            TaiKhoan tk = new TaiKhoan();
            if(this.txtMaSo.Text == "" && this.txtMaSo.Text.Length != 5 && this.txtHoTen.Text == "" && this.txtDiaChi.Text == "" && this.txtMonGD.Text == "" && this.txtSoDT.Text == "" && this.txtEmail.Text == "")            
                MessageBox.Show("Dữ liệu không được trống hoặc Mã số không vượt quá 5 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                gv.MaGV = this.txtMaSo.Text.ToUpper();
                gv.TenGV = this.txtHoTen.Text;
                gv.DiaChi = this.txtDiaChi.Text;
                gv.SoDT = this.txtSoDT.Text;
                gv.MaToGV = null;
                gv.NgaySinh = this.dtpNgaySinh.Value.ToShortDateString();
                gv.GioiTinh = this.cbGioiTinh.SelectedItem.ToString();
                gv.Email = this.txtEmail.Text;
                gv.MonGD = this.txtMonGD.Text;
                gv.Taikhoan = this.txtTenDN.Text;
                gv.Matkhau = this.txtMatKhau.Text;

                if (giaoVienBLL.Insert(gv) == 0)
                    MessageBox.Show("Mã Giáo viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    int rowGV = giaoVienBLL.Insert(gv);                   
                }    
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }
      

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            giaoVienBLL.Save();
        }

        private void txtMaSo_TextChanged(object sender, EventArgs e)
        {
            this.txtTenDN.Text = this.txtMaSo.Text.ToUpper();
            this.txtMatKhau.Text = this.txtMaSo.Text;
        }

       
    }
}
