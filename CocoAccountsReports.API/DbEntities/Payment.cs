using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Payment
    {
        public int Id { get; set; }
        public int TransId { get; set; }
        public double? Exchangerate { get; set; }
        public int? PaymentmethodId { get; set; }
    }
}
