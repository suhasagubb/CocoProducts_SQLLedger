using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Gl
    {
        public int? Id { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public DateTime? Transdate { get; set; }
        public int? EmployeeId { get; set; }
        public string Notes { get; set; }
        public int? DepartmentId { get; set; }
        public bool? Approved { get; set; }
        public string Curr { get; set; }
        public double? Exchangerate { get; set; }
    }
}
