using Flowaccount.Enum;
namespace Flowaccount.Models
{
    public partial class ReconciledDocument : BaseModel
    {
        public long DocumentId { get; set; }
        public DocumentTypes DocumentType { get; set; }
        public string TransactionId { get; set; }
        public decimal Amount { get; set; }
        public string FromAccount { get; set; }
        public string Channel { get; set; }
        public string Description { get; set; }
        public string AccountNumber { get; set; }
        public int BankId { get; set; }
       
        public long CompanyId { get; set; }
    
        public virtual Bank Bank { get; set; }
        public virtual Company Company { get; set; }
    }
}
