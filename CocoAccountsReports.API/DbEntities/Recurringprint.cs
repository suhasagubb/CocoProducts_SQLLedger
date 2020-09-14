using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Recurringprint
    {
        public int? Id { get; set; }
        public string Formname { get; set; }
        public string Format { get; set; }
        public string Printer { get; set; }
    }
}
