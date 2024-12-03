using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GiaoVienDAL : Connection
    {
        SqlDataAdapter _da;

        public GiaoVienDAL()
        {
            string strSQL = "SELECT gv.*, lg.PASSWORD FROM GIAOVIEN gv, LOGIN_TABLE lg WHERE gv.USERNAME = lg.USERNAME";
            _da = new SqlDataAdapter(strSQL, Conn);
        }

        public DataSet GetDataSet()
        {
            return GetDataSet(_da, "tblGIAOVIEN");
        }

        public 
    }
}
