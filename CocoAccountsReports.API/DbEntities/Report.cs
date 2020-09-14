using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Report
    {
        public int Reportid { get; set; }
        public string Reportcode { get; set; }
        public string Reportdescription { get; set; }
        public string Login { get; set; }
    }
}
