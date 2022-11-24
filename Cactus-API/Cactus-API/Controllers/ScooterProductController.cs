using Cactus_API.BLL.Models;
using Cactus_API.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cactus_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScooterProductController : ControllerBase
    {
        private readonly IScooterProductService _scooterProductService;

        public ScooterProductController(IScooterProductService scooterProductService)
        {
            _scooterProductService = scooterProductService;
        }


        [HttpGet("scooters")]
        public ActionResult<List<ScooterProductModel>> GetAllScooters()
        {
            return Ok(_scooterProductService.GetAllScoters());
        }

        [HttpGet("{scooterId}")]
        public ActionResult<ScooterProductModel> GetScooterById(int scooterId)
        {
            return Ok(_scooterProductService.GetScoterById(scooterId));
        }
    }
}
