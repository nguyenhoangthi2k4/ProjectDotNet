using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NamHocDAL : Connection
    {
        private SqlDataAdapter _da;
        public NamHocDAL()
        {
            string strSQL = "SELECT * FROM NAMHOC";
            _da = new SqlDataAdapter(strSQL, Conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(_da);
        }
       
        public DataSet GetDataSet()
        {
            return GetDataSet(_da, "tblNAMHOC");
        }

        public DataSet Insert(NamHoc namHoc)
        {
            DataRow row = DataSet.Tables["tblNAMHOC"].NewRow();
            row["MaNH"] = namHoc.MaNH;
            row["MaHK"] = namHoc.MaHK;
            DataSet.Tables["tblNAMHOC"].Rows.Add(row);
            return DataSet;
        }
        
        public bool CheckPrimary(NamHoc namHoc)
        {
            DataTable dt = DataSet.Tables["tblNAMHOC"];
            string condition = $"MaNH = '{namHoc.MaNH}' AND MaHK = '{namHoc.MaHK}'";
            return CheckPrimary(dt, condition); 
        }

        public DataSet Save()
        {
            _da.Update(DataSet, "tblNAMHOC");
            return DataSet;
        }
    }
}
