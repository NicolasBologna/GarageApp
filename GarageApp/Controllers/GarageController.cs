using Common.DTOs;
using Data.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace GarageApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GarageController : ControllerBase
    {
        private readonly IGarageService _garageService;

        public GarageController(IGarageService garageService)
        {
            _garageService = garageService;
        }

        [HttpPost]
        public IActionResult Create(CreateGarageDto newGarage)
        {
            if (_garageService.GetGarage(newGarage.Number) != null)
            {
                return BadRequest($"El garage con el number {newGarage.Number} ya existe por lo que no se puede crear.");
            }

            var newId = _garageService.Add(newGarage);

            return Ok(newId);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var allGarages = _garageService.GetAll();
            return Ok(allGarages);
        }
    }
}
