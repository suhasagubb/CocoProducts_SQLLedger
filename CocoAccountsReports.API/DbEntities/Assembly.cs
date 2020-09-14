using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Assembly
    {
        public int? Id { get; set; }
        public int? PartsId { get; set; }
        public double? Qty { get; set; }
        public bool? Bom { get; set; }
        public bool? Adj { get; set; }
        public int? Aid { get; set; }
    }
}
