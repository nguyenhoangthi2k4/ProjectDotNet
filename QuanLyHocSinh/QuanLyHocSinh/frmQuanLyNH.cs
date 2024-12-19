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
        LopHocBLL lopHocBLL = new LopHocBLL();      
        public frmQuanLyNH()
        {
            InitializeComponent();
            // this.cbHocKy
            string[] hk = new string[2] { "1", "2" };
            this.cbHocKy.Items.AddRange(hk);

            // Danh sách Năm học
            DataTable dtNH = namHocBLL.GetData();
            this.dgvDanhSachNH.DataSource = dtNH;
            this.dgvDanhSachNH.Columns["MaNH"].HeaderText = "Năm học";
            this.dgvDanhSachNH.Columns["MaHK"].HeaderText = "Học kỳ";
          
            this.txtNamHoc.Focus();
            this.cbHocKy.SelectedIndex = -1;
        }       
        
        public void InsertNH()
        {
            NamHoc namHoc = new NamHoc();
            namHoc.MaNH = this.txtNamHoc.Text.ToUpper();
            namHoc.MaHK = this.cbHocKy.SelectedItem?.ToString();

            string resultNH = namHocBLL.Insert(namHoc);
            MessageBox.Show(resultNH, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.txtNamHoc.Text = string.Empty;
            this.cbHocKy.SelectedIndex = -1;           
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            this.InsertNH();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                namHocBLL.Save();
                this.dgvDanhSachNH.ClearSelection();
            }
        }

        private void dgvDanhSachNH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDanhSachNH.SelectedRows.Count > 0)
            {
                this.txtNamHoc.ReadOnly = true;
                this.txtNamHoc.BackColor = Color.LightGray;

                DataGridViewRow row = this.dgvDanhSachNH.SelectedRows[0];
                this.txtNamHoc.Text = row.Cells[0].Value.ToString();
                if (row.Cells[1].Value.ToString() == "1")
                    this.cbHocKy.SelectedIndex = 0;
                else
                    this.cbHocKy.SelectedIndex = 1;
            }
        }

        private void frmQuanLyNH_Click(object sender, EventArgs e)
        {
            this.txtNamHoc.ReadOnly = false;
            this.dgvDanhSachNH.ClearSelection();
            this.txtNamHoc.BackColor = Color.White;
        }
    }
}
