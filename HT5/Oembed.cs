using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT5
{
    public class Oembed
    {
        public string author_name { get; set; }
        public int version { get; set; }
        public string title { get; set; }
        public string author_url { get; set; }
        public int thumbnail_width { get; set; }
        public long cache_age { get; set; }
        public string provider_url { get; set; }
        public string thumbnail_url { get; set; }
        public int width { get; set; }
        public int thumbnail_height { get; set; }
        public string type { get; set; }
        public string provider_name { get; set; }
        public int height { get; set; }
        public string html { get; set; }
    }
}
