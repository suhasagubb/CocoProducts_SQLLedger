using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Inventory
    {
        public int? Id { get; set; }
        public int? WarehouseId { get; set; }
        public int? PartsId { get; set; }
        public int? TransId { get; set; }
        public int? OrderitemsId { get; set; }
        public double? Qty { get; set; }
        public DateTime? Shippingdate { get; set; }
        public int? EmployeeId { get; set; }
    }
}
