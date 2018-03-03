using Flowaccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount.Resources
{
    public class ProductUnitResource : BaseResource, IRetrievable<ProductUnit>
    {
        public ProductUnitResource(IRequest requester)
            : base(requester, Endpoint.Api, "/products") {
        }

        public async Task<IEnumerable<ProductUnit>> Search(string query)
        {
            return await Request.StartRequest<string, IEnumerable<ProductUnit>>(
                Endpoint,
                "POST",
                BasePath,
                query
            );
        }
    }
}
