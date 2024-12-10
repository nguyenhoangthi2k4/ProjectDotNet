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
        private SqlDataAdapter _daTk;

        public GiaoVienDAL()
        {
            string strSQL = "SELECT * FROM GIAOVIEN";
            string strSQLTK = "SELECT * FROM LOGIN_TABLE";

            _da = new SqlDataAdapter(strSQL, Conn);
            _daTk = new SqlDataAdapter(strSQLTK, Conn);
            _daTk.Fill(DataSet, "tblLOGINTABLE");

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(_da);
            SqlCommandBuilder commandBuilderTK = new SqlCommandBuilder(_daTk);            
        }
        public DataSet GetDataSet()
        {
            return GetDataSet(_da, "tblGIAOVIEN");
        }

        public bool CheckPrimary(GiaoVien giaoVien)
        {
            DataTable dt = DataSet.Tables["tblGIAOVIEN"];
            string conditon = $"MAGV = '{giaoVien.MaGV}'";
            return CheckCondition(dt, conditon);
        }

        public bool CheckEmail(GiaoVien giaoVien)
        {
            DataTable dt = DataSet.Tables["tblGIAOVIEN"];
            string conditon = $"EMAIL = '{giaoVien.Email}'";
            return CheckCondition(dt, conditon);
        }

        public string Insert(GiaoVien giaoVien)
        {
            if (CheckPrimary(giaoVien) == false)
                return "Mã số đã tồn tại";

            if (CheckEmail(giaoVien) == false)
                return "Email đã tồn tại";

            DataRow row = DataSet.Tables["tblGIAOVIEN"].NewRow();
            row["MAGV"] = giaoVien.MaGV;
            row["HOTEN"] = giaoVien.TenGV;
            row["NGAYSINH"] = giaoVien.NgaySinh;
            row["QUEQUAN"] = giaoVien.QueQuan;
            row["EMAIL"] = giaoVien.Email;
            row["SODT"] = giaoVien.SoDT;
            row["GIOITINH"] = giaoVien.GioiTinh;            
            row["MATOGV"] = giaoVien.MaToGV;
            row["USERNAME"] = giaoVien.Taikhoan;
            row["MONGD"] = giaoVien.MonGD;

            DataRow rowTK = DataSet.Tables["tblLOGINTABLE"].NewRow();
            rowTK["USERNAME"] = giaoVien.Taikhoan;
            rowTK["PASSWORD"] = giaoVien.Matkhau;
            rowTK["QUYEN"] = "GV";
            DataSet.Tables["tblLOGINTABLE"].Rows.Add(rowTK);

            DataSet.Tables["tblGIAOVIEN"].Rows.Add(row);
            return "Thêm Thành công";
        }

        public string Update(GiaoVien giaoVien)
        {
            DataRow row = DataSet.Tables["tblGIAOVIEN"].Select($"MAGV = '{giaoVien.MaGV}'")[0];
            row["HOTEN"] = giaoVien.TenGV;
            row["NGAYSINH"] = giaoVien.NgaySinh;
            row["QUEQUAN"] = giaoVien.QueQuan;
            row["EMAIL"] = giaoVien.Email;
            row["SODT"] = giaoVien.SoDT;
            row["GIOITINH"] = giaoVien.GioiTinh;
            row["MATOGV"] = giaoVien.MaToGV;
            row["USERNAME"] = giaoVien.Taikhoan;
            row["MONGD"] = giaoVien.MonGD;

            return "Sửa Thành công";
        }

        public void Destroy()
        {
            DataSet.Tables["tblGIAOVIEN"].RejectChanges();
        }

        public void Save()
        {
            Save(_daTk, "tblLOGINTABLE");
            Save(_da, "tblGIAOVIEN");          
        }
    }
}
