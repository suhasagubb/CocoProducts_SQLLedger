using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public short? Terms { get; set; }
        public bool? Taxincluded { get; set; }
        public string Customernumber { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public int? BusinessId { get; set; }
        public string Taxnumber { get; set; }
        public string SicCode { get; set; }
        public float? Discount { get; set; }
        public double? Creditlimit { get; set; }
        public int? EmployeeId { get; set; }
        public string LanguageCode { get; set; }
        public int? PricegroupId { get; set; }
        public string Curr { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public int? ArapAccnoId { get; set; }
        public int? PaymentAccnoId { get; set; }
        public int? DiscountAccnoId { get; set; }
        public float? Cashdiscount { get; set; }
        public short? Discountterms { get; set; }
        public double? Threshold { get; set; }
        public int? PaymentmethodId { get; set; }
        public bool? Remittancevoucher { get; set; }
        public int? PrepaymentAccnoId { get; set; }
    }
}
