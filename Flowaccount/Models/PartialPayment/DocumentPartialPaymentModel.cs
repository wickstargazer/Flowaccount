using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount.Models.PartialPayment
{
    public class DocumentPartialPaymentModel
    {
        public string documentId { get; set; }
        public string documentSerial { get; set; } 
        public decimal value { get; set; }
        public decimal discountPercentage { get; set; }
        public decimal discountValue { get; set; }
        public string modifiedOn { get; set; }
        public List<ProductItemPartial> productItems { get; set; }
    }
}
