using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinLogger.Entites
{
   public abstract class BitcoinEntry 
    {
        public int Id { get; set; }
        public abstract string Source { get; set; }
        public abstract decimal Price { get; set; }
        public abstract string Date { get; set; }
    }
}
