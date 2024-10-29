using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ParkingRepository : IParkingRepository
    {
        private readonly GarageContext _context;

        public ParkingRepository(GarageContext context)
        {
            _context = context;
        }

        public IEnumerable<Parking> GetAllParkings()
        {
            return _context.Parkings.ToList();
        }

        public IEnumerable<Parking> GetAllParkingsWithSpots()
        {
            return _context.Parkings.Include(p => p.ParkingSpot).ToList();
        }

        public Parking? GetParkingById(int id)
        {
            return _context.Parkings.Include(p => p.ParkingSpot).FirstOrDefault(p => p.Id == id);
        }

        public Parking? GetParkingByPlate(string plate)
        {
            return _context.Parkings.Include(p => p.ParkingSpot).Include(p => p.Rate).FirstOrDefault(p => p.LicensePlate == plate);
        }

        public int AddParking(Parking parking)
        {
            var newParking = _context.Parkings.Add(parking);
            _context.SaveChanges();
            return newParking.Entity.Id;
        }

        public void UpdateParking(Parking parking)
        {
            _context.Parkings.Update(parking);
            _context.SaveChanges();
        }

        public void DeleteParking(int id)
        {
            var parking = _context.Parkings.Find(id);
            if (parking != null)
            {
                _context.Parkings.Remove(parking);
                _context.SaveChanges();
            }
        }
    }

}
