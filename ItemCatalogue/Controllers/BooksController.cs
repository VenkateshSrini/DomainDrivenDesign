using ItemCatalogue.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ItemCatalogue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet("GetAllBooks")]
     
        public List<Book> GetAllBooks()
        {
            return new List<Book>();
        }

        // GET api/<ValuesController>/5
      
        [HttpGet("/api/[controller]/GetById/{id}")]
     
        public Book GetById(int id)
        {
            return new Book();
        }

        // POST api/<ValuesController>
        [HttpPost("AddBook")]
       
        public void AddBook([FromBody] Book book)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("/api/[controller]/EditBook/{id}")]
        
        public void EditBook(int id, [FromBody] string title, float price)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("/api/[controller]/Remove/{id}")]
        
        public void RemoveBook(int id)
        {
        }
    }
}
