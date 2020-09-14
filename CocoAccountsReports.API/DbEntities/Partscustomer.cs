using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Partscustomer
    {
        public int? PartsId { get; set; }
        public int? CustomerId { get; set; }
        public int? PricegroupId { get; set; }
        public double? Pricebreak { get; set; }
        public double? Sellprice { get; set; }
        public DateTime? Validfrom { get; set; }
        public DateTime? Validto { get; set; }
        public string Curr { get; set; }
    }
}
