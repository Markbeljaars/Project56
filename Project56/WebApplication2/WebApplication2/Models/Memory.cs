using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Memory
    {
        public string name { get; set; }
        public string speed { get; set; }
        public string type { get; set; }
        public int cas { get; set; }
        public string modules { get; set; }
        public string size { get; set; }
        public decimal? price { get; set; }
        public int ID { get; set; }


    }
}