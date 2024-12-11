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
        BangDiemDAL bangDiemDAL = new BangDiemDAL();

        public DataTable GetData()
        {
            return bangDiemDAL.GetDataSet().Tables["tblBANGDIEM"];
        }

        public DataTable GetDataByMaLop(string MaLop)
        {
            return bangDiemDAL.GetDataSet(MaLop).Tables["tblBANGDIEM_MALOP"];
        }
    }
}
