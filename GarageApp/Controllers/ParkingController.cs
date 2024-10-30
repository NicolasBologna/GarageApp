using Common.DTOs.Spanish;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace GarageApp.Controllers
{
    [Route("estacionamientos")]
    [ApiController]
    public class ParkingController : ControllerBase
    {
        private readonly IParkingService _parkingService;

        public ParkingController(IParkingService parkingService)
        {
            _parkingService = parkingService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_parkingService.GetActives());
        }

        [HttpPost]
        [Route("abrir")]
        public IActionResult Open([FromBody] ESPOpenParkingDto dto)
        {
            var newId = _parkingService.StartParking(dto);
            return Ok(newId);
        }

        [HttpPatch]
        [Route("cerrar")]
        public IActionResult Close([FromBody] ESPCloseParkingDto dto)
        {
            var newId = _parkingService.EndParking(dto);
            return Ok(newId);
        }
    }
}
