namespace Flowaccount.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bank : BaseModel
    {
        public Bank()
        {
        }
    
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public int Id { get; set; }
        public string BankCode { get; set; }
    
        public virtual IList<BankAccount> BankAccount { get; set; }
        public virtual IList<ReconciledDocument> ReconciledDocument { get; set; }
    }
}
