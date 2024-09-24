using Data.Entities;

namespace Data.Repositories
{
    public interface IGarageRepository
    {
        int Add(Garage garage);
        public Garage? GetGarage(string number);
        public List<Garage> GetAll();
    }
}