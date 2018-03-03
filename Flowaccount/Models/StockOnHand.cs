namespace Flowaccount.Models
{
    using System;

    public partial class StockOnHand
    {
        public long CompanyId { get; set; }
        public long ProductId { get; set; }
        public decimal Quantity { get; set; }
        public virtual Company Company { get; set; }
        public virtual Product ProductList { get; set; }
    }
}
