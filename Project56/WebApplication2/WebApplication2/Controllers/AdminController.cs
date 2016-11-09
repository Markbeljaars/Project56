using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.DAL;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class AdminController : Controller
    {

        private AccountContext ac = new AccountContext();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public string test()
        {
            return "test ";
        }

        
        public ActionResult table()
        {
            return View();
        }
    }
}