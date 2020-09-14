using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Business
    {
        public int? Id { get; set; }
        public string Description { get; set; }
        public float? Discount { get; set; }
        public int? Rn { get; set; }
    }
}
