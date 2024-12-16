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
    public class BangDiemBLL
    {
        BangDiemDAL bangDiemDAL;

        public DataTable GetDataByMaLop(LopHoc lopHoc)
        {
            bangDiemDAL = new BangDiemDAL(lopHoc);
            return bangDiemDAL.GetDataSet().Tables["tblBANGDIEM"];
        }

        // fillter by HK
        public DataTable GetDataByMaLop(LopHoc lopHoc, string maHK)
        {
            bangDiemDAL = new BangDiemDAL(lopHoc);

            if(maHK == "Cả năm")
            {
                if (bangDiemDAL.DataSet.Tables.Contains("tblBANGDIEM"))
                    bangDiemDAL.DataSet.Tables["tblBANGDIEM"].Clear();

                return bangDiemDAL.GetDataSet().Tables["tblBANGDIEM"];
            }            
            if (bangDiemDAL.DataSet.Tables.Contains("tblBANGDIEM_MaHK"))
                bangDiemDAL.DataSet.Tables["tblBANGDIEM_MaHK"].Clear();

            return bangDiemDAL.GetDataSet(maHK).Tables["tblBANGDIEM_MaHK"];
        }

        public bool CheckInput(BangDiem bd)
        {
            if (bd.Toan == "" || bd.NgVan == "" || bd.NgNgu == "" || bd.VatLy == "" || bd.HoaHoc == "" || bd.SinhHoc == "" || bd.DiaLy == "" || bd.LichSu == "" || bd.Gdcd == "")
                return false;
            if (double.Parse(bd.Toan) < 0 || double.Parse(bd.Toan) > 10     ||
                double.Parse(bd.NgVan) < 0 || double.Parse(bd.NgVan) > 10   ||
                double.Parse(bd.NgNgu) < 0 || double.Parse(bd.NgNgu) > 10   ||
                double.Parse(bd.NgVan) < 0 || double.Parse(bd.NgVan) > 10   ||
                double.Parse(bd.VatLy) < 0 || double.Parse(bd.VatLy) > 10   ||
                double.Parse(bd.HoaHoc) < 0 || double.Parse(bd.HoaHoc) > 10 ||
                double.Parse(bd.SinhHoc) < 0 || double.Parse(bd.SinhHoc) > 10  ||
                double.Parse(bd.DiaLy) < 0 || double.Parse(bd.DiaLy) > 10   ||
                double.Parse(bd.LichSu) < 0 || double.Parse(bd.LichSu) > 10 ||
                double.Parse(bd.NgVan) < 0 || double.Parse(bd.NgVan) > 10 )
                return false;
            return true;
        }

        public string Update(BangDiem bd)
        {
            if(bd.MaHK == "Cả năm")
                return "Hãy chọn học kì để nhập điểm";

            if (this.CheckInput(bd) == false)            
                return "Nhập điểm không hợp lệ";
            
            return bangDiemDAL.Update(bd);
        }

        public void Save()
        {
            bangDiemDAL.Save();
        }

        public void Cancel()
        {
            bangDiemDAL.Cancel();
        }
    }
}
