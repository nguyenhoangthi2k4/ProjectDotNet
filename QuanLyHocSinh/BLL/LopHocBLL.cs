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

        // get classes by GVCV
        public DataTable GetDataByGVCV(string GVCN)
        {
            return lopHocDAL.GetTableByGVCN(GVCN);
        }

        // get info by MaLop
        public DataTable GetDataByMaLop(string MaLop)
        {
            return lopHocDAL.GetTableByMaLop(MaLop);
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

        public string Update(LopHoc lopHoc)
        {
            if (this.CheckInput(lopHoc) == false)
                return "Nhập thông tin Lớp học không hợp lệ";
            return lopHocDAL.Update(lopHoc);
        }

        public void Cancel()
        {
            lopHocDAL.Cancel();
        }

        public void Save()
        {
            lopHocDAL.Save();
        }
    }
}
