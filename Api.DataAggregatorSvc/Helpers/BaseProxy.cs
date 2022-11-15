using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Api.DataAggregatorSvc.Helpers
{
    public class BaseProxy<T> where T : class
    {
        protected readonly ILogger<T> _logger;
        protected readonly IHttpClientFactory _httpClientFactory;

        public BaseProxy(ILogger<T> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        protected HttpClient httpClient => _httpClientFactory.CreateClient("HttpClient");

        protected async Task<TT> GetDataAsync<TT>(Uri requestUrl)
        {
            try
            {
                using HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(requestUrl);
                httpResponseMessage.EnsureSuccessStatusCode();
                var response = await httpResponseMessage.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<TT>(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Get Error Message", requestUrl?.AbsoluteUri);
                throw;
            }
        }
        protected async Task<TT> PostDataAsync<TT>(Uri requestUrl, HttpContent content)
        {
            try
            {
                using HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(requestUrl,content);
                httpResponseMessage.EnsureSuccessStatusCode();
                var response = await httpResponseMessage.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<TT>(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Post Error Message", requestUrl?.AbsoluteUri);
                throw;
            }
        }
    }
}
