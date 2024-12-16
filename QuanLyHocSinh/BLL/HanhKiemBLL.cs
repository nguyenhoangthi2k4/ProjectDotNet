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
    public class HanhKiemBLL
    {
        HanhKiemDAL hanhKiemDAL;
        public HanhKiemBLL() { }

        public DataTable GetDataByMaLop(LopHoc lopHoc)
        {
            hanhKiemDAL = new HanhKiemDAL(lopHoc);
            return hanhKiemDAL.GetDataSet().Tables["tblHANHKIEM"];
        }

        public DataTable GetDataByMaLop(LopHoc lopHoc, string maHK)
        {
            hanhKiemDAL = new HanhKiemDAL(lopHoc);
            if(maHK == "Cả năm")
            {
                if (hanhKiemDAL.DataSet.Tables.Contains("tblHANHKIEM"))
                    hanhKiemDAL.DataSet.Tables["tblHANHKIEM"].Clear();
                return hanhKiemDAL.GetDataSet().Tables["tblHANHKIEM"];
            }    

            if (hanhKiemDAL.DataSet.Tables.Contains("tblHANHKIEM_MaHK"))
                hanhKiemDAL.DataSet.Tables["tblHANHKIEM_MaHK"].Clear();

            return hanhKiemDAL.GetDataSet(maHK).Tables["tblHANHKIEM_MaHK"];
        }

        public string Update(HanhKiem hanhKiem)
        {
            if(hanhKiem.MaHK == "Cả năm")
                return "Hãy chọn học kì để đánh giá";

            if(hanhKiem.LoaiHK == null)
                return "Hãy chọn loại hạnh kiểm";

            return hanhKiemDAL.Update(hanhKiem);
        }

        public void Cancel()
        {
            hanhKiemDAL.Cancel();
        }

        public void Save()
        {
            hanhKiemDAL.Save();
        }
    }
}
