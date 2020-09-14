using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Status
    {
        public int? TransId { get; set; }
        public string Formname { get; set; }
        public bool? Printed { get; set; }
        public bool? Emailed { get; set; }
        public string Spoolfile { get; set; }
    }
}
