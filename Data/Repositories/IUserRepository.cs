using Data.Entities;

namespace Data.Repositories
{
    public interface IUserRepository
    {
        bool ValidateUser(string username, string password);
    }
}