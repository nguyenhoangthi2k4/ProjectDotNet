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
        private SqlDataAdapter _daThuNgan;
        private SqlDataAdapter _daBangDiem;
        private SqlDataAdapter _daHanhKiem;
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

            string strSQLThuNgan = "SELECT * FROM THUNGAN";
            _daThuNgan = new SqlDataAdapter(strSQLThuNgan, Conn);
            _daThuNgan.Fill(DataSet, "tblTHUNGAN");

            string strSQLBangDiem = "SELECT * FROM BANGDIEM";
            _daBangDiem = new SqlDataAdapter(strSQLBangDiem, Conn);
            _daBangDiem.Fill(DataSet, "tblBANGDIEM");

            string strSQLHanhKiem = "SELECT * FROM HANHKIEM";
            _daHanhKiem = new SqlDataAdapter(strSQLHanhKiem, Conn);
            _daHanhKiem.Fill(DataSet, "tblHANHKIEM");


            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(_da);
            SqlCommandBuilder commandBuilderTK = new SqlCommandBuilder(_daTk);
            SqlCommandBuilder sqlCommandBuilderLopHoc = new SqlCommandBuilder(_daLopHoc);
            SqlCommandBuilder sqlCommandBuilderThuNgan = new SqlCommandBuilder(_daThuNgan);
            SqlCommandBuilder sqlCommandBuilderBangDiem = new SqlCommandBuilder(_daBangDiem);
            SqlCommandBuilder sqlCommandBuilderHanhKiem = new SqlCommandBuilder(_daHanhKiem);
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
            string MaNH = rowsLop["MANH"].ToString();
            rowsLop["SISO"] = int.Parse(rowsLop["SISO"].ToString()) + 1;

            // Tự động tạo bảng Thu ngân
            // Học Kì 1
            DataRow rowTNHK1 = DataSet.Tables["tblTHUNGAN"].NewRow();
            rowTNHK1["MANH"] = MaNH;
            rowTNHK1["MAHK"] = "1";
            rowTNHK1["MAHS"] = hs.MaHS;
            rowTNHK1["SOTIEN_HP"] = 0;
            rowTNHK1["TINHTRANG_HP"] = "Chưa hoàn thành";
            rowTNHK1["NGAYDONG_HP"] = DBNull.Value;
            rowTNHK1["SOTIEN_BHYT"] = 0;
            rowTNHK1["TINHTRANG_BHYT"] = "Chưa hoàn thành";
            rowTNHK1["NGAYDONG_BHYT"] = DBNull.Value; ;
            DataSet.Tables["tblTHUNGAN"].Rows.Add(rowTNHK1);

            // Học Kỳ 2
            DataRow rowTNHK2 = DataSet.Tables["tblTHUNGAN"].NewRow();
            rowTNHK2["MANH"] = MaNH;
            rowTNHK2["MAHK"] = "2";
            rowTNHK2["MAHS"] = hs.MaHS;
            rowTNHK2["SOTIEN_HP"] = 0;
            rowTNHK2["TINHTRANG_HP"] = "Chưa hoàn thành";
            rowTNHK2["NGAYDONG_HP"] = DBNull.Value; 
            rowTNHK2["SOTIEN_BHYT"] = 0;
            rowTNHK2["TINHTRANG_BHYT"] = "Chưa hoàn thành";
            rowTNHK2["NGAYDONG_BHYT"] = DBNull.Value; 
            DataSet.Tables["tblTHUNGAN"].Rows.Add(rowTNHK2);

            // Tự động tạo bảng Bảng điểm
            // Học kì 1
            DataRow rowBDHK1 = DataSet.Tables["tblBANGDIEM"].NewRow();
            rowBDHK1["MANH"] = MaNH;
            rowBDHK1["MAHK"] = "1";
            rowBDHK1["MAHS"] = hs.MaHS;
            rowBDHK1["TOAN"] = 0;
            rowBDHK1["NGUVAN"] = 0;
            rowBDHK1["NGOAINGU"] = 0;
            rowBDHK1["VATLY"] = 0;
            rowBDHK1["HOAHOC"] = 0;
            rowBDHK1["SINHHOC"] = 0;
            rowBDHK1["LICHSU"] = 0;
            rowBDHK1["DIALY"] = 0;
            rowBDHK1["GDCD"] = 0;
            rowBDHK1["DTB"] = 0;
            DataSet.Tables["tblBANGDIEM"].Rows.Add(rowBDHK1);

            // Học kì 2
            DataRow rowBDHK2 = DataSet.Tables["tblBANGDIEM"].NewRow();
            rowBDHK2["MANH"] = MaNH;
            rowBDHK2["MAHK"] = "2";
            rowBDHK2["MAHS"] = hs.MaHS;
            rowBDHK2["TOAN"] = 0;
            rowBDHK2["NGUVAN"] = 0;
            rowBDHK2["NGOAINGU"] = 0;
            rowBDHK2["VATLY"] = 0;
            rowBDHK2["HOAHOC"] = 0;
            rowBDHK2["SINHHOC"] = 0;
            rowBDHK2["LICHSU"] = 0;
            rowBDHK2["DIALY"] = 0;
            rowBDHK2["GDCD"] = 0;
            rowBDHK2["DTB"] = 0;
            DataSet.Tables["tblBANGDIEM"].Rows.Add(rowBDHK2);

            // Tự động tạo bảng Hạnh kiểm
            // Học kì 1
            DataRow rowHKHK1 = DataSet.Tables["tblHANHKIEM"].NewRow();
            rowHKHK1["MANH"] = MaNH;
            rowHKHK1["MAHK"] = "1";
            rowHKHK1["MAHS"] = hs.MaHS;
            rowHKHK1["LOAIHK"] = "";
            DataSet.Tables["tblHANHKIEM"].Rows.Add(rowHKHK1);

            // Học kì 2
            DataRow rowHKHK2 = DataSet.Tables["tblHANHKIEM"].NewRow();
            rowHKHK2["MANH"] = MaNH;
            rowHKHK2["MAHK"] = "2";
            rowHKHK2["MAHS"] = hs.MaHS;
            rowHKHK2["LOAIHK"] = "";
            DataSet.Tables["tblHANHKIEM"].Rows.Add(rowHKHK2);

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
            Save(_daThuNgan, "tblTHUNGAN");
            Save(_daBangDiem, "tblBANGDIEM");
            Save(_daHanhKiem, "tblHANHKIEM");
        }
    }
}
