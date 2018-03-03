using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount
{
    public sealed partial class Endpoint
    {
        public static readonly Endpoint Api = new Endpoint(System.Configuration.ConfigurationManager.AppSettings["flowaccount-api-endpoint"], Credentials.UseSecretKey);
    }

    public sealed partial class Endpoint
    {
        public string ApiPrefix { get; private set; }
        public KeySelector KeySelector { get; private set; }

        public Endpoint(string apiPrefix, KeySelector keySelector = null)
        {
            if (string.IsNullOrEmpty(apiPrefix)) throw new ArgumentNullException("apiPrefix");
            if (keySelector == null) keySelector = Credentials.UseSecretKey;
            ApiPrefix = apiPrefix;
            KeySelector = keySelector;
        }
    }
}
