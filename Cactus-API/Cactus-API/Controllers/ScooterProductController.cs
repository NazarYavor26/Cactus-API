using Cactus_API.BLL.Models;
using Cactus_API.BLL.Services;
using Cactus_API.DAL.Entities;
using Microsoft.AspNetCore.Http;
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


        [HttpGet("scooter")]
        public ActionResult<List<ScooterProduct>> GetAllScooters()
        {
            return Ok(_scooterProductService.GetAllScoters());
        }
    }
}
