using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Powersupply
    {
        public string name { get; set; }
        public string form { get; set; }
        public string watts { get; set; }
        public string modular { get; set; }
        public decimal? price { get; set; }

    }
}