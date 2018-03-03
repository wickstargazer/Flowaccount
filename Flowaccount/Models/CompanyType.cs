using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flowaccount.Enum;

namespace Flowaccount.Models
{
    public partial class CompanyType
    {
        public CompanyType()
        {
            
        }

        public CompanyTypeEnum Id { get; set; }
        public string Name { get; set; }
    }
}
