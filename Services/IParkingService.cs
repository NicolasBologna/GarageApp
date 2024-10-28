using Common.DTOs.Spanish;

namespace Services
{
    public interface IParkingService
    {
        bool EndParking(ESPCloseParkingDto dto);
        IEnumerable<ESPParkingDto> GetActives();
        IEnumerable<ESPParkingDto> GetAll();
        int StartParking(ESPOpenParkingDto dto);
    }
}