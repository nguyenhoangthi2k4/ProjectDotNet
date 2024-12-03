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
    public partial class frmThongTinCaNhanGV : Form
    {
        private frmStudentManagement _frmstudentManagement;
        public frmThongTinCaNhanGV(frmStudentManagement frmStudentManagement)
        {
            InitializeComponent();
            _frmstudentManagement = frmStudentManagement;
        }

        private void btnDangXuatCN_Click(object sender, EventArgs e)
        {
            this._frmstudentManagement.tsMnItemDangXuat_Click(sender, e);
        }
    }
}
