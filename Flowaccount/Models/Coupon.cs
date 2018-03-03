namespace Flowaccount.Models
{
    using System;
    using System.Collections.Generic;
    using Flowaccount.Enum;
    public partial class Coupon : BaseModel
    {
        public Coupon()
        {
            this.IsActive = false;
        }
    
        public new int Id { get; set; }
        public string Code { get; set; }
        public string Remarks { get; set; }
        public int Discount { get; set; }
        public System.DateTime ExpiryDate { get; set; }
        public Nullable<int> PackageId { get; set; }
        public bool IsActive { get; set; }
        public CouponType Type { get; set; }
    
    }
}
