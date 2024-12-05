﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ToGVDAL : Connection
    {
        private SqlDataAdapter _da;
        public ToGVDAL()
        {
            string strSQL = "SELECT * FROM TOGV";
            _da = new SqlDataAdapter(strSQL, Conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(_da);
        }

        public DataSet GetDataSet()
        {
            return GetDataSet(_da, "tblTOGV");
        }
        public bool CheckPrimary(ToGV toGV)
        {
            DataTable dt = DataSet.Tables["tblTOGV"];
            string condition = $"MATOGV = '{toGV.MaToGV}'";
            return CheckPrimary(dt, condition);
        }
        public string Insert(ToGV toGV)
        {
            if (CheckPrimary(toGV) == false)
                return "Mã tổ Đã tồn tại";

            DataRow row = DataSet.Tables["tblTOGV"].NewRow();
            row["MATOGV"] = toGV.MaToGV;
            row["TRUONGTOGV"] = toGV.TruongToGV;
            row["TENTOGV"] = toGV.TenToGV;
            DataSet.Tables["tblTOGV"].Rows.Add(row);
            return "Thành công";
        }

        public void Save()
        {
            Save(_da, "tblTOGV");
        }
    }
}
