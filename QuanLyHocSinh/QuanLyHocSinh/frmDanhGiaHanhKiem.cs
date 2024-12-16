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
    public partial class frmDanhGiaHanhKiem : Form
    {
        private string _maLop;
        private LopHoc _lopHoc;
        HanhKiemBLL hanhKiemBLL = new HanhKiemBLL();
        LopHocBLL lopHocBLL = new LopHocBLL();
        DataTable dtHK;

        public string MaLop { get => _maLop; set => _maLop = value; }

        public LopHoc LopHoc { get => _lopHoc; set => _lopHoc = value; }

        public frmDanhGiaHanhKiem(string maLop)
        {
            InitializeComponent();
            this.TopLevel = false;

            this.MaLop = maLop;
            // Load Danh sách Điểm học sinh theo lớp
            // Get thông tin lớp học
            DataRow rowLH = lopHocBLL.GetDataByMaLop(MaLop).Rows[0];
            this.LopHoc = new LopHoc();
            this.LopHoc.MaLop = rowLH["MALOP"].ToString();
            this.LopHoc.MaNH = rowLH["MANH"].ToString();

            // Load data Hạnh kiểm
            dtHK = hanhKiemBLL.GetDataByMaLop(this.LopHoc);
            this.dgvDanhSach.DataSource = dtHK;
            this.dgvDanhSach.Columns["MAHK"].HeaderText = "Học kỳ";
            this.dgvDanhSach.Columns["MAHS"].HeaderText = "Mã số";
            this.dgvDanhSach.Columns["HOTEN"].HeaderText = "Họ tên";
            this.dgvDanhSach.Columns["LOAIHK"].HeaderText = "Loại hạnh kiểm";

            this.txtHoTen.Enabled = true;
            this.txtHoTen.BackColor = Color.LightGray;

            this.cbHocKy.SelectedIndex = 0;
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDanhSach.SelectedRows.Count > 0)
            {
                this.cbHocKy.SelectedItem = this.dgvDanhSach.SelectedRows[0].Cells["MAHK"].Value.ToString();
                this.txtHoTen.Text = this.dgvDanhSach.SelectedRows[0].Cells["HOTEN"].Value.ToString();
                this.cbLoaiHK.SelectedItem = this.dgvDanhSach.SelectedRows[0].Cells["LOAIHK"].Value.ToString();
            } 
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if(this.cbHocKy.SelectedIndex != -1)
            {
                if(this.dgvDanhSach.Rows.Count > 0)
                {
                    this.dgvDanhSach.DataSource = null;
                    this.dgvDanhSach.Rows.Clear();
                }

                dtHK = hanhKiemBLL.GetDataByMaLop(this.LopHoc, this.cbHocKy.SelectedItem.ToString());
                this.dgvDanhSach.DataSource = dtHK;
                this.dgvDanhSach.Columns["MAHK"].HeaderText = "Học kỳ";
                this.dgvDanhSach.Columns["MAHS"].HeaderText = "Mã số";
                this.dgvDanhSach.Columns["HOTEN"].HeaderText = "Họ tên";
                this.dgvDanhSach.Columns["LOAIHK"].HeaderText = "Loại hạnh kiểm";

                this.txtHoTen.Clear();
                this.cbLoaiHK.SelectedIndex = -1;
            }    
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            HanhKiem hk = new HanhKiem();
            hk.MaNH = this.LopHoc.MaNH;
            hk.MaHK = this.cbHocKy.SelectedItem?.ToString();
            hk.MaHS = this.dgvDanhSach.SelectedRows[0].Cells["MAHS"].Value.ToString();
            hk.LoaiHK = this.cbLoaiHK.SelectedItem?.ToString();

            string result = hanhKiemBLL.Update(hk);
            MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.txtHoTen.Clear();
            this.cbLoaiHK.SelectedIndex = -1;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            hanhKiemBLL.Cancel();

            this.dgvDanhSach.ClearSelection();
            this.cbHocKy.SelectedIndex = 0;
            this.txtHoTen.Text = "";
            this.cbLoaiHK.SelectedIndex = -1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                hanhKiemBLL.Save();

                this.dgvDanhSach.ClearSelection();
                this.cbHocKy.SelectedIndex = 0;
                this.txtHoTen.Text = "";
                this.cbLoaiHK.SelectedIndex = -1;
            }
        }

        private void frmDanhGiaHanhKiem_Click(object sender, EventArgs e)
        {
            if(this.dgvDanhSach.SelectedRows.Count > 0)
                this.dgvDanhSach.ClearSelection();

            this.cbHocKy.SelectedIndex = 0;
            this.txtHoTen.Text = "";
            this.cbLoaiHK.SelectedIndex = -1;
        }
    }
}
