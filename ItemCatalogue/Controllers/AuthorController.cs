using ItemCatalogue.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ItemCatalogue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        [HttpGet("GetAllAuthors")]
        public List<Author> GetAllAuthors()
        {
            return new List<Author>();
        }
        [HttpGet("/api/[controller]/GetById/{id}")]
        public Author Get(string id) {
            return new Author();
        }
        [HttpPost("AddAuthors")]
        public void Post([FromBody] Author author)
        {

        }
        [HttpPut("UpdateBio")]
        public void Put(string id, [FromBody] string bio)
        {

        }
        [HttpDelete("DeleteAuthor/{id}")]
        public void Delete([FromRoute]string id)
        {

        }
    }
}
