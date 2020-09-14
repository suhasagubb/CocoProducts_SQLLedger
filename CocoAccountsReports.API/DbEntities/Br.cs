using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Br
    {
        public int Id { get; set; }
        public string Batchnumber { get; set; }
        public string Description { get; set; }
        public string Batch { get; set; }
        public DateTime? Transdate { get; set; }
        public DateTime? Apprdate { get; set; }
        public double? Amount { get; set; }
        public int? Managerid { get; set; }
        public int? EmployeeId { get; set; }
    }
}
