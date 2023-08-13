using DomainObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        [HttpGet("GetByBook")]
        public List<Discount> GetByBook([FromRoute]string ISBNID)
        {
            return new List<Discount>();
        }

        [HttpGet("GetByUser")]
        public List<Discount> GetByUser([FromRoute] string userId)
        {
            return new List<Discount>();
        }
        [HttpGet("GetByPurchase")]
        public List<Discount> GetByPurchase([FromRoute] string userId, [FromRoute] string isbnID )
        {
            return new List<Discount>();
        }
        [HttpPost]
        public void Add(Discount discount)
        {

        }
        [HttpDelete]
        public void Delete(string discountId)
        {

        }
        [HttpPut]
        public void Edit(Discount discount)
        {

        }
    }
}
