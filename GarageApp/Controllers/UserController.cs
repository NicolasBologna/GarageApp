using Microsoft.AspNetCore.Mvc;
using Services;

namespace GarageApp.Controllers
{
    [Route("usuarios")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("{username}")]
        public IActionResult GetUserData(string username)
        {
            return Ok(_userService.GetUserByUserName(username));
        }
    }
}
