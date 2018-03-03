using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount.Models
{
    public class OutstandingDocument : BaseModel
    {
        public String InvoiceId { get; set; }
        public String Customer { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? Expected { get; set; }
        public DateTime? BillingDate { get; set; }
        public decimal Value { get; set; }
        public decimal Collected { get; set; }
        public decimal WithHeld { get; set; }
        public decimal? Outstanding { get; set; }
        public String Status { get; set; }
        public String Reference { get; set; }
        public String SalesMan { get; set; }
        public String ClientEmail { get; set; }
        public String id { get; set; }
        public bool AllowDelete { get; set; }
        public String Type { get; set; }
        public int VATRate { get; set; }
        public DateTime? DatePayment { get; set; }
    }
}
