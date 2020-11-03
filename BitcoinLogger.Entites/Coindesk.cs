using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinLogger.Entites
{
    public class Coindesk 
    {
        public string Source { get; set; } 
        public decimal Price { get; set; }
        public string Date { get; set; }
        public Time time { get; set; }
        public string disclaimer { get; set; }
        public Bpi bpi { get; set; }

        
            public class Bpi
            {
                public USD usd { get; set; }            
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
