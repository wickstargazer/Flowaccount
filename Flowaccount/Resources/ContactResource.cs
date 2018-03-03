using Flowaccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount.Resources
{
    public class ContactResource : BaseResource, IRetrievable<Contact>
    {

        public ContactResource(IRequest requester)
            : base(requester, Endpoint.Api, "/contacts") {
        }

        public async Task<IEnumerable<Contact>> Search(string query)
        {
            return await Request.StartRequest<string, IEnumerable<Contact>>(
                Endpoint,
                "POST",
                BasePath,
                query
            );
        }
    }
}
