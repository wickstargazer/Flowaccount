using Flowaccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount.Resources
{
    public class BillingNoteResource : DocumentResource<BillingNote>
    {
        public BillingNoteResource(IRequest requester)
            : base(requester, Endpoint.Api, "/companies/billing-notes") {
        }

        
    }
}
