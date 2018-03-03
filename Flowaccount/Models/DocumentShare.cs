namespace Flowaccount.Models
{
    using System;
    using System.Collections.Generic;
    using Flowaccount.Enum;

    public partial class DocumentShare : BaseModel
    {
        public long Id { get; set; }
        public string MongoDBObjectId { get; set; }
        public long DocumentId { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public long FromUserId { get; set; }
        public bool IsDelete { get; set; }
        public string HashKey { get; set; }
        public string PasswordHash { get; set; }
        public Nullable<bool> IsPasswordProtect { get; set; }
        public DocumentTypes DocumentTypes { get; set; }
    
        public virtual User User { get; set; }
    }
}
