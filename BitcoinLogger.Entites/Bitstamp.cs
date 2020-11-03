using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinLogger.Entites
{
   
    public class Bitstamp
    {
        public string Source { get; set; }
        public string volume { get; set; }
        [JsonProperty("last")]
        public decimal Price { get; set ; }
        [JsonProperty("timestamp")]        
        public string Date { get; set; }
        public string bid { get; set; }
        public string vwap { get; set; }
        public string high { get; set; }
        public string low { get; set; }
        public string ask { get; set; }
        public string open { get; set; }
    }
}
