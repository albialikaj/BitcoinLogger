using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinLogger.Entites
{
    public class Bitcoin
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public decimal Price { get; set; }
        public DateTime? Date { get; set; }
    }
}
