using Data.Entities;

namespace Data.Repositories
{
    public interface IParkingRepository
    {
        int AddParking(Parking parking);
        void DeleteParking(int id);
        IEnumerable<Parking> GetAllParkings();
        Parking? GetParkingById(int id);
        void UpdateParking(Parking parking);
        IEnumerable<Parking> GetAllParkingsWithSpots();
        Parking? GetParkingByPlate(string plate);
    }
}