using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Reportvars
    {
        public int Reportid { get; set; }
        public string Reportvariable { get; set; }
        public string Reportvalue { get; set; }
    }
}
