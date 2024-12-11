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
        DataTable dtTK = new DataTable();

        public frmQuanLyTK()
        {
            InitializeComponent();
            
            dtTK = taiKhoanBLL.GetData();
            this.dgvDanhSach.DataSource = dtTK;
            this.dgvDanhSach.Columns["USERNAME"].HeaderText = "Tên Đăng Nhập";
            this.dgvDanhSach.Columns["PASSWORD"].HeaderText = "Mật khẩu";
            this.dgvDanhSach.Columns["QUYEN"].HeaderText = "Quyền";

            this.txtTenDN.Enabled = false;
            this.txtTenDN.BackColor = Color.LightGray;
        }

        private void frmQuanLyTK_Click(object sender, EventArgs e)
        {
            this.cbQuyen.Enabled = true;            
            this.dgvDanhSach.ClearSelection();
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDanhSach.SelectedRows.Count > 0)
            {
                this.cbQuyen.Enabled = false;

                this.txtTenDN.Text = this.dgvDanhSach.SelectedRows[0].Cells["USERNAME"].Value.ToString();
                this.txtMatKhau.Text = this.dgvDanhSach.SelectedRows[0].Cells["PASSWORD"].Value.ToString();
                this.cbQuyen.SelectedItem = this.dgvDanhSach.SelectedRows[0].Cells["QUYEN"].Value.ToString();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            taiKhoanBLL.Destroy();

            this.dgvDanhSach.ClearSelection();

            this.txtTenDN.Text = string.Empty;
            this.txtMatKhau.Text = string.Empty;
            this.cbQuyen.SelectedIndex = -1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.Taikhoan = this.txtTenDN.Text;
            tk.Matkhau = this.txtMatKhau.Text.ToLower();
            tk.Quyen = this.cbQuyen.SelectedItem.ToString();

            string result = taiKhoanBLL.Update(tk);
            MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có muốn lưu thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                taiKhoanBLL.Save();
                this.dgvDanhSach.ClearSelection();

                this.txtTenDN.Text = string.Empty;
                this.txtMatKhau.Text = string.Empty;
                this.cbQuyen.SelectedIndex = -1;
            }                
        }
    }
}
