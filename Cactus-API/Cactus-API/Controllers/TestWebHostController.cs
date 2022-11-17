using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cactus_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestWebHostController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GetTestData()
        {
            return Ok("Some string just for see work host or not");
        }
    }
}
