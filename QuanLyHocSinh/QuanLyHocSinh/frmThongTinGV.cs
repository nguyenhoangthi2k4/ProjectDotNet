using BLL;
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
    public partial class frmThongTinGV : Form
    {
        private string _maGV, _maLop;
        GiaoVienBLL giaoVienBLL = new GiaoVienBLL();
        LopHocBLL lopHocBLL = new LopHocBLL();
        DataTable dtGV = new DataTable();
        DataTable dtLH = new DataTable();

        public string MaGV { get => _maGV; set => _maGV = value; }
        public string MaLop { get => _maLop; set => _maLop = value; }

        public frmThongTinGV(string MaGV)
        {
            InitializeComponent();
            this.MaGV = MaGV;

            // Load thông tin giáo viên
            dtGV = giaoVienBLL.GetData(MaGV);
            this.txtHoTen.Text = dtGV.Rows[0]["HOTEN"].ToString();
            this.txtQueQuan.Text = dtGV.Rows[0]["QUEQUAN"].ToString();
            this.txtSoDT.Text = dtGV.Rows[0]["SODT"].ToString();
            this.txtEmail.Text = dtGV.Rows[0]["EMAIL"].ToString();
            this.dtpNamSinh.Text = dtGV.Rows[0]["NGAYSINH"].ToString();

            // Load thông tin lớp học
            dtLH = lopHocBLL.GetDataByGVCV(MaGV);
            dtLH.Columns.Add("TenLop_NamHoc", typeof(string), "TENLOP + ' - ' + MANH");
            this.cbMaLop.DataSource = dtLH;
            this.cbMaLop.DisplayMember = "TenLop_NamHoc";
            this.cbMaLop.ValueMember = "MALOP";
        }

        private async void btnQuanLy_Click(object sender, EventArgs e)
        {
            for(int i=0; i<=150; i++)
            {
                pbLoading.Value = i;
                await Task.Delay(50);
            } 
                
            MaLop = this.cbMaLop.SelectedValue?.ToString();
            if (MaLop == null)
            {
                MessageBox.Show("Giáo viên này chưa quản lý lớp");
                return;
            }   

            this.Hide();
            frmStudentManagement frm = new frmStudentManagement(MaLop);
            frm.ShowDialog();
            pbLoading.Value = 0;
            this.Show();
        }
    }
}
