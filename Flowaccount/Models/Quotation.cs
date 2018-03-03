namespace Flowaccount.Models
{
    using System;
    using System.Collections.Generic;
    using Flowaccount.Enum;
    public partial class Quotation : Document, IDocument
    {
        public Quotation()
        {
            this.VatRate = 0;
           
        }
    
        public bool Published { get; set; }
        public bool Approved { get; set; }
        public Nullable<long> ApprovedBy { get; set; }
        public Nullable<long> ApprovedByClientId { get; set; }
        public string ApprovedImageUrl { get; set; }
        public Nullable<System.DateTime> ExpectedDate { get; set; }
        public virtual User ApprovedByUser { get; set; }
        public virtual User CreatedByUser { get; set; }
        public virtual ICollection<QuotationBillingNotePartialPayment> QuotationBillingNotePartialPayment { get; set; }
        public virtual ICollection<QuotationInvoicePartialPayment> QuotationInvoicePartialPayment { get; set; }
    }
}
