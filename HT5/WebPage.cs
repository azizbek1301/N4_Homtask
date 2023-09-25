using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT5
{
    public class Webpage
    {
        public Oembed oembed { get; set; }
        public List<Video> videos { get; set; }
        public string title { get; set; }
        public List<Image> images { get; set; }
        public string url { get; set; }
        public string locale { get; set; }
        public string description { get; set; }
    }
}
