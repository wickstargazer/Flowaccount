namespace Flowaccount.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExpenseList : Document, IDocument
	{
        public new long Id { get; set; }
        public string ReceiptImage { get; set; }
        public string Description { get; set; }
        public long ExpenseCategoryId { get; set; }
        public System.DateTime ExpenseDate { get; set; }
        public bool Published { get; set; }
        public bool Approved { get; set; }
        public long ApprovedBy { get; set; }
        public bool IsTax { get; set; }
        public bool TaxRefundable { get; set; }
        public string BankAccountNumber { get; set; }
        public Nullable<int> PaymentMethod { get; set; }
        public decimal ValueIncludeVat { get; set; }
        public virtual ExpenseCategory ExpenseCategory { get; set; }
    }
}
