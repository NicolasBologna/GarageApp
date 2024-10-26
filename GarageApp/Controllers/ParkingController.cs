using Microsoft.AspNetCore.Mvc;
using Services;

namespace GarageApp.Controllers
{
    [Route("estacionamientos")]
    [ApiController]
    public class ParkingController : ControllerBase
    {
        private readonly IParkingService _ParkingService;

        public ParkingController(IParkingService parkingService)
        {
            _ParkingService = parkingService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_ParkingService.GetActives());
        }
    }
}
