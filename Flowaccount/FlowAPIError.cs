using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount
{
    public class FlowAPIError : FlowAPIException
    {
        public ErrorResult Error { get; private set; }
        public HttpStatusCode HttpStatusCode { get { return Error.HttpStatusCode; } }
        public string Location { get { return Error.Location; } }
        public string Code { get { return Error.Code; } }
        public override string Message { get { return Error.Message; } }

        public FlowAPIError(
            ErrorResult result,
            Exception inner
        ) : base("API call result in an error.", inner)
        {
            Error = result;
        }

        public override string ToString()
        {
            return "(" + ((int)HttpStatusCode).ToString() + "/" + Code + ") " + Error.Message;
        }
    }
   
}
