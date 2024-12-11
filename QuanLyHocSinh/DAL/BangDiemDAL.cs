using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BangDiemDAL : Connection
    {
        private SqlDataAdapter _da;
        public BangDiemDAL()
        {
            string strSQL = "SELECT hs.HOTEN, bd.* FROM BANGDIEM bd, HOCSINH hs WHERE bd.MAHS = hs.MAHS";
            _da = new SqlDataAdapter(strSQL, Conn);
        }

        public DataSet GetDataSet()
        {
            return GetDataSet(_da, "tblBANGDIEM");
        }

        public DataSet GetDataSet(string MaLop)
        {
            SqlCommand cmd = new SqlCommand("sp_Select_BangDiem_ByMaLop", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaLop", SqlDbType.NVarChar, 10) { Value = MaLop });
            cmd.Parameters.Add(new SqlParameter("@MaNH", SqlDbType.NVarChar, 10) { Value = "N2021" });

            SqlDataAdapter _daBH = new SqlDataAdapter(cmd);
            return GetDataSet(_daBH, "tblBANGDIEM_MALOP");
        }
        public void Destroy()
        {
            DataSet.Tables["tblBANGDIEM"].RejectChanges();
        }

        public void Save()
        {
            Save(_da, "tblBANGDIEM");
        }
    }
}
