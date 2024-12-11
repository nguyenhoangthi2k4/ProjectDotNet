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
            string strSQL = "SELECT * FROM BANGDIEM";
            _da = new SqlDataAdapter(strSQL, Conn);
            _da.Fill(DataSet, "tblBANGDIEM");
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(_da);
        }

        public DataSet GetDataSet()
        {
            return GetDataSet(_da, "tblBANGDIEM");
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
