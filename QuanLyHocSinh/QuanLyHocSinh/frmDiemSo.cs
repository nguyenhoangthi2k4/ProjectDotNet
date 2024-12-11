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
        BangDiemBLL bangDiemBLL = new BangDiemBLL();
        LopHocBLL lopHocBLL = new LopHocBLL();
        DataTable dt;

        public frmDiemSo(string maGV)
        {
            InitializeComponent();
            DataTable dtLH = lopHocBLL.GetData();
            string maLop = dtLH.Select($"GVCN = '{maGV}' AND MANH = 'N2021' AND MAHK = '1'")[0]["MALOP"].ToString();

            dt = bangDiemBLL.GetDataByMaLop(maLop);
            this.dgvDanhSach.DataSource = dt;
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.dgvDanhSach.SelectedRows.Count > 0)
            {
                this.txtToan.Text = this.dgvDanhSach.SelectedRows[0].Cells["TOAN"].Value.ToString();
                this.txtVan.Text = this.dgvDanhSach.SelectedRows[0].Cells["NGUVAN"].Value.ToString();
                this.txtNgNgu.Text = this.dgvDanhSach.SelectedRows[0].Cells["NGOAINGU"].Value.ToString();
                this.txtLy.Text = this.dgvDanhSach.SelectedRows[0].Cells["VATLY"].Value.ToString();
                this.txtHoa.Text = this.dgvDanhSach.SelectedRows[0].Cells["HOAHOC"].Value.ToString();
                this.txtSinh.Text = this.dgvDanhSach.SelectedRows[0].Cells["SINHHOC"].Value.ToString();
                this.txtSu.Text = this.dgvDanhSach.SelectedRows[0].Cells["LICHSU"].Value.ToString();
                this.txtDia.Text = this.dgvDanhSach.SelectedRows[0].Cells["DIALY"].Value.ToString();
                this.txtGDCD.Text = this.dgvDanhSach.SelectedRows[0].Cells["GDCD"].Value.ToString();
            }    
        }
    }
}
