using Flowaccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount.Resources
{
    public class DebitNoteResource : DocumentResource<DebitNote>
    {
        public DebitNoteResource(IRequest requester)
            : base(requester, Endpoint.Api, "/creditnotes") {
        }
    }
}
