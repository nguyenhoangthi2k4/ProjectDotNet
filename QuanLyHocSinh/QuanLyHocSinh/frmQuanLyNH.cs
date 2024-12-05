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
    public partial class frmQuanLyNH : Form
    {
        NamHocBLL namHocBLL = new NamHocBLL();
        //private bool flagNH = false; // Không thay đổi dữ liệu bảng NAMHOC
        //private bool flagLH = false; // Không thay đổi dữ liệu bảng LOPHOC
        public frmQuanLyNH()
        {
            InitializeComponent();
            // Danh sách Năm học           
            this.dgvDanhSachNH.DataSource = namHocBLL.GetData();
            this.dgvDanhSachNH.Columns["MaNH"].HeaderText = "Năm học";
            this.dgvDanhSachNH.Columns["MaHK"].HeaderText = "Học kỳ";
            this.dgvDanhSachNH.ClearSelection();

            // this.cbHocKy
            string[] hk = new string[2] { "1", "2" };
            this.cbHocKy.Items.AddRange(hk);

            this.txtNamHoc.Focus();
            this.cbHocKy.SelectedIndex = -1;
        }

        private void btnThemNH_Click(object sender, EventArgs e)
        {
            NamHoc namHoc = new NamHoc();     
            TaiKhoan taiKhoan = new TaiKhoan();
            
            if (this.txtNamHoc.Text != " " && this.txtNamHoc.Text.Length == 5)
            {
                namHoc.MaNH = this.txtNamHoc.Text.ToUpper();
                namHoc.MaHK = this.cbHocKy.SelectedItem.ToString();
                if (namHocBLL.Insert(namHoc) == 0)
                    MessageBox.Show("Mã năm học và học kỳ đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    int row = namHocBLL.Insert(namHoc);
                    if (row > 0)
                        MessageBox.Show("Nhập thêm thành công", "Thông báo", MessageBoxButtons.OK);                   
                }                   
                this.txtNamHoc.Text = string.Empty;
                this.cbHocKy.SelectedIndex = -1;
                this.txtNamHoc.Focus();
            }                   
            else
                MessageBox.Show("Năm học không để trống hoặc quá 5 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLuuNH_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có muốn lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //flagNH = false;
                namHocBLL.Save();
            }    
        }

        private void dgvDanhSachNH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDanhSachNH.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvDanhSachNH.SelectedRows[0];
                this.txtNamHoc.Text = row.Cells[0].Value.ToString();
                if (row.Cells[1].Value.ToString() == "1")
                    this.cbHocKy.SelectedIndex = 0;
                else
                    this.cbHocKy.SelectedIndex = 1;

            }
        }
    }
}
