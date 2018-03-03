using Flowaccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
//using Tamir.SharpSsh;

namespace Flowaccount
{
    public class FTPRequest : IRequest
    {
        //Sftp client;
        Credentials _credentials;
        
        public FTPRequest(Credentials credentials)
        {
            _credentials = credentials;
        }

        public async Task<TResult> StartRequest<TResult>(
            Endpoint endpoint,
            string method,
            string path)
            where TResult : class
        {
            return await StartRequest<object, TResult>(endpoint, method, path, null);
        }

        public Task<TResult> StartRequest<TPayload, TResult>(
            Endpoint endpoint,
            string method,
            string path,
            TPayload payload)
			where TPayload : class
			where TResult : class
        {
            var _payload = (FTPRequestModel)(object)payload;
            //client = new Sftp(endpoint.ApiPrefix, _credentials.PublicKey, _credentials.SecretKey);
            //client.Connect();
            
            //client.Get(path, _payload.Output);
            //client.Close();

           

            //var _result =  Activator.CreateInstance(typeof(FTPResponsetModel).MakeGenericType(typeof(TResult)), true) as TResult;
            object _result = Activator.CreateInstance(typeof(TResult));
            ((FTPResponsetModel)_result).Success = true;
            ((FTPResponsetModel)_result).Output = _payload.Output;

            return Task.FromResult<TResult>((TResult)_result);
        }

        public void Roundtrip(string ip, Credentials cred, string uri, string output)
        {
            
           
        }
    }
}
