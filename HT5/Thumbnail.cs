using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT5
{
    public class Thumbnail
    {
        public OriginalSize original_size { get; set; }
        public int page { get; set; }
        public Size size { get; set; }
        public string url { get; set; }
        public bool resized { get; set; }
        public string requested_size { get; set; }
    }
}
