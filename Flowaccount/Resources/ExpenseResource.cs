using Flowaccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount.Resources
{
    public class ExpenseResource : DocumentResource<ExpenseList>
	{
		public ExpenseResource(IRequest requester)
            : base(requester, Endpoint.Api, "/companies/expenses") {
		}


	}
}
