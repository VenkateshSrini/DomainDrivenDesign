using DomainObjects;
using ItemCatalogue.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingKartController : ControllerBase
    {
        [HttpGet("GetByUserId")]
        public ShoppingKart GetByUserId(string userId)
        {
            return new ShoppingKart();
        }
        [HttpPost("AddItems")]
        public bool AddItems([FromBody]List<Book>books, [FromRoute] string userId) {
            return true;
        }
        [HttpPut("EditCart")]
        public bool Edit([FromBody] List<Book> books, [FromRoute] string userId)
        {
            return true;
        }
        [HttpDelete("RemoveItem")]
        public void RemoveItem([FromBody] List<Book> books, [FromRoute] string userId)
        {

        }
        [HttpDelete("EmptyCart")]
        public void EmptyCart([FromRoute]string userId)
        {

        }
        [HttpGet("FinalPrice")]
        public double FinalPrice(string userId, Discount discount) { return 0d;}
        [HttpPost("DoPayment")]
        public void DoPayment(ShoppingKart cart)
        {

        }
        [HttpPost("AddToLibrary")]
        public void AddToLibrary(ShoppingKart shoppingKart)
        {

        }
    }
}
