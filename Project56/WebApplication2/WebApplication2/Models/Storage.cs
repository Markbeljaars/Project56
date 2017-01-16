using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Storage
    {
        public string name { get; set; }
        public string form { get; set; }
        public string type { get; set; }
        public string capacity { get; set; }
        public string cache { get; set; }
        public decimal? cache_gb { get; set; }
        public string price { get; set; }
    }
}