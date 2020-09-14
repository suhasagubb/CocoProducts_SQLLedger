using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Parts
    {
        public int? Id { get; set; }
        public string Partnumber { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public double? Listprice { get; set; }
        public double? Sellprice { get; set; }
        public double? Lastcost { get; set; }
        public DateTime? Priceupdate { get; set; }
        public double? Weight { get; set; }
        public double? Onhand { get; set; }
        public string Notes { get; set; }
        public bool? Makemodel { get; set; }
        public bool? Assembly { get; set; }
        public bool? Alternate { get; set; }
        public double? Rop { get; set; }
        public int? InventoryAccnoId { get; set; }
        public int? IncomeAccnoId { get; set; }
        public int? ExpenseAccnoId { get; set; }
        public string Bin { get; set; }
        public bool? Obsolete { get; set; }
        public bool? Bom { get; set; }
        public string Image { get; set; }
        public string Drawing { get; set; }
        public string Microfiche { get; set; }
        public int? PartsgroupId { get; set; }
        public int? ProjectId { get; set; }
        public double? Avgcost { get; set; }
        public string TariffHscode { get; set; }
        public string Countryorigin { get; set; }
        public string Barcode { get; set; }
        public string Toolnumber { get; set; }
        public string Lot { get; set; }
        public DateTime? Expires { get; set; }
        public bool? Checkinventory { get; set; }
    }
}
