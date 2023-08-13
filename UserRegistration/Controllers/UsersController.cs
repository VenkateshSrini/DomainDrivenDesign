using DomainObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UserRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet("GetAllUsers")]
        public List<User>GetAllUsers()
        {
            return new List<User>();
        }
        [HttpGet("GetUserByID")]
        public User GetUserByID([FromRoute] int id)
        {
            return new User();
        }
        [HttpPost("AddUser")]
        public void AddUser([FromBody] User user)
        {

        }
        [HttpPut("EditUser")]
        public User EditUser([FromBody]User user)
        {
            return new User();
        }
        [HttpDelete("DeleteUser")]
        public User DeleteUser([FromBody]int EmailId)
        {
            return new User();
        }
    }
}
