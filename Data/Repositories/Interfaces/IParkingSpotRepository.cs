using Data.Entities;

namespace Data.Repositories.Interfaces
{
    public interface IParkingSpotRepository
    {
        int Add(ParkingSpot parkingSpot);
        public ParkingSpot? GetParkingSpotByDescription(string description);
        public List<ParkingSpot> GetAll();
        ParkingSpot? GetParkingSpotById(int id);
        void UpdateSpot(ParkingSpot spot);
    }
}