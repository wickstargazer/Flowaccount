namespace Flowaccount.Models
{
    using System;
    using Flowaccount.Enum;

    public partial class CompanyTag : BaseModel
    {
        public string Tag { get; set; }
        public long DocumentId { get; set; }
        public bool IsSystemTag { get; set; }
        public long CompanyId { get; set; }
        public DocumentTypes DocumentType { get; set; }
        public Nullable<long> ReferenceDocumentId { get; set; }
    
        public virtual Company Company { get; set; }
    }
}
