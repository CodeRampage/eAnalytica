﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emissions_Analytica.Pages
{
    class DBHelper
    {
        private string connStr;
        private SqlConnection conn;
        private SqlCommand cmd;
        private DataTable table;

        public DataTable TBL { get { return table; } }

        public DBHelper(string uid, string pwd)
        {
            connStr = "Server=143.160.178.196; Database=energy_cons_dw; User=" + uid + "; password=" + pwd + ";";
            conn = new SqlConnection(connStr);
        }

        public bool login()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
