using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Department
    {
        public int? Id { get; set; }
        public string Description { get; set; }
        public char? Role { get; set; }
        public int? Rn { get; set; }
    }
}
