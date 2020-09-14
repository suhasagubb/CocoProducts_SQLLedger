using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Recurringemail
    {
        public int? Id { get; set; }
        public string Formname { get; set; }
        public string Format { get; set; }
        public string Message { get; set; }
    }
}
