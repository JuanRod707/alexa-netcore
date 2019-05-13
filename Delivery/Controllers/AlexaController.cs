using Delivery.Dtos.Request;
using Delivery.Dtos.Response;
using Delivery.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Controllers
{
    [Route("intent")]
    [ApiController]
    public class AlexaController : ControllerBase
    {
        [HttpPost]
        public SkillResponse Intent([FromBody] SkillRequest intent) => SkillResponseHelper.SimpleGreetResponse("my app");
    }
}