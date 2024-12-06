using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class LopHocBLL
    {
        LopHocDAL lopHocDAL = new LopHocDAL();

        public DataTable GetData()
        {
            return lopHocDAL.GetDataSet().Tables["tblLOPHOC"];
        }

        public bool CheckInput(LopHoc lopHoc)
        {
            if (lopHoc.MaLop == "" || lopHoc.MaLop.Length != 5 || lopHoc.TenLop == "" || lopHoc.MaNH == null || lopHoc.Gvcn == null)
                return false;
            return true;
        }

        public string Insert(LopHoc lopHoc)
        {
            if (this.CheckInput(lopHoc) == false)
                return "Nhập thông tin Lớp học không hợp lệ";

            return lopHocDAL.Insert(lopHoc);
        }

        public void Save()
        {
            lopHocDAL.Save();
        }
    }
}
