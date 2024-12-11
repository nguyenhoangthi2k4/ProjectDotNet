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
    public class ThuNganDAL : Connection
    {
        private SqlDataAdapter _da;
        public ThuNganDAL()
        {
            string strSQL = "SELECT tn.MANH, tn.MAHK, tn.MAHS, hs.HOTEN, tn.SOTIEN_HP, tn.TINHTRANG_HP, tn.NGAYDONG_HP, tn.SOTIEN_BHYT, tn.TINHTRANG_BHYT, tn.NGAYDONG_BHYT FROM THUNGAN tn JOIN HOCSINH hs ON tn.MAHS = hs.MAHS";
            _da = new SqlDataAdapter(strSQL, Conn);

            // InsertCommand
            _da.InsertCommand = new SqlCommand("INSERT INTO THUNGAN (MANH, MAHK, MAHS, SOTIEN_HP, TINHTRANG_HP, NGAYDONG_HP, SOTIEN_BHYT, TINHTRANG_BHYT, NGAYDONG_BHYT) VALUES (@MANH, @MAHK, @MAHS, @SOTIEN_HP, @TINHTRANG_HP, @NGAYDONG_HP, @SOTIEN_BHYT, @TINHTRANG_BHYT, @NGAYDONG_BHYT)", Conn);
            _da.InsertCommand.Parameters.Add("@MANH", SqlDbType.Char, 5, "MANH");
            _da.InsertCommand.Parameters.Add("@MAHK", SqlDbType.Char, 5, "MAHK");
            _da.InsertCommand.Parameters.Add("@MAHS", SqlDbType.Char, 5, "MAHS");
            _da.InsertCommand.Parameters.Add("@SOTIEN_HP", SqlDbType.Decimal, 18, "SOTIEN_HP");
            _da.InsertCommand.Parameters.Add("@TINHTRANG_HP", SqlDbType.NVarChar, 50, "TINHTRANG_HP");
            _da.InsertCommand.Parameters.Add("@NGAYDONG_HP", SqlDbType.DateTime, 8, "NGAYDONG_HP");
            _da.InsertCommand.Parameters.Add("@SOTIEN_BHYT", SqlDbType.Decimal, 18, "SOTIEN_BHYT");
            _da.InsertCommand.Parameters.Add("@TINHTRANG_BHYT", SqlDbType.NVarChar, 50, "TINHTRANG_BHYT");
            _da.InsertCommand.Parameters.Add("@NGAYDONG_BHYT", SqlDbType.DateTime, 8, "NGAYDONG_BHYT");

            // UpdateCommand
            _da.UpdateCommand = new SqlCommand("UPDATE THUNGAN SET SOTIEN_HP = @SOTIEN_HP, TINHTRANG_HP = @TINHTRANG_HP, NGAYDONG_HP = @NGAYDONG_HP, SOTIEN_BHYT = @SOTIEN_BHYT, TINHTRANG_BHYT = @TINHTRANG_BHYT, NGAYDONG_BHYT = @NGAYDONG_BHYT WHERE MANH = @MANH AND MAHK = @MAHK AND MAHS = @MAHS", Conn);
            _da.UpdateCommand.Parameters.Add("@SOTIEN_HP", SqlDbType.Decimal, 18, "SOTIEN_HP");
            _da.UpdateCommand.Parameters.Add("@TINHTRANG_HP", SqlDbType.NVarChar, 50, "TINHTRANG_HP");
            _da.UpdateCommand.Parameters.Add("@NGAYDONG_HP", SqlDbType.DateTime, 8, "NGAYDONG_HP");
            _da.UpdateCommand.Parameters.Add("@SOTIEN_BHYT", SqlDbType.Decimal, 18, "SOTIEN_BHYT");
            _da.UpdateCommand.Parameters.Add("@TINHTRANG_BHYT", SqlDbType.NVarChar, 50, "TINHTRANG_BHYT");
            _da.UpdateCommand.Parameters.Add("@NGAYDONG_BHYT", SqlDbType.DateTime, 8, "NGAYDONG_BHYT");
            _da.UpdateCommand.Parameters.Add("@MANH", SqlDbType.Char, 5, "MANH");
            _da.UpdateCommand.Parameters.Add("@MAHK", SqlDbType.Char, 5, "MAHK");
            _da.UpdateCommand.Parameters.Add("@MAHS", SqlDbType.Char, 5, "MAHS");

            // DeleteCommand
            _da.DeleteCommand = new SqlCommand("DELETE FROM THUNGAN WHERE MANH = @MANH AND MAHK = @MAHK AND MAHS = @MAHS", Conn);
            _da.DeleteCommand.Parameters.Add("@MANH", SqlDbType.Char, 5, "MANH");
            _da.DeleteCommand.Parameters.Add("@MAHK", SqlDbType.Char, 5, "MAHK");
            _da.DeleteCommand.Parameters.Add("@MAHS", SqlDbType.Char, 5, "MAHS");
        }

        public DataSet GetDataSet()
        {
            return GetDataSet(_da, "tblTHUNGAN");
        }

        public DataSet GetDataSetByNamHoc_HocKy(NamHoc nh)
        {
            string strSQL = $"SELECT tn.MANH, tn.MAHK, tn.MAHS, hs.HOTEN, tn.SOTIEN_HP, tn.TINHTRANG_HP, tn.NGAYDONG_HP, tn.SOTIEN_BHYT, tn.TINHTRANG_BHYT, tn.NGAYDONG_BHYT FROM THUNGAN tn JOIN HOCSINH hs ON tn.MAHS = hs.MAHS WHERE tn.MANH = '{nh.MaNH}' AND tn.MAHK = '{nh.MaHK}'";
            _da.SelectCommand = new SqlCommand(strSQL, Conn);
            return GetDataSet(_da, "tblTHUNGAN_NH");
        }

        public string Update(ThuNgan tn)
        {
            if(DataSet.Tables.Contains("tblTHUNGAN_NH"))
            {
                DataRow drTN_NH = DataSet.Tables["tblTHUNGAN_NH"].Select($"MANH = '{tn.MaNH}' AND MAHK = '{tn.MaHK}' AND MAHS = '{tn.MaHS}'")[0];
                drTN_NH["SOTIEN_HP"] = tn.TienHP;
                drTN_NH["TINHTRANG_HP"] = tn.TinhTrangHP;
                drTN_NH["NGAYDONG_HP"] = tn.NgayDongHP;
                drTN_NH["SOTIEN_BHYT"] = tn.TienBHYT;
                drTN_NH["TINHTRANG_BHYT"] = tn.TinTrangBHYT;
                drTN_NH["NGAYDONG_BHYT"] = tn.NgayDongBHYT;
            }                

            DataRow dr = DataSet.Tables["tblTHUNGAN"].Select($"MANH = '{tn.MaNH}' AND MAHK = '{tn.MaHK}' AND MAHS = '{tn.MaHS}'")[0];
            dr["SOTIEN_HP"] = tn.TienHP;
            dr["TINHTRANG_HP"] = tn.TinhTrangHP;
            dr["NGAYDONG_HP"] = tn.NgayDongHP;
            dr["SOTIEN_BHYT"] = tn.TienBHYT;
            dr["TINHTRANG_BHYT"] = tn.TinTrangBHYT;
            dr["NGAYDONG_BHYT"] = tn.NgayDongBHYT;
            return "Cập nhật thành công";            
        }

        public void Destroy()
        {
            DataSet.Tables["tblTHUNGAN"].RejectChanges();
        }

        public void Save()
        {
            Save(_da, "tblTHUNGAN");
            if (DataSet.Tables.Contains("tblTHUNGAN_NH"))
            {
                Save(_da, "tblTHUNGAN_NH");
                DataSet.Tables["tblTHUNGAN_NH"].Dispose();
            }  
        }
    }

}
