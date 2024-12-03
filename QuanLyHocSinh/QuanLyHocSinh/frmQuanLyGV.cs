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

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
      

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
