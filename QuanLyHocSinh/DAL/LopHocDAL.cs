using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class LopHocDAL : Connection
    {
        private SqlDataAdapter _da;

        public LopHocDAL()
        {
            string strSQL = "SELECT * FROM LOPHOC";
            _da = new SqlDataAdapter(strSQL, Conn);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(_da);
        }

        public DataSet GetDataSet()
        {
            return GetDataSet(_da, "tblLOPHOC");
        }

        public bool CheckPrimary(LopHoc lopHoc)
        {
            DataTable dt = DataSet.Tables["tblLOPHOC"];
            string condition = $"MALOP = '{lopHoc.MaLop}'";
            return CheckPrimary(dt, condition); 
        }

        public string Insert(LopHoc lopHoc)
        {
            if (CheckPrimary(lopHoc) == false)
                return "Mã lớp đã tồn tại";

            DataRow row = DataSet.Tables["tblLOPHOC"].NewRow();
            row["MALOP"] = lopHoc.MaLop;
            row["TENLOP"] = lopHoc.TenLop;
            row["GVCN"] = lopHoc.Gvcn;
            row["SISO"] = lopHoc.SiSo;
            row["MANH"] = lopHoc.MaNH;
            row["MAHK"] = lopHoc.MaHK;

            DataSet.Tables["tblLOPHOC"].Rows.Add(row);
            return "Thành công";
        }
        public void Save()
        {
            Save(_da, "tblLOPHOC");
        }
    }
}
