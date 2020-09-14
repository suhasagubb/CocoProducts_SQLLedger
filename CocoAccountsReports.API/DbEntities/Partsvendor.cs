using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Partsvendor
    {
        public int? VendorId { get; set; }
        public int? PartsId { get; set; }
        public string Partnumber { get; set; }
        public short? Leadtime { get; set; }
        public double? Lastcost { get; set; }
        public string Curr { get; set; }
    }
}
