using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount
{
    public interface IRoundTripper
    {
        HttpRequestMessage CreateRequest(string method, string uri);
        HttpClient GetClient();
        Task<HttpResponseMessage> Roundtrip(HttpRequestMessage request);
    }
}
