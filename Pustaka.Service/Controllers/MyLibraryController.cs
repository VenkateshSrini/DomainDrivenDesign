using ItemCatalogue.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pustaka.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyLibraryController : ControllerBase
    {
        [HttpGet("GetAllPurchasedBooks")]
        public List<Book> GetAllPurchasedBooks()
        {
            return new List<Book>();
        }
        [HttpGet("GetBookURI")]
        public string GetBookURI([FromRoute] string isbnID)
        {
            return string.Empty;
        }
        [HttpPost("AddToLibrary")]
        public void AddToLibrary(List<Book> books)
        {
          
        }
    }
}
