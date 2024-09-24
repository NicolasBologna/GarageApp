using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class GarageRepository : IGarageRepository
    {
        private readonly GarageContext _context;

        public GarageRepository(GarageContext context)
        {
            _context = context;
        }
        public int Add(Garage garage)
        {
            var newGarage = _context.Garages.Add(garage);
            _context.SaveChanges();
            return newGarage.Entity.Id;
        }

        public Garage? GetGarage(string number)
        {
            return _context.Garages.SingleOrDefault(g => g.Number.ToLower() == number.ToLower());
        }

        public List<Garage> GetAll()
        {
            return _context.Garages.ToList();
        }
    }
}
