using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WebApplication2.Models;
using System.Data;

namespace WebApplication2.Database
{
    public class AccountFactory
    {
        public static Account genAcc(string uName) {
            var generatedAccount = new Account();
            var connString = "Data Source=145.24.222.224,8080;Initial Catalog=Project56;User ID=abc;Password=abc123";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand stmt = new SqlCommand("SELECT * FROM Users WHERE username = '" + uName + "'", conn);
                conn.Open();
                using(SqlDataReader dReader = stmt.ExecuteReader())
                {
                    while (dReader.Read())
                    {
                        generatedAccount.username = dReader["username"].ToString();
                        generatedAccount.name = dReader["name"].ToString();
                        generatedAccount.surname = dReader["surname"].ToString();
                        generatedAccount.address = dReader["address"].ToString();
                        generatedAccount.email = dReader["email"].ToString();
                        generatedAccount.password = dReader["password"].ToString();
                        generatedAccount.type = dReader["type"].ToString();

                    }
                }
            }
                
            return generatedAccount;
        }
    }
}
