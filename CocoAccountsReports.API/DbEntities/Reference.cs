using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Reference
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? TransId { get; set; }
        public string Description { get; set; }
        public int? ArchiveId { get; set; }
        public string Login { get; set; }
        public string Formname { get; set; }
        public string Folder { get; set; }
    }
}
