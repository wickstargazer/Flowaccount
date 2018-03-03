using System;

namespace Flowaccount.Models
{
    
    public partial class CreditNote : Document, IDocument
    {
        public bool Published { get; set; }
        public bool Approved { get; set; }
        public string ApprovedBy { get; set; }
        public Nullable<long> ApprovedByClientId { get; set; }
        public string ApprovedImageUrl { get; set; }
        public long ClientCompanyId { get; set; }
        public decimal Collected { get; set; }
        public decimal Outstanding { get; set; }
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
        public Nullable<int> MethodPayment { get; set; }
        public Nullable<System.DateTime> CheckDatePaid { get; set; }
        public virtual User User { get; set; }
    }
}
