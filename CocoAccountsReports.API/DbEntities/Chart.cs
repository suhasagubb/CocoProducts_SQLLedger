using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Chart
    {
        public int? Id { get; set; }
        public string Accno { get; set; }
        public string Description { get; set; }
        public char? Charttype { get; set; }
        public char? Category { get; set; }
        public string Link { get; set; }
        public string GifiAccno { get; set; }
        public bool? Contra { get; set; }
        public bool? Closed { get; set; }
    }
}
