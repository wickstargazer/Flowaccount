using Flowaccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount.Resources
{
    public class WithHoldingTaxResource : BaseResource
    {
        public WithHoldingTaxResource(IRequest requester)
            : base(requester, Endpoint.Api, "/invoices") {
        }

        public async Task<WithholdingTax> ListInvoices(long? userid)
        {
            return await Request.StartRequest<WithholdingTax>(
                Endpoint,
                "GET",
                BasePath + userid
            );
        }

        public async Task<WithholdingTax> GetInvoice(long? userid)
        {
            return await Request.StartRequest<WithholdingTax>(
                Endpoint,
                "GET",
                BasePath + userid
            );
        }

        public async Task<WithholdingTax> DeleteInvoice(long? userid)
        {
            return await Request.StartRequest<WithholdingTax>(
                Endpoint,
                "DELETE",
                BasePath + userid
            );
        }
        public async Task<WithholdingTax> CreateUpdateInvoice(long? userid)
        {
            return await Request.StartRequest<WithholdingTax>(
                Endpoint,
                "DELETE",
                BasePath + userid
            );
        }
    }
}
