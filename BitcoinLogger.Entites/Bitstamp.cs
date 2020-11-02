using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinLogger.Entites
{
   
    public class Bitstamp : BitcoinEntry
    {
        public override string Source { get; set; }
        public string volume { get; set; }

        [JsonProperty("last")]
        public override decimal Price { get; set ; }

        [JsonProperty("timestamp")]
        public override string Date { get; set; }

        public string bid { get; set; }
        public string vwap { get; set; }
        public string high { get; set; }
        public string low { get; set; }
        public string ask { get; set; }
        public string open { get; set; }









        private DateTime _datevalue;

        //public DateTime getSmoething() {
        //    int temp = Convert.ToInt32(this.Date);
        //    return new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(temp);
        //}

        public string dt
        {
            get { return _datevalue.ToString(); }
            set { DateTime.TryParse(this.Date, out _datevalue); }
        }



    }
}
