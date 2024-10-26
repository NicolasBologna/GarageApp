using Data.Entities;

namespace Data.Repositories
{
    public interface IParkingRepository
    {
        void AddParking(Parking parking);
        void DeleteParking(int id);
        IEnumerable<Parking> GetAllParkings();
        Parking? GetParkingById(int id);
        void UpdateParking(Parking parking);
        IEnumerable<Parking> GetAllParkingsWithSpots();
    }
}