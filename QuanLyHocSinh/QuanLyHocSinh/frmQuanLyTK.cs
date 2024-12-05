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
        public frmQuanLyTK()
        {
            InitializeComponent();
            this.dgvDanhSach.DataSource = taiKhoanBLL.GetData();
            this.dgvDanhSach.Columns[0].HeaderText = "Tên Đăng Nhập";
            this.dgvDanhSach.Columns[1].HeaderText = "Mật khẩu";
            this.dgvDanhSach.Columns[2].HeaderText = "Quyền";
        }

        
    }
}
