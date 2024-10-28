using Common.DTOs.Spanish;
using Data.Entities;
using Data.Repositories;
using Data.Repositories.Interfaces;

namespace Services
{
    public class ParkingService : IParkingService
    {
        private readonly IParkingRepository _parkingRepository;
        private readonly IParkingSpotRepository _parkingSpotRepository;
        private readonly IUserService _userService;

        public ParkingService(IParkingRepository parkingRepository, IParkingSpotRepository parkingSpotRepository, IUserService userService)
        {
            _parkingRepository = parkingRepository;
            _parkingSpotRepository = parkingSpotRepository;
            _userService = userService;
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

        public int StartParking(ESPOpenParkingDto dto)
        {
            var spot = _parkingSpotRepository.GetParkingSpotById(dto.IdCochera);
            if (spot is null)
                throw new Exception("La cochera a la que intenta asociar esta reserva no existe");

            var userExists = _userService.UserExistsById(dto.IdUsuarioIngreso);
            if (!userExists)
                throw new Exception("El usuario al que intenta asociar esta reserva no existe");

            var newParking = new Parking()
            {
                LicensePlate = dto.Patente,
                ParkingSpotId = dto.IdCochera,
                IsDeleted = false,
                EntryTime = DateTime.Now,
                EntryUserId = dto.IdUsuarioIngreso.ToString(),
            };
            return _parkingRepository.AddParking(newParking);

        }

        public bool EndParking(ESPCloseParkingDto dto)
        {
            var parking = _parkingRepository.GetParkingByPlate(dto.Patente);
            if (parking is null)
                throw new Exception("La patente a la que asocia esta reserva no existe");

            var userExists = _userService.UserExistsById(dto.IdUsuarioEgreso);
            if (!userExists)
                throw new Exception("El usuario al que intenta asociar esta reserva no existe");

            parking.ExitTime = DateTime.Now;
            parking.Cost = 600; //TODO: Calculate cost
            parking.ExitUserId = dto.IdUsuarioEgreso.ToString();

            _parkingRepository.UpdateParking(parking);
            return true;
        }
    }
}
