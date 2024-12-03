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
    }
}
