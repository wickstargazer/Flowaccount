


//





namespace Flowaccount.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductUnit : BaseModel
    {
        public ProductUnit()
        {
        }
    
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsShare { get; set; }
        public bool IsDelete { get; set; }
    }
}
