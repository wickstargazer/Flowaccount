


//



namespace Flowaccount.Models
{
    using System;
    using System.Collections.Generic;

    public partial class CompanySubscription : BaseModel
    {
        public long Id { get; set; }
        
        public long CompanyId { get; set; }
        public int PackageId { get; set; }
        public PackageStatus PackageStatus { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public string TransactionId { get; set; }
        public System.DateTime ExpirationDate { get; set; }
        public Nullable<int> CouponId { get; set; }
        public long PaidBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public int Days { get; set; }
        public int PackageDays { get; set; }

        public virtual Company Company { get; set; }
        public virtual PackageList PackageList { get; set; }
        public virtual User User { get; set; }
    }
}
