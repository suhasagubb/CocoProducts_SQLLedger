using System;
using System.Collections.Generic;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class Contact
    {
        public int Id { get; set; }
        public int TransId { get; set; }
        public string Salutation { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Contacttitle { get; set; }
        public string Occupation { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public char? Gender { get; set; }
        public int? ParentId { get; set; }
        public string Typeofcontact { get; set; }
    }
}
