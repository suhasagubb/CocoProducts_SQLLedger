using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Cargo
    {
        public int Id { get; set; }
        public int TransId { get; set; }
        public string Package { get; set; }
        public double? Netweight { get; set; }
        public double? Grossweight { get; set; }
        public double? Volume { get; set; }
    }
}
