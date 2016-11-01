using System;
using System.Collections.Generic;
using System.Data;
using System.Web.Mvc;
using WebApplication2.Models;
using System.Data.SqlClient;

namespace WebApplication2.Controllers
{
    public class AccountController : Controller
    {
        // GET: account/profile
        public ActionResult profile()
        {
            var conn = new SqlConnection("Data Source=145.24.222.224,8080;Initial Catalog=Project56;User ID=abc;Password=abc123");
            conn.Open();

            var stmt = new SqlCommand("SELECT * FROM Users", conn);

            var myReader = stmt.ExecuteReader();

            var account = new Account();

            while (myReader.Read())
            {
                ViewBag.Message = myReader.GetValue(0);
            }
                       
             //= new Account() { Id = 1, name = "Admin", address = "Wijnhaven 107" };
            return View(account);
        }

        public ActionResult register()
        {
            return View();
        }

        public ActionResult login()
        {
            ViewBag.Message = "Please enter your login details.";

            return View();
        }

        //[HttpPost]
        //public ActionResult Register(Account account) { 

        //    if (ModelState.IsValid)
        //    {
                
        //    }
        //}
        

        
    }
}