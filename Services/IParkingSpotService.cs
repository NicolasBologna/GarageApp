using Common.DTOs.English;
using Common.DTOs.Spanish;
using Data.Entities;

namespace Services
{
    public interface IParkingSpotService
    {
        int Add(ESPCreateParkingSpotDto dto);
        public ParkingSpot? GetParkingSpotByDescription(string number);
        public List<ESPParkingSpotForViewDto> GetAll();
        bool DeleteSpot(int spotId);
        bool DisableSpot(int spotId);
        bool EnableSpot(int spotId);
        ParkingSpot? GetParkingSpotById(int id);
    }
}