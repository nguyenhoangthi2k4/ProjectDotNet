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
    public class BangDiemDAL : Connection
    {
        private SqlDataAdapter _da;
        private LopHoc _lopHoc;

        public LopHoc LopHoc { get => _lopHoc; set => _lopHoc = value; }

        public BangDiemDAL(LopHoc lopHoc)
        {
            this.LopHoc = lopHoc;
            string strSQL = $"SELECT bd.MAHS, hs.HOTEN, bd.MAHK, bd.TOAN, bd.NGUVAN, bd.NGOAINGU, bd.VATLY, bd.HOAHOC, bd.SINHHOC, bd.DIALY, bd.LICHSU, bd.GDCD, bd.DTB FROM BANGDIEM bd JOIN HOCSINH hs ON bd.MAHS = hs.MAHS WHERE bd.MANH = '{lopHoc.MaNH}' AND hs.MALOP = '{lopHoc.MaLop}'";
            _da = new SqlDataAdapter(strSQL, Conn);

            // Define the InsertCommand
            _da.InsertCommand = new SqlCommand(
                "INSERT INTO BANGDIEM (MAHS, MAHK, MANH, TOAN, NGUVAN, NGOAINGU, VATLY, HOAHOC, SINHHOC, DIALY, LICHSU, GDCD, DTB) " +
                "VALUES (@MAHS, @MAHK, @MANH, @TOAN, @NGUVAN, @NGOAINGU, @VATLY, @HOAHOC, @SINHHOC, @DIALY, @LICHSU, @GDCD, @DTB)", Conn);
            _da.InsertCommand.Parameters.Add("@MAHS", SqlDbType.VarChar, 50, "MAHS");
            _da.InsertCommand.Parameters.Add("@MAHK", SqlDbType.VarChar, 50, "MAHK");
            _da.InsertCommand.Parameters.Add("@MANH", SqlDbType.VarChar, 50, "MANH");
            _da.InsertCommand.Parameters.Add("@TOAN", SqlDbType.Decimal, 10, "TOAN");
            _da.InsertCommand.Parameters.Add("@NGUVAN", SqlDbType.Decimal, 10, "NGUVAN");
            _da.InsertCommand.Parameters.Add("@NGOAINGU", SqlDbType.Decimal, 10, "NGOAINGU");
            _da.InsertCommand.Parameters.Add("@VATLY", SqlDbType.Decimal, 10, "VATLY");
            _da.InsertCommand.Parameters.Add("@HOAHOC", SqlDbType.Decimal, 10, "HOAHOC");
            _da.InsertCommand.Parameters.Add("@SINHHOC", SqlDbType.Decimal, 10, "SINHHOC");
            _da.InsertCommand.Parameters.Add("@DIALY", SqlDbType.Decimal, 10, "DIALY");
            _da.InsertCommand.Parameters.Add("@LICHSU", SqlDbType.Decimal, 10, "LICHSU");
            _da.InsertCommand.Parameters.Add("@GDCD", SqlDbType.Decimal, 10, "GDCD");
            _da.InsertCommand.Parameters.Add("@DTB", SqlDbType.Decimal, 10, "DTB");

            // Define the UpdateCommand
            _da.UpdateCommand = new SqlCommand(
                "UPDATE BANGDIEM SET TOAN = @TOAN, NGUVAN = @NGUVAN, NGOAINGU = @NGOAINGU, VATLY = @VATLY, HOAHOC = @HOAHOC, SINHHOC = @SINHHOC, DIALY = @DIALY, LICHSU = @LICHSU, GDCD = @GDCD, DTB = @DTB " +
                "WHERE MAHS = @MAHS AND MAHK = @MAHK AND MANH = @MANH", Conn);
            _da.UpdateCommand.Parameters.Add("@TOAN", SqlDbType.Decimal, 10, "TOAN");
            _da.UpdateCommand.Parameters.Add("@NGUVAN", SqlDbType.Decimal, 10, "NGUVAN");
            _da.UpdateCommand.Parameters.Add("@NGOAINGU", SqlDbType.Decimal, 10, "NGOAINGU");
            _da.UpdateCommand.Parameters.Add("@VATLY", SqlDbType.Decimal, 10, "VATLY");
            _da.UpdateCommand.Parameters.Add("@HOAHOC", SqlDbType.Decimal, 0, "HOAHOC");
            _da.UpdateCommand.Parameters.Add("@SINHHOC", SqlDbType.Decimal, 10, "SINHHOC");
            _da.UpdateCommand.Parameters.Add("@DIALY", SqlDbType.Decimal, 10, "DIALY");
            _da.UpdateCommand.Parameters.Add("@LICHSU", SqlDbType.Decimal, 10, "LICHSU");
            _da.UpdateCommand.Parameters.Add("@GDCD", SqlDbType.Decimal, 10, "GDCD");
            _da.UpdateCommand.Parameters.Add("@DTB", SqlDbType.Decimal , 10, "DTB");
            _da.UpdateCommand.Parameters.Add("@MAHS", SqlDbType.VarChar, 50, "MAHS");
            _da.UpdateCommand.Parameters.Add("@MAHK", SqlDbType.VarChar, 50, "MAHK");
            _da.UpdateCommand.Parameters.Add("@MANH", SqlDbType.VarChar, 50, "MANH");

            // Define the DeleteCommand
            _da.DeleteCommand = new SqlCommand(
                "DELETE FROM BANGDIEM WHERE MAHS = @MAHS AND MAHK = @MAHK AND MANH = @MANH", Conn);
            _da.DeleteCommand.Parameters.Add("@MAHS", SqlDbType.VarChar, 50, "MAHS");
            _da.DeleteCommand.Parameters.Add("@MAHK", SqlDbType.VarChar, 50, "MAHK");
            _da.DeleteCommand.Parameters.Add("@MANH", SqlDbType.VarChar, 50, "MANH");
        }

        public DataSet GetDataSet()
        {
            return GetDataSet(_da, "tblBANGDIEM");
        }

        public DataSet GetDataSet(string maHK)
        {
            string strSQL = $"SELECT bd.MANH, bd.MAHS, hs.HOTEN, bd.MAHK, bd.TOAN, bd.NGUVAN, bd.NGOAINGU, bd.VATLY, bd.HOAHOC, bd.SINHHOC, bd.DIALY, bd.LICHSU, bd.GDCD, bd.DTB FROM BANGDIEM bd JOIN HOCSINH hs ON bd.MAHS = hs.MAHS WHERE bd.MANH = '{this.LopHoc.MaNH}' AND hs.MALOP = '{this.LopHoc.MaLop}' AND bd.MAHK = '{maHK}'";
            _da.SelectCommand = new SqlCommand(strSQL, Conn);
            return GetDataSet(_da, "tblBANGDIEM_MaHK");
        }

        public string Update(BangDiem bd)
        {
            if(!DataSet.Tables.Contains("tblBANGDIEM_MaHK"))
                return "Hãy chọn học kì để nhập điểm";

            DataRow row = DataSet.Tables["tblBANGDIEM_MaHK"].Select($"MAHS = '{bd.MaHS}' AND MAHK = '{bd.MaHK}' AND MANH = '{bd.MaNH}'")[0];
            row["TOAN"] = Math.Round(decimal.Parse(bd.Toan), 2);
            row["NGUVAN"] = Math.Round(decimal.Parse(bd.NgVan), 2);
            row["NGOAINGU"] = Math.Round(decimal.Parse(bd.NgNgu), 2);
            row["VATLY"] = Math.Round(decimal.Parse(bd.VatLy), 2);
            row["HOAHOC"] = Math.Round(decimal.Parse(bd.HoaHoc), 2);
            row["SINHHOC"] = Math.Round(decimal.Parse(bd.SinhHoc), 2);
            row["DIALY"] = Math.Round(decimal.Parse(bd.DiaLy), 2);
            row["LICHSU"] = Math.Round(decimal.Parse(bd.LichSu), 2);
            row["GDCD"] = Math.Round(decimal.Parse(bd.Gdcd), 2);
            bd.TinhDTB();
            row["DTB"] = Math.Round(decimal.Parse(bd.Dtb), 2);

            return "Nhập điểm thành công";
        }

        public void Cancel()
        {
            if (DataSet.Tables.Contains("tblBANGDIEM"))
                DataSet.Tables["tblBANGDIEM"].RejectChanges();
            if (DataSet.Tables.Contains("tblBANGDIEM_MaHK"))
                DataSet.Tables["tblBANGDIEM_MaHK"].RejectChanges();
        }

        public void Save()
        {
            if(DataSet.Tables.Contains("tblBANGDIEM"))
                Save(_da, "tblBANGDIEM");
            if (DataSet.Tables.Contains("tblBANGDIEM_MaHK"))
                Save(_da, "tblBANGDIEM_MaHK");
        }
    }
}
