using ItemCatalogue.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainObjects
{
    public class Favorites
    {
        public string UserId { get;set; }
        public List<Book> Books { get; set; }
    }
}
