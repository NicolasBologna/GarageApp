using Common.DTOs.Spanish;
using Data.Repositories;

namespace Services
{
    public class ParkingService : IParkingService
    {
        private readonly IParkingRepository _parkingRepository;

        public ParkingService(IParkingRepository parkingRepository)
        {
            _parkingRepository = parkingRepository;
        }

        public IEnumerable<ESPParkingDto> GetAll()
        {
            return _parkingRepository.GetAllParkings().Select(p => new ESPParkingDto()
            {
                Id = p.Id,
                Costo = p.Cost,
                Eliminado = p.IsDeleted,
                HoraEgreso = p.ExitTime?.ToString(),
                HoraIngreso = p.EntryTime.ToString(),
                IdCochera = p.ParkingSpotId,
                IdUsuarioEgreso = p.ExitUserId,
                IdUsuarioIngreso = p.EntryUserId,
                Patente = p.LicensePlate,
            });
        }

        public IEnumerable<ESPParkingDto> GetActives()
        {
            return _parkingRepository.GetAllParkings().Where(p => p.ExitTime is null).Select(p => new ESPParkingDto()
            {
                Id = p.Id,
                Costo = p.Cost,
                Eliminado = p.IsDeleted,
                HoraIngreso = p.EntryTime.ToString(),
                IdCochera = p.ParkingSpotId,
                IdUsuarioIngreso = p.EntryUserId,
                Patente = p.LicensePlate,
            });
        }
    }
}
