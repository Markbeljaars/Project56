using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class AccountController : Controller
    {
        // GET: account/profile
        public ActionResult profile()
        {
            var conn = new MySqlConnection("Data Source=145.24.222.224,8080;Initial Catalog=Project56;User ID=abc;Password=***********");
            conn.Open();

            var stmt = new MySqlCommand("SELECT * FROM users", conn);
            MySqlDataReader myReader = stmt.ExecuteReader();

            var account = new Account();

            while (myReader.Read())
            {
                ViewBag.Message = myReader.GetValue(0);
            }
                       
             //= new Account() { Id = 1, name = "Admin", address = "Wijnhaven 107" };
            return View(account);
        }
    }
}