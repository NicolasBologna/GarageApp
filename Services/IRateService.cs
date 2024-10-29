using Common.DTOs.Spanish;

namespace Services
{
    public interface IRateService
    {
        IEnumerable<ESPRateDto> GetAllRates();
        Rate GetRate(int id);
        Rate? GetRateByDescription(string description);
    }
}