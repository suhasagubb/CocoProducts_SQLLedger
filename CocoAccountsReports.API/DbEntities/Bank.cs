using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Bank
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Iban { get; set; }
        public string Qriban { get; set; }
        public string Bic { get; set; }
        public int? AddressId { get; set; }
        public string Dcn { get; set; }
        public string Rvc { get; set; }
        public string Membernumber { get; set; }
        public string Clearingnumber { get; set; }
    }
}
