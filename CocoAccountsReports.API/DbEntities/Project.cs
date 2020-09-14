using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Project
    {
        public int? Id { get; set; }
        public string Projectnumber { get; set; }
        public string Description { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public int? PartsId { get; set; }
        public double? Production { get; set; }
        public double? Completed { get; set; }
        public int? CustomerId { get; set; }
    }
}
