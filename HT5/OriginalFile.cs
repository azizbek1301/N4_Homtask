using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT5
{
    public class OriginalFile
    {
        public string name { get; set; }
        public int size { get; set; }
        public string encoding { get; set; }
        public Metadata metadata { get; set; }
        public string mimetype { get; set; }
        public string type { get; set; }
        public int total_pages { get; set; }
        public string extension { get; set; }
    }
}
