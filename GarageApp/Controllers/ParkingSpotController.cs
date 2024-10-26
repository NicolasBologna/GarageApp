using Common.DTOs.English;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace GarageApp.Controllers
{
    [Route("cocheras")]
    [ApiController]
    public class ParkingSpotController : ControllerBase
    {
        private readonly IParkingSpotService _ParkingSpotService;

        public ParkingSpotController(IParkingSpotService ParkingSpotService)
        {
            _ParkingSpotService = ParkingSpotService;
        }

        [HttpPost]
        public IActionResult Create(ENCreateParkingSpotDto newParkingSpot)
        {
            if (_ParkingSpotService.GetParkingSpot(newParkingSpot.Description) != null)
            {
                return BadRequest($"La cochera con la descripción {newParkingSpot.Description} ya existe por lo que no se puede crear.");
            }

            var newId = _ParkingSpotService.Add(newParkingSpot);

            return Ok(newId);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var allParkingSpot = _ParkingSpotService.GetAll();
            return Ok(allParkingSpot);
        }
    }
}
