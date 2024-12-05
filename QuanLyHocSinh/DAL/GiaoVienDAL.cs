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
    public class GiaoVienDAL : Connection
    {
        private SqlDataAdapter _da;

        public GiaoVienDAL()
        {
            string strSQL = "SELECT gv.*, lg.PASSWORD FROM GIAOVIEN gv, LOGIN_TABLE lg WHERE gv.USERNAME = lg.USERNAME";
            _da = new SqlDataAdapter(strSQL, Conn);
            GiaoVien gv = new GiaoVien();

            // InsertCommand
            string ISQL = @"INSERT INTO GIAOVIEN(MAGV, HOTEN, NGAYSINH, DIACHI, EMAIL, SODT, GIOITINH, MATOGV, USERNAME, MONGD) VALUES (@MAGV, @HOTEN, @NGAYSINH, @DIACHI, @EMAIL, @SODT, @GIOITINH, @MATOGV, @USERNAME, @MONGD)";
            SqlCommand Icmd = new SqlCommand(ISQL, Conn);
            Icmd.Parameters.Add("@MAGV", SqlDbType.NVarChar, 5, "MAGV");
            Icmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar, 255, "HOTEN");
            Icmd.Parameters.Add("@NGAYSINH", SqlDbType.Date, 10, "NGAYSINH");
            Icmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar, 255, "DIACHI");
            Icmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar, 255, "EMAIL");
            Icmd.Parameters.Add("@SODT", SqlDbType.NVarChar, 20, "SODT");
            Icmd.Parameters.Add("@GIOITINH", SqlDbType.NVarChar, 10, "GIOITINH");
            Icmd.Parameters.Add("@MATOGV", SqlDbType.NVarChar, 10, "MATOGV");
            Icmd.Parameters.Add("@USERNAME", SqlDbType.NVarChar, 50, "USERNAME");
            Icmd.Parameters.Add("@MONGD", SqlDbType.NVarChar, 30, "MONGD");
            _da.InsertCommand = Icmd;
        }

        public DataSet GetDataSet()
        {
            return GetDataSet(_da, "tblGIAOVIEN");
        }

        public bool CheckPrimary(GiaoVien giaoVien)
        {
            DataTable dt = DataSet.Tables["tblGIAOVIEN"];
            string conditon = $"MAGV = '{giaoVien.MaGV}'";
            return CheckPrimary(dt, conditon);
        }
        public int Insert(GiaoVien giaoVien)
        {
            if (CheckPrimary(giaoVien) == false)
                return 0;
            
            DataRow row = DataSet.Tables["tblGIAOVIEN"].NewRow();
            row["MAGV"] = giaoVien.MaGV;
            row["HOTEN"] = giaoVien.TenGV;
            row["NGAYSINH"] = giaoVien.NgaySinh;
            row["DIACHI"] = giaoVien.DiaChi;
            row["EMAIL"] = giaoVien.Email;
            row["SODT"] = giaoVien.SoDT;
            row["GIOITINH"] = giaoVien.GioiTinh;            
            row["MATOGV"] = null;
            row["USERNAME"] = null;//giaoVien.Taikhoan;           
            row["MONGD"] = giaoVien.MonGD;
            
            DataSet.Tables["tblGIAOVIEN"].Rows.Add(row);
            return 1;
        }
        public void Save()
        {
            //_da.Update(DataSet, "tblGIAOVIEN");
            Save(_da, "tblGIAOVIEN");          
        }

    }
}
