using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Deductionrate
    {
        public short? Rn { get; set; }
        public int? TransId { get; set; }
        public double? Rate { get; set; }
        public double? Amount { get; set; }
        public double? Above { get; set; }
        public double? Below { get; set; }
    }
}
