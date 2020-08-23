using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace WaktuShalat.Helper
{
    class APIHttpHandler
    {
        public static async Task<HttpResponseMessage> GetResponse(Uri RequestURL)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = RequestURL;

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = (HttpResponseMessage)await client.GetAsync(RequestURL);
            if(response.IsSuccessStatusCode)
            {
                return response;
            }

            return response;
        }
    }
}
