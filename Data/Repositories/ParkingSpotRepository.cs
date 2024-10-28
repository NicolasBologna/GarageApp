using Data.Entities;
using Data.Repositories.Interfaces;

namespace Data.Repositories
{
    public class ParkingSpotRepository : IParkingSpotRepository
    {
        private readonly GarageContext _context;

        public ParkingSpotRepository(GarageContext context)
        {
            _context = context;
        }
        public int Add(ParkingSpot garage)
        {
            var newParkingSpot = _context.ParkingSpots.Add(garage);
            _context.SaveChanges();
            return newParkingSpot.Entity.Id;
        }

        public ParkingSpot? GetParkingSpotByDescription(string number)
        {
            return _context.ParkingSpots.SingleOrDefault(g => g.Description.ToLower() == number.ToLower());
        }

        public ParkingSpot? GetParkingSpotById(int id)
        {
            return _context.ParkingSpots.SingleOrDefault(g => g.Id == id);
        }

        public List<ParkingSpot> GetAll()
        {
            return _context.ParkingSpots.Where(p => p.Deleted == 0).ToList();
        }

        public void UpdateSpot(ParkingSpot spot)
        {
            _context.ParkingSpots.Update(spot);
            _context.SaveChanges();
        }
    }
}
