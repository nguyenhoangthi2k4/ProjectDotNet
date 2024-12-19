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
    public class HocSinhBLL
    {
        HocSinhDAL hocSinhDAL = new HocSinhDAL();

        public HocSinhBLL() { }

        public DataTable GetData()
        {
            return hocSinhDAL.GetDataSet().Tables["tblHOCSINH"];
        }

        public DataTable GetDataByMaLop(string MaLop)
        {
            return hocSinhDAL.GetDataSetByMaLop(MaLop).Tables["tblHOCSINH_ByMaLop"];
        }

        public bool CheckInput(HocSinh hs)
        {
            if (hs.MaHS == "" || hs.MaHS.Length != 5 || hs.HoTen == "" || hs.GioiTinh == null || hs.DiaChi == "" || hs.SoDT == "" || hs.SoDT.Length != 10 || hs.MaLop == null)
                return false;
            return true;
        }

        public string Insert(HocSinh hs)
        {
            if (this.CheckInput(hs) == false)
                return "Nhập thông tin không hợp lệ";
            return hocSinhDAL.Insert(hs);
        }

        public string Update(HocSinh hs)
        {
            if(this.CheckInput(hs) == false)
                return "Nhập thông tin không hợp lệ";
            return hocSinhDAL.Update(hs);
        }

        public string Delete(string MaHS)
        {
            return hocSinhDAL.Delete(MaHS);
        }

        public void Cancel()
        {
            hocSinhDAL.Cancel();
        }
        public void Save()
        {
            hocSinhDAL.Save();
        }
    }
}
