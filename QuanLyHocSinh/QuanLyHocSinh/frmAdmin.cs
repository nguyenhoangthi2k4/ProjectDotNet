using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyHocSinh
{
    public partial class frmAdmin : Form
    {
        private Form _currentForm = null;
        public frmAdmin()
        {
            InitializeComponent();
            this.SwitchFrom(new frmQuanLyNH());
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

        private void tsMnuItemDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsMnuItemDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsMnuItemQLHS_Click(object sender, EventArgs e)
        {
            this.SwitchFrom(new frmQuanLyHS());
        }

        private void tsMnuItemQLGV_Click(object sender, EventArgs e)
        {
            this.SwitchFrom(new frmQuanLyGV());
        }

        private void stMnuItemQLNH_Click(object sender, EventArgs e)
        {
            this.SwitchFrom(new frmQuanLyNH());
        }

        private void tsMnuItemQLTK_Click(object sender, EventArgs e)
        {
            this.SwitchFrom(new frmQuanLyTK());
        }
    }
}
