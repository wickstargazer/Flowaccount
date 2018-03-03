using Flowaccount.Enum;

namespace Flowaccount.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class WithholdingTax : BaseModel, IDocument
    {
        public new long Id { get; set; }
        public long VendorCompanyId { get; set; }
        public long CompanyId { get; set; }
        public WithholdingTaxStatus Status { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime PublishedOn { get; set; }
        public string DocumentSerial { get; set; }
        public string DocumentId { get; set; }
        public WithHoldingTaxType Entity { get; set; }
        public WithHoldingTaxIncomeType IncomeType { get; set; }
        public decimal Income { get; set; }
        public decimal IncomeNoVat { get; set; }
        public decimal Value { get; set; }
        public bool IsVat { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxAmount { get; set; }
        public bool IsDelete { get; set; }
        public Nullable<long> GalleryId { get; set; }
        public int VatRate { get; set; }
        public string TextOther { get; set; }
        public string Remarks { get; set; }
        public TaxType TaxType { get; set; }
        public string InternalNotes { get; set; }
        public decimal RoundingAdjustment { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public string Name { get; set; }
        public System.DateTime DocumentDate { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual Gallery Gallery { get; set; }
    }
}
