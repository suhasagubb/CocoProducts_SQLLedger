using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Sic
    {
        public string Code { get; set; }
        public char? Sictype { get; set; }
        public string Description { get; set; }
    }
}
