using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinLogger.Entites
{
    public class Coindesk : BitcoinEntry
    {
        public override string Source { get; set; } = "https://api.coindesk.com/v1/bpi/currentprice/EUR.json";
        public override decimal Price { get; set; }

        public override string Date { get; set; }

        //public override DateTime Date { get {
        //        return Date;
        //    } set {
        //        Date = DateTime.Parse(time.updated);
        //    }}


        public Time time { get; set; }
        public string disclaimer { get; set; }
        public Bpi bpi { get; set; }


        public class Bpi
        {

            public USD usd { get; set; }
            //public eur EUR { get; set; }
        }


        public class USD
        {
            public string code { get; set; }
            public decimal rate { get; set; }
            public string description { get; set; }
        }


        public class Time
        {
            public string updated { get; set; }
            public string updatedISO { get; set; }
            public string updateduk { get; set; }
        }
    }
}
