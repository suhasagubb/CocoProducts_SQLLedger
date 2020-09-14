using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Makemodel
    {
        public int? PartsId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}
