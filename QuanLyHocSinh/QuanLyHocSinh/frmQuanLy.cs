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
namespace QuanLyHocSinh
{
    public partial class frmQuanLy : Form
    {
        private string _maGV;
        LopHocBLL lopHocBLL = new LopHocBLL();
        HocSinhBLL hocSinhBLL = new HocSinhBLL();
        DataTable dtLH;
        DataTable dtHS;

        public frmQuanLy(string maGV)
        {
            InitializeComponent();

            MaGV = maGV;
            dtLH = lopHocBLL.GetData();
            string maLop = dtLH.Select($"GVCN = '{maGV}' AND MANH = 'N2021' AND MAHK = '1'")[0]["MALOP"].ToString();
            dtHS = hocSinhBLL.GetDataByMaLop(maLop);

            this.dgvDanhSach.DataSource = dtHS;
            this.dgvDanhSach.Columns["MAHS"].HeaderText = "Mã học sinh";
            this.dgvDanhSach.Columns["HOTEN"].HeaderText = "Họ tên";
            this.dgvDanhSach.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
            this.dgvDanhSach.Columns["DIACHI"].HeaderText = "Địa chỉ";
            this.dgvDanhSach.Columns["SODT"].HeaderText = "Số điện thoại";
            this.dgvDanhSach.Columns["MAPH"].Visible = false;
            this.dgvDanhSach.Columns["GIOITINH"].HeaderText = "Giới tính";
            this.dgvDanhSach.Columns["MALOP"].Visible = false;
            this.dgvDanhSach.Columns["USERNAME"].Visible = false;

            this.txtNamHoc.Text =dtLH.Select($"GVCN = '{maGV}' AND MANH = 'N2021' AND MAHK = '1'")[0]["MANH"].ToString();
            this.lblLop.Text = dtLH.Select($"GVCN = '{maGV}' AND MANH = 'N2021' AND MAHK = '1'")[0]["TENLOP"].ToString();
        }

        public string MaGV { get => _maGV; set => _maGV = value; }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.dgvDanhSach.SelectedRows.Count > 0)
            {
                this.txtMaso.Text = this.dgvDanhSach.SelectedRows[0].Cells["MAHS"].Value.ToString();
                this.txtHoTen.Text = this.dgvDanhSach.SelectedRows[0].Cells["HOTEN"].Value.ToString();
                this.dtpNgaySinh.Text = this.dgvDanhSach.SelectedRows[0].Cells["NGAYSINH"].Value.ToString();
                this.txtDiaChi.Text = this.dgvDanhSach.SelectedRows[0].Cells["DIACHI"].Value.ToString();
                this.txtSoDT.Text = this.dgvDanhSach.SelectedRows[0].Cells["SODT"].Value.ToString();
                this.cbGioiTinh.Text = this.dgvDanhSach.SelectedRows[0].Cells["GIOITINH"].Value.ToString();                
            }    
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(this.txtTimKiem.Text != "")
            {
                DataRow findRow = dtHS.Select($"HOTEN = '{this.txtTimKiem.Text}'")[0];
                if(findRow != null)
                {
                    this.dgvDanhSach.Rows[dtHS.Rows.IndexOf(findRow)].Selected = true;
                    this.dgvDanhSach_CellContentClick(null, null);
                    this.dgvDanhSach.ClearSelection();
                    this.txtTimKiem.Clear();
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
