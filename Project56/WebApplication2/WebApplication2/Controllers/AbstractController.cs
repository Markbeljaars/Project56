using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public abstract class AbstractController : Controller
    {


        public SqlDataReader getDataFromDatabase(String query)
        {
            SqlConnection conn = new SqlConnection("Data Source=145.24.222.224,8080;Initial Catalog=Project56;User ID=abc;Password=abc123");
            conn.Open();

            SqlCommand stmt = new SqlCommand(query, conn);

            SqlDataReader myReader = stmt.ExecuteReader();

            return myReader;
        }
    }
}