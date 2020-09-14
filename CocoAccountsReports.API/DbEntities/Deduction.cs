using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Deduction
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int? EmployeeAccnoId { get; set; }
        public float? Employeepays { get; set; }
        public int? EmployerAccnoId { get; set; }
        public float? Employerpays { get; set; }
        public short? Fromage { get; set; }
        public short? Toage { get; set; }
        public bool? Agedob { get; set; }
        public int? Basedon { get; set; }
    }
}
