using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Workphone { get; set; }
        public string Workfax { get; set; }
        public string Workmobile { get; set; }
        public string Homephone { get; set; }
        public string Homemobile { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public string Notes { get; set; }
        public bool? Sales { get; set; }
        public string Email { get; set; }
        public string Ssn { get; set; }
        public string Employeenumber { get; set; }
        public DateTime? Dob { get; set; }
        public short? Payperiod { get; set; }
        public int? Apid { get; set; }
        public int? Paymentid { get; set; }
        public int? PaymentmethodId { get; set; }
        public int? AcsroleId { get; set; }
        public string Acs { get; set; }
    }
}
