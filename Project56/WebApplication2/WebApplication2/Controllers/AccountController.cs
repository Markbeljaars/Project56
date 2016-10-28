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
            var conn = new MySqlConnection("server = localhost; user id = root; database = project56; password = msige602qd");
            conn.Open();

            var stmt = new MySqlCommand("SELECT * FROM users", conn);
            MySqlDataReader myReader = stmt.ExecuteReader();

            var account = new Account;

            while (myReader.Read())
            {
                ViewBag.Message = myReader.GetValue(0);
            }
                       
             = new Account() { Id = 1, name = "Admin", adress = "Wijnhaven 107" };
            return View(account);
        }
    }
}