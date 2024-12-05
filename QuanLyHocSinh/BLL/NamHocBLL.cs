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

        public int Insert(NamHoc namHoc)
        {
           return namHocDAL.Insert(namHoc);
        }

        public void Save()
        {
            namHocDAL.Save();
        }
    }
}
