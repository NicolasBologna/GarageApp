using Common.DTOs.English;
using Common.DTOs.Spanish;
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
        public IActionResult Create(ESPCreateParkingSpotDto newParkingSpot)
        {
            if (_ParkingSpotService.GetParkingSpotByDescription(newParkingSpot.Descripcion) != null)
            {
                return BadRequest($"La cochera con la descripción {newParkingSpot.Descripcion} ya existe por lo que no se puede crear.");
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

        [HttpDelete]
        [Route("{idToDelete}")]
        public IActionResult Delete([FromRoute] int idToDelete)
        {
            var deleteResult = _ParkingSpotService.DeleteSpot(idToDelete);
            if (deleteResult)
                return Ok();

            return BadRequest($"La cochera con id {idToDelete} no pudo ser eliminada porque no existe o está en uso");
        }

        [HttpPost]
        [Route("{id}/disable")]
        public IActionResult Disable([FromRoute] int id)
        {
            var deleteResult = _ParkingSpotService.DisableSpot(id);
            if (deleteResult)
                return Ok();

            return BadRequest($"La cochera con id {id} no pudo ser deshabilitada porque no existe o está en uso");
        }

        [HttpPost]
        [Route("{id}/enable")]
        public IActionResult Enable([FromRoute] int id)
        {
            var deleteResult = _ParkingSpotService.EnableSpot(id);
            if (deleteResult)
                return Ok();

            return BadRequest($"La cochera con id {id} no pudo ser habilitada porque no existe o está en uso");
        }
    }
}
