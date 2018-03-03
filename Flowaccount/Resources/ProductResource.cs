using Flowaccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount.Resources
{
    public class ProductResource : BaseResource, IRetrievable<Product>
    {
        public ProductResource(IRequest requester)
            : base(requester, Endpoint.Api, "/products") {
        }

        public async Task<IEnumerable<Product>> Search(string query)
        {
            return await Request.StartRequest<string, IEnumerable<Product>>(
                Endpoint,
                "POST",
                BasePath,
                query
            );
        }

        public async Task<APIResponse<Product>> Save(Product _request)
        {
            return await Request.StartRequest<Product, APIResponse<Product>>(
                Endpoint,
                "POST",
                BasePath,
                _request
            );
        }
    }
}
