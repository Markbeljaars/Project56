using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WebApplication2.Controllers
{
    public class DatabaseController
    {
        public static SqlConnection conn;
        public static SqlCommand stmt;
        public static void connect()
        {
            conn = new SqlConnection("Data Source=145.24.222.224,8080;Initial Catalog=Project56;User ID=abc;Password=abc123");
            conn.Open(); 
        }

        public static SqlDataReader runQuery(string query)
        {
            stmt = new SqlCommand(query, conn);
            var myRs = stmt.ExecuteReader();

            return myRs;
        }

        public static int runScalarQuery(string query)
        {
            stmt = new SqlCommand(query, conn);
            int myRsInt = (int)stmt.ExecuteScalar();

            return myRsInt;
        }
        public static void runNonQuery(string query)
        {
            stmt = new SqlCommand(query, conn);
            var myRs = stmt.ExecuteNonQuery();
        }

        public static void close()
        {
            
            conn.Close();
        }
    }
}
