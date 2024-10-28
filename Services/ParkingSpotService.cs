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
        public int Add(ESPCreateParkingSpotDto dto)
        {
            ParkingSpot newParkingSpot = new ParkingSpot()
            {
                Description = dto.Descripcion,
                Disabled = 0,
                Deleted = 0,
            };

            return _parkingSpotRepository.Add(newParkingSpot);
        }

        public ParkingSpot? GetParkingSpotByDescription(string number)
        {
            return _parkingSpotRepository.GetParkingSpotByDescription(number);
        }

        public ParkingSpot? GetParkingSpotById(int id)
        {
            return _parkingSpotRepository.GetParkingSpotById(id);
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

        public bool DeleteSpot(int spotId)
        {
            var spot = _parkingSpotRepository.GetParkingSpotById(spotId);
            if (spot is null)
                return false;

            spot.Deleted = 1;
            _parkingSpotRepository.UpdateSpot(spot);
            return true;
        }

        public bool DisableSpot(int spotId)
        {
            var spot = _parkingSpotRepository.GetParkingSpotById(spotId);
            if (spot is null)
                return false;

            spot.Disabled = 1;
            _parkingSpotRepository.UpdateSpot(spot);
            return true;
        }

        public bool EnableSpot(int spotId)
        {
            var spot = _parkingSpotRepository.GetParkingSpotById(spotId);
            if (spot is null)
                return false;

            spot.Disabled = 0;
            _parkingSpotRepository.UpdateSpot(spot);
            return true;
        }
    }
}
