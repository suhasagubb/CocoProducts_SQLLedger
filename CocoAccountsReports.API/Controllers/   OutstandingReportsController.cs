using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CocoAccountsReports.API.DbEntities;
using CocoAccountsReports.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CocoAccountsReports.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OutstandingReportsController : ControllerBase
    {
        private readonly ILogger<OutstandingReportsController> logger;

        private readonly CocoAccountsContext context;

        public OutstandingReportsController(ILogger<OutstandingReportsController> logger, CocoAccountsContext context)
        {
            this.logger = logger;
            this.context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var outstandingARs = context.Ar.Where(ar => ar.Amount - ar.Paid != 0).ToList();

            if  (outstandingARs == null || outstandingARs.Count <= 0)
            {
                logger.LogWarning("No AR transactions available");
                return NoContent();
            }

            var allCustomers = context.Customer.ToList();

            var reports = outstandingARs?.Select(ar => new OutstandingReport() {
                InvoiceDate = ar.Transdate ?? default(DateTime),
                InvoiceNumber = ar.Invnumber,
                CustomerName = allCustomers.FirstOrDefault(c => c.Id == ar.CustomerId)?.Name,
                Amount = ar.Amount ?? default(double)  ,
                Paid = ar.Paid ?? default(double),
                Due = ar.Amount - ar.Paid ?? default(double)
            });

            return Ok(reports);
        }
    }
}
