using DomainObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Favorites.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoritesController : ControllerBase
    {
        [HttpGet("GetByUserId")]
        public DomainObjects.Favorites GetByUserId(string  userId)
        {
            return new DomainObjects.Favorites();
        }
        [HttpGet("GetByBookId")]
        public List<DomainObjects.Favorites> GetByBookId(string bookId)
        {
            return new List<DomainObjects.Favorites>();
        }
        [HttpPost("Entice")]
        public void Communication(string userId,string book)
        {

        }
        [HttpPost("AddToFavorites")]

        public void AddToFavorites([FromRoute]string BookId, [FromRoute] string UserId)
        {

        }
        [HttpDelete("RemoveItem")]

        public void Delete([FromRoute] string BookId, [FromRoute] string UserId)
        {

        }

    }
}
