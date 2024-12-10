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
    public class ToGVBLL
    {
        ToGVDAL ToGVDAL = new ToGVDAL();

        public ToGVBLL() { }

        public DataTable GetData()
        {
            return ToGVDAL.GetDataSet().Tables["tblTOGV"];
        }

        public bool CheckInput(ToGV toGV)
        {
            if (toGV.TenToGV == "" || toGV.MaToGV == "" || toGV.MaToGV.Length != 5)
                return false;
            return true;
        }
        public string Insert(ToGV toGV)
        {
            if (this.CheckInput(toGV) == false)
                return "Nhập thông tin Tổ Giáo viên không chính xác";
            return ToGVDAL.Insert(toGV);
        }

        public string Update(ToGV toGV)
        {
            return ToGVDAL.Update(toGV);
        }

        public void Destroy()
        {
            ToGVDAL.Destroy();
        }

        public void Save()
        {
            ToGVDAL.Save();
        }
    }
}
