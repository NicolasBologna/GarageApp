namespace Data.Repositories.Interfaces
{
    public interface IRateRepository
    {
        IEnumerable<Rate> GetAllRates();
        Rate GetRateById(int id);
        void AddRate(Rate rate);
        void UpdateRate(Rate rate);
        void DeleteRate(string id);
        Rate? GetRateByDescription(string description);
    }
}