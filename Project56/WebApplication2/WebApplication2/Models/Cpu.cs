using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Cpu
    {
        public string name { get; set; }
        public string series { get; set; }
        public string chipset { get; set; }
        public string memory { get; set; }
        public string core_clock { get; set; }
        public decimal? price { get; set; }
    }
}