using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Paymentmethod
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double? Fee { get; set; }
        public int? Rn { get; set; }
        public float? Roundchange { get; set; }
    }
}
