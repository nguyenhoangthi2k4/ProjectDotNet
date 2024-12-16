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
    public class NamHocBLL
    {
        NamHocDAL namHocDAL = new NamHocDAL();
        public DataTable GetData()
        {
            return namHocDAL.GetDataSet().Tables["tblNAMHOC"];
        }

        public DataTable GetDataMaNH()
        {
            return namHocDAL.GetDataMaNH();
        }

        public bool CheckInput(NamHoc namHoc)
        {
            if(namHoc.MaNH == "" ||  namHoc.MaNH.Length != 5 || namHoc.MaHK == null)
                return false;
            return true;
        }
        public string Insert(NamHoc namHoc)
        {
            if (this.CheckInput(namHoc) == false)
                return "Nhập thông tin không hợp lệ";
            return namHocDAL.Insert(namHoc);
        }

        public void Save()
        {
            namHocDAL.Save();
        }
    }
}
