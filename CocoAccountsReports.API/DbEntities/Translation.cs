using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Translation
    {
        public int? TransId { get; set; }
        public string LanguageCode { get; set; }
        public string Description { get; set; }
    }
}
