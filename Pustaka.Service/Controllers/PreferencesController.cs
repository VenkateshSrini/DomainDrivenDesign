using DomainObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pustaka.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreferencesController : ControllerBase
    {
        [HttpGet("Get")]
        public ReaderPreference Get(string UserId) { 
            return new ReaderPreference();
        }
        [HttpPut("Update")]
        public void Update([FromBody] ReaderPreference preference)
        {

        }
    }
}
