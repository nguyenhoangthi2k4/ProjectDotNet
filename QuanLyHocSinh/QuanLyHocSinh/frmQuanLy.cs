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
        private string _maLop;
        HocSinhBLL hocSinhBLL = new HocSinhBLL();  
        LopHocBLL LopHocBLL = new LopHocBLL();
        DataTable dtHS = new DataTable();

        public string MaLop { get => _maLop; set => _maLop = value; }

        public frmQuanLy(string maLop)
        {
            InitializeComponent();

            MaLop = maLop;

            // Load thông tin học sinh
            dtHS = hocSinhBLL.GetDataByMaLop(MaLop);
            this.dgvDanhSach.DataSource = dtHS;
            this.dgvDanhSach.Columns["MAHS"].HeaderText = "Mã học sinh";
            this.dgvDanhSach.Columns["HOTEN"].HeaderText = "Họ tên";
            this.dgvDanhSach.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
            this.dgvDanhSach.Columns["DIACHI"].HeaderText = "Địa chỉ";
            this.dgvDanhSach.Columns["SODT"].HeaderText = "Số điện thoại";
            this.dgvDanhSach.Columns["GIOITINH"].HeaderText = "Giới tính";
            this.dgvDanhSach.Columns["MALOP"].Visible = false;
            this.dgvDanhSach.Columns["USERNAME"].Visible = false;

            // Get tên lớp
            DataTable lopHoc = LopHocBLL.GetDataByMaLop(MaLop);
            this.lblLop.Text = lopHoc.Rows[0]["TENLOP"].ToString();

            this.txtNamHoc.ReadOnly = true;
            this.txtNamHoc.BackColor = Color.LightGray;
            this.txtNamHoc.Text = lopHoc.Rows[0]["MANH"].ToString();
        }


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
                DataRow[] findRows = dtHS.Select($"HOTEN = '{this.txtTimKiem.Text}'");
                if(findRows.Length > 0)
                {
                    DataRow findRow = findRows[0];
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
