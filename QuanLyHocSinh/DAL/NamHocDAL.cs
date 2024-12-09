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

        public DataTable GetDataMaNH()
        {
            return SelectQuery("sp_Select_NamHoc_ByMaHK", null);
        }        

        public string Insert(NamHoc namHoc)
        {
            if (this.CheckPrimary(namHoc)==false)
                return "Mã năm học và Học kỳ đã tồn tại";

            DataRow row = DataSet.Tables["tblNAMHOC"].NewRow();
            row["MANH"] = namHoc.MaNH;
            row["MAHK"] = namHoc.MaHK;
            DataSet.Tables["tblNAMHOC"].Rows.Add(row);
            return "Thêm Thành Công";
        }
        
        public bool CheckPrimary(NamHoc namHoc)
        {
            DataTable dt = DataSet.Tables["tblNAMHOC"];
            string condition = $"MaNH = '{namHoc.MaNH}' AND MaHK = '{namHoc.MaHK}'";
            return CheckCondition(dt, condition); 
        }

        public void Save()
        {
            Save(_da, "tblNAMHOC");
        }
    }
}
