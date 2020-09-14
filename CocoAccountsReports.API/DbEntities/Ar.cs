using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Ar
    {
        public int? Id { get; set; }
        public string Invnumber { get; set; }
        public DateTime? Transdate { get; set; }
        public int? CustomerId { get; set; }
        public bool? Taxincluded { get; set; }
        public double? Amount { get; set; }
        public double? Netamount { get; set; }
        public double? Paid { get; set; }
        public DateTime? Datepaid { get; set; }
        public DateTime? Duedate { get; set; }
        public bool? Invoice { get; set; }
        public string Shippingpoint { get; set; }
        public short? Terms { get; set; }
        public string Notes { get; set; }
        public string Curr { get; set; }
        public string Ordnumber { get; set; }
        public int? EmployeeId { get; set; }
        public string Till { get; set; }
        public string Quonumber { get; set; }
        public string Intnotes { get; set; }
        public int? DepartmentId { get; set; }
        public string Shipvia { get; set; }
        public string LanguageCode { get; set; }
        public string Ponumber { get; set; }
        public bool? Approved { get; set; }
        public float? Cashdiscount { get; set; }
        public short? Discountterms { get; set; }
        public string Waybill { get; set; }
        public int? WarehouseId { get; set; }
        public string Description { get; set; }
        public bool? Onhold { get; set; }
        public double? Exchangerate { get; set; }
        public string Dcn { get; set; }
        public int? BankId { get; set; }
        public int? PaymentmethodId { get; set; }
    }
}
