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
    public class ThuNganBLL
    {
        ThuNganDAL thuNganDAL = new ThuNganDAL();
        public ThuNganBLL() { }

        public DataTable GetData()
        {
            return thuNganDAL.GetDataSet().Tables["tblTHUNGAN"];
        }

        public DataTable GetDataByNamHoc_HocKy(NamHoc namHoc)
        {
            if (thuNganDAL.DataSet.Tables.Contains("tblTHUNGAN_NH"))            
                thuNganDAL.DataSet.Tables["tblTHUNGAN_NH"].Clear();
            
            return thuNganDAL.GetDataSetByNamHoc_HocKy(namHoc).Tables["tblTHUNGAN_NH"];
        }        

        public string Update(ThuNgan tn)
        {
            return thuNganDAL.Update(tn);
        }

        public void Cancel()
        {
            thuNganDAL.Cancel();
        }

        public void Save()
        {
            thuNganDAL.Save();
        }
    }
}
