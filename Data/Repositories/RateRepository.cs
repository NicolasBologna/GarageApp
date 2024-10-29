using Data.Repositories.Interfaces;

namespace Data.Repositories
{
    public class RateRepository : IRateRepository
    {
        private readonly GarageContext _context;

        public RateRepository(GarageContext context)
        {
            _context = context;
        }

        public IEnumerable<Rate> GetAllRates()
        {
            return _context.Rates.ToList();
        }

        public Rate GetRateById(int id)
        {
            return _context.Rates.Find(id);
        }

        public Rate? GetRateByDescription(string description)
        {
            return _context.Rates.FirstOrDefault(r => r.Description == description);
        }


        public void AddRate(Rate rate)
        {
            _context.Rates.Add(rate);
            _context.SaveChanges();
        }

        public void UpdateRate(Rate rate)
        {
            _context.Rates.Update(rate);
            _context.SaveChanges();
        }

        public void DeleteRate(string id)
        {
            var rate = _context.Rates.Find(id);
            if (rate != null)
            {
                _context.Rates.Remove(rate);
                _context.SaveChanges();
            }
        }
    }
}