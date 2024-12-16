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
    public partial class frmQuanLyTN : Form
    {
        ThuNganBLL thuNganBLL = new ThuNganBLL();
        NamHocBLL namHocBLL = new NamHocBLL();
        DataTable dtTN;
        DataTable dtNH;
        public frmQuanLyTN()
        {
            InitializeComponent();
            // Load cbNamHoc
            dtNH = namHocBLL.GetDataMaNH();
            this.cbMaNH.DataSource = dtNH;
            this.cbMaNH.DisplayMember = "MaNH";
            this.cbMaNH.ValueMember = "MaNH";
            this.cbMaNH.SelectedIndex = -1;

            this.cbHocKy.SelectedIndex = -1;

            // Load Data
            dtTN = thuNganBLL.GetData();
            this.dgvDanhSachTN.DataSource = dtTN;
            this.dgvDanhSachTN.Columns["MANH"].HeaderText = "Năm học";
            this.dgvDanhSachTN.Columns["MAHK"].HeaderText = "Học kỳ";
            this.dgvDanhSachTN.Columns["MAHS"].HeaderText = "Mã HS";
            this.dgvDanhSachTN.Columns["HOTEN"].HeaderText = "Họ tên";
            this.dgvDanhSachTN.Columns["SOTIEN_HP"].HeaderText = "Học phí";
            this.dgvDanhSachTN.Columns["TINHTRANG_HP"].HeaderText = "Tình trạng";
            this.dgvDanhSachTN.Columns["NGAYDONG_HP"].HeaderText = "Ngày đóng";
            this.dgvDanhSachTN.Columns["SOTIEN_BHYT"].HeaderText = "BHYT";
            this.dgvDanhSachTN.Columns["TINHTRANG_BHYT"].HeaderText = "Tình trạng";
            this.dgvDanhSachTN.Columns["NGAYDONG_BHYT"].HeaderText = "Ngày đóng";

            this.txtMaSo.Enabled = false;
            this.txtMaSo.BackColor = Color.LightGray;
            this.txtHoTen.Enabled = false;
            this.txtHoTen.BackColor = Color.LightGray;
        }

        private void dgvDanhSachTN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.dgvDanhSachTN.SelectedRows.Count > 0)
            {
                this.txtMaSo.Text = this.dgvDanhSachTN.SelectedRows[0].Cells["MAHS"].Value.ToString();
                this.txtHoTen.Text = this.dgvDanhSachTN.SelectedRows[0].Cells["HOTEN"].Value.ToString();
                this.txtHocPhi.Text = this.dgvDanhSachTN.SelectedRows[0].Cells["SOTIEN_HP"].Value.ToString();
                this.txtBHYT.Text = this.dgvDanhSachTN.SelectedRows[0].Cells["SOTIEN_BHYT"].Value.ToString();
                this.cbTTHP.SelectedItem = this.dgvDanhSachTN.SelectedRows[0].Cells["TINHTRANG_HP"].Value.ToString();
                this.cbTTBHYT.SelectedItem = this.dgvDanhSachTN.SelectedRows[0].Cells["TINHTRANG_BHYT"].Value.ToString();
                this.dtpNgayDongHP.Text = this.dgvDanhSachTN.SelectedRows[0].Cells["NGAYDONG_HP"].Value.ToString();
                this.dtpNgayDongBHYT.Text = this.dgvDanhSachTN.SelectedRows[0].Cells["NGAYDONG_BHYT"].Value.ToString();
            }    
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            if(this.dgvDanhSachTN.SelectedRows.Count > 0)
            {
                ThuNgan tn = new ThuNgan();
                tn.MaNH = this.dgvDanhSachTN.SelectedRows[0].Cells["MANH"].Value.ToString();
                tn.MaHK = this.dgvDanhSachTN.SelectedRows[0].Cells["MAHK"].Value.ToString();
                tn.MaHS = this.txtMaSo.Text;
                tn.TienHP = float.Parse(this.txtHocPhi.Text);
                tn.TinhTrangHP = this.cbTTHP.SelectedItem?.ToString();
                tn.NgayDongHP = this.dtpNgayDongHP.Value.ToShortDateString();
                tn.TienBHYT = float.Parse(this.txtBHYT.Text);
                tn.TinTrangBHYT = this.cbTTBHYT.SelectedItem?.ToString();
                tn.NgayDongBHYT = this.dtpNgayDongBHYT.Value.ToShortDateString();

                string result = thuNganBLL.Update(tn);
                MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh Data
                this.txtMaSo.Text = string.Empty;
                this.txtHoTen.Text = string.Empty;
                this.txtHocPhi.Text = string.Empty;
                this.txtBHYT.Text = string.Empty;
                this.cbTTHP.SelectedIndex = -1;
                this.cbTTBHYT.SelectedIndex = -1;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            thuNganBLL.Cancel();

            this.dgvDanhSachTN.ClearSelection();

            this.txtMaSo.Enabled = true;
            this.txtMaSo.BackColor = Color.White;
            this.txtHoTen.Enabled = true;
            this.txtHoTen.BackColor = Color.White;

            this.txtMaSo.Text = string.Empty;
            this.txtHoTen.Text = string.Empty;
            this.txtHocPhi.Text = string.Empty;
            this.txtBHYT.Text = string.Empty;
            this.cbTTHP.SelectedIndex = -1;
            this.cbTTBHYT.SelectedIndex = -1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                thuNganBLL.Save();

                this.dgvDanhSachTN.ClearSelection();

                this.txtMaSo.Enabled = true;
                this.txtMaSo.BackColor = Color.White;
                this.txtHoTen.Enabled = true;
                this.txtHoTen.BackColor = Color.White;

                this.txtMaSo.Text = string.Empty;
                this.txtHoTen.Text = string.Empty;
                this.txtHocPhi.Text = string.Empty;
                this.txtBHYT.Text = string.Empty;
                this.cbTTHP.SelectedIndex = -1;
                this.cbTTBHYT.SelectedIndex = -1;
            }        
        }

        private void frmQuanLyTN_Click(object sender, EventArgs e)
        {
            this.dgvDanhSachTN.ClearSelection();

            this.txtMaSo.Enabled = true;
            this.txtMaSo.BackColor = Color.White;
            this.txtHoTen.Enabled = true;
            this.txtHoTen.BackColor = Color.White;

            this.txtMaSo.Text = string.Empty;
            this.txtHoTen.Text = string.Empty;
            this.txtHocPhi.Text = string.Empty;
            this.txtBHYT.Text = string.Empty;
            this.cbTTHP.SelectedIndex = -1;
            this.cbTTBHYT.SelectedIndex = -1;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            NamHoc namHoc = new NamHoc();
            namHoc.MaNH = this.cbMaNH.SelectedValue?.ToString();
            namHoc.MaHK = this.cbHocKy.SelectedItem?.ToString();

            if(namHoc.MaNH == null || namHoc.MaHK == null)
            {
                MessageBox.Show("Vui lòng chọn năm học và học kỳ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if(this.dgvDanhSachTN.Rows.Count > 0) 
                {
                    this.dgvDanhSachTN.DataSource = null;
                    this.dgvDanhSachTN.Rows.Clear();
                }

                dtTN = thuNganBLL.GetDataByNamHoc_HocKy(namHoc);
                this.dgvDanhSachTN.DataSource = dtTN;
                this.dgvDanhSachTN.Columns["MANH"].HeaderText = "Năm học";
                this.dgvDanhSachTN.Columns["MAHK"].HeaderText = "Học kỳ";
                this.dgvDanhSachTN.Columns["MAHS"].HeaderText = "Mã HS";
                this.dgvDanhSachTN.Columns["HOTEN"].HeaderText = "Họ tên";
                this.dgvDanhSachTN.Columns["SOTIEN_HP"].HeaderText = "Học phí";
                this.dgvDanhSachTN.Columns["TINHTRANG_HP"].HeaderText = "Tình trạng";
                this.dgvDanhSachTN.Columns["NGAYDONG_HP"].HeaderText = "Ngày đóng";
                this.dgvDanhSachTN.Columns["SOTIEN_BHYT"].HeaderText = "BHYT";
                this.dgvDanhSachTN.Columns["TINHTRANG_BHYT"].HeaderText = "Tình trạng";
                this.dgvDanhSachTN.Columns["NGAYDONG_BHYT"].HeaderText = "Ngày đóng";
            }    
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(this.txtTimKiem.Text != "")
            {
                DataRow dr = dtTN.Select($"HOTEN = '{this.txtTimKiem.Text}'")[0];
                if(dr != null)
                {
                    this.txtTimKiem.Clear();
                    this.dgvDanhSachTN.ClearSelection();
                    this.dgvDanhSachTN_CellContentClick(null, null);
                    this.dgvDanhSachTN.Rows[dtTN.Rows.IndexOf(dr)].Selected = true;
                }    
                else
                {
                    MessageBox.Show("Không tìm thấy học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtTimKiem.Clear();
                }    
            }    
        }
    }
}
