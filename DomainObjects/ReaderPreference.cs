using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainObjects
{
    public class ReaderPreference
    {
        public string UserId { get;set; }
        public bool NightMode { get; set; }
        public string HighlightColor { get; set; }
        public int ZoomSize { get; set; }
    }
}
