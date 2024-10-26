using Common.DTOs.Spanish;

namespace Services
{
    public interface IParkingService
    {
        IEnumerable<ESPParkingDto> GetActives();
        IEnumerable<ESPParkingDto> GetAll();
    }
}