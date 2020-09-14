using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Payrate
    {
        public int? TransId { get; set; }
        public int? Id { get; set; }
        public double? Rate { get; set; }
        public double? Above { get; set; }
    }
}
