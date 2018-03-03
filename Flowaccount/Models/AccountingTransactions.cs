namespace Flowaccount.Models
{
    using System;

    public partial class AccountingTransactions : BaseModel
    {
        public new long Id { get; set; }
        public int Type { get; set; }
        public decimal Value { get; set; }
        public decimal VatRate { get; set; }
        public string DocumentId { get; set; }
        public string InternalNotes { get; set; }
        public DateTime PublishedOn { get; set; }
        public DateTime DocumentDate { get; set; }
        public bool IsVatInclusive { get; set; }
        public string BankAccountNumber { get; set; }
        public int BankId { get; set; }
        public long ContactCompanyId { get; set; }
        public int Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public long CreatedBy { get; set; }
        public string Name { get; set; }
        public string DocumentSerial { get; set; }
        public decimal RoundingAdjustMent { get; set; }
        public int BankAccountType { get; set; }
        public long CompanyId { get; set; }
    }
}
