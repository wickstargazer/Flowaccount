using Flowaccount.Enum;
namespace Flowaccount.Models
{
    public partial class DocumentReference
    {
        public DocumentReference()
        {
            this.IsDelete = false;
        }

        public long ReferenceId { get; set; }
        public DocumentTypes ReferenceDocumentType { get; set; }
        public string ReferenceDocumentSerial { get; set; }
        public long DocumentId { get; set; }
        public DocumentTypes DocumentType { get; set; }
        public long CompanyId { get; set; }
        public string DocumentSerial { get; set; }
        public bool IsDelete { get; set; }
        public DocumentReferenceTypes Type { get; set; }
    
        public virtual Company Company { get; set; }
    }
}
