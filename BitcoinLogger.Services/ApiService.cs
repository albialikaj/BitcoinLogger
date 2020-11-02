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

        //public Task<Bitstamp> GetBitstampAsync()
        //{
        //    var url = "https://www.bitstamp.net/api/ticker/";
        //    return GetAsync<Bitstamp>(url);
        //}


        public Task<Bitstamp> GetBitstampAsync()
        {
            Bitstamp bitstamp = new Bitstamp();
            return GetAsync<Bitstamp>(bitstamp.Source);
        }


        /// <summary>
        /// Επιστρέφει ενα διαμορφωμένο object Coindesk Διαμορφωμένο.
        /// </summary>
        public async Task<Coindesk> GetCoindeskAsync()
        {
            Coindesk coindesk = new Coindesk();
            var model = GetAsync<Coindesk>(coindesk.Source);
            var result = await model;

            coindesk.Price = result.bpi.usd.rate;
            coindesk.Date = result.time.updated;

            return coindesk;
        }



        public async Task<Gdax> GetGdaxAsync()
        {
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            ApiClient.DefaultRequestHeaders.Add("User-Agent", ".NET Framework Test Client");
         
            Gdax gdax = new Gdax();
            using (HttpResponseMessage response = await ApiClient.GetAsync(gdax.Source))
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
