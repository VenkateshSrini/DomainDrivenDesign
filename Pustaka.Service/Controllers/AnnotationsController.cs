using DomainObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pustaka.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnotationsController : ControllerBase
    {
        /// <summary>
        /// used by Audio book
        /// </summary>
        /// <param name="ISBNID"></param>
        /// <returns></returns>
        [HttpGet("GetAnnotationByBookId")]
        public List<Annotations>GetAnnotationByBookId(string ISBNID)
        {
            return new List<Annotations>();
        }
        [HttpGet("GetAnnotationByBookPage")]
        public List<Annotations>GetAnnotation(string ISBNID, int pageNo) {
            return new List<Annotations>();
        }
        [HttpPost("UpsertAnnotation")]
        public void AddAnnotation(Annotations annotation)
        {

        }
        [HttpDelete("DeleteAnnotation")]
       public void DeleteAnnotation([FromBody]string annotationId)
        {

        }

    }
}
