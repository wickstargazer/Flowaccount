using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flowaccount.Enum;

namespace Flowaccount.Models
{
    public class Product : BaseModel
    {
        public Product()
        {
            this.MainUnitAmount = 1;
            this.SubUnitAmount = 1;
            this.VatRate = 0;
            
        }

        public long Id { get; set; }
        public string BarCode { get; set; }
        public string Name { get; set; }
        public string UnitMeasurement { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<decimal> UnitWeight { get; set; }
        public Nullable<long> CategoryId { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
        public Nullable<long> GalleryId { get; set; }
        public bool IsVat { get; set; }
        public Nullable<long> MainUnitId { get; set; }
        public Nullable<long> SubUnitId { get; set; }
        public int MainUnitAmount { get; set; }
        public int SubUnitAmount { get; set; }
        public bool HasStock { get; set; }
        public string ProductCode { get; set; }
        public ProductTypes Type { get; set; }
        public Nullable<decimal> BuyPrice { get; set; }
        public bool IsBuyVat { get; set; }
        public bool AllowOverSold { get; set; }
        public string Image { get; set; }
        public bool IsDelete { get; set; }
        public int VatRate { get; set; }

        public virtual IList<ProductInventory> ProductInventory { get; set; }
        public virtual Company Company { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual Gallery Gallery { get; set; }
        public virtual ProductUnit MainUnit { get; set; }
        public virtual ProductUnit SubUnit { get; set; }
        public virtual StockOnHand StockOnHand { get; set; }
    }
}