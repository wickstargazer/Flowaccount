namespace Flowaccount.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PurchaseOrder : Document, IDocument
    {
        public PurchaseOrder()
        {
            this.VatRate = 0;
        }
    
        public bool Published { get; set; }
        public bool Approved { get; set; }
        public Nullable<long> ApprovedBy { get; set; }
        public string ApprovedImageUrl { get; set; }
        public Nullable<System.DateTime> ExpectedDate { get; set; }
        public virtual User CreatedByUser { get; set; }
        public virtual User ApprovedByUser { get; set; }
    }
}
