using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT1
{
    public class DD

    {
        public Guid siteKey { get; set; }
        public string id { get; set; }
        public SMT SMT { get; set; }
        public DDStatus DDStatus { get; set; }
        public Address[] Address { get; set; }

    }
}
