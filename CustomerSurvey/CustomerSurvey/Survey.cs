using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerSurvey
{
    public class Survey
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int ResponseTime { get; set; }
        public int TechEfficiency { get; set; }
        public int Resolution { get; set; }
        public string Comments { get; set; }
        public string Phone { get; set; }
        public bool Contact { get; set; }
    }
}