using KickScooter_API.BLL.Models;
using KickScooter_API.BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KickScooter_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelpCallController : ControllerBase
    {
        private readonly IHelpCallService helpCallService;

        public HelpCallController(IHelpCallService helpCallService)
        {
            this.helpCallService = helpCallService;
        }

        [HttpPost("helpcall")]
        public ActionResult<HelpCallModel> AddHelpCallData([FromBody] HelpCallModel helpCallModel)
        {
            HelpCallModel ResponseHelpCallModel = helpCallService.AddHelpCallData(helpCallModel);
            if (ResponseHelpCallModel != null)
            {
                return Ok(ResponseHelpCallModel);
            }

            return BadRequest();
        }
    }
}
