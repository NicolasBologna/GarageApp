using Microsoft.AspNetCore.Mvc;
using Services;

namespace GarageApp.Controllers
{
    [Route("tarifas")]
    [ApiController]
    public class RateController : ControllerBase
    {
        private readonly IRateService _userService;

        public RateController(IRateService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetRates()
        {
            return Ok(_userService.GetAllRates());
        }
    }
}
