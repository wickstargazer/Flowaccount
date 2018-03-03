using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount.Models
{
    public partial class ContactBankAccount
    {
        public long ContactId { get; set; }
        public string AccountNumber { get; set; }
        public int BankId { get; set; }
        public string Branch { get; set; }
        public string AccountName { get; set; }
        public int AccountType { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public bool IsDelete { get; set; }


        public virtual Contact Contact { get; set; }
    }
}
