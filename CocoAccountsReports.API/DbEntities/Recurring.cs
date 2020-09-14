using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Recurring
    {
        public int? Id { get; set; }
        public string Reference { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Nextdate { get; set; }
        public DateTime? Enddate { get; set; }
        public short? Repeat { get; set; }
        public string Unit { get; set; }
        public int? Howmany { get; set; }
        public bool? Payment { get; set; }
        public string Description { get; set; }
    }
}
