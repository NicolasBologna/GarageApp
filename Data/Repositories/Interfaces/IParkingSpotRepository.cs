using Data.Entities;

namespace Data.Repositories.Interfaces
{
    public interface IParkingSpotRepository
    {
        int Add(ParkingSpot parkingSpot);
        public ParkingSpot? GetParkingSpot(string description);
        public List<ParkingSpot> GetAll();
    }
}