using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Tax
    {
        public int? ChartId { get; set; }
        public double? Rate { get; set; }
        public string Taxnumber { get; set; }
        public DateTime? Validto { get; set; }
    }
}
