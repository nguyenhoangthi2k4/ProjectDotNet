using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DTO;

namespace DAL
{
    public class HocSinhDAL : Connection
    {
        private SqlDataAdapter _da;
        private SqlDataAdapter _daTk;
        private SqlDataAdapter _daLopHoc;
        public HocSinhDAL()
        {
            string strSQL = "SELECT * FROM HOCSINH";
            _da = new SqlDataAdapter(strSQL, Conn);

            string strSQLTK = "SELECT * FROM LOGIN_TABLE";
            _daTk = new SqlDataAdapter(strSQLTK, Conn);
            _daTk.Fill(DataSet, "tblLOGINTABLE");

            string strSQLLopHoc = "SELECT * FROM LOPHOC";
            _daLopHoc = new SqlDataAdapter(strSQLLopHoc, Conn);
            _daLopHoc.Fill(DataSet, "tblLOPHOC");

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(_da);
            SqlCommandBuilder commandBuilderTK = new SqlCommandBuilder(_daTk);
            SqlCommandBuilder sqlCommandBuilderLopHoc = new SqlCommandBuilder(_daLopHoc);
        }

        public DataSet GetDataSet()
        {
            return GetDataSet(_da, "tblHOCSINH");
        }

        public bool CheckPrimary(HocSinh hs)
        {
            DataTable dt = DataSet.Tables["tblHOCSINH"];
            string condition = $"MAHS = '{hs.MaHS}'";
            return CheckCondition(dt, condition);
        }

        public string Insert(HocSinh hs)
        {
            if (this.CheckPrimary(hs) == false)
                return "Mã học sinh đã tồn tại";

            DataRow dr = DataSet.Tables["tblHOCSINH"].NewRow();
            dr["MAHS"] = hs.MaHS;
            dr["HOTEN"] = hs.HoTen;
            dr["NGAYSINH"] = hs.NgaySinh;
            dr["GIOITINH"] = hs.GioiTinh;
            dr["DIACHI"] = hs.DiaChi;
            dr["SODT"] = hs.SoDT;
            dr["MALOP"] = hs.MaLop;
            dr["GIOITINH"] = hs.GioiTinh;
            dr["USERNAME"] = hs.Taikhoan;
            DataSet.Tables["tblHOCSINH"].Rows.Add(dr);

            // Cập nhật sĩ số Lớp học
            DataRow rowsLop = DataSet.Tables["tblLOPHOC"].Select($"MALOP = '{hs.MaLop}'")[0];
            rowsLop["SISO"] = int.Parse(rowsLop["SISO"].ToString()) + 1;

            // Tự động tạo Tài khoản
            DataRow rowTK = DataSet.Tables["tblLOGINTABLE"].NewRow();
            rowTK["USERNAME"] = hs.Taikhoan;
            rowTK["PASSWORD"] = hs.Matkhau;
            rowTK["QUYEN"] = "HS";
            DataSet.Tables["tblLOGINTABLE"].Rows.Add(rowTK);            
            
            return "Thêm thành công";
        }

        public string Update(HocSinh hs)
        {
            DataRow dr = DataSet.Tables["tblHOCSINH"].Select($"MAHS = '{hs.MaHS}'")[0];            
            dr["HOTEN"] = hs.HoTen;
            dr["NGAYSINH"] = hs.NgaySinh;
            dr["GIOITINH"] = hs.GioiTinh;
            dr["DIACHI"] = hs.DiaChi;
            dr["SODT"] = hs.SoDT;            
            
            string currentClass = dr["MALOP"].ToString();
            if (currentClass != hs.MaLop)
            {
                // Cập nhật sĩ số lớp cũ                
                DataRow rowOldClass = DataSet.Tables["tblLOPHOC"].Select($"MALOP = '{currentClass}'")[0];
                rowOldClass["SISO"] = int.Parse(rowOldClass["SISO"].ToString()) - 1;                

                // Cập nhật sĩ số lớp mới
                DataRow rowNewClass = DataSet.Tables["tblLOPHOC"].Select($"MALOP = '{hs.MaLop}'")[0];
                rowNewClass["SISO"] = int.Parse(rowNewClass["SISO"].ToString()) + 1;                
            }
            dr["MALOP"] = hs.MaLop;

            return "Sửa thành công";
        }

        public void Destroy()
        {
            DataSet.Tables["tblHOCSINH"].RejectChanges();
        }

        public void Save()
        {
            Save(_daLopHoc, "tblLOPHOC");
            Save(_daTk, "tblLOGINTABLE");
            Save(_da, "tblHOCSINH");
        }
    }
}
