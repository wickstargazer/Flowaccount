using Flowaccount.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Flowaccount.Resources
{
    public class UserResource : BaseResource, IRetrievable<User>
    {
        public UserResource(IRequest requester)
            : base(requester, Endpoint.Api, "/companies/users") {
        }

		public async Task<Profile> GetMyInfo()
		{
			return await Request.StartRequest<Profile>(
				Endpoint,
				"GET",
				BasePath + "/me"
			);
		}

		public async Task<User> Get(long? userid)
        {
            return await Request.StartRequest<User>(
                Endpoint,
				"GET",
                BasePath + userid
            );
        }

        public async Task<User> GetPreferences(User _request)
        {
            return await Request.StartRequest<User, User>(
                Endpoint,
                "POST",
                BasePath,
                _request
            );
        }

        public async Task<APIResponse<User>> Save(User _request)
        {
            return await Request.StartRequest<User, APIResponse<User>> (
                Endpoint,
                "POST",
                BasePath,
                _request
            );
        }

        public async Task<APIResponse<string>> SaveSignature(string _request)
        {
            return await Request.StartRequest<string, APIResponse<string>>(
                Endpoint,
                "POST",
                BasePath,
                _request
            );
        }

        public async Task<APIResponse<IEnumerable<User>>> Delete(IList<long> _request)
        {
            return await Request.StartRequest<IList<long>, APIResponse<IEnumerable<User>>>(
                Endpoint,
                "POST",
                BasePath,
                _request
            );
        }

        public async Task<APIResponse<IEnumerable<User>>> ToggleActive(IList<long> _request)
        {
            return await Request.StartRequest<IList<long>, APIResponse<IEnumerable<User>>>(
                Endpoint,
                "POST",
                BasePath,
                _request
            );
        }

        public async Task<IEnumerable<User>> SearchByName(string query)
        {
            return await Request.StartRequest<string, IEnumerable<User>>(
                Endpoint,
                "POST",
                BasePath,
                query
            );
        }
    }
}
