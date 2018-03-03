namespace Flowaccount.Models
{
    using System;
    using System.Collections.Generic;
    using Flowaccount.Enum;

    public partial class ProductInventory : BaseModel
    {
        public ProductInventory()
        {
        }
    
        public long Id { get; set; }
        public long ProductId { get; set; }
        public decimal Count { get; set; }
        public InventoryType Type { get; set; }
        public string DocumentSerial { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public int RowIndex { get; set; }
        public bool IsDelete { get; set; }
        public decimal Quantity { get; set; }
        public DocumentTypes DocumentType { get; set; }
        public long DocumentId { get; set; }
        public decimal Total { get; set; }
        public long CompanyId { get; set; }
        public string Remarks { get; set; }
        public string Reason { get; set; }
        public System.DateTime PublishedOn { get; set; }
        public Nullable<System.DateTime> DocumentCreatedOn { get; set; }
    
        public virtual Product ProductList { get; set; }
        public virtual IList<ProductInventoryReference> OutReference { get; set; }
        public virtual IList<ProductInventoryReference> InReference { get; set; }
        public virtual Company Company { get; set; }
    }
}
