using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount.Models
{
    public class ProductItemPartial : BaseModel
    {
        public string id { get; set; }
        public string barcode { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal pricePerUnit { get; set; }
        public decimal quantity { get; set; }
        public decimal total
        {
            get
            {
                return this.pricePerUnit * this.quantity;
            }
        }

    }
}
