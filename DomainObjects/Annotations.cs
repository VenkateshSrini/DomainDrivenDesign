using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainObjects
{
    public enum AnnotationType
    {
        BookMark=0,
        Highlight =1,
        Comment =2,
    }
    public class Annotations
    {
        public string ID { get;set; }
        public string ISBNID { get;set; }
        public int PageNo { get;set; }
        public int Position { get; set; }
        public AnnotationType AnnotationType { get; set;}

    }
}
