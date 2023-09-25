using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT5
{
    public class Root
    {
        public string id { get; set; }
        public string url { get; set; }
        public string status { get; set; }
        public Preview preview { get; set; }
        public Thumbnail thumbnails { get; set; }
        public OriginalFile original_file { get; set; }
        public object user_data { get; set; }
    }
}
