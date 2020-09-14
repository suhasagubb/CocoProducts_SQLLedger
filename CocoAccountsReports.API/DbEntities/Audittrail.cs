using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Audittrail
    {
        public int? TransId { get; set; }
        public string Tablename { get; set; }
        public string Reference { get; set; }
        public string Formname { get; set; }
        public string Action { get; set; }
        public DateTime? Transdate { get; set; }
        public int? EmployeeId { get; set; }
    }
}
