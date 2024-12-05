using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Connection
    {
        // Các field 
        private SqlConnection _conn;
        private DataSet _dataSet;

        // Các properties
        public SqlConnection Conn { get => _conn; set => _conn = value; }
        public DataSet DataSet { get => _dataSet; set => _dataSet = value; }

        // Constructor
        public Connection()
        {
            _conn = new SqlConnection(@"Data Source=DESKTOP-Q9F3DFL\HOANGTHI;Initial Catalog=QLHS;User ID=sa;Pwd=130804;TrustServerCertificate=True");
            _dataSet = new DataSet();            
        }
       
        // Execute Stored Procedure
        public int ExecuteSQL(string procName, SqlParameter[] parameters)
        {
            int row = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand(procName, Conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    Conn.Open();
                    row = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(Conn.State == ConnectionState.Open)
                    Conn.Close();   
            }
            return row;
        }

        public DataSet GetDataSet(SqlDataAdapter adapter, string tblName)
        {
            adapter.Fill(DataSet, tblName);
            return DataSet;
        }

        public bool CheckPrimary(DataTable table, string condition)
        {
            DataRow[] rows = table.Select(condition);
            return rows.Length < 1 ? true : false; // Không tồn tại giá trị
        }

        public void Save(SqlDataAdapter dataAdapter, string tblName)
        {
            dataAdapter.Update(DataSet, tblName);
            //SqlTransaction Transaction = null;
            //try
            //{
            //    Conn.Open();
            //    Transaction = Conn.BeginTransaction();

            //    // Thiết lập Transaction cho SqlDataAdapter
            //    dataAdapter.SelectCommand.Transaction = Transaction;
            //    // Cập nhật vào Database
            //    dataAdapter.Update(DataSet, tblName);
            //    Transaction.Commit();
            //}
            //catch (Exception ex)
            //{

            //}
            //finally
            //{
            //    if(Conn.State == ConnectionState.Open)
            //        Conn.Close();
            //}
        }
    }
}
