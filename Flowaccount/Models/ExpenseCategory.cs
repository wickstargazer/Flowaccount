namespace Flowaccount.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExpenseCategory : BaseModel
    {
        public ExpenseCategory()
        {
           
        }
    
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsShare { get; set; }
        public bool IsDelete { get; set; }
    
        public virtual IList<ExpenseList> ExpenseList { get; set; }
        public virtual IList<Company> Company { get; set; }
    }
}
