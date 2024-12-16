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
    public class GiaoVienBLL
    {
        GiaoVienDAL giaoVienDAL = new GiaoVienDAL(); 

        public DataTable GetData()
        {
            return giaoVienDAL.GetDataSet().Tables["tblGIAOVIEN"];
        }

        public DataTable GetData(string MaGV)
        {
            return giaoVienDAL.GetTableByMaGV(MaGV);
        }

        public bool CheckInput(GiaoVien giaoVien)
        {
            if (giaoVien.MaGV == "" || giaoVien.MaGV.Length != 5 || giaoVien.TenGV == "" || giaoVien.SoDT == "" || giaoVien.SoDT.Length != 10 || giaoVien.MonGD == "" || giaoVien.Email == "" || giaoVien.QueQuan == "" || giaoVien.GioiTinh == null)
                return false;
            return true;
        }
        public string Insert(GiaoVien giaoVien)
        {
            if(this.CheckInput(giaoVien) == false)
                return "Nhập thông tin Giáo viên không hợp lệ";

            return giaoVienDAL.Insert(giaoVien); 
        }

        public string Update(GiaoVien giaoVien)
        {
            if (this.CheckInput(giaoVien) == false)
                return "Nhập thông tin Giáo viên không hợp lệ";

            return giaoVienDAL.Update(giaoVien);
        }

        public void Cancel()
        {
            giaoVienDAL.Cancel();
        }

        public void Save()
        {
            giaoVienDAL.Save();
        }
       
    }
}
