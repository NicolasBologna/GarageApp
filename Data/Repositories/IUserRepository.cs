using Data.Entities;

namespace Data.Repositories
{
    public interface IUserRepository
    {
        User ValidateUser(string username, string password);
    }
}