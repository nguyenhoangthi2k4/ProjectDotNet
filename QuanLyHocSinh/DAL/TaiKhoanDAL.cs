using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoanDAL : Connection
    {
        private SqlDataAdapter _da;
        public TaiKhoanDAL()
        {
            string strSQL = "SELECT * FROM TAIKHOAN";
            _da = new SqlDataAdapter(strSQL, Conn);
        }
        public DataSet GetData()
        {
            _da.Fill(DataSet, "tblTAIKHOAN");
            return DataSet;
        }
        public string CheckLogin(TaiKhoan tk)
        {
            string user = null;
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@tenTK", tk.Taikhoan),
                new SqlParameter("@matKhau", tk.Matkhau)
            };
            using (SqlCommand cmd = new SqlCommand("sp_checkLogin_LOGIN_TABLE", Conn))
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(para);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        user = dr.GetString(0) + " " + dr.GetString(2);                        
                        break;
                    }                    
                }
                else
                {
                    dr.Close();
                    return "Tài khoản không hợp lệ";
                } 
                dr.Close();
            }
            return user;  
        }
    }
}
