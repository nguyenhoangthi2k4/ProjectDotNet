using System;
using System.Collections.Generic;
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
