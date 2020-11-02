using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BitcoinLogger.Entites
{
    public class Gdax : BitcoinEntry
    {
        public override string Source { get; set; } = "https://api.gdax.com/products/BTC-USD/ticker";
        public int trade_id { get; set; }
        [JsonProperty("price")]
        public override decimal Price { get; set; }
        public string size { get; set; }
        [JsonProperty("time")]
        public override string Date { get; set; }
        public string ask { get; set; }
        public string volume { get; set; }        
    }
}
