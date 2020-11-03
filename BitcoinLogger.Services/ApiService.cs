using Newtonsoft.Json;
using System;
using System.Net.Http;
using BitcoinLogger.Entites;

using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace BitcoinLogger.Services
{
    public class ApiService
    {

        public static HttpClient ApiClient = new HttpClient();
        static Lazy<HttpClient> http = new Lazy<HttpClient>();

        public async Task<T> GetAsync<T>(string url)
        {
            var json = await http.Value.GetStringAsync(url);
            return JsonConvert.DeserializeObject<T>(json);
        }

        public Task<Bitstamp> GetBitstampAsync(string url)
        {          
            return GetAsync<Bitstamp>(url);
        }

        public Task<Coindesk> GetCoindeskAsync(string url)
        {
            return GetAsync<Coindesk>(url);
        }



        public async Task<Gdax> GetGdaxAsync(string url)
        {
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            ApiClient.DefaultRequestHeaders.Add("User-Agent", ".NET Framework Test Client");

            Gdax gdax = new Gdax();
            using (HttpResponseMessage response = await ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    gdax = await response.Content.ReadAsAsync<Gdax>();
                    return gdax;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

    }

}
