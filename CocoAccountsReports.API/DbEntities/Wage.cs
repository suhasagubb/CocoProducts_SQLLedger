using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Wage
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double? Amount { get; set; }
        public int? Defer { get; set; }
        public bool? Exempt { get; set; }
        public int? ChartId { get; set; }
    }
}
