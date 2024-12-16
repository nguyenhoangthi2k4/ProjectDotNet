using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmQuanLyToGV : Form
    {
        ToGVBLL toGVBLL = new ToGVBLL();
        GiaoVienBLL giaoVienBLL = new GiaoVienBLL();

        DataTable dtGV = new DataTable();
        public frmQuanLyToGV()
        {
            InitializeComponent();
            // dgvDanhSachToGV
            this.dgvDanhSachToGV.DataSource = toGVBLL.GetData();
            this.dgvDanhSachToGV.Columns["MaToGv"].HeaderText = "Mã tổ";
            this.dgvDanhSachToGV.Columns["TenToGv"].HeaderText = "Tên tổ";
            this.dgvDanhSachToGV.Columns["TruongToGV"].Visible = false;
            this.dgvDanhSachToGV.Columns["HOTEN"].HeaderText = "Tên Trưởng tổ";

            // cbTruongTo            
            dtGV = giaoVienBLL.GetData();
            this.cbTruongTo.DataSource = dtGV;
            this.cbTruongTo.DisplayMember = "HOTEN";
            this.cbTruongTo.ValueMember = "MAGV";
            this.cbTruongTo.SelectedIndex = -1;
        }

        private void dgvDanhSachToGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDanhSachToGV.SelectedRows.Count > 0)
            {
                this.txtMaToGV.ReadOnly = true;
                this.txtMaToGV.BackColor = Color.LightGray;

                DataGridViewRow row = this.dgvDanhSachToGV.SelectedRows[0];
                this.txtMaToGV.Text = row.Cells["MATOGV"].Value.ToString();
                this.txtTenTo.Text = row.Cells["TENTOGV"].Value.ToString();

                DataRow[] findrow = dtGV.Select($"MAGV = '{row.Cells["TRUONGTOGV"].Value.ToString()}'");
                if (findrow.Length > 0)                        
                    this.cbTruongTo.SelectedValue = findrow[0]["MAGV"];                                
            }
        }

        public void InsertToGV()
        {
            ToGV toGV = new ToGV();
            toGV.MaToGV = this.txtMaToGV.Text.ToUpper();
            toGV.TenToGV = this.txtTenTo.Text;
            toGV.TruongToGV = this.cbTruongTo.SelectedValue?.ToString();

            string resultToGV = toGVBLL.Insert(toGV);
            MessageBox.Show(resultToGV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.txtMaToGV.Text = string.Empty;
            this.txtTenTo.Text = string.Empty;
            this.cbTruongTo.SelectedIndex = -1;
        }

        public void Update_ToGV()
        {
            ToGV toGV = new ToGV();
            toGV.MaToGV = this.txtMaToGV.Text;
            toGV.TenToGV = this.txtTenTo.Text;
            toGV.TruongToGV = this.cbTruongTo.SelectedValue?.ToString();

            string resultUpadte = toGVBLL.Update(toGV);
            MessageBox.Show(resultUpadte, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.InsertToGV();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(this.dgvDanhSachToGV.SelectedRows.Count > 0)
            {
                this.Update_ToGV();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            toGVBLL.Cancel();

            this.txtMaToGV.ReadOnly = false;
            this.txtMaToGV.BackColor = Color.White;
            this.dgvDanhSachToGV.ClearSelection();

            this.txtMaToGV.Focus();
            this.txtMaToGV.Text = string.Empty;
            this.txtTenTo.Text = string.Empty;
            this.cbTruongTo.SelectedIndex = -1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn lưu thay đổi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                toGVBLL.Save();

                this.txtMaToGV.ReadOnly = false;
                this.txtMaToGV.BackColor = Color.White;
                this.dgvDanhSachToGV.ClearSelection();

                this.txtMaToGV.Focus();
                this.txtMaToGV.Text = string.Empty;
                this.txtTenTo.Text = string.Empty;
                this.cbTruongTo.SelectedIndex = -1;
            }
        }

        private void frmQuanLyToGV_Click(object sender, EventArgs e)
        {
            this.txtMaToGV.ReadOnly = false;
            this.txtMaToGV.BackColor = Color.White;
            this.dgvDanhSachToGV.ClearSelection();
        }
    }
}
