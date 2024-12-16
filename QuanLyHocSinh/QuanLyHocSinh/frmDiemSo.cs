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
    public partial class frmDiemSo : Form
    {
        private string _maLop;
        private LopHoc _lopHoc;
        BangDiemBLL bangDiemBLL = new BangDiemBLL();
        LopHocBLL lopHocBLL = new LopHocBLL();
        DataTable dtBD;

        public string MaLop { get => _maLop; set => _maLop = value; }
        public LopHoc LopHoc { get => _lopHoc; set => _lopHoc = value; }

        public frmDiemSo(string maLop)
        {
            InitializeComponent();
            MaLop = maLop;
            
            // Load Danh sách Điểm học sinh theo lớp
            // Get thông tin lớp học
            DataRow rowLH = lopHocBLL.GetDataByMaLop(MaLop).Rows[0];
            this.LopHoc = new LopHoc();
            this.LopHoc.MaLop = rowLH["MALOP"].ToString();
            this.LopHoc.MaNH = rowLH["MANH"].ToString();

            // Load thông tin bảng điểm
            dtBD = bangDiemBLL.GetDataByMaLop(this.LopHoc);
            this.dgvDanhSach.DataSource = dtBD;
            this.dgvDanhSach.Columns["MAHS"].HeaderText = "Mã số";
            this.dgvDanhSach.Columns["HOTEN"].HeaderText = "Họ tên";
            this.dgvDanhSach.Columns["HOTEN"].Width = 200;
            this.dgvDanhSach.Columns["MAHK"].HeaderText = "Học kỳ";
            this.dgvDanhSach.Columns["TOAN"].HeaderText = "Toán";
            this.dgvDanhSach.Columns["NGUVAN"].HeaderText = "Ngữ văn";
            this.dgvDanhSach.Columns["NGOAINGU"].HeaderText = "Ngoại ngữ";
            this.dgvDanhSach.Columns["VATLY"].HeaderText = "Vật lý";
            this.dgvDanhSach.Columns["HOAHOC"].HeaderText = "Hóa học";
            this.dgvDanhSach.Columns["SINHHOC"].HeaderText = "Sinh học";
            this.dgvDanhSach.Columns["DIALY"].HeaderText = "Địa lý";
            this.dgvDanhSach.Columns["LICHSU"].HeaderText = "Lịch sử";
            this.dgvDanhSach.Columns["GDCD"].HeaderText = "GDCD";
            this.dgvDanhSach.Columns["DTB"].HeaderText = "ĐTB";

            this.txtDTB.Enabled = false;
            this.txtDTB.BackColor = Color.LightGray;

            this.txtHoTen.Enabled = false;
            this.txtHoTen.BackColor = Color.LightGray;

            this.dgvDanhSach.ClearSelection();
            this.cbHocKy.SelectedIndex = 0;
        }

       

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDanhSach.SelectedRows.Count > 0)
            {
                this.txtToan.Focus();
                this.cbHocKy.SelectedItem = this.dgvDanhSach.SelectedRows[0].Cells["MAHK"].Value.ToString();
                this.txtHoTen.Text = this.dgvDanhSach.SelectedRows[0].Cells["HOTEN"].Value.ToString();
                this.txtToan.Text = this.dgvDanhSach.SelectedRows[0].Cells["TOAN"].Value.ToString();
                this.txtVan.Text = this.dgvDanhSach.SelectedRows[0].Cells["NGUVAN"].Value.ToString();
                this.txtNgNgu.Text = this.dgvDanhSach.SelectedRows[0].Cells["NGOAINGU"].Value.ToString();
                this.txtLy.Text = this.dgvDanhSach.SelectedRows[0].Cells["VATLY"].Value.ToString();
                this.txtHoa.Text = this.dgvDanhSach.SelectedRows[0].Cells["HOAHOC"].Value.ToString();
                this.txtSinh.Text = this.dgvDanhSach.SelectedRows[0].Cells["SINHHOC"].Value.ToString();
                this.txtSu.Text = this.dgvDanhSach.SelectedRows[0].Cells["LICHSU"].Value.ToString();
                this.txtDia.Text = this.dgvDanhSach.SelectedRows[0].Cells["DIALY"].Value.ToString();
                this.txtGDCD.Text = this.dgvDanhSach.SelectedRows[0].Cells["GDCD"].Value.ToString();
                this.txtDTB.Text = this.dgvDanhSach.SelectedRows[0].Cells["DTB"].Value.ToString();
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

                dtBD = bangDiemBLL.GetDataByMaLop(this.LopHoc, this.cbHocKy.SelectedItem.ToString());
                this.dgvDanhSach.DataSource = dtBD;
                this.dgvDanhSach.Columns["MAHS"].HeaderText = "Mã số";
                this.dgvDanhSach.Columns["HOTEN"].HeaderText = "Họ tên";
                this.dgvDanhSach.Columns["HOTEN"].Width = 200;
                this.dgvDanhSach.Columns["MAHK"].HeaderText = "Học kỳ";
                this.dgvDanhSach.Columns["TOAN"].HeaderText = "Toán";
                this.dgvDanhSach.Columns["NGUVAN"].HeaderText = "Ngữ văn";
                this.dgvDanhSach.Columns["NGOAINGU"].HeaderText = "Ngoại ngữ";
                this.dgvDanhSach.Columns["VATLY"].HeaderText = "Vật lý";
                this.dgvDanhSach.Columns["HOAHOC"].HeaderText = "Hóa học";
                this.dgvDanhSach.Columns["SINHHOC"].HeaderText = "Sinh học";
                this.dgvDanhSach.Columns["DIALY"].HeaderText = "Địa lý";
                this.dgvDanhSach.Columns["LICHSU"].HeaderText = "Lịch sử";
                this.dgvDanhSach.Columns["GDCD"].HeaderText = "GDCD";
                this.dgvDanhSach.Columns["DTB"].HeaderText = "ĐTB";
            }
        }

        private void frmDiemSo_Click(object sender, EventArgs e)
        {
            if (this.dgvDanhSach.SelectedRows.Count > 0)
            {
                this.dgvDanhSach.ClearSelection();
                this.txtHoTen.Clear();
                this.txtToan.Clear();
                this.txtVan.Clear();
                this.txtNgNgu.Clear();
                this.txtLy.Clear();
                this.txtHoa.Clear();
                this.txtSinh.Clear();
                this.txtSu.Clear();
                this.txtDia.Clear();
                this.txtGDCD.Clear();
                this.txtDTB.Clear();
            }    
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            BangDiem bangDiem = new BangDiem();
            bangDiem.MaNH = this.LopHoc.MaNH;
            bangDiem.MaHK = this.cbHocKy.SelectedItem?.ToString();
            bangDiem.MaHS = this.dgvDanhSach.SelectedRows[0].Cells["MAHS"].Value.ToString();
            bangDiem.Toan = this.txtToan.Text;
            bangDiem.NgVan = this.txtVan.Text;
            bangDiem.NgNgu = this.txtNgNgu.Text;
            bangDiem.VatLy = this.txtLy.Text;
            bangDiem.HoaHoc = this.txtHoa.Text;
            bangDiem.SinhHoc = this.txtSinh.Text;
            bangDiem.DiaLy = this.txtDia.Text;
            bangDiem.LichSu = this.txtSu.Text;
            bangDiem.Gdcd = this.txtGDCD.Text;

            string result = bangDiemBLL.Update(bangDiem);
            MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.txtHoTen.Clear();
            this.txtToan.Clear();
            this.txtVan.Clear();
            this.txtNgNgu.Clear();
            this.txtLy.Clear();
            this.txtHoa.Clear();
            this.txtSinh.Clear();
            this.txtSu.Clear();
            this.txtDia.Clear();
            this.txtGDCD.Clear();
            this.txtDTB.Clear();
            this.dgvDanhSach.ClearSelection();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            bangDiemBLL.Cancel();

            this.cbHocKy.SelectedIndex = 0;
            this.txtHoTen.Clear();
            this.txtToan.Clear();
            this.txtVan.Clear();
            this.txtNgNgu.Clear();
            this.txtLy.Clear();
            this.txtHoa.Clear();
            this.txtSinh.Clear();
            this.txtSu.Clear();
            this.txtDia.Clear();
            this.txtGDCD.Clear();
            this.txtDTB.Clear();
            this.dgvDanhSach.ClearSelection();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                bangDiemBLL.Save();
                this.cbHocKy.SelectedIndex = 0;
                this.txtHoTen.Clear();
                this.txtToan.Clear();
                this.txtVan.Clear();
                this.txtNgNgu.Clear();
                this.txtLy.Clear();
                this.txtHoa.Clear();
                this.txtSinh.Clear();
                this.txtSu.Clear();
                this.txtDia.Clear();
                this.txtGDCD.Clear();
                this.txtDTB.Clear();
                this.dgvDanhSach.ClearSelection();
            }    
        }
    }
}
