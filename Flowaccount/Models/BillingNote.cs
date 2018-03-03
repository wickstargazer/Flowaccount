using System;
using System.Collections.Generic;

namespace Flowaccount.Models
{
    public partial class BillingNote : Document, IDocument
    {
        public BillingNote()
        {
            this.VatRate = 0;
        }
    
        public bool Published { get; set; }
        public bool Approved { get; set; }
        public Nullable<long> ApprovedBy { get; set; }
        public Nullable<long> ApprovedByClientId { get; set; }
        public string ApprovedImageUrl { get; set; }
        public Nullable<System.DateTime> ExpectedDate { get; set; }
        public virtual User ApprovedByClient { get; set; }
        public virtual User CreatedByUser { get; set; }
        public virtual User ApprovedByUser { get; set; }
        public virtual IList<QuotationBillingNotePartialPayment> QuotationBillingNotePartialPayment { get; set; }
	}
}
