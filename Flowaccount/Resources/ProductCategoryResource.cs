using Flowaccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount.Resources
{
    public class ProductCategoryResource : BaseResource, IRetrievable<ProductCategory>
    {
        public ProductCategoryResource(IRequest requester)
            : base(requester, Endpoint.Api, "/products") {
        }

        public async Task<IEnumerable<ProductCategory>> Search(string query)
        {
            return await Request.StartRequest<string, IEnumerable<ProductCategory>>(
                Endpoint,
                "POST",
                BasePath,
                query
            );
        }
    }
}
