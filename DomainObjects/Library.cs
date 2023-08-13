using ItemCatalogue.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainObjects
{
    public class Library
    {
        public  string UserId { get; set; }
        public Dictionary<Uri,Book> PurchasedBooks { get; set; }
    }
}
