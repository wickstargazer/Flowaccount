using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount
{
    public delegate Key KeySelector(Credentials creds);
    public sealed partial class Credentials
    {
        public static readonly KeySelector UsePublicKey = new KeySelector(creds => creds.ClientId);
        public static readonly KeySelector UseSecretKey = new KeySelector(creds => creds.ClientSecret);
    }
    public sealed partial class Credentials
    {
        public Key ClientId { get; private set; }
        public Key ClientSecret { get; private set; }

        public Credentials(string pkey = null, string skey = null)
        {
            if (string.IsNullOrEmpty(pkey) && string.IsNullOrEmpty(skey))
            {
                throw new ArgumentException("pkey and skey can't both be null");
            }

            ClientId = pkey;
            ClientSecret = skey;
        }

        public override string ToString()
        {
            return string.Format("[Credentials: PublicKey={0}, SecretKey={1}]", ClientId, ClientSecret);
        }
    }
}
