using Flowaccount.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Flowaccount.Enum;

namespace Flowaccount.Resources
{
    public class SettingsResource : BaseResource, IRetrievable<Company>
    {
        public SettingsResource(IRequest requester)
            : base(requester, Endpoint.Api, "/settings/") {
        }

    }
}
