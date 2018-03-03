using System;
using System.Text;

namespace Flowaccount
{
    public struct Key
    {
        string value;

        public bool IsTest { get { return value.Contains("_test_"); } }
        public bool IsLive { get { return !IsTest; } }

        public string EncodeForAuthorizationHeader()
        {
            var encoded = Encoding.GetEncoding("ISO-8859-1").GetBytes(value + ":");
            return "Basic " + Convert.ToBase64String(encoded);
        }

        public string EncodeForOAuthorizationHeader()
        {
            return "Bearer " + value;
        }

        public static implicit operator Key(string value)
        {
            return new Key { value = value };
        }

        public static implicit operator string(Key key)
        {
            return key.value;
        }

        public override string ToString()
        {
            return this;
        }
    }
}

