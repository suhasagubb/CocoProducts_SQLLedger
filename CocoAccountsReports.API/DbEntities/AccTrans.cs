using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class AccTrans
    {
        public int? TransId { get; set; }
        public int? ChartId { get; set; }
        public double? Amount { get; set; }
        public DateTime? Transdate { get; set; }
        public string Source { get; set; }
        public bool? Approved { get; set; }
        public bool? FxTransaction { get; set; }
        public int? ProjectId { get; set; }
        public string Memo { get; set; }
        public int? Id { get; set; }
        public DateTime? Cleared { get; set; }
        public int? VrId { get; set; }
    }
}
