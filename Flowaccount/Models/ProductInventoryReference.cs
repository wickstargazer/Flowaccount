namespace Flowaccount.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductInventoryReference : BaseModel
    {
        public long Id { get; set; }
        public long OutReference { get; set; }
        public long InReference { get; set; }
        public decimal Amount { get; set; }
        public bool IsDelete { get; set; }
    
        public virtual ProductInventory InventoryOut { get; set; }
        public virtual ProductInventory InventoryIn { get; set; }
    }
}
