using Common.DTOs;
using Data.Entities;

namespace Services
{
    public interface IGarageService
    {
        int Add(CreateGarageDto dto);
        public Garage? GetGarage(string number);
        public List<GarageForViewDto> GetAll();
    }
}