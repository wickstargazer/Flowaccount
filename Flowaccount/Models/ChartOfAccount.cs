


//





namespace Flowaccount.Models
{
    using System;
    using System.Collections.Generic;

    public partial class ChartOfAccount : BaseModel
    {
        public string Id { get; set; }
        public long CompanyId { get; set; }
        public string Name { get; set; }
        public int Category { get; set; }
        public string ParentId { get; set; }
        public bool IsFolder { get; set; }
    }
}
