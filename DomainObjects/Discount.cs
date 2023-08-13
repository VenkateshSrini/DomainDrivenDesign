using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainObjects
{
    public class Discount
    {
        string Id { get; set; }
        public string UserId { get;set; }
        public string ISBNID { get; set; }  
        public string CouponCode { get;set; }
        public  double DiscountPercentage { get; set; }
    }
}
