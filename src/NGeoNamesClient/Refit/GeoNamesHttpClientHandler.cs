using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace DutchAndBold.NGeoNamesClient.Refit
{
    public class GeoNamesHttpClientHandler : HttpClientHandler
    {
        private readonly string _userName;

        public GeoNamesHttpClientHandler(string userName)
        {
            _userName = userName;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var queryConcatenation = request.RequestUri.Query != string.Empty ? "&" : "?";
            var uri = request.RequestUri + queryConcatenation + "username=" + _userName;
            request.RequestUri = new Uri(uri);
            
            return base.SendAsync(request, cancellationToken);
        }
    }
}