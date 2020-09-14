using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Recent
    {
        public int? Id { get; set; }
        public int? EmployeeId { get; set; }
        public int ObjectId { get; set; }
        public string Code { get; set; }
    }
}
