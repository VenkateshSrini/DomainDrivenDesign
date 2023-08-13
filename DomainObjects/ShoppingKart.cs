using ItemCatalogue.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainObjects
{
    public  class ShoppingKart
    {
        public string UserId { get;set; }
        public List<Book> Books { get; set; }
        public double FinalPrice { get;set; }
        public double Discount { get; set; }
        public double SpecialPrince { get; set; }   

    }
}
