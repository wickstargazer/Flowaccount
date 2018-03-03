using Flowaccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount
{
    public interface IRetrievable<TModel> : IResource
    {
    }

    public interface IListRetrievable<TModel> : IResource
    {
    }

    public static class Retrievables
    {
        public static async Task<TResult> Get<TResult>(
            this IRetrievable<TResult> resource
        ) where TResult : BaseModel
        {
            return await resource.Request.StartRequest<TResult>(
                resource.Endpoint,
                "GET",
                resource.BasePath
            );
        }

        public static async Task<TResult> Get<TResult>(
            this IListRetrievable<TResult> resource,
            string modelId
        ) where TResult : BaseModel
        {
            return await resource.Request.StartRequest<TResult>(
                resource.Endpoint,
                "GET",
                resource.BasePath + "/" + modelId
            );
        }
    }
}
