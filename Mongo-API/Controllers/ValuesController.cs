using Microsoft.AspNetCore.Mvc;

namespace Mongo_API.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class ValuesController : Controller
    {
       // GET api/values
       [HttpGet("{id}")]
       public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values/S
        [HttpPost("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/S
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
