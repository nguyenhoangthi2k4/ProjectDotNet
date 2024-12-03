using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ToGVDAL : Connection
    {
        private SqlDataAdapter _da;
        public ToGVDAL()
        {
            string strSQL = "SELECT * FROM TOGV";
            _da = new SqlDataAdapter(strSQL, Conn);
        }

        public DataSet GetDataSet()
        {
            return GetDataSet(_da, "tblTOGV");
        }

    }
}
