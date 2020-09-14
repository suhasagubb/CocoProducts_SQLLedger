﻿using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Invoice
    {
        public int Id { get; set; }
        public int? TransId { get; set; }
        public int? PartsId { get; set; }
        public string Description { get; set; }
        public double? Qty { get; set; }
        public double? Allocated { get; set; }
        public double? Sellprice { get; set; }
        public double? Fxsellprice { get; set; }
        public float? Discount { get; set; }
        public bool? Assemblyitem { get; set; }
        public string Unit { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? Deliverydate { get; set; }
        public string Serialnumber { get; set; }
        public string Itemnotes { get; set; }
        public bool? Lineitemdetail { get; set; }
        public string Ordernumber { get; set; }
        public string Ponumber { get; set; }
        public double? Cost { get; set; }
        public string Vendor { get; set; }
        public int? VendorId { get; set; }
        public bool? Kititem { get; set; }
    }
}
