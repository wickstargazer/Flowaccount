namespace Flowaccount.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Receipt : BaseModel, IDocument
    {
        public long Id { get; set; }
        public long CompanyId { get; set; }
        public ReceiptStatus Status { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public bool Published { get; set; }
        public bool Approved { get; set; }
        public string ApprovedBy { get; set; }
        public Nullable<long> ApprovedByClientId { get; set; }
        public string ApprovedImageUrl { get; set; }
        public string DocumentId { get; set; }
        public string DocumentSerial { get; set; }
        public long ClientCompanyId { get; set; }
        public long CreatedBy { get; set; }
        public decimal Value { get; set; }
        public decimal Collected { get; set; }
        public decimal Outstanding { get; set; }
        public string Name { get; set; }
        public decimal WithHeld { get; set; }
        public string Remarks { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<System.DateTime> ExpectedDate { get; set; }
        public Nullable<System.DateTime> BillingDate { get; set; }
        public string ReceiptSerial { get; set; }
        public string ReceiptDocumentId { get; set; }
        public Nullable<System.DateTime> ReceiptIssueDate { get; set; }
        public Nullable<int> Withholding { get; set; }
        public Nullable<decimal> Charge { get; set; }
        public Nullable<System.DateTime> DatePayment { get; set; }
        public string CheckNumber { get; set; }
        public string CheckBankId { get; set; }
        public string TransferBankId { get; set; }
        public Nullable<int> Tax { get; set; }
        public int VatRate { get; set; }
        public Nullable<int> MethodPayment { get; set; }
        public Nullable<System.DateTime> CheckDatePaid { get; set; }
        public System.DateTime PublishedOn { get; set; }
        public bool IsDelete { get; set; }
        public Nullable<long> GalleryId { get; set; }
        public bool IsVatInclusive { get; set; }
        public string InternalNotes { get; set; }
        public decimal RoundingAdjustment { get; set; }
        public Nullable<long> SalesId { get; set; }
        public string SalesName { get; set; }
        public System.DateTime DocumentDate { get; set; }
        public string BankAccountNumber { get; set; }
    
        public virtual Contact Contact { get; set; }
        public virtual Company Company { get; set; }
        public virtual Gallery Gallery { get; set; }
        public virtual User User { get; set; }
    }
}
