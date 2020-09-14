using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Semaphore
    {
        public int? Id { get; set; }
        public string Login { get; set; }
        public string Module { get; set; }
        public string Expires { get; set; }
    }
}
