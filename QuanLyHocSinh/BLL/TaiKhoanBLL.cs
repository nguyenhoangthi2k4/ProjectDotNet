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
            taiKhoanDAL.Destroy();
        }

        public void Save()
        {
            taiKhoanDAL.Save();
        }

        public string[] Login(TaiKhoan tk)
        {
            string[] taikhoan = new string[2];
            if (tk.Taikhoan == " ")               
                taikhoan[0] = "Tài khoản không hợp lệ";
            else if (tk.Matkhau == " ")
                taikhoan[0] = "Tài khoản không hợp lệ";
            else
            {
                string tmp = taiKhoanDAL.CheckLogin(tk);
                if (tmp != "Tài khoản không hợp lệ")                              
                    taikhoan = tmp.Split(' ');      
                else
                    taikhoan[0] = tmp;
            }    
            return taikhoan;
        }
       
    }
}
