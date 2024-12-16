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
    public class TaiKhoanBLL
    {
        TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();  
        public TaiKhoanBLL()
        {
        }

        public DataTable GetData()
        {
            return taiKhoanDAL.GetDataSet().Tables["tblLOGIN_TABLE"];
        }

        public bool CheckInput(TaiKhoan tk)
        {
            if(tk.Matkhau == "" || tk.Matkhau.Length >15)
                return false;
            return true;
        }

        public bool CheckQuyenADMIN(TaiKhoan tk)
        {
            if (tk.Quyen == "AD")
                return false;
            return true;
        }

        public string Update(TaiKhoan tk)
        {
            if (this.CheckQuyenADMIN(tk) == false)
                return "Không thể sửa quyền ADMIN";

            if (this.CheckInput(tk) == false)
                return "Mật khẩu không hợp lệ";

            return taiKhoanDAL.Update(tk);
        }

        public void Destroy()
        {
            taiKhoanDAL.Cancel();
        }

        public void Save()
        {
            taiKhoanDAL.Save();
        }

        public string CheckLogin(TaiKhoan tk)
        {
            if(tk.Taikhoan == "" || tk.Matkhau == "")
                return "Tài khoản không hợp lệ";

            string user = taiKhoanDAL.CheckLogin(tk);
            return user;
        }
    }
}
