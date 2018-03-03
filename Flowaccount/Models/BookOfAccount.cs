namespace Flowaccount.Models
{
    using System;
    using Flowaccount.Enum;

    public partial class BookOfAccount : BaseModel
    {
        public long DocumentId { get; set; }
        public DocumentTypes DocumentType { get; set; }
        public string ChartOfAccount { get; set; }
        public int Book { get; set; }
        public long CompanyId { get; set; }
        //public FinancialTransactionType DebitCredit { get; set; }
        public decimal Value { get; set; }
    }
}
