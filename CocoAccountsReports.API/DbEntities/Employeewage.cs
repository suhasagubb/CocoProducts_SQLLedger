using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Employeewage
    {
        public int? Id { get; set; }
        public int? EmployeeId { get; set; }
        public int? WageId { get; set; }
    }
}
