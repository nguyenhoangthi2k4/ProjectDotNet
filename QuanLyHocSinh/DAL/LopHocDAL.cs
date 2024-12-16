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
            string strSQL = "SELECT lh.MANH, lh.MALOP, lh.TENLOP, lh.SISO, lh.GVCN, lh.MAHK, gv.HOTEN FROM LOPHOC lh, GIAOVIEN gv WHERE lh.GVCN = gv.MAGV";
            _da = new SqlDataAdapter(strSQL, Conn);
            // Manually specify the commands
            _da.InsertCommand = new SqlCommand("INSERT INTO LOPHOC (MANH, MALOP, TENLOP, SISO, GVCN, MAHK) VALUES (@MANH, @MALOP, @TENLOP, @SISO, @GVCN, @MAHK)", Conn);
            _da.UpdateCommand = new SqlCommand("UPDATE LOPHOC SET TENLOP = @TENLOP, SISO = @SISO, GVCN = @GVCN, MAHK = @MAHK WHERE MALOP = @MALOP", Conn);
            _da.DeleteCommand = new SqlCommand("DELETE FROM LOPHOC WHERE MALOP = @MALOP", Conn);

            // Add parameters for InsertCommand
            _da.InsertCommand.Parameters.Add("@MANH", SqlDbType.VarChar, 50, "MANH");
            _da.InsertCommand.Parameters.Add("@MALOP", SqlDbType.VarChar, 50, "MALOP");
            _da.InsertCommand.Parameters.Add("@TENLOP", SqlDbType.NVarChar, 50, "TENLOP");
            _da.InsertCommand.Parameters.Add("@SISO", SqlDbType.Int, 4, "SISO");
            _da.InsertCommand.Parameters.Add("@GVCN", SqlDbType.VarChar, 50, "GVCN");
            _da.InsertCommand.Parameters.Add("@MAHK", SqlDbType.VarChar, 50, "MAHK");

            // Add parameters for UpdateCommand
            _da.UpdateCommand.Parameters.Add("@TENLOP", SqlDbType.NVarChar, 50, "TENLOP");
            _da.UpdateCommand.Parameters.Add("@SISO", SqlDbType.Int, 4, "SISO");
            _da.UpdateCommand.Parameters.Add("@GVCN", SqlDbType.VarChar, 50, "GVCN");
            _da.UpdateCommand.Parameters.Add("@MAHK", SqlDbType.VarChar, 50, "MAHK");
            _da.UpdateCommand.Parameters.Add("@MALOP", SqlDbType.VarChar, 50, "MALOP");

            // Add parameters for DeleteCommand
            _da.DeleteCommand.Parameters.Add("@MALOP", SqlDbType.VarChar, 50, "MALOP");
        }

        public DataSet GetDataSet()
        {
            return GetDataSet(_da, "tblLOPHOC");
        }

        // Get data by MaLop
        public DataTable GetTableByMaLop(string MaLop)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM LOPHOC WHERE MALOP = '{MaLop}'", Conn))
            {
                da.Fill(dt);
                return dt;
            }
        }

        // Get data by GVCN
        public DataTable GetTableByGVCN(string GVCN)
        {
            DataTable dt = new DataTable();
            using(SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM LOPHOC WHERE GVCN = '{GVCN}'", Conn))
            {
                da.Fill(dt);
                return dt;
            }
        }

        public bool CheckPrimary(LopHoc lopHoc)
        {
            DataTable dt = DataSet.Tables["tblLOPHOC"];
            string condition = $"MALOP = '{lopHoc.MaLop}'";
            return CheckCondition(dt, condition); 
        }

        public bool CheckTenLop(LopHoc lopHoc)
        {
            DataTable dt = DataSet.Tables["tblLOPHOC"];
            string condition = $"TENLOP = '{lopHoc.TenLop}' AND MANH = '{lopHoc.MaNH}'";
            return CheckCondition(dt, condition);
        }
        public bool CheckGVCN(LopHoc lopHoc)
        {
            DataTable dt = DataSet.Tables["tblLOPHOC"];
            string condition = $"GVCN = '{lopHoc.Gvcn}' AND MANH = '{lopHoc.MaNH}'";
            return CheckCondition(dt, condition);
        }

        public string Insert(LopHoc lopHoc)
        {
            if (CheckPrimary(lopHoc) == false) 
                return "Mã lớp đã tồn tại";
            if (CheckTenLop(lopHoc) == false)
                return "Tên lớp đã tồn tại trong cùng học kỳ";
            if (CheckGVCN(lopHoc) == false)
                return "GVCN đã tồn tại trong cùng học kỳ";

            DataRow row = DataSet.Tables["tblLOPHOC"].NewRow();
            row["MALOP"] = lopHoc.MaLop;
            row["TENLOP"] = lopHoc.TenLop;
            row["GVCN"] = lopHoc.Gvcn;
            row["SISO"] = lopHoc.SiSo;
            row["MANH"] = lopHoc.MaNH;
            row["MAHK"] = lopHoc.MaHK;

            using (SqlDataAdapter daGV = new SqlDataAdapter("SELECT * FROM GIAOVIEN", Conn))
            {
                daGV.Fill(DataSet, "tblGIAOVIEN");

                DataRow findGV = DataSet.Tables["tblGIAOVIEN"].Select($"MAGV = '{lopHoc.Gvcn}'")[0];
                if (findGV != null)
                    row["HOTEN"] = findGV["HOTEN"];
            }

            DataSet.Tables["tblLOPHOC"].Rows.Add(row);
            return "Thêm Thành công";
        }

        public string Update(LopHoc lopHoc)
        {
            if (CheckTenLop(lopHoc) == false)
                return "Tên lớp đã tồn tại trong cùng học kỳ";
            //if (CheckGVCN(lopHoc) == false)
            //    return "GVCN đã tồn tại trong cùng học kỳ";

            DataRow row = DataSet.Tables["tblLOPHOC"].Select($"MALOP = '{lopHoc.MaLop}'")[0];
            row["TENLOP"] = lopHoc.TenLop;            
            row["GVCN"] = lopHoc.Gvcn;

            using (SqlDataAdapter daGV = new SqlDataAdapter("SELECT * FROM GIAOVIEN", Conn))
            {
                daGV.Fill(DataSet, "tblGIAOVIEN");

                DataRow findGV = DataSet.Tables["tblGIAOVIEN"].Select($"MAGV = '{lopHoc.Gvcn}'")[0];
                if (findGV != null)
                    row["HOTEN"] =  findGV["HOTEN"];
            }
            return "Sửa thành công";
        }

        public void Cancel()
        {
            DataSet.Tables["tblLOPHOC"].RejectChanges();
        }

        public void Save()
        {
            Save(_da, "tblLOPHOC");
        }
    }
}
