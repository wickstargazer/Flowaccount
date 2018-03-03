using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount
{
    public class FlowAPIException : Exception
    {
        public FlowAPIException()
        {
        }

        public FlowAPIException(string message) : base(message)
        {
        }

        public FlowAPIException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
