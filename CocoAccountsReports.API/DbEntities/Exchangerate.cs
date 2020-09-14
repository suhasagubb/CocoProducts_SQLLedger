using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Exchangerate
    {
        public string Curr { get; set; }
        public DateTime? Transdate { get; set; }
        public double? Exchangerate1 { get; set; }
    }
}
