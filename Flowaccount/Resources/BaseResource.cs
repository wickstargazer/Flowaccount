using Flowaccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount.Resources
{
    public class BaseResource : IResource
    {
        public IRequest Request { get; private set; }
        public Endpoint Endpoint { get; private set; }
        public string BasePath { get; private set; }

        public BaseResource(IRequest requester, Endpoint endpoint, string basePath)
        {
            Request = requester;
            Endpoint = endpoint;
            BasePath = basePath;
        }
    }
}
