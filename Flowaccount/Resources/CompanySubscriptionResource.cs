using Flowaccount.Models;
using System.Threading.Tasks;

namespace Flowaccount.Resources
{
    public class CompanySubscriptionResource : BaseResource, IRetrievable<CompanySubscription>
    {
        public CompanySubscriptionResource(IRequest requester)
            : base(requester, Endpoint.Api, "/companies") {
        }

        public async Task<CompanySubscription> GetInfo(long? userid)
        {
            return await Request.StartRequest<CompanySubscription>(
                Endpoint,
                "POST",
                BasePath + userid
            );
        }

    }
}
