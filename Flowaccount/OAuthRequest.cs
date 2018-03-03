using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using Flowaccount.Models;

namespace Flowaccount
{
    public class OAuthRequest : IRequest
    {
        readonly string userAgent;

        public Credentials Credentials { get; private set; }
        public string APIVersion { get; set; }

        public IRoundTripper Roundtripper { get; private set; }
        public Serializer Serializer { get; private set; }

        public OAuthRequest(
            Credentials creds,
            IRoundTripper roundtripper = null,
            string apiVersion = null
        )
        {
            if (creds == null) throw new ArgumentNullException("creds");

            var metadata = new Dictionary<string, string>
            {
                { "Flowaccount.Net", new AssemblyName(GetType().Assembly.FullName).Version.ToString() },
                { ".Net", new AssemblyName(typeof(object).Assembly.FullName).Version.ToString() },
            };

            userAgent = metadata.Aggregate("", (acc, pair) => acc + " " + pair.Key + "/" + pair.Value).Trim();

            Credentials = creds;
            APIVersion = apiVersion;

            Roundtripper = roundtripper ?? new DefaultRoundtripper();
            Serializer = new Serializer();
        }

        public async Task<TResult> StartRequest<TResult>(
            Endpoint endpoint,
            string method,
            string path)
            where TResult : class
        {
            return await StartRequest<object, TResult>(endpoint, method, path, null);
        }

        public async Task<TResult> StartRequest<TPayload, TResult>(
            Endpoint endpoint,
            string method,
            string path,
            TPayload payload)
			where TPayload : class
			where TResult : class
        {

            var key = endpoint.KeySelector(Credentials);

            // creates initial request
            // TODO: Dispose request.
            var request = Roundtripper.CreateRequest(method, endpoint.ApiPrefix + path);
            request.Headers.Accept.Clear();
            request.Headers.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            request.Headers.Add("Authorization", key.EncodeForOAuthorizationHeader());
            request.Headers.Add("User-Agent", userAgent);
            if (!string.IsNullOrEmpty(APIVersion))
            {
                request.Headers.Add("Flowaccount-Version", APIVersion);
            }
			try
			{
				if (payload != null)
				{
					request.Content = Serializer.ExtractJsonValue<TPayload>(payload);
				}

				ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
				var response = await Roundtripper.Roundtrip(request);
				var stream = await response.Content.ReadAsStreamAsync();
				if (!response.IsSuccessStatusCode)
				{
					var error = Serializer.JsonDeserialize<ErrorResult>(stream);
					error.HttpStatusCode = response.StatusCode;
					throw new FlowAPIError(error, null);
				}
                //var apiResponse = Serializer.JsonDeserialize<TResult>(stream);
                           var apiResponse = Serializer.JsonDeserialize<APIResponse<TResult>>(stream);
                var result = apiResponse.Data;
                var model = result as BaseModel;
                if (model != null)
                {
                    model.Request = this;
                }
                return result;
                //return null;
			}
			catch (HttpRequestException e)
			{
				throw new FlowAPIException("Error while making HTTP request", e);
			}
        }
    }
}

