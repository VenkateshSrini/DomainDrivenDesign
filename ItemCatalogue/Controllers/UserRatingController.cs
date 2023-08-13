using DomainObjects;
using ItemCatalogue.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ItemCatalogue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRatingController : ControllerBase
    {
        [HttpGet("GetAllRatings")]
        public List<UserRating> GetAllRatings()
        {
            return new List<UserRating>();
        }
        [HttpGet("/api/[controller]/GetById/{id}")]
        public UserRating Get(string id, string bookId)
        {
            return new UserRating();
        }
        [HttpPost("RateBook")]
        public void Upsert([FromBody] UserRating userRating)
        {

        }
    }
}
