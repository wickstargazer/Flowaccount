using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount
{
    public interface IRequest
    {
        Task<TResult> StartRequest<TResult>(
            Endpoint endpoint,
            string method,
            string path)
            where TResult : class;

        Task<TResult> StartRequest<TPayload, TResult>(
            Endpoint endpoint,
            string method,
            string path,
            TPayload payload)
			where TPayload : class
			where TResult : class;
    }
   
}
