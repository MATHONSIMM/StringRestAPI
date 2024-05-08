using Antlr.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace StringRestAPI.Models
{
    public class Strings
    {
        public string Account { get; set; }
        public string Company { get; set; }
        public string Division { get; set; }
        public string SubDivision { get; set; }
        public string Department { get; set; }
        public string Partner { get; set; }
        public string Class { get; set; }
        public string Scheme { get; set; }

    }
}