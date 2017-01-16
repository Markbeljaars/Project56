using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Case
    {
        public string name { get; set; }
        public string type { get; set; }
        public int ext { get; set; }
        public int Int { get; set; } //DB NEEDS TO CHANGE THE VALUE
        public decimal? price { get; set; }


    }
}