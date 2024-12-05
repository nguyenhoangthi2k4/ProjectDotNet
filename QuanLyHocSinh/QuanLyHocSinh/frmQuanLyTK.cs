using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL; 

namespace QuanLyHocSinh
{
    public partial class frmQuanLyTK : Form
    {
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        TaiKhoan tk = new TaiKhoan();
        public frmQuanLyTK()
        {
            InitializeComponent();
            
            this.dgvDanhSach.DataSource = taiKhoanBLL.GetData();
            this.dgvDanhSach.Columns["USERNAME"].HeaderText = "Tên Đăng Nhập";
            this.dgvDanhSach.Columns["PASSWORD"].HeaderText = "Mật khẩu";
            this.dgvDanhSach.Columns["QUYEN"].HeaderText = "Quyền";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            taiKhoanBLL.Save();
        }
    }
}
