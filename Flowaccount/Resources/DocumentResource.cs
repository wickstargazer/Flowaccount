using Flowaccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Flowaccount.Resources
{
    public abstract class DocumentResource<T> : BaseResource
       where T : Document
    {
        public DocumentResource(IRequest requester, Endpoint endpoint, string basePath)
            : base(requester, Endpoint.Api, basePath) {
        }

        public async Task<APIResponse<T>> Get(long documentid)
        {
            return await Request.StartRequest<APIResponse<T>>(
                Endpoint,
                "GET",
                BasePath + documentid
            );
        }

        public async Task<APIResponse<DocumentListViewModel>> GetList(DocumentQuery query)
        {
			var _requestObject = query.ToKeyValue();
			var formUrlEncodedContent = new FormUrlEncodedContent(_requestObject);
			var urlEncodedString = await formUrlEncodedContent.ReadAsStringAsync();

			return await Request.StartRequest<APIResponse<DocumentListViewModel>>(
                Endpoint,
                "GET",
                BasePath + "?" + urlEncodedString
            );
        }

        public async Task<APIResponse<IEnumerable<long>>> Delete(List<long> ids)
        {
            return await Request.StartRequest<List<long>, APIResponse<IEnumerable<long>>>(
                Endpoint,
                "DELETE",
                BasePath,
                ids
            );
        }

        public async Task<APIResponse<IDocument>> Save(IDocument document) 
        {
            return await Request.StartRequest<IDocument, APIResponse<IDocument>>(
                Endpoint,
                "PUT",
                BasePath,
                document
            );
        }

        public async Task<APIResponse<IEnumerable<IDocument>>> Save(List<IDocument> document) 
        {
            return await Request.StartRequest<List<IDocument>, APIResponse<IEnumerable<IDocument>>>(
                Endpoint,
                "PUT",
                BasePath,
                document
            );
        }

		public async Task<APIResponse<T>> ChangeStatus(long documentid, System.Enum status)
		{
			return await Request.StartRequest<System.Enum, APIResponse<T>>(
				Endpoint,
				"POST",
				BasePath + documentid,
				status
			);
		}
	}
}
