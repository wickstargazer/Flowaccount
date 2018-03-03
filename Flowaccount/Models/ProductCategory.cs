namespace Flowaccount.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductCategory : BaseModel
    {
        public ProductCategory()
        {
        }
    
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsDelete { get; set; }
    
        public virtual IList<Product> ProductList { get; set; }
        public virtual IList<Company> Company { get; set; }
    }
}
