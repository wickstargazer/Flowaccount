namespace Flowaccount.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class QuotationInvoicePartialPayment : BaseModel
    {
        public long Id { get; set; }
        public long QuotationId { get; set; }
        public long InvoiceId { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public System.DateTime PublishedOn { get; set; }
        public decimal Value { get; set; }
        public bool IsDelete { get; set; }
        public string Remarks { get; set; }
    
        public virtual Invoice Invoice { get; set; }
        public virtual Quotation Quotation { get; set; }
        public virtual User User { get; set; }
    }
}
