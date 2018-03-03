using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount
{
    public class ErrorResult
    {
        [JsonProperty("location")]
        public string Location { get; protected internal set; }

        [JsonIgnore]
        public HttpStatusCode HttpStatusCode { get; protected internal set; }

        [JsonProperty("code")]
        public string Code { get; protected internal set; }

        [JsonProperty("message")]
        public string Message { get; protected internal set; }
    }
}
