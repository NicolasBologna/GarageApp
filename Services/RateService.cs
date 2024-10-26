using Common.DTOs.Spanish;
using Data.Repositories.Interfaces;

namespace Services
{
    public class RateService : IRateService
    {
        private readonly IRateRepository _rateRepository;

        public RateService(IRateRepository rateRepository)
        {
            _rateRepository = rateRepository;
        }

        public IEnumerable<ESPRateDto> GetAllRates()
        {
            //Mapeamos los datos de la entidad a DTO en español
            IEnumerable<ESPRateDto> allRates = _rateRepository.GetAllRates().Select(r =>
                new ESPRateDto()
                {
                    Descripcion = r.Description,
                    Id = r.Id,
                    Valor = r.Value
                });

            return allRates;
        }
        public Rate GetRate(int id)
        {
            return _rateRepository.GetRateById(id);
        }
    }
}
