namespace Flowaccount.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Media : BaseModel
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public Nullable<int> OrderNumber { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public bool IsDisplay { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<long> GalleryId { get; set; }
        public int MediaType { get; set; }
        public long CompanyId { get; set; }
        public long UserId { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Gallery Gallery { get; set; }
        public virtual User User { get; set; }
    }
}
