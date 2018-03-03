using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount
{
    public class DefaultRoundtripper : IRoundTripper
    {
        readonly HttpClient client = new HttpClient();

        public HttpRequestMessage CreateRequest(string method, string uri)
        {
            return new HttpRequestMessage(new HttpMethod(method), uri);
        }

        public HttpClient GetClient()
        {
            return client;
        }

        public Task<HttpResponseMessage> Roundtrip(HttpRequestMessage request)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            return client.SendAsync(request);
        }
    }
}
