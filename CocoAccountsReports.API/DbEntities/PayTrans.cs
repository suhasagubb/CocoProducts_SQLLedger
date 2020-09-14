using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class PayTrans
    {
        public int? TransId { get; set; }
        public int? Id { get; set; }
        public int? Glid { get; set; }
        public double? Qty { get; set; }
        public double? Amount { get; set; }
    }
}
