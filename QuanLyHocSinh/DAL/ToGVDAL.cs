using DTO;
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
            string strSQL = "SELECT toGV.*, gv.HOTEN FROM TOGV toGV, GIAOVIEN gv WHERE toGV.TRUONGTOGV = gv.MAGV";
            _da = new SqlDataAdapter(strSQL, Conn);

            // InsertCommand
            _da.InsertCommand = new SqlCommand("INSERT INTO TOGV (MATOGV, TRUONGTOGV, TENTOGV) VALUES (@MATOGV, @TRUONGTOGV, @TENTOGV)", Conn);
            _da.InsertCommand.Parameters.Add("@MATOGV", SqlDbType.Char, 5, "MATOGV");
            _da.InsertCommand.Parameters.Add("@TRUONGTOGV", SqlDbType.VarChar, 50, "TRUONGTOGV");
            _da.InsertCommand.Parameters.Add("@TENTOGV", SqlDbType.NVarChar, 50, "TENTOGV");

            // UpdateCommand
            _da.UpdateCommand = new SqlCommand("UPDATE TOGV SET TRUONGTOGV = @TRUONGTOGV, TENTOGV = @TENTOGV WHERE MATOGV = @MATOGV", Conn);
            _da.UpdateCommand.Parameters.Add("@MATOGV", SqlDbType.Char, 5, "MATOGV");
            _da.UpdateCommand.Parameters.Add("@TRUONGTOGV", SqlDbType.VarChar, 50, "TRUONGTOGV");
            _da.UpdateCommand.Parameters.Add("@TENTOGV", SqlDbType.NVarChar, 50, "TENTOGV");

            // DeleteCommand
            _da.DeleteCommand = new SqlCommand("DELETE FROM TOGV WHERE MATOGV = @MATOGV", Conn);
            _da.DeleteCommand.Parameters.Add("@MATOGV", SqlDbType.VarChar, 50, "MATOGV");
        }    
    
        public DataSet GetDataSet()
        {
            return GetDataSet(_da, "tblTOGV");
        }
        public bool CheckPrimary(ToGV toGV)
        {
            DataTable dt = DataSet.Tables["tblTOGV"];
            string condition = $"MATOGV = '{toGV.MaToGV}'";
            return CheckCondition(dt, condition);
        }

        public bool CheckTruongToGV(ToGV toGV)
        {
            DataTable dt = DataSet.Tables["tblTOGV"];
            string condition = $"TRUONGTOGV = '{toGV.TruongToGV}'";
            return CheckCondition(dt, condition);
        }

        public string Insert(ToGV toGV)
        {
            if (CheckPrimary(toGV) == false)
                return "Mã tổ Đã tồn tại";
            if (CheckTruongToGV(toGV) == false)
                return "Giáo viên này đã là Trưởng tổ";

            DataRow row = DataSet.Tables["tblTOGV"].NewRow();
            row["MATOGV"] = toGV.MaToGV;
            row["TRUONGTOGV"] = toGV.TruongToGV;
            row["TENTOGV"] = toGV.TenToGV;

            using (GetDataSet(new SqlDataAdapter("SELECT * FROM GIAOVIEN", Conn), "tblGIAOVIEN"))
            {
                row["HOTEN"] = DataSet.Tables["tblGIAOVIEN"].Select($"MAGV = '{toGV.TruongToGV}'")[0]["HOTEN"];
            }    

            DataSet.Tables["tblTOGV"].Rows.Add(row);
            return "Thêm thành công";
        }

        public string Update(ToGV toGV)
        {
            DataRow row = DataSet.Tables["tblTOGV"].Select($"MATOGV = '{toGV.MaToGV}'")[0];
            row["MATOGV"] = toGV.MaToGV;
            row["TRUONGTOGV"] = toGV.TruongToGV;
            row["TENTOGV"] = toGV.TenToGV;

            using (GetDataSet(new SqlDataAdapter("SELECT * FROM GIAOVIEN", Conn), "tblGIAOVIEN"))
            {
                row["HOTEN"] = DataSet.Tables["tblGIAOVIEN"].Select($"MAGV = '{toGV.TruongToGV}'")[0]["HOTEN"];
            }

            return "Sửa Thành công";
        }

        public void Destroy()
        {
            DataSet.Tables["tblTOGV"].RejectChanges();
        }

        public void Save()
        {
            Save(_da, "tblTOGV");
        }
    }
}
