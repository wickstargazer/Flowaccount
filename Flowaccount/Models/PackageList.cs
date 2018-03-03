namespace Flowaccount.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PackageList : BaseModel
    {
        public PackageList()
        {
        }
    
        public int Id { get; set; }
        public string PackageName { get; set; }
        public string Description { get; set; }
        public string Configuration { get; set; }
        public string Remarks { get; set; }
        public string DisplayNameTH { get; set; }
        public string DisplayNameEN { get; set; }
    
        public virtual ICollection<Company> Company { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<CompanySubscription> CompanySubscription { get; set; }
    }
}
