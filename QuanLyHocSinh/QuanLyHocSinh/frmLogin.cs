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
    public partial class frmLogin : Form
    {
        TaiKhoan taiKhoan = new TaiKhoan();
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        public frmLogin()
        {
            InitializeComponent();
            this.txtUsername.Text = "admin";
            this.txtPassword.Text = "admin";
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Bạn muốn thoát hệ thống", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                e.Cancel = false;
            else
                e.Cancel = true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            taiKhoan.Taikhoan = this.txtUsername.Text;
            taiKhoan.Matkhau = this.txtPassword.Text;
            string[] DangNhap = taiKhoanBLL.Login(taiKhoan);
            
            if (DangNhap[0] != "Tài khoản không hợp lệ")
            {
                if (taiKhoanBLL.Login(taiKhoan)[1] == "AD")
                {
                    this.Hide();
                    frmAdmin frmAdmin = new frmAdmin();
                    frmAdmin.ShowDialog();
                    this.Show();
                }
                else if(DangNhap[1] == "GV")
                {
                    this.Hide();
                    frmStudentManagement frmStudentManagement = new frmStudentManagement();
                    frmStudentManagement.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hợp lệ!" );
                }                        
            }
            else
                MessageBox.Show("Tài khoản không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.txtUsername.Text = string.Empty;            
            this.txtPassword.Text = string.Empty;
            this.txtUsername.Focus();
        }       
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
