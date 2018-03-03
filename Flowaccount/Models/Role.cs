

namespace Flowaccount.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Role : BaseModel
    {
        public Role()
        {
        }
    
        public new long Id { get; set; }
        public string Name { get; set; }
        public long Permission { get; set; }
        public bool IsShare { get; set; }
    
        public virtual IList<User> User { get; set; }
    }
}
