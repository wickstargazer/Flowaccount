
namespace Flowaccount.Models
{
    using System;
    public partial class BankAccount
    {
        public long CompanyId { get; set; }
        public string AccountNumber { get; set; }
        public int BankId { get; set; }
        public string Branch { get; set; }
        public string AccountName { get; set; }
        public int AccountType { get; set; }
        public Nullable<System.DateTime> LastReconciledDate { get; set; }
        public Nullable<System.DateTime> LastOutstandingBalanceDate { get; set; }
        public Nullable<System.DateTime> LastStatementDate { get; set; }
        public string LastStatementDocumentId { get; set; }
        public bool Synced { get; set; }
        public decimal OutstandingBalance { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public bool IsDefault { get; set; }
        public decimal LastAvailableBalance { get; set; }
        public decimal LastOutstandingBalance { get; set; }
    
        public virtual Bank Bank { get; set; }
        public virtual Company Company { get; set; }
    }
}
