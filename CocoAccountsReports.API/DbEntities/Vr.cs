using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Vr
    {
        public int? BrId { get; set; }
        public int TransId { get; set; }
        public int Id { get; set; }
        public string Vouchernumber { get; set; }

        public virtual Br Br { get; set; }
    }
}
