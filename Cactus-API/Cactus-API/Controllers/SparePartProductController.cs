using Cactus_API.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cactus_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SparePartProductController : ControllerBase
    {
        private readonly ISparePartProductService _sparePartProductService;

        public SparePartProductController(ISparePartProductService sparePartProductService)
        {
            _sparePartProductService = sparePartProductService;
        }

        [HttpGet("spare-parts")]
        public ActionResult<List<SparePartProductService>> GetAllSparePart()
        {
            return Ok(_sparePartProductService.GetAllSpareParts());
        }
    }
}
