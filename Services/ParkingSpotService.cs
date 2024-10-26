using Common.DTOs.English;
using Common.DTOs.Spanish;
using Data.Entities;
using Data.Repositories.Interfaces;

namespace Services
{
    public class ParkingSpotService : IParkingSpotService
    {
        private readonly IParkingSpotRepository _parkingSpotRepository;
        private readonly IParkingService _parkingService;

        public ParkingSpotService(IParkingSpotRepository parkingSpotRepository, IParkingService parkingService)
        {
            _parkingSpotRepository = parkingSpotRepository;
            _parkingService = parkingService;
        }
        public int Add(ENCreateParkingSpotDto dto)
        {
            ParkingSpot newParkingSpot = new ParkingSpot()
            {
                Description = dto.Description,
                Disabled = 0,
                Deleted = 0,
            };

            return _parkingSpotRepository.Add(newParkingSpot);
        }

        public ParkingSpot? GetParkingSpot(string number)
        {
            return _parkingSpotRepository.GetParkingSpot(number);
        }

        public List<ESPParkingSpotForViewDto> GetAll()
        {
            var parkingSpots = _parkingSpotRepository.GetAll();

            return parkingSpots.Select(g => new ESPParkingSpotForViewDto()
            {
                Id = g.Id,
                Eliminada = g.Deleted,
                Descripcion = g.Description,
                Deshabilitada = g.Disabled,
            }).ToList();
        }
    }
}
