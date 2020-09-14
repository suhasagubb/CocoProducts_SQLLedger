using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Archivedata
    {
        public int? ArchiveId { get; set; }
        public string Bt { get; set; }
        public int? Rn { get; set; }

        public virtual Archive Archive { get; set; }
    }
}
