using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PruebaTecnicaJavierCalles.RemoteServices
{
    public class RestApiConsumer
    {
        private readonly RestClient _restClient;
        public RestApiConsumer(string url)
        {
            if (string.IsNullOrEmpty(url))
                throw new ArgumentNullException(nameof(url));

            _restClient = new RestClient(url);
        }


        public TResponse Consume<TResponse>(string controller, string action, object request, Method method = Method.GET)
           where TResponse : new()
        {
            var restRequest = new RestRequest($"/{controller}/{action}", method);
            //restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddJsonBody(request);
            restRequest.Timeout = 600000;
            var restResponse = _restClient.Execute<TResponse>(restRequest);


            if (restResponse.ErrorException != null)
                throw new Exception(restResponse.ErrorMessage, restResponse.ErrorException);

            return restResponse.Data;
        }

        public TResponse Consume<TResponse>(string controller, string action, Method method = Method.GET)
           where TResponse : new()
        {
            var restRequest = new RestRequest($"/{controller}/{action}", method);
            restRequest.Timeout = 600000;
            var restResponse = _restClient.Execute<TResponse>(restRequest);


            if (restResponse.ErrorException != null)
                throw new Exception(restResponse.ErrorMessage, restResponse.ErrorException);

            return restResponse.Data;
        }


    }
}