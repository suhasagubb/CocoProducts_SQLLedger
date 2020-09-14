using System;

namespace CocoAccountsReports.API.Models
{
    public class OutstandingReport
    {
        public DateTime InvoiceDate { get; set; }

        public string InvoiceNumber { get; set; }

        public string CustomerName { get; set; }

        public double Amount { get; set; }

        public double Paid { get; set; }

        public double Due { get; set; }
    }
}