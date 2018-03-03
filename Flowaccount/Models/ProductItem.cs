using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flowaccount.Enum;

namespace Flowaccount.Models
{
    public class ProductItem
    {
        public long? Id { get; set; }
        public int No { get; set; }
        public string ProductCode { get; set; }
        public string BarCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PricePerUnit { get; set; }
        public double DiscountPerItem { get; set; }
        public ProductDiscountTypes ProductDiscountTypes { get; set; }
        public int VATRate { get; set; }
        public string Quantity { get; set; }
        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public int UnitAmount { get; set; }
        public bool IsVat { get; set; }
        //public int Unit { get; set; }
        //public InvoiceUnit UnitType { get; set; }
        public ProductTypes Type { get; set; }
        public ProductTypes OriginalType { get; set; }
        public bool HasStock { get; set; }
        public bool AllowOverSold { get; set; }
        public bool IsBroughtForward { get; set; }

        public System.DateTime PublishedOn { get; set; }
        public virtual Company VendorCompany { get; set; }
        public double Total { get; set; }

        public long? DocumentId { get; set; }
        public int? DocumentType { get; set; }


        public string DocumentSerial { get; set; }
        public DateTime? DocumentPublishedOn { get; set; }
        public DateTime? DocumentDuedate { get; set; }
        public decimal? DocumentGrandTotal { get; set; }
        public string Remarks { get; set; }



        public bool returnStock { get; set; }
    }
}
