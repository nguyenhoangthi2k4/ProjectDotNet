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
    public class HanhKiemDAL : Connection
    {
        private SqlDataAdapter _da;
        private LopHoc _lopHoc;

        public LopHoc LopHoc { get => _lopHoc; set => _lopHoc = value; }

        public HanhKiemDAL(LopHoc lopHoc)
        {
            this.LopHoc = lopHoc;
            string strSQL = $"SELECT hk.MAHK, hs.MAHS, hs.HOTEN, hk.LOAIHK FROM HANHKIEM hk JOIN HOCSINH hs ON hk.MAHS = hs.MAHS WHERE hk.MANH = '{this.LopHoc.MaNH}' AND hs.MALOP = '{this.LopHoc.MaLop}'";

            _da = new SqlDataAdapter(strSQL, Conn);

            // InsertCommand
            _da.InsertCommand = new SqlCommand("INSERT INTO HANHKIEM (MAHK, MANH, MAHS, LOAIHK) VALUES (@MAHK, @MANH, @MAHS, @LOAIHK)", Conn);
            _da.InsertCommand.Parameters.Add("@MAHK", SqlDbType.VarChar, 50, "MAHK");
            _da.InsertCommand.Parameters.Add("@MANH", SqlDbType.VarChar, 50, "MANH");
            _da.InsertCommand.Parameters.Add("@MAHS", SqlDbType.VarChar, 50, "MAHS");
            _da.InsertCommand.Parameters.Add("@LOAIHK", SqlDbType.NVarChar, 50, "LOAIHK");

            // UpdateCommand
            _da.UpdateCommand = new SqlCommand("UPDATE HANHKIEM SET LOAIHK = @LOAIHK WHERE MAHK = @MAHK AND MANH = @MANH AND MAHS = @MAHS", Conn);
            _da.UpdateCommand.Parameters.Add("@LOAIHK", SqlDbType.NVarChar, 50, "LOAIHK");
            _da.UpdateCommand.Parameters.Add("@MAHK", SqlDbType.VarChar, 50, "MAHK");
            _da.UpdateCommand.Parameters.Add("@MANH", SqlDbType.VarChar, 50, "MANH");
            _da.UpdateCommand.Parameters.Add("@MAHS", SqlDbType.VarChar, 50, "MAHS");

            // DeleteCommand
            _da.DeleteCommand = new SqlCommand("DELETE FROM HANHKIEM WHERE MAHK = @MAHK AND MANH = @MANH AND MAHS = @MAHS", Conn);
            _da.DeleteCommand.Parameters.Add("@MAHK", SqlDbType.VarChar, 50, "MAHK");
            _da.DeleteCommand.Parameters.Add("@MANH", SqlDbType.VarChar, 50, "MANH");
            _da.DeleteCommand.Parameters.Add("@MAHS", SqlDbType.VarChar, 50, "MAHS");

        }

        public DataSet GetDataSet()
        {
            return GetDataSet(_da, "tblHANHKIEM");
        }

        public DataSet GetDataSet(string maHK)
        {
            string strSQL = $"SELECT hk.MAHK, hk.MANH, hs.MAHS, hs.HOTEN, hk.LOAIHK FROM HANHKIEM hk JOIN HOCSINH hs ON hk.MAHS = hs.MAHS WHERE hk.MANH = '{this.LopHoc.MaNH}' AND hs.MALOP = '{this.LopHoc.MaLop}' AND hk.MAHK = '{maHK}'";
            _da.SelectCommand = new SqlCommand(strSQL, Conn);
            return GetDataSet(_da, "tblHANHKIEM_MaHK");
        }

        public string Update(HanhKiem hk)
        {
            if(!DataSet.Tables.Contains("tblHANHKIEM_MaHK"))
                return "Hãy chọn học kì để đánh giá";

            DataRow dr = DataSet.Tables["tblHANHKIEM_MaHK"].Select($"MAHK = '{hk.MaHK}' AND MANH = '{hk.MaNH}' AND MAHS = '{hk.MaHS}'")[0];
            dr["LOAIHK"] = hk.LoaiHK;

            return "Đánh giá thành công";
        }

        public void Cancel()
        {
            if(DataSet.Tables.Contains("tblHANHKIEM"))
                DataSet.Tables["tblHANHKIEM"].RejectChanges();
            if (DataSet.Tables.Contains("tblHANHKIEM_MaHK"))
                DataSet.Tables["tblHANHKIEM_MaHK"].RejectChanges();
        }

        public void Save()
        {
            if(DataSet.Tables.Contains("tblHANHKIEM"))
                Save(_da, "tblHANHKIEM");
            if (DataSet.Tables.Contains("tblHANHKIEM_MaHK"))
                Save(_da, "tblHANHKIEM_MaHK");
        }
    }
}
