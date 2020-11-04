using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinLogger.Entites
{
    public class Comment
    {
        public int Id { get; set; }
        public Bitcoin bitcoin { get; set; }
        public string Text { get; set; }
        public DateTime? CreatedOn { get; set; }
        public ApplicationUser Author { get; set; }
    }
}
