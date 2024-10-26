using Common.DTOs.English;
using Common.DTOs.Spanish;
using Data.Entities;

namespace Services
{
    public interface IParkingSpotService
    {
        int Add(ENCreateParkingSpotDto dto);
        public ParkingSpot? GetParkingSpot(string number);
        public List<ESPParkingSpotForViewDto> GetAll();
    }
}