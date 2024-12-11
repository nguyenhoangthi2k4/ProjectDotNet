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
    public partial class frmStudentManagement : Form
    {
        private Form _currentForm = null;
        private string _maGV;
        public string MaGV { get => _maGV; set => _maGV = value; }

        public frmStudentManagement(string maGV)
        {
            InitializeComponent();

            MaGV = maGV;
            this.SwitchFrom(new frmQuanLy(MaGV));
        }

        public void SwitchFrom(Form childForm)
        {
            if (this._currentForm != null)
                this._currentForm.Close();

            // Đặt thuộc tính cho childForm
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;

            // Thêm childForm vào pnContainer
            pnContainer.Controls.Clear();
            pnContainer.Controls.Add(childForm);
            
            childForm.Show();
            this._currentForm = childForm;
        }

        private void tsMmnItemDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void tsMnItemDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsMnItemQuanLy_Click(object sender, EventArgs e)
        {
            this.SwitchFrom(new frmQuanLy(MaGV));
        }

        private void tsMnItemDanhGia_Click(object sender, EventArgs e)
        {
            this.SwitchFrom(new frmDanhGiaHanhKiem());
        }

        private void tsMnItemThuNgan_Click(object sender, EventArgs e)
        {
            this.SwitchFrom(new frmQuanLyTN());
        }

        private void tsMnuItemPhuHuynh_Click(object sender, EventArgs e)
        {
            this.SwitchFrom(new frmPhuHuynh());
        }

        private void tsMuItemTTCN_Click(object sender, EventArgs e)
        {
            this.SwitchFrom(new frmThongTinCaNhanGV(this));
        }

        private void tsMnItemDiemSo_Click(object sender, EventArgs e)
        {
            this.SwitchFrom(new frmDiemSo(MaGV));
        }
    }
}
