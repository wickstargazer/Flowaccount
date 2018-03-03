using Flowaccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount
{
    public interface IResource
    {
        IRequest Request { get; }

        Endpoint Endpoint { get; }
        string BasePath { get; }
    }
}
