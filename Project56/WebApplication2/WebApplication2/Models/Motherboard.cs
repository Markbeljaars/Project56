using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Motherboard
    {
        public string name { get; set; }
        public string socket { get; set; }
        public string formFactor { get; set; }
        public int ramSlots { get; set; }
        public int maxRam { get; set; }
        public decimal? price { get; set; } 

    }
}