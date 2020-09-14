using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Jcitems
    {
        public int? Id { get; set; }
        public int? ProjectId { get; set; }
        public int? PartsId { get; set; }
        public string Description { get; set; }
        public double? Qty { get; set; }
        public double? Allocated { get; set; }
        public double? Sellprice { get; set; }
        public double? Fxsellprice { get; set; }
        public string Serialnumber { get; set; }
        public DateTime? Checkedin { get; set; }
        public DateTime? Checkedout { get; set; }
        public int? EmployeeId { get; set; }
        public string Notes { get; set; }
    }
}
