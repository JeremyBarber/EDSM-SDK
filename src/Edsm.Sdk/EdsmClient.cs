using Edsm.Sdk.Dto;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Edsm.Sdk
{
    public class EdsmClient : IEdsmClient
    {
        private readonly HttpClient _client;

        public EdsmClient(HttpClient client)
        {
            _client = client;
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<T?> SendRequest<T>(IEdsmRequest request) where T : IEdsmResponse
        {
            var requestContent = new StringContent(JsonConvert.SerializeObject(request));
            requestContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await _client.PostAsync(request.Path, requestContent);

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException("Request to EDSM API was not successful", null, response.StatusCode);
            }

            var responseContent = await response.Content.ReadAsStringAsync();

            try
            {
                // EDSM will often return an empty array if a call fails, even if the response cannot be an array
                return JsonConvert.DeserializeObject<T>(responseContent);
            }
            catch
            {
                return default;
            }
        }
    }
}
