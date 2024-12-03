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

        //public bool CheckMaNH_MaHK(NamHoc namHoc)
        //{
        //   return namHocDAL.CheckPrimary(namHoc);
        //}

        public DataSet Insert(NamHoc namHoc)
        {
            if(namHocDAL.CheckPrimary(namHoc))
                return namHocDAL.Insert(namHoc);
            return null;
        }

        public DataSet Save()
        {
            return namHocDAL.Save();
        }
    }
}
