namespace Flowaccount.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Purchase : Document, IDocument
    {
        public Purchase()
        {
            this.VatRate = 0;
        }
    
        public long VendorCompanyId { get; set; }
        public bool Published { get; set; }
        public bool Approved { get; set; }
        public Nullable<long> ApprovedBy { get; set; }
        public string ApprovedImageUrl { get; set; }
        public Nullable<System.DateTime> ExpectedDate { get; set; }
        public virtual User User { get; set; }
        public virtual User ApprovedByUser { get; set; }
    }
}
