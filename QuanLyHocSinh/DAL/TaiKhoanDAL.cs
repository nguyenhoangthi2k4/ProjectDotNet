using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TaiKhoanDAL : Connection
    {
        private SqlDataAdapter _da;
        public TaiKhoanDAL()
        {
            string strSQL = "SELECT * FROM LOGIN_TABLE";
            _da = new SqlDataAdapter(strSQL, Conn);

            TaiKhoan tk = new TaiKhoan();
            string ISQL = @"INSERT INTO LOGIN_TABLE(USERNAME, PASSWORD, QUYEN) VALUES(@USERNAME, @PASSWORD, @QUYEN)";
            SqlCommand Icmd = new SqlCommand(ISQL, Conn);
            Icmd.Parameters.Add("@USERNAME", SqlDbType.VarChar, 15, "USERNAME"); // USERNAME là column trong giá trị trong table của DataSet
            Icmd.Parameters.Add("@PASSWORD", SqlDbType.NVarChar, 15, "PASSWORD");
            Icmd.Parameters.Add("@QUYEN", SqlDbType.NVarChar, 5, "QUYEN");
            _da.InsertCommand = Icmd;
        }

        public DataSet GetDataSet()
        {
            return GetDataSet(_da, "tblLOGIN_TABLE");
        }
       
        public int Insert(TaiKhoan tk)
        {
            //if (!DataSet.Tables.Contains("tblLOGIN_TABLE"))
            //    this.GetDataSet();

            DataRow row = DataSet.Tables["tblLOGIN_TABLE"].NewRow();
            row["USERNAME"] = tk.Taikhoan;
            row["PASSWORD"] = tk.Matkhau;
            row["QUYEN"] = tk.Quyen;            
            DataSet.Tables["tblLOGIN_TABLE"].Rows.Add(row);

            return 1;
        }

        public void Save()
        {
            //_da.Update(DataSet, "tblLOGIN_TABLE");
            Save(_da, "tblLOGIN_TABLE");
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
