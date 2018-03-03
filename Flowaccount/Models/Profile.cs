using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount.Models
{
	public class Profile : BaseModel
	{
		public Company Company { get; set; }
		public CompanySubscription CompanySubscription { get; set; }
		public PackageList PackageList { get;set;}
		public User User { get; set; }
		public Role Role { get; set; }
	}
}
