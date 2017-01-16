using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Videocard
    {
        public string name { get; set; }
        public string series { get; set; }
        public string chipset { get; set; }
        public string memory { get; set; }
        public string coreclock { get; set; }
        public decimal? price { get; set; }

    }
}