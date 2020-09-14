using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Acsrole
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Acs { get; set; }
        public short? Rn { get; set; }
    }
}
