using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class GiaoVienBLL
    {
        GiaoVienDAL giaoVienDAL = new GiaoVienDAL();        
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();

        public DataTable GetData()
        {
            return giaoVienDAL.GetDataSet().Tables["tblGIAOVIEN"];
        }

        public int Insert(GiaoVien giaoVien)
        {
            // Insert thông tin Giáo viên vào bảng Login_Table
            //TaiKhoan tk = new TaiKhoan();
            //tk.Taikhoan = giaoVien.Taikhoan;
            //tk.Matkhau = giaoVien.Matkhau;
            //tk.Quyen = "GV";
            //int resultTK = taiKhoanBLL.Insert(tk);

            // Insert thông tin Giáo viên vào bảng Giao viên
            int resultGV = giaoVienDAL.Insert(giaoVien);            

            // Kiểm tra nếu Insert
            if (resultGV == 1) //&& resultTK == 1)
                return 1;
            else return 0;
        }

        public void Save()
        {
            giaoVienDAL.Save();           
        }
    }
}
