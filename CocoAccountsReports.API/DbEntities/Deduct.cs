using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Deduct
    {
        public int? TransId { get; set; }
        public int? DeductionId { get; set; }
        public bool? Withholding { get; set; }
        public float? Percent { get; set; }
    }
}
