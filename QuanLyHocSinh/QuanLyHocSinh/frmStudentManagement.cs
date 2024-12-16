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
        private string _maLop;

        public string MaLop { get => _maLop; set => _maLop = value; }

        public frmStudentManagement(string maLop)
        {
            InitializeComponent();

            MaLop = maLop;
            this.SwitchFrom(new frmQuanLy(maLop));
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
            this.SwitchFrom(new frmQuanLy(MaLop));
        }

        private void tsMnItemDanhGia_Click(object sender, EventArgs e)
        {
            this.SwitchFrom(new frmDanhGiaHanhKiem(MaLop));
        }

        private void tsMnItemDiemSo_Click(object sender, EventArgs e)
        {
            this.SwitchFrom(new frmDiemSo(MaLop));
        }

        private void tsMnuItemDangXuat_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

