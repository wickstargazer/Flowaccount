using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount.Models
{
    public class InventoryHistoryModel : BaseModel
    {
        public long Id { get; set; }
        public string DocumentSerial { get; set; }
        public string PurchaseDate { get; set; }
        public DateTime Date { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string UnitName { get; set; }
        public string StockUnitName { get; set; }
        public string Type { get; set; }
        public string DocumentType { get; set; }
        public decimal Stock { get; set; }
        public string DocumentId { get; set; }
        public bool AllowDelete { get; set; }

    }
}
