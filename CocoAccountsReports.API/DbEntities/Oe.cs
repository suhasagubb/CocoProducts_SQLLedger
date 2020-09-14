using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Oe
    {
        public int? Id { get; set; }
        public string Ordnumber { get; set; }
        public DateTime? Transdate { get; set; }
        public int? VendorId { get; set; }
        public int? CustomerId { get; set; }
        public double? Amount { get; set; }
        public double? Netamount { get; set; }
        public DateTime? Reqdate { get; set; }
        public bool? Taxincluded { get; set; }
        public string Shippingpoint { get; set; }
        public string Notes { get; set; }
        public string Curr { get; set; }
        public int? EmployeeId { get; set; }
        public bool? Closed { get; set; }
        public bool? Quotation { get; set; }
        public string Quonumber { get; set; }
        public string Intnotes { get; set; }
        public int? DepartmentId { get; set; }
        public string Shipvia { get; set; }
        public string LanguageCode { get; set; }
        public string Ponumber { get; set; }
        public short? Terms { get; set; }
        public string Waybill { get; set; }
        public int? WarehouseId { get; set; }
        public string Description { get; set; }
        public int? AaId { get; set; }
        public double? Exchangerate { get; set; }
        public bool? Backorder { get; set; }
    }
}
