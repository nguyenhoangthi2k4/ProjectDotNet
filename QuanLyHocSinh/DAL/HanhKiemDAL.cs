using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HanhKiemDAL : Connection
    {
        private SqlDataAdapter _da;
        public HanhKiemDAL()
        {
            string strSQL = "SELECT * FROM HANHKIEM";
            _da = new SqlDataAdapter(strSQL, Conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(_da);
        }

        public DataSet GetDataSet()
        {
            return GetDataSet(_da, "tblHANHKIEM");
        }

        public void Destroy()
        {
            DataSet.Tables["tblHANHKIEM"].RejectChanges();
        }

        public void Save()
        {
            Save(_da, "tblHANHKIEM");
        }
    }
}
