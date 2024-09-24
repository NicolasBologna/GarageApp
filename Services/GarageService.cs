using Common.DTOs;
using Data.Entities;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class GarageService : IGarageService
    {
        private readonly IGarageRepository _garageRepository;

        public GarageService(IGarageRepository garageRepository)
        {
            _garageRepository = garageRepository;
        }
        public int Add(CreateGarageDto dto)
        {
            Garage newGarage = new Garage()
            {
                Number = dto.Number,
                Plate = null,
                StartDateTime = null,
                EndDateTime = null,
            };

            return _garageRepository.Add(newGarage);
        }

        public Garage? GetGarage(string number)
        {
            return _garageRepository.GetGarage(number);
        }

        public List<GarageForViewDto> GetAll()
        {
            var garages = _garageRepository.GetAll();
            return garages.Select(g => new GarageForViewDto()
            {
                EndDateTime = g.EndDateTime,
                Number = g.Number,
                Plate = g.Plate,
                StartDateTime = g.StartDateTime,
                Status = g.Status
            }).ToList();
        }
    }
}
