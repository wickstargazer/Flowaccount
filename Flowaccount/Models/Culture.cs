using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flowaccount.Enum;

namespace Flowaccount.Models
{
    public partial class Culture
    {
        public Culture()
        {
            this.User = new HashSet<User>();
            this.User1 = new HashSet<User>();
        }

        public long Id { get; set; }
        public CultureType CultureCode { get; set; }
        public string CultureName { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }

        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<User> User1 { get; set; }
    }
}
