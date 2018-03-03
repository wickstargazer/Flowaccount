using Flowaccount.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Flowaccount.Enum;

namespace Flowaccount.Resources
{
    public class CompanyResource : BaseResource, IRetrievable<Company>
    {
        public CompanyResource(IRequest requester)
            : base(requester, Endpoint.Api, "/companies/") {
        }

		public async Task<Company> GetMyCompanyInfo()
		{
			return await Request.StartRequest<Company>(
				Endpoint,
				"GET",
				BasePath
			);
		}

		public async Task<Company> GetCompanyInfo(long? companyId)
        {
            return await Request.StartRequest<Company>(
                Endpoint,
                "GET",
                BasePath + companyId
			);
        }

        public async Task<Company> GetCompanyPreferences(Company _request)
        {
            return await Request.StartRequest<Company, Company>(
                Endpoint,
                "POST",
                BasePath,
                _request
            );
        }

        public async Task<APIResponse<Company>> SaveSettings(Company _request)
        {
            return await Request.StartRequest<Company, APIResponse<Company>>(
                Endpoint,
                "POST",
                BasePath,
                _request
            );
        }

        public async Task<APIResponse<string>> SaveLogo(String _request)
        {
            return await Request.StartRequest<String, APIResponse<String>>(
                Endpoint,
                "POST",
                BasePath,
                _request
            );
        }

        public async Task<APIResponse<String>> SaveStamp(String _request)
        {
            return await Request.StartRequest<String, APIResponse<String>>(
                Endpoint,
                "POST",
                BasePath,
                _request
            );
        }

        public async Task<APIResponse<CompanyPreferences>> SavePreferences(CompanyPreferences _request)
        {
            return await Request.StartRequest<CompanyPreferences, APIResponse<CompanyPreferences>>(
               Endpoint,
               "POST",
               BasePath,
               _request
           );
        }
        public async Task<APIResponse<CompanyPreferences>> SaveRunningNumber(CompanyPreferences _request, DocumentTypes _documentType)
        {
            return await Request.StartRequest<CompanyPreferences, APIResponse<CompanyPreferences>>(
               Endpoint,
               "POST",
               BasePath,
               _request
           );
        }

        public async Task<APIResponse<IEnumerable<User>>> GetUsers()
        {
            return await Request.StartRequest<APIResponse<IEnumerable<User>>> (
                Endpoint,
                "POST",
                BasePath
            );
        }

    }
}
