using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simada.Dashboard.Data
{
    public class Report
    {
        public int No { get; set; }
        public string Title { get; set; }
        public string ReportUrl { get; set; }
        public string[] Parameters { get; set; }
    }
}
