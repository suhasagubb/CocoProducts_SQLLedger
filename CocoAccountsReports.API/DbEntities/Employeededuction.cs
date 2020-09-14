using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Employeededuction
    {
        public int? Id { get; set; }
        public int? EmployeeId { get; set; }
        public int? DeductionId { get; set; }
        public double? Exempt { get; set; }
        public double? Maximum { get; set; }
    }
}
