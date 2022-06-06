using System.Net.Http.Headers;
using System.Text.Json;

namespace Frontend.Utils
{
    public static class HttpClientExtensions
    {
        private static MediaTypeHeaderValue contentType =
            new MediaTypeHeaderValue("application/json");

        public static async Task<T> ReadContentAs<T>(
            this HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
                throw new ApplicationException(
                    $"Something went wrong calling the api: " +
                    $"{response.ReasonPhrase}"
                );
            var dataAsString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return JsonSerializer.Deserialize<T>(dataAsString,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public static Task<HttpResponseMessage> PostAsJson<T>(
            this HttpClient httpClient,
            string url,
            T data
        )
        {
            try
            {
                var dataAsString = JsonSerializer.Serialize(data);
                var content = new StringContent(dataAsString);
                content.Headers.ContentType = contentType;
                return httpClient.PostAsync(url, content);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public static Task<HttpResponseMessage> PutAsJson<T>(
            this HttpClient httpClient,
            string url,
            T data
        )
        {
            var dataAsString = JsonSerializer.Serialize(data);
            var content = new StringContent(dataAsString);
            content.Headers.ContentType = contentType;
            return httpClient.PutAsync(url, content);
        }
    }
}