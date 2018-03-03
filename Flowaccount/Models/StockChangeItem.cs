using System;

namespace Flowaccount.Models
{
    public class StockChangeItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int RowIndex { get; set; }
        public bool IsUpdate { get; set; }
        public bool IsPriceUpdate { get; set; }
        public bool IsDateUpdate { get; set; }
        public bool IsEnough { get; set; }
        public decimal Quantity { get; set; }
        public decimal TempQuantity { get; set; }
        public decimal PricePerUnit { get; set; }
        public decimal AvailableQuantity { get; set; }
        public bool AllowOverSold { get; set; }
        public bool IsDelete { get; set; }
    }
}
