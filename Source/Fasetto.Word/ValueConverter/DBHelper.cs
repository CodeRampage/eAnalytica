using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emissions_Analytica.Pages
{
    static class DBHelper
    {
        private static string connStr;
        private static SqlConnection conn;
        private static SqlCommand cmd;
        private static DataTable table;

        public static DataTable TBL { get { return table; } }
        public static SqlConnection Conn { get; set; }

        public static void init(string uid, string pwd)
        {
            connStr = "Server=143.160.178.196; Database=energy_cons_dw; User=" + uid + "; password=" + pwd + ";";
            conn = new SqlConnection(connStr);
        }

        public static bool login()
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

        public static SqlCommand shopCpmsByShopCTypeDate(string shopName, string consType, string dayOfWekk, int dayOfMonth, string monthName, int year)
        {
            string sql = "USE[energy_cons_dw] GO DECLARE @return_value int EXEC    @return_value = [dbo].[shopConsByShopCTypeDate] @shopName = @a, @consType = @b', @dayOfWeek = @c, @dayOfMonth = @d, @name_of_month = @e, @_year = @f SELECT  'Return Value' = @return_value GO";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@a", shopName));
            cmd.Parameters.Add(new SqlParameter("@b", consType));
            cmd.Parameters.Add(new SqlParameter("@c", dayOfWekk));
            cmd.Parameters.Add(new SqlParameter("@d", dayOfMonth));
            cmd.Parameters.Add(new SqlParameter("@e", monthName));
            cmd.Parameters.Add(new SqlParameter("@f", year));

            return cmd;
        }
    }
}
