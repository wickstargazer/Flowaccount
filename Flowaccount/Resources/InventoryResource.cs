using Flowaccount.Models;
using System.Threading.Tasks;

namespace Flowaccount.Resources
{
    public class InventoryResource : BaseResource
    {
        public InventoryResource(IRequest requester)
            : base(requester, Endpoint.Api, "") {
        }

        public async Task<Product> getInventoryList(long? companyId)
        {
            return await Request.StartRequest<Product>(
                Endpoint,
                "GET",
                BasePath + companyId
            );
        }


    }
}