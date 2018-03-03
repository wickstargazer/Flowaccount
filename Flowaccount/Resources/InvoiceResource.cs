using Flowaccount.Models;
using Flowaccount.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount.Resources
{
    public class InvoiceResource : DocumentResource<Invoice>
    {
        public InvoiceResource(IRequest requester)
            : base(requester, Endpoint.Api, "/companies/tax-invoices/") {
        }

        public async Task<Invoice> ListInvoices(long? userid)
        {
            return await Request.StartRequest<Invoice>(
                Endpoint,
                "GET",
                BasePath + userid
            );
        }

        public async Task<Invoice> GetInvoice(long? userid)
        {
            return await Request.StartRequest<Invoice>(
                Endpoint,
                "GET",
                BasePath + userid
            );
        }

        public async Task<Invoice> DeleteInvoice(long? userid)
        {
            return await Request.StartRequest<Invoice>(
                Endpoint,
                "DELETE",
                BasePath + userid
            );
        }
        public async Task<Invoice> CreateUpdateInvoice(long? userid)
        {
            return await Request.StartRequest<Invoice>(
                Endpoint,
                "PUT",
                BasePath  + userid
            );
        }

    }
}
