namespace Flowaccount.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Gallery : BaseModel
    {
        public Gallery()
        {
           
        }
    
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    
        public virtual IList<Media> Media { get; set; }
    }
}
