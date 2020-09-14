using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Shipto
    {
        public int? TransId { get; set; }
        public string Shiptoname { get; set; }
        public string Shiptoaddress1 { get; set; }
        public string Shiptoaddress2 { get; set; }
        public string Shiptocity { get; set; }
        public string Shiptostate { get; set; }
        public string Shiptozipcode { get; set; }
        public string Shiptocountry { get; set; }
        public string Shiptocontact { get; set; }
        public string Shiptophone { get; set; }
        public string Shiptofax { get; set; }
        public string Shiptoemail { get; set; }
        public bool? Shiptorecurring { get; set; }
    }
}
