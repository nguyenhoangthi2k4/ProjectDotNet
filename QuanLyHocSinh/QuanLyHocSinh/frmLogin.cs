﻿using System;
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

            this.txtUsername.Text = string.Empty;
            this.txtPassword.Text = string.Empty;
            this.txtUsername.Focus();

            string user = taiKhoanBLL.CheckLogin(taiKhoan);
            if (user == "Lỗi kết nối")
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (user == "Tài khoản không hợp lệ")
            {
                MessageBox.Show("Tài khoản không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] DangNhap = user.Split(' ');
            if (DangNhap[1] == "AD")
            {
                this.Hide();
                frmAdmin frmAdmin = new frmAdmin();
                frmAdmin.ShowDialog();
                this.Show();
            }
            else if (DangNhap[1] == "GV")
            {
                this.Hide();
                frmThongTinGV frmThongTin = new frmThongTinGV(DangNhap[0]);
                frmThongTin.ShowDialog();
                this.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
